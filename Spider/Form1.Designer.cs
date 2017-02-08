namespace Spider {
	partial class Form1 {
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent() {
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tsslLeft = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslCompleteds = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslThreads = new System.Windows.Forms.ToolStripStatusLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnStart = new System.Windows.Forms.Button();
			this.tcMain = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtFilterFileType = new System.Windows.Forms.TextBox();
			this.panelFilterLeft = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtFilterHost = new System.Windows.Forms.TextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.panel11 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.trbThreads = new System.Windows.Forms.TrackBar();
			this.panel8 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.lblLogTips = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.MyListView();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.statusStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tcMain.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panelFilterLeft.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel10.SuspendLayout();
			this.panel11.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trbThreads)).BeginInit();
			this.panel8.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslLeft,
            this.tsslCompleteds,
            this.tsslThreads});
			this.statusStrip1.Location = new System.Drawing.Point(0, 471);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
			this.statusStrip1.Size = new System.Drawing.Size(641, 37);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tsslLeft
			// 
			this.tsslLeft.Name = "tsslLeft";
			this.tsslLeft.Size = new System.Drawing.Size(451, 32);
			this.tsslLeft.Spring = true;
			this.tsslLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tsslCompleteds
			// 
			this.tsslCompleteds.AutoSize = false;
			this.tsslCompleteds.Name = "tsslCompleteds";
			this.tsslCompleteds.Size = new System.Drawing.Size(100, 32);
			this.tsslCompleteds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tsslThreads
			// 
			this.tsslThreads.AutoSize = false;
			this.tsslThreads.Name = "tsslThreads";
			this.tsslThreads.Size = new System.Drawing.Size(70, 32);
			this.tsslThreads.Text = "线程：12";
			this.tsslThreads.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnStart);
			this.panel1.Controls.Add(this.tcMain);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(16, 20, 16, 20);
			this.panel1.Size = new System.Drawing.Size(641, 471);
			this.panel1.TabIndex = 2;
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.Color.Gainsboro;
			this.btnStart.Location = new System.Drawing.Point(518, 17);
			this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(103, 32);
			this.btnStart.TabIndex = 17;
			this.btnStart.Text = "开始";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// tcMain
			// 
			this.tcMain.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.tcMain.Controls.Add(this.tabPage1);
			this.tcMain.Controls.Add(this.tabPage2);
			this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcMain.Location = new System.Drawing.Point(16, 20);
			this.tcMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tcMain.Name = "tcMain";
			this.tcMain.SelectedIndex = 0;
			this.tcMain.Size = new System.Drawing.Size(609, 431);
			this.tcMain.TabIndex = 12;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.panel3);
			this.tabPage1.Controls.Add(this.panel5);
			this.tabPage1.Location = new System.Drawing.Point(4, 32);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
			this.tabPage1.Size = new System.Drawing.Size(601, 395);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "设置";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.panelFilterLeft);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 242);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(601, 153);
			this.panel3.TabIndex = 25;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.groupBox2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(307, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(294, 153);
			this.panel4.TabIndex = 4;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtFilterFileType);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 12, 6, 12);
			this.groupBox2.Size = new System.Drawing.Size(294, 153);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "按文件类型进行过滤";
			// 
			// txtFilterFileType
			// 
			this.txtFilterFileType.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtFilterFileType.Location = new System.Drawing.Point(6, 31);
			this.txtFilterFileType.Multiline = true;
			this.txtFilterFileType.Name = "txtFilterFileType";
			this.txtFilterFileType.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtFilterFileType.Size = new System.Drawing.Size(282, 110);
			this.txtFilterFileType.TabIndex = 1;
			this.txtFilterFileType.Text = ".aspx\r\n.asmx\r\n.asp\r\n.php\r\n.jsp";
			// 
			// panelFilterLeft
			// 
			this.panelFilterLeft.Controls.Add(this.groupBox1);
			this.panelFilterLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelFilterLeft.Location = new System.Drawing.Point(0, 0);
			this.panelFilterLeft.Name = "panelFilterLeft";
			this.panelFilterLeft.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
			this.panelFilterLeft.Size = new System.Drawing.Size(307, 153);
			this.panelFilterLeft.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtFilterHost);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 12, 6, 12);
			this.groupBox1.Size = new System.Drawing.Size(287, 153);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "按域名进行过滤";
			// 
			// txtFilterHost
			// 
			this.txtFilterHost.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtFilterHost.Location = new System.Drawing.Point(6, 31);
			this.txtFilterHost.Multiline = true;
			this.txtFilterHost.Name = "txtFilterHost";
			this.txtFilterHost.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtFilterHost.Size = new System.Drawing.Size(275, 110);
			this.txtFilterHost.TabIndex = 0;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.groupBox3);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 20);
			this.panel5.Name = "panel5";
			this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
			this.panel5.Size = new System.Drawing.Size(601, 222);
			this.panel5.TabIndex = 24;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.panel9);
			this.groupBox3.Controls.Add(this.panel6);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(0, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
			this.groupBox3.Size = new System.Drawing.Size(601, 216);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "基础";
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.panel10);
			this.panel9.Controls.Add(this.panel11);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel9.Location = new System.Drawing.Point(6, 69);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(589, 133);
			this.panel9.TabIndex = 5;
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.label3);
			this.panel10.Controls.Add(this.txtUrl);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel10.Location = new System.Drawing.Point(92, 0);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(497, 133);
			this.panel10.TabIndex = 30;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Location = new System.Drawing.Point(-4, 33);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(500, 100);
			this.label3.TabIndex = 29;
			this.label3.Text = "登陆请使用以下方法：\r\n请设置入口地址，如：http://xxx/spider_login.aspx?user=admin&pass=xxx\r\n登陆完成后请使用 " +
				"Response.Write(\"<a href=\'/index.aspx\'></a>\"); 返回首页\r\n\r\n其他扩展同理，请按顺序设置好自定义访问的页面！";
			this.label3.UseMnemonic = false;
			// 
			// txtUrl
			// 
			this.txtUrl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtUrl.Location = new System.Drawing.Point(0, 0);
			this.txtUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(497, 26);
			this.txtUrl.TabIndex = 27;
			this.txtUrl.DoubleClick += new System.EventHandler(this.txtUrl_DoubleClick);
			// 
			// panel11
			// 
			this.panel11.Controls.Add(this.label2);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel11.Location = new System.Drawing.Point(0, 0);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(92, 133);
			this.panel11.TabIndex = 29;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 20);
			this.label2.TabIndex = 27;
			this.label2.Text = "入口地址";
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Controls.Add(this.panel8);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(6, 22);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(589, 47);
			this.panel6.TabIndex = 4;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.trbThreads);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(92, 0);
			this.panel7.Name = "panel7";
			this.panel7.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
			this.panel7.Size = new System.Drawing.Size(497, 47);
			this.panel7.TabIndex = 30;
			// 
			// trbThreads
			// 
			this.trbThreads.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trbThreads.Location = new System.Drawing.Point(0, 6);
			this.trbThreads.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.trbThreads.Maximum = 100;
			this.trbThreads.Minimum = 1;
			this.trbThreads.Name = "trbThreads";
			this.trbThreads.Size = new System.Drawing.Size(497, 41);
			this.trbThreads.TabIndex = 28;
			this.trbThreads.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trbThreads.Value = 12;
			this.trbThreads.Scroll += new System.EventHandler(this.trbThreads_Scroll);
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.label1);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel8.Location = new System.Drawing.Point(0, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(92, 47);
			this.panel8.TabIndex = 29;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 6);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 20);
			this.label1.TabIndex = 26;
			this.label1.Text = "线程";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.lblLogTips);
			this.tabPage2.Controls.Add(this.listView1);
			this.tabPage2.Location = new System.Drawing.Point(4, 32);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
			this.tabPage2.Size = new System.Drawing.Size(601, 395);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "日志";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// lblLogTips
			// 
			this.lblLogTips.AutoSize = true;
			this.lblLogTips.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblLogTips.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblLogTips.Location = new System.Drawing.Point(202, 176);
			this.lblLogTips.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLogTips.Name = "lblLogTips";
			this.lblLogTips.Size = new System.Drawing.Size(199, 20);
			this.lblLogTips.TabIndex = 30;
			this.lblLogTips.Text = "选中日志，复制HTTP请求响应";
			this.lblLogTips.UseMnemonic = false;
			this.lblLogTips.Visible = false;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.Location = new System.Drawing.Point(0, 20);
			this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(601, 375);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "时间";
			this.columnHeader4.Width = 65;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "URL";
			this.columnHeader1.Width = 211;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "内面包含的链接数量";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader2.Width = 138;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "毫时(ms)";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader3.Width = 69;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "状态";
			this.columnHeader5.Width = 92;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 508);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimumSize = new System.Drawing.Size(649, 468);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "蜘蛛侠";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.tcMain.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panelFilterLeft.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			this.panel10.PerformLayout();
			this.panel11.ResumeLayout(false);
			this.panel11.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trbThreads)).EndInit();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tsslLeft;
		private System.Windows.Forms.ToolStripStatusLabel tsslCompleteds;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabControl tcMain;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ToolStripStatusLabel tsslThreads;
		private System.Windows.Forms.MyListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel panelFilterLeft;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.TrackBar trbThreads;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TextBox txtFilterHost;
		private System.Windows.Forms.TextBox txtFilterFileType;
		private System.Windows.Forms.Label lblLogTips;

	}
}

