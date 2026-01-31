namespace Clock
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelTime = new System.Windows.Forms.Label();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiTopmost = new System.Windows.Forms.ToolStripMenuItem();
			this.tsimShowControls = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiShowDate = new System.Windows.Forms.ToolStripMenuItem();
			this.tsimShowWeekday = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsimFont = new System.Windows.Forms.ToolStripMenuItem();
			this.tsimColor = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiForegoundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsimAlarms = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiAutorun = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.checkBoxShowDate = new System.Windows.Forms.CheckBox();
			this.checkBoxShowWeekday = new System.Windows.Forms.CheckBox();
			this.buttonHideControls = new System.Windows.Forms.Button();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.BackColor = System.Drawing.SystemColors.Highlight;
			this.labelTime.ContextMenuStrip = this.contextMenuStrip;
			this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTime.Location = new System.Drawing.Point(22, 18);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(321, 61);
			this.labelTime.TabIndex = 0;
			this.labelTime.Text = "CurrentTime";
			this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTopmost,
            this.tsimShowControls,
            this.toolStripSeparator1,
            this.tsmiShowDate,
            this.tsimShowWeekday,
            this.toolStripSeparator2,
            this.tsimFont,
            this.tsimColor,
            this.toolStripSeparator3,
            this.tsimAlarms,
            this.toolStripSeparator4,
            this.tsmiAutorun,
            this.toolStripSeparator5,
            this.tsmiExit});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(211, 278);
			// 
			// tsmiTopmost
			// 
			this.tsmiTopmost.CheckOnClick = true;
			this.tsmiTopmost.Name = "tsmiTopmost";
			this.tsmiTopmost.Size = new System.Drawing.Size(210, 24);
			this.tsmiTopmost.Text = "Topmost";
			this.tsmiTopmost.CheckedChanged += new System.EventHandler(this.tsmiTopmost_CheckedChanged);
			// 
			// tsimShowControls
			// 
			this.tsimShowControls.CheckOnClick = true;
			this.tsimShowControls.Name = "tsimShowControls";
			this.tsimShowControls.Size = new System.Drawing.Size(210, 24);
			this.tsimShowControls.Text = "Show controls";
			this.tsimShowControls.CheckedChanged += new System.EventHandler(this.tsimShowControls_CheckedChanged);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
			// 
			// tsmiShowDate
			// 
			this.tsmiShowDate.CheckOnClick = true;
			this.tsmiShowDate.Name = "tsmiShowDate";
			this.tsmiShowDate.Size = new System.Drawing.Size(210, 24);
			this.tsmiShowDate.Text = "Show date";
			this.tsmiShowDate.CheckedChanged += new System.EventHandler(this.tsmiShowDate_CheckedChanged);
			// 
			// tsimShowWeekday
			// 
			this.tsimShowWeekday.CheckOnClick = true;
			this.tsimShowWeekday.Name = "tsimShowWeekday";
			this.tsimShowWeekday.Size = new System.Drawing.Size(210, 24);
			this.tsimShowWeekday.Text = "Show Weekday";
			this.tsimShowWeekday.CheckedChanged += new System.EventHandler(this.tsimShowWeekday_CheckedChanged);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
			// 
			// tsimFont
			// 
			this.tsimFont.Name = "tsimFont";
			this.tsimFont.Size = new System.Drawing.Size(210, 24);
			this.tsimFont.Text = "Font";
			// 
			// tsimColor
			// 
			this.tsimColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiForegoundColor,
            this.tsmiBackgroundColor});
			this.tsimColor.Name = "tsimColor";
			this.tsimColor.Size = new System.Drawing.Size(210, 24);
			this.tsimColor.Text = "Color";
			// 
			// tsmiForegoundColor
			// 
			this.tsmiForegoundColor.Name = "tsmiForegoundColor";
			this.tsmiForegoundColor.Size = new System.Drawing.Size(209, 26);
			this.tsmiForegoundColor.Text = "Foregound";
			// 
			// tsmiBackgroundColor
			// 
			this.tsmiBackgroundColor.Name = "tsmiBackgroundColor";
			this.tsmiBackgroundColor.Size = new System.Drawing.Size(209, 26);
			this.tsmiBackgroundColor.Text = "Background color";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(207, 6);
			// 
			// tsimAlarms
			// 
			this.tsimAlarms.Name = "tsimAlarms";
			this.tsimAlarms.Size = new System.Drawing.Size(210, 24);
			this.tsimAlarms.Text = "Alarms";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(207, 6);
			// 
			// tsmiAutorun
			// 
			this.tsmiAutorun.CheckOnClick = true;
			this.tsmiAutorun.Name = "tsmiAutorun";
			this.tsmiAutorun.Size = new System.Drawing.Size(210, 24);
			this.tsmiAutorun.Text = "Autorun";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(207, 6);
			// 
			// tsmiExit
			// 
			this.tsmiExit.Name = "tsmiExit";
			this.tsmiExit.Size = new System.Drawing.Size(210, 24);
			this.tsmiExit.Text = "Exit";
			this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// checkBoxShowDate
			// 
			this.checkBoxShowDate.AutoSize = true;
			this.checkBoxShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxShowDate.Location = new System.Drawing.Point(33, 268);
			this.checkBoxShowDate.Name = "checkBoxShowDate";
			this.checkBoxShowDate.Size = new System.Drawing.Size(170, 36);
			this.checkBoxShowDate.TabIndex = 1;
			this.checkBoxShowDate.Text = "Show date";
			this.checkBoxShowDate.UseVisualStyleBackColor = true;
			this.checkBoxShowDate.CheckedChanged += new System.EventHandler(this.checkBoxShowDate_CheckedChanged);
			// 
			// checkBoxShowWeekday
			// 
			this.checkBoxShowWeekday.AutoSize = true;
			this.checkBoxShowWeekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxShowWeekday.Location = new System.Drawing.Point(33, 310);
			this.checkBoxShowWeekday.Name = "checkBoxShowWeekday";
			this.checkBoxShowWeekday.Size = new System.Drawing.Size(226, 36);
			this.checkBoxShowWeekday.TabIndex = 2;
			this.checkBoxShowWeekday.Text = "Show weekday";
			this.checkBoxShowWeekday.UseVisualStyleBackColor = true;
			this.checkBoxShowWeekday.CheckedChanged += new System.EventHandler(this.checkBoxShowWeekday_CheckedChanged);
			// 
			// buttonHideControls
			// 
			this.buttonHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonHideControls.Location = new System.Drawing.Point(33, 353);
			this.buttonHideControls.Name = "buttonHideControls";
			this.buttonHideControls.Size = new System.Drawing.Size(321, 72);
			this.buttonHideControls.TabIndex = 3;
			this.buttonHideControls.Text = "Hide controls";
			this.buttonHideControls.UseVisualStyleBackColor = true;
			this.buttonHideControls.Click += new System.EventHandler(this.buttonHideControls_Click);
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "Clock PV_522";
			this.notifyIcon.Visible = true;
			this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(486, 549);
			this.Controls.Add(this.buttonHideControls);
			this.Controls.Add(this.checkBoxShowWeekday);
			this.Controls.Add(this.checkBoxShowDate);
			this.Controls.Add(this.labelTime);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "ClockPV_522";
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.CheckBox checkBoxShowDate;
		private System.Windows.Forms.CheckBox checkBoxShowWeekday;
		private System.Windows.Forms.Button buttonHideControls;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem tsmiTopmost;
		private System.Windows.Forms.ToolStripMenuItem tsimShowControls;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem tsmiShowDate;
		private System.Windows.Forms.ToolStripMenuItem tsimShowWeekday;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem tsimFont;
		private System.Windows.Forms.ToolStripMenuItem tsimColor;
		private System.Windows.Forms.ToolStripMenuItem tsmiForegoundColor;
		private System.Windows.Forms.ToolStripMenuItem tsmiBackgroundColor;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem tsimAlarms;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem tsmiAutorun;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem tsmiExit;
	}
}

