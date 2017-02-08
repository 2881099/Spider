using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net;
using System.IO;

public class NicSpider {
	private string _startUrl;
	private int _threads;
	private string[] _acceptHosts;
	private string[] _accpetExternal;

	private Regex _regexUrls = new Regex(@"(<a ([^h]|h(?!ref=))*href=|<iframe ([^s]|s(?!rc=))*src=|<script ([^s]|s(?!rc=))*src=)([^ >]+)", RegexOptions.IgnoreCase | RegexOptions.Compiled);

	private CookieContainer _cc;
	private WorkQueue _wq;
	private int _completed;
	private int _errors;
	public event NicSpiderDataEventHandler OnData;
	public event NicSpiderErrorEventHandler OnError;
	public event NicSpiderStatusEventHandler OnStatus;

	public NicSpider(string startUrl)
		: this(startUrl, 10, null, null) {
	}
	public NicSpider(string startUrl, int threads)
		: this(startUrl, threads, null, null) {
	}
	public NicSpider(string startUrl, int threads, string[] acceptHosts, string[] accpetExternal) {
		this.Init(startUrl, threads, acceptHosts, accpetExternal);
	}
	private void Init(string startUrl, int threads, string[] acceptHosts, string[] accpetExternal) {
		_startUrl = startUrl;
		_threads = threads;
		Uri uri = null;
		Uri.TryCreate(startUrl, UriKind.Absolute, out uri);
		if (acceptHosts == null || acceptHosts.Length == 0) acceptHosts = new string[] { uri.Host };
		if (accpetExternal == null || accpetExternal.Length == 0) accpetExternal = new string[] { ".aspx", ".asmx", ".asp", ".php", ".jsp" };
		_acceptHosts = filterArray(acceptHosts, uri.Host);
		_accpetExternal = filterArray(accpetExternal, string.Empty);
	}
	private string[] filterArray(string[] arr, string value) {
		List<string> ls = new List<string>(arr);
		while (ls.Remove(value)) ;
		ls.Add(value);
		return ls.ToArray();
	}

	public void Start() {
		_completed = 0;
		_cc = new CookieContainer();
		_wq = new WorkQueue(_threads, 10000);
		_wq.Enqueue(delegate() { go(_startUrl); });
	}
	public void Stop() {
		if (_wq != null) {
			_wq.Dispose();
		}
	}

	private void go(string url) {
		int links = 0;
		TimeSpan time = TimeSpan.Zero;

		HttpRequest hr = new HttpRequest();
		hr.CookieContainer = _cc;
		Exception ex = Lib.Trys(delegate() {
			hr.Action = url;
			hr.Referer = hr.Address.AbsoluteUri;
			hr.Charset = "gb2312";

			DateTime dt = DateTime.Now;
			hr.Send();
			time = DateTime.Now - dt;
		}, 3);
		if (ex != null) {
			throw ex;
		}
		if (hr.Response.ContentType.ToLower().IndexOf("text/html") != -1) {
			string html = hr.Response.Html;
			MatchCollection mc = _regexUrls.Matches(html);
			foreach (Match m in mc) {
				string url2 = m.Groups[5].Value.Trim('"', '\'', '\r', '\n', '\t', ' ');
				url2 = hr.Response.TranslateUrlToAbsolute(url2);
				Uri uri = null;
				if (Uri.TryCreate(url2, UriKind.Absolute, out uri) && 
					uri.Scheme.IndexOf("http", StringComparison.CurrentCultureIgnoreCase) == 0) {
					if (Array.FindIndex<string>(_acceptHosts, delegate(string host) { return string.Compare(host, uri.Host, false) == 0; }) == -1)
						continue;
					if (Array.FindIndex<string>(_accpetExternal, delegate(string ext) { return string.Compare(ext, Path.GetExtension(uri.AbsolutePath), false) == 0; }) == -1)
						continue;

					_wq.Enqueue(delegate() {
						try {
							go(url2);
						} catch (Exception eex) {
						    Interlocked.Increment(ref _errors);
						    if (OnError != null) {
						        NicSpiderErrorEventArgs e = new NicSpiderErrorEventArgs(eex, _errors);
						        OnError(this, e);
						    }
						}
					});
				}
			}
			links = mc.Count;
		}
		Interlocked.Increment(ref _completed);
		if (OnStatus != null) {
			NicSpiderStatusEventArgs e = new NicSpiderStatusEventArgs(_completed);
			OnStatus(this, e);
		}
		if (OnData != null) {
			NicSpiderDataEventArgs e = new NicSpiderDataEventArgs(hr.Head, hr.Response, links, time);
			OnData(this, e);
		}
		hr.Dispose();
	}

	public int Threads {
		get { return _threads; }
		set { _threads = value; }
	}
	public string StartUrl {
		get { return _startUrl; }
		set { _startUrl = value; }
	}

	class StaticsUrlInfo {
		private string _url;

		public StaticsUrlInfo(string url) {
			_url = url;
		}
		public string Url {
			get { return _url; }
		}
	}
}

public delegate void NicSpiderDataEventHandler(object sender, NicSpiderDataEventArgs e);
public delegate void NicSpiderErrorEventHandler(object sender, NicSpiderErrorEventArgs e);
public delegate void NicSpiderStatusEventHandler(object sender, NicSpiderStatusEventArgs e);
public delegate void NicSpiderCompletedEventHander(object sender, NicSpiderCompletedEventArgs e);

public class NicSpiderDataEventArgs : EventArgs {
	private string _request;
	private HttpResponse _response;
	private int _links;
	private TimeSpan _time;

	public string Request {
		get { return _request; }
	}
	public HttpResponse Response {
		get { return _response; }
	}
	public int Links {
		get { return _links; }
	}
	public TimeSpan Time {
		get { return _time; }
	}

	public NicSpiderDataEventArgs(string request, HttpResponse response, int links, TimeSpan time) {
		_request = request;
		_response = response;
		_links = links;
		_time = time;
	}
}

public class NicSpiderErrorEventArgs : EventArgs {
	private Exception _exception;

	public Exception Exception {
		get { return _exception; }
	}
	private int _errors;

	public int Errors {
		get { return _errors; }
	}

	public NicSpiderErrorEventArgs(Exception exception, int errors) {
		_exception = exception;
		_errors = errors;
	}
}

public class NicSpiderStatusEventArgs : EventArgs {
	private int _completed;

	public int Completed {
		get { return _completed; }
	}

	public NicSpiderStatusEventArgs(int completed) {
		_completed = completed;
	}
}

public class NicSpiderCompletedEventArgs : EventArgs {
	private int _completed;

	public int Completed {
		get { return _completed; }
	}

	public NicSpiderCompletedEventArgs(int completed) {
		_completed = completed;
	}
}
