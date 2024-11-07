namespace VideoConverter.Forms;

partial class Options {
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing) {
		if (disposing && (components != null)) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
		components = new System.ComponentModel.Container();
		Options_TabGroup = new TabControl();
		Options_General = new TabPage();
		flowLayoutPanel1 = new FlowLayoutPanel();
		groupBox1 = new GroupBox();
		flowLayoutPanel2 = new FlowLayoutPanel();
		Options_General_Application_Language_Label = new Label();
		Language = new ComboBox();
		groupBox2 = new GroupBox();
		flowLayoutPanel3 = new FlowLayoutPanel();
		label2 = new Label();
		Extensions = new TextBox();
		Options_FFmpeg = new TabPage();
		flowLayoutPanel4 = new FlowLayoutPanel();
		FFmpegMode = new RadioGroup();
		flowLayoutPanel5 = new FlowLayoutPanel();
		FFmpegSystem = new RadioButton();
		FFmpegApplication = new RadioButton();
		radioButton3 = new RadioButton();
		label3 = new Label();
		FFmpegPath = new TextBox();
		FFmpegBrowse = new Button();
		groupBox3 = new GroupBox();
		flowLayoutPanel6 = new FlowLayoutPanel();
		label4 = new Label();
		FFmpegThreads = new NumericUpDown();
		label5 = new Label();
		groupBox4 = new GroupBox();
		flowLayoutPanel7 = new FlowLayoutPanel();
		label6 = new Label();
		FFmpegLogLevel = new ComboBox();
		Options_Save = new Button();
		Options_Cancel = new Button();
		DataSource = new BindingSource(components);
		FolderBrowser = new FolderBrowserDialog();
		Options_TabGroup.SuspendLayout();
		Options_General.SuspendLayout();
		flowLayoutPanel1.SuspendLayout();
		groupBox1.SuspendLayout();
		flowLayoutPanel2.SuspendLayout();
		groupBox2.SuspendLayout();
		flowLayoutPanel3.SuspendLayout();
		Options_FFmpeg.SuspendLayout();
		flowLayoutPanel4.SuspendLayout();
		FFmpegMode.SuspendLayout();
		flowLayoutPanel5.SuspendLayout();
		groupBox3.SuspendLayout();
		flowLayoutPanel6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)FFmpegThreads).BeginInit();
		groupBox4.SuspendLayout();
		flowLayoutPanel7.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)DataSource).BeginInit();
		SuspendLayout();
		// 
		// Options_TabGroup
		// 
		Options_TabGroup.Controls.Add(Options_General);
		Options_TabGroup.Controls.Add(Options_FFmpeg);
		Options_TabGroup.Location = new Point(12, 12);
		Options_TabGroup.Name = "Options_TabGroup";
		Options_TabGroup.SelectedIndex = 0;
		Options_TabGroup.Size = new Size(562, 408);
		Options_TabGroup.TabIndex = 0;
		// 
		// Options_General
		// 
		Options_General.Controls.Add(flowLayoutPanel1);
		Options_General.Location = new Point(4, 24);
		Options_General.Name = "Options_General";
		Options_General.Padding = new Padding(3);
		Options_General.Size = new Size(554, 380);
		Options_General.TabIndex = 0;
		Options_General.Text = "General";
		Options_General.UseVisualStyleBackColor = true;
		// 
		// flowLayoutPanel1
		// 
		flowLayoutPanel1.Controls.Add(groupBox1);
		flowLayoutPanel1.Controls.Add(groupBox2);
		flowLayoutPanel1.Dock = DockStyle.Fill;
		flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
		flowLayoutPanel1.Location = new Point(3, 3);
		flowLayoutPanel1.Name = "flowLayoutPanel1";
		flowLayoutPanel1.Size = new Size(548, 374);
		flowLayoutPanel1.TabIndex = 0;
		// 
		// groupBox1
		// 
		groupBox1.AutoSize = true;
		groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		groupBox1.Controls.Add(flowLayoutPanel2);
		groupBox1.Dock = DockStyle.Top;
		groupBox1.Location = new Point(6, 6);
		groupBox1.Margin = new Padding(6);
		groupBox1.MinimumSize = new Size(534, 50);
		groupBox1.Name = "groupBox1";
		groupBox1.Padding = new Padding(6, 6, 6, 12);
		groupBox1.Size = new Size(534, 63);
		groupBox1.TabIndex = 0;
		groupBox1.TabStop = false;
		groupBox1.Text = "Application";
		groupBox1.Visible = false;
		// 
		// flowLayoutPanel2
		// 
		flowLayoutPanel2.AutoSize = true;
		flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		flowLayoutPanel2.Controls.Add(Options_General_Application_Language_Label);
		flowLayoutPanel2.Controls.Add(Language);
		flowLayoutPanel2.Dock = DockStyle.Fill;
		flowLayoutPanel2.Location = new Point(6, 22);
		flowLayoutPanel2.MinimumSize = new Size(0, 28);
		flowLayoutPanel2.Name = "flowLayoutPanel2";
		flowLayoutPanel2.Size = new Size(522, 29);
		flowLayoutPanel2.TabIndex = 0;
		// 
		// Options_General_Application_Language_Label
		// 
		Options_General_Application_Language_Label.Anchor = AnchorStyles.Left;
		Options_General_Application_Language_Label.AutoSize = true;
		Options_General_Application_Language_Label.Location = new Point(3, 7);
		Options_General_Application_Language_Label.Name = "Options_General_Application_Language_Label";
		Options_General_Application_Language_Label.Size = new Size(62, 15);
		Options_General_Application_Language_Label.TabIndex = 3;
		Options_General_Application_Language_Label.Text = "Language:";
		// 
		// Language
		// 
		Language.DisplayMember = "Name";
		Language.DropDownStyle = ComboBoxStyle.DropDownList;
		Language.FormattingEnabled = true;
		Language.Location = new Point(71, 3);
		Language.Name = "Language";
		Language.Size = new Size(121, 23);
		Language.TabIndex = 2;
		Language.ValueMember = "Key";
		// 
		// groupBox2
		// 
		groupBox2.AutoSize = true;
		groupBox2.Controls.Add(flowLayoutPanel3);
		groupBox2.Dock = DockStyle.Top;
		groupBox2.Location = new Point(6, 81);
		groupBox2.Margin = new Padding(6);
		groupBox2.MinimumSize = new Size(0, 50);
		groupBox2.Name = "groupBox2";
		groupBox2.Padding = new Padding(6, 6, 6, 12);
		groupBox2.Size = new Size(534, 63);
		groupBox2.TabIndex = 1;
		groupBox2.TabStop = false;
		groupBox2.Text = "File Extensions";
		// 
		// flowLayoutPanel3
		// 
		flowLayoutPanel3.AutoSize = true;
		flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		flowLayoutPanel3.Controls.Add(label2);
		flowLayoutPanel3.Controls.Add(Extensions);
		flowLayoutPanel3.Dock = DockStyle.Fill;
		flowLayoutPanel3.Location = new Point(6, 22);
		flowLayoutPanel3.MinimumSize = new Size(0, 28);
		flowLayoutPanel3.Name = "flowLayoutPanel3";
		flowLayoutPanel3.Size = new Size(522, 29);
		flowLayoutPanel3.TabIndex = 1;
		// 
		// label2
		// 
		label2.Anchor = AnchorStyles.Left;
		label2.AutoSize = true;
		label2.Location = new Point(3, 7);
		label2.Name = "label2";
		label2.Size = new Size(112, 15);
		label2.TabIndex = 2;
		label2.Text = "Allowed Extensions:";
		// 
		// Extensions
		// 
		Extensions.Location = new Point(121, 3);
		Extensions.Name = "Extensions";
		Extensions.Size = new Size(395, 23);
		Extensions.TabIndex = 1;
		// 
		// Options_FFmpeg
		// 
		Options_FFmpeg.Controls.Add(flowLayoutPanel4);
		Options_FFmpeg.Location = new Point(4, 24);
		Options_FFmpeg.Name = "Options_FFmpeg";
		Options_FFmpeg.Padding = new Padding(3);
		Options_FFmpeg.Size = new Size(554, 380);
		Options_FFmpeg.TabIndex = 1;
		Options_FFmpeg.Text = "FFmpeg";
		Options_FFmpeg.UseVisualStyleBackColor = true;
		// 
		// flowLayoutPanel4
		// 
		flowLayoutPanel4.Controls.Add(FFmpegMode);
		flowLayoutPanel4.Controls.Add(groupBox3);
		flowLayoutPanel4.Controls.Add(groupBox4);
		flowLayoutPanel4.Dock = DockStyle.Fill;
		flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
		flowLayoutPanel4.Location = new Point(3, 3);
		flowLayoutPanel4.Name = "flowLayoutPanel4";
		flowLayoutPanel4.Size = new Size(548, 374);
		flowLayoutPanel4.TabIndex = 1;
		// 
		// FFmpegMode
		// 
		FFmpegMode.AutoSize = true;
		FFmpegMode.Controls.Add(flowLayoutPanel5);
		FFmpegMode.Dock = DockStyle.Top;
		FFmpegMode.Location = new Point(6, 6);
		FFmpegMode.Margin = new Padding(6);
		FFmpegMode.MinimumSize = new Size(534, 63);
		FFmpegMode.Name = "FFmpegMode";
		FFmpegMode.Padding = new Padding(6, 6, 6, 12);
		FFmpegMode.Selected = 0;
		FFmpegMode.Size = new Size(534, 88);
		FFmpegMode.TabIndex = 2;
		FFmpegMode.TabStop = false;
		FFmpegMode.Text = "Location";
		// 
		// flowLayoutPanel5
		// 
		flowLayoutPanel5.AutoSize = true;
		flowLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		flowLayoutPanel5.Controls.Add(FFmpegSystem);
		flowLayoutPanel5.Controls.Add(FFmpegApplication);
		flowLayoutPanel5.Controls.Add(radioButton3);
		flowLayoutPanel5.Controls.Add(label3);
		flowLayoutPanel5.Controls.Add(FFmpegPath);
		flowLayoutPanel5.Controls.Add(FFmpegBrowse);
		flowLayoutPanel5.Dock = DockStyle.Fill;
		flowLayoutPanel5.Location = new Point(6, 22);
		flowLayoutPanel5.MinimumSize = new Size(0, 28);
		flowLayoutPanel5.Name = "flowLayoutPanel5";
		flowLayoutPanel5.Size = new Size(522, 54);
		flowLayoutPanel5.TabIndex = 1;
		// 
		// FFmpegSystem
		// 
		FFmpegSystem.AutoSize = true;
		FFmpegSystem.Checked = true;
		FFmpegSystem.Location = new Point(3, 3);
		FFmpegSystem.Name = "FFmpegSystem";
		FFmpegSystem.Padding = new Padding(3, 0, 3, 0);
		FFmpegSystem.Size = new Size(96, 19);
		FFmpegSystem.TabIndex = 0;
		FFmpegSystem.TabStop = true;
		FFmpegSystem.Tag = "0";
		FFmpegSystem.Text = "System Path";
		FFmpegSystem.UseVisualStyleBackColor = true;
		FFmpegSystem.Click += FFmpegSystem_Click;
		// 
		// FFmpegApplication
		// 
		FFmpegApplication.AutoSize = true;
		FFmpegApplication.Location = new Point(105, 3);
		FFmpegApplication.Name = "FFmpegApplication";
		FFmpegApplication.Padding = new Padding(3, 0, 3, 0);
		FFmpegApplication.Size = new Size(119, 19);
		FFmpegApplication.TabIndex = 1;
		FFmpegApplication.Tag = "1";
		FFmpegApplication.Text = "Application Path";
		FFmpegApplication.UseVisualStyleBackColor = true;
		FFmpegApplication.Click += FFmpegApplication_Click;
		// 
		// radioButton3
		// 
		radioButton3.AutoSize = true;
		flowLayoutPanel5.SetFlowBreak(radioButton3, true);
		radioButton3.Location = new Point(230, 3);
		radioButton3.Name = "radioButton3";
		radioButton3.Padding = new Padding(3, 0, 3, 0);
		radioButton3.Size = new Size(109, 19);
		radioButton3.TabIndex = 2;
		radioButton3.Tag = "2";
		radioButton3.Text = "Custom Folder";
		radioButton3.UseVisualStyleBackColor = true;
		// 
		// label3
		// 
		label3.Anchor = AnchorStyles.Left;
		label3.AutoSize = true;
		label3.Location = new Point(3, 32);
		label3.Name = "label3";
		label3.Size = new Size(88, 15);
		label3.TabIndex = 6;
		label3.Text = "Custom Folder:";
		// 
		// FFmpegPath
		// 
		FFmpegPath.Location = new Point(97, 28);
		FFmpegPath.Name = "FFmpegPath";
		FFmpegPath.Size = new Size(339, 23);
		FFmpegPath.TabIndex = 4;
		// 
		// FFmpegBrowse
		// 
		FFmpegBrowse.Location = new Point(442, 28);
		FFmpegBrowse.Name = "FFmpegBrowse";
		FFmpegBrowse.Size = new Size(75, 23);
		FFmpegBrowse.TabIndex = 5;
		FFmpegBrowse.Text = "Browse";
		FFmpegBrowse.UseVisualStyleBackColor = true;
		FFmpegBrowse.Click += FFmpegBrowse_Click;
		// 
		// groupBox3
		// 
		groupBox3.AutoSize = true;
		groupBox3.Controls.Add(flowLayoutPanel6);
		groupBox3.Dock = DockStyle.Top;
		groupBox3.Location = new Point(6, 106);
		groupBox3.Margin = new Padding(6);
		groupBox3.MinimumSize = new Size(0, 50);
		groupBox3.Name = "groupBox3";
		groupBox3.Padding = new Padding(6, 6, 6, 12);
		groupBox3.Size = new Size(534, 63);
		groupBox3.TabIndex = 3;
		groupBox3.TabStop = false;
		groupBox3.Text = "Performance";
		// 
		// flowLayoutPanel6
		// 
		flowLayoutPanel6.AutoSize = true;
		flowLayoutPanel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		flowLayoutPanel6.Controls.Add(label4);
		flowLayoutPanel6.Controls.Add(FFmpegThreads);
		flowLayoutPanel6.Controls.Add(label5);
		flowLayoutPanel6.Dock = DockStyle.Fill;
		flowLayoutPanel6.Location = new Point(6, 22);
		flowLayoutPanel6.MinimumSize = new Size(0, 28);
		flowLayoutPanel6.Name = "flowLayoutPanel6";
		flowLayoutPanel6.Size = new Size(522, 29);
		flowLayoutPanel6.TabIndex = 1;
		// 
		// label4
		// 
		label4.Anchor = AnchorStyles.Left;
		label4.AutoSize = true;
		label4.Location = new Point(3, 7);
		label4.Name = "label4";
		label4.Size = new Size(51, 15);
		label4.TabIndex = 2;
		label4.Text = "Threads:";
		// 
		// FFmpegThreads
		// 
		FFmpegThreads.Location = new Point(60, 3);
		FFmpegThreads.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
		FFmpegThreads.Name = "FFmpegThreads";
		FFmpegThreads.Size = new Size(38, 23);
		FFmpegThreads.TabIndex = 3;
		FFmpegThreads.TextAlign = HorizontalAlignment.Center;
		// 
		// label5
		// 
		label5.Anchor = AnchorStyles.Left;
		label5.AutoSize = true;
		label5.Location = new Point(104, 7);
		label5.Name = "label5";
		label5.Size = new Size(185, 15);
		label5.TabIndex = 4;
		label5.Text = "set to zero for all available threads";
		// 
		// groupBox4
		// 
		groupBox4.AutoSize = true;
		groupBox4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		groupBox4.Controls.Add(flowLayoutPanel7);
		groupBox4.Dock = DockStyle.Top;
		groupBox4.Location = new Point(6, 181);
		groupBox4.Margin = new Padding(6);
		groupBox4.MinimumSize = new Size(534, 50);
		groupBox4.Name = "groupBox4";
		groupBox4.Padding = new Padding(6, 6, 6, 12);
		groupBox4.Size = new Size(534, 63);
		groupBox4.TabIndex = 4;
		groupBox4.TabStop = false;
		groupBox4.Text = "Logging";
		// 
		// flowLayoutPanel7
		// 
		flowLayoutPanel7.AutoSize = true;
		flowLayoutPanel7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		flowLayoutPanel7.Controls.Add(label6);
		flowLayoutPanel7.Controls.Add(FFmpegLogLevel);
		flowLayoutPanel7.Dock = DockStyle.Fill;
		flowLayoutPanel7.Location = new Point(6, 22);
		flowLayoutPanel7.MinimumSize = new Size(0, 28);
		flowLayoutPanel7.Name = "flowLayoutPanel7";
		flowLayoutPanel7.Size = new Size(522, 29);
		flowLayoutPanel7.TabIndex = 0;
		// 
		// label6
		// 
		label6.Anchor = AnchorStyles.Left;
		label6.AutoSize = true;
		label6.Location = new Point(3, 7);
		label6.Name = "label6";
		label6.Size = new Size(60, 15);
		label6.TabIndex = 3;
		label6.Text = "Log Level:";
		// 
		// FFmpegLogLevel
		// 
		FFmpegLogLevel.DisplayMember = "Name";
		FFmpegLogLevel.DropDownStyle = ComboBoxStyle.DropDownList;
		FFmpegLogLevel.FormattingEnabled = true;
		FFmpegLogLevel.Location = new Point(69, 3);
		FFmpegLogLevel.Name = "FFmpegLogLevel";
		FFmpegLogLevel.Size = new Size(100, 23);
		FFmpegLogLevel.TabIndex = 2;
		FFmpegLogLevel.ValueMember = "Key";
		// 
		// Options_Save
		// 
		Options_Save.Location = new Point(417, 426);
		Options_Save.Name = "Options_Save";
		Options_Save.Size = new Size(75, 23);
		Options_Save.TabIndex = 1;
		Options_Save.Text = "Save";
		Options_Save.UseVisualStyleBackColor = true;
		Options_Save.Click += Options_Save_Click;
		// 
		// Options_Cancel
		// 
		Options_Cancel.Location = new Point(498, 426);
		Options_Cancel.Name = "Options_Cancel";
		Options_Cancel.Size = new Size(75, 23);
		Options_Cancel.TabIndex = 2;
		Options_Cancel.Text = "Cancel";
		Options_Cancel.UseVisualStyleBackColor = true;
		Options_Cancel.Click += Options_Cancel_Click;
		// 
		// DataSource
		// 
		DataSource.AllowNew = false;
		// 
		// FolderBrowser
		// 
		FolderBrowser.Description = "Select Folder";
		FolderBrowser.ShowNewFolderButton = false;
		FolderBrowser.UseDescriptionForTitle = true;
		// 
		// Options
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(584, 461);
		Controls.Add(Options_Cancel);
		Controls.Add(Options_Save);
		Controls.Add(Options_TabGroup);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "Options";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "Options";
		Options_TabGroup.ResumeLayout(false);
		Options_General.ResumeLayout(false);
		flowLayoutPanel1.ResumeLayout(false);
		flowLayoutPanel1.PerformLayout();
		groupBox1.ResumeLayout(false);
		groupBox1.PerformLayout();
		flowLayoutPanel2.ResumeLayout(false);
		flowLayoutPanel2.PerformLayout();
		groupBox2.ResumeLayout(false);
		groupBox2.PerformLayout();
		flowLayoutPanel3.ResumeLayout(false);
		flowLayoutPanel3.PerformLayout();
		Options_FFmpeg.ResumeLayout(false);
		flowLayoutPanel4.ResumeLayout(false);
		flowLayoutPanel4.PerformLayout();
		FFmpegMode.ResumeLayout(false);
		FFmpegMode.PerformLayout();
		flowLayoutPanel5.ResumeLayout(false);
		flowLayoutPanel5.PerformLayout();
		groupBox3.ResumeLayout(false);
		groupBox3.PerformLayout();
		flowLayoutPanel6.ResumeLayout(false);
		flowLayoutPanel6.PerformLayout();
		((System.ComponentModel.ISupportInitialize)FFmpegThreads).EndInit();
		groupBox4.ResumeLayout(false);
		groupBox4.PerformLayout();
		flowLayoutPanel7.ResumeLayout(false);
		flowLayoutPanel7.PerformLayout();
		((System.ComponentModel.ISupportInitialize)DataSource).EndInit();
		ResumeLayout(false);
	}

	#endregion

	private TabControl Options_TabGroup;
	private TabPage Options_General;
	private TabPage Options_FFmpeg;
	private Button Options_Save;
	private Button Options_Cancel;
	private FlowLayoutPanel flowLayoutPanel1;
	private GroupBox groupBox1;
	private GroupBox groupBox2;
	private FlowLayoutPanel flowLayoutPanel2;
	private FlowLayoutPanel flowLayoutPanel3;
	private FlowLayoutPanel flowLayoutPanel4;
	private Controls.RadioGroup FFmpegMode;
	private FlowLayoutPanel flowLayoutPanel5;
	private RadioButton FFmpegSystem;
	private RadioButton FFmpegApplication;
	private RadioButton radioButton3;
	private TextBox FFmpegPath;
	private Button FFmpegBrowse;
	private ComboBox Language;
	private TextBox Extensions;
	private Label Options_General_Application_Language_Label;
	private Label label2;
	private Label label3;
	private GroupBox groupBox3;
	private FlowLayoutPanel flowLayoutPanel6;
	private Label label4;
	private NumericUpDown FFmpegThreads;
	private Label label5;
	private GroupBox groupBox4;
	private FlowLayoutPanel flowLayoutPanel7;
	private Label label6;
	private ComboBox FFmpegLogLevel;
	private BindingSource DataSource;
	private FolderBrowserDialog FolderBrowser;
}