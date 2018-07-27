using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;

namespace Spider {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		#region safe access
		delegate void SafeSetText(Component c, string text);
		protected void safeSetText(Component c, string text) {
			if (this.InvokeRequired)
				this.Invoke(new SafeSetText(safeSetText), new object[] { c, text });
			else {
				if (c is ToolStripItem) {
					ToolStripItem o = c as ToolStripItem;
					if (o == null) return;
					o.Text = text;
				} else if (c is Control) {
					Control o = c as Control;
					if (o == null) return;
					o.Text = text;
				}
			}
		}
		protected void safeAppendText(Component c, string text) {
			if (this.InvokeRequired)
				this.Invoke(new SafeSetText(safeAppendText), new object[] { c, text });
			else {
				TextBox o = c as TextBox;
				if (o == null) return;
				o.AppendText(DateTime.Now.ToString("MM:ss ") + text + "\r\n");
				o.ScrollToCaret();
			}
		}
		delegate void SafeSetEnabled(Control c, bool enabled);
		protected void safeSetEnabled(Control c, bool enabled) {
			if (c.InvokeRequired)
				this.Invoke(new SafeSetEnabled(safeSetEnabled), new object[] { c, enabled });
			else
				c.Enabled = enabled;
		}
		#endregion

		private NicSpider spider;
		private Regex regexEmail = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase | RegexOptions.Compiled);
		private Regex regexTitle = new Regex(@"<title>(([^<]|<(?!/title>))*)</title>", RegexOptions.IgnoreCase | RegexOptions.Compiled);
		private object emailInsertLock = new object();

		private void trbThreads_Scroll(object sender, EventArgs e) {
			this.tsslThreads.Text = "线程：" + this.trbThreads.Value;
		}

		private void btnStart_Click(object sender, EventArgs e) {
			if (this.btnStart.Text == "开始") {
				Uri uri = null;
				if (!Uri.TryCreate(this.txtUrl.Text, UriKind.Absolute, out uri)) {
					MessageBox.Show("请输入正确格式的“入口地址”(URL)！", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.txtUrl.Focus();
					return;
				}

				this.label1.Enabled = 
				this.label2.Enabled = 
				this.label3.Enabled = 
				this.trbThreads.Enabled = 
				this.txtFilterHost.Enabled = 
				this.txtFilterFileType.Enabled = 
				this.txtUrl.Enabled = false;
				this.tcMain.SelectedIndex = 1;
				this.btnStart.Text = "停止";

				spider = new NicSpider(uri.AbsoluteUri, this.trbThreads.Value,
					this.txtFilterHost.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None),
					this.txtFilterFileType.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None));
				spider.OnData += spider_OnData;
				spider.OnError += spider_OnError;
				spider.OnStatus += spider_OnStatus;
				spider.Start();

				this.lblLogTips.Location = new Point(
					(this.listView1.Width - this.lblLogTips.Width) / 2,
					(this.listView1.Height - this.lblLogTips.Height) / 2);
				this.lblLogTips.Visible = true;
				Lib.SetTimeout(delegate() {
					this.lblLogTips.Visible = false;
				}, 5000);
			} else {
				this.label1.Enabled =
				this.label2.Enabled =
				this.label3.Enabled =
				this.trbThreads.Enabled =
				this.txtFilterHost.Enabled =
				this.txtFilterFileType.Enabled = 
				this.txtUrl.Enabled = true;
				this.btnStart.Text = "开始";

				if (spider != null) {
					spider.Stop();
					spider = null;
				}
			}
		}

		private void spider_OnData(object sender, NicSpiderDataEventArgs e) {
			this.appendLog(e.Response.Action, e.Links, e.Time, e.Response.StatusCode.ToString(), 
				e.Request + "\r\n\r\n" + e.Response.Head + "\r\n\r\n" + e.Response.Xml);
		}
		private void spider_OnError(object sender, NicSpiderErrorEventArgs e) {
			string log = e.Exception.Message + "(" + e.Errors + ")";
			safeSetText(this.tsslLeft, log.Replace("\r\n", " "));
		}
		private void spider_OnStatus(object sender, NicSpiderStatusEventArgs e) {
			safeSetText(this.tsslCompleteds, "完成：" + e.Completed);
		}

		private delegate void AppendLog(string url, int links, TimeSpan ts, string status, string tag);
		private void appendLog(string url, int links, TimeSpan ts, string status, string tag) {
			if (this.InvokeRequired)
				this.Invoke(new AppendLog(appendLog), new object[] { url, links, ts, status, tag });
			else {
				ListViewItem lvi = this.listView1.Items.Insert(0, DateTime.Now.ToString("HH:mm:ss"));
				lvi.SubItems.Add(url);
				lvi.SubItems.Add(links > 0 ? links.ToString() : "");
				lvi.SubItems.Add(ts.TotalMilliseconds.ToString("f2"));
				lvi.SubItems.Add(status);
				if (status != "OK") lvi.ForeColor = Color.Red;
				lvi.Tag = tag;
			}
		}

		private void txtUrl_DoubleClick(object sender, EventArgs e) {
			this.txtUrl.SelectAll();
		}

		private void Form1_SizeChanged(object sender, EventArgs e) {
			this.panelFilterLeft.Width = (this.Size.Width - 40) / 2;
			this.btnStart.Location = new Point(this.Size.Width - 28 - this.btnStart.Width, 20);
		}

		private void Form1_Load(object sender, EventArgs e) {
			//DateTime dt = DateTime.Now;
			//HttpRequest hr = new HttpRequest();
			//hr.Action = "http://bbs.025.com/func/view.aspx?groupid=025&act=forums";
			//hr.Referer = hr.Action;
			//hr.Send();
			//TimeSpan ts = DateTime.Now - dt;
			//Lib.Alert(ts.TotalMilliseconds.ToString("f2"));
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			if (this.btnStart.Text != "开始") {
				this.btnStart_Click(sender, EventArgs.Empty);
			}
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e) {
			if (this.listView1.SelectedItems.Count > 0) {
				Clipboard.SetText(string.Concat(this.listView1.SelectedItems[0].Tag));
			}
		}
	}
}