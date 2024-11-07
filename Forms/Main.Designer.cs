namespace VideoConverter.Forms;

partial class Main {
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
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
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
		Menu = new MenuStrip();
		Menu_File = new ToolStripMenuItem();
		Menu_AddFiles = new ToolStripMenuItem();
		Menu_AddFolder = new ToolStripMenuItem();
		Menu_ClearList = new ToolStripMenuItem();
		toolStripSeparator1 = new ToolStripSeparator();
		Menu_Options = new ToolStripMenuItem();
		toolStripSeparator2 = new ToolStripSeparator();
		Menu_Exit = new ToolStripMenuItem();
		Menu_Edit = new ToolStripMenuItem();
		editSingleToolStripMenuItem = new ToolStripMenuItem();
		editMultipleToolStripMenuItem = new ToolStripMenuItem();
		Menu_Process = new ToolStripMenuItem();
		startProcessToolStripMenuItem = new ToolStripMenuItem();
		stopProcessToolStripMenuItem = new ToolStripMenuItem();
		Menu_Help = new ToolStripMenuItem();
		Menu_Help_GitHub = new ToolStripMenuItem();
		Menu_Help_Donate = new ToolStripMenuItem();
		Menu_Help_About = new ToolStripMenuItem();
		panel1 = new Panel();
		ToolBar = new ToolStrip();
		AddFiles = new ToolStripButton();
		AddFolder = new ToolStripButton();
		ClearList = new ToolStripButton();
		toolStripSeparator3 = new ToolStripSeparator();
		SingleEdit = new ToolStripButton();
		BatchEdit = new ToolStripButton();
		toolStripSeparator4 = new ToolStripSeparator();
		StartProcess = new ToolStripButton();
		StopProcess = new ToolStripButton();
		panel2 = new Panel();
		ListView = new ListView();
		columnHeader1 = new ColumnHeader();
		columnHeader2 = new ColumnHeader();
		columnHeader3 = new ColumnHeader();
		columnHeader4 = new ColumnHeader();
		columnHeader5 = new ColumnHeader();
		AddFilesDialog = new OpenFileDialog();
		AddFolderDialog = new FolderBrowserDialog();
		Menu.SuspendLayout();
		ToolBar.SuspendLayout();
		SuspendLayout();
		// 
		// Menu
		// 
		Menu.Items.AddRange(new ToolStripItem[] { Menu_File, Menu_Edit, Menu_Process, Menu_Help });
		Menu.Location = new Point(0, 0);
		Menu.Name = "Menu";
		Menu.Size = new Size(784, 24);
		Menu.TabIndex = 0;
		Menu.Text = "menuStrip1";
		// 
		// Menu_File
		// 
		Menu_File.DropDownItems.AddRange(new ToolStripItem[] { Menu_AddFiles, Menu_AddFolder, Menu_ClearList, toolStripSeparator1, Menu_Options, toolStripSeparator2, Menu_Exit });
		Menu_File.Name = "Menu_File";
		Menu_File.Size = new Size(37, 20);
		Menu_File.Text = "File";
		// 
		// Menu_AddFiles
		// 
		Menu_AddFiles.Image = Properties.Images.icon_add_16;
		Menu_AddFiles.Name = "Menu_AddFiles";
		Menu_AddFiles.Size = new Size(180, 22);
		Menu_AddFiles.Text = "Add Files";
		Menu_AddFiles.Click += AddFiles_Click;
		// 
		// Menu_AddFolder
		// 
		Menu_AddFolder.Image = Properties.Images.icon_add_folder_16;
		Menu_AddFolder.Name = "Menu_AddFolder";
		Menu_AddFolder.Size = new Size(180, 22);
		Menu_AddFolder.Text = "Add Folder";
		Menu_AddFolder.Click += AddFolder_Click;
		// 
		// Menu_ClearList
		// 
		Menu_ClearList.AccessibleDescription = "";
		Menu_ClearList.Image = Properties.Images.icon_erase_16;
		Menu_ClearList.Name = "Menu_ClearList";
		Menu_ClearList.Size = new Size(180, 22);
		Menu_ClearList.Text = "Clear List";
		Menu_ClearList.Click += ClearList_Click;
		// 
		// toolStripSeparator1
		// 
		toolStripSeparator1.Name = "toolStripSeparator1";
		toolStripSeparator1.Size = new Size(177, 6);
		// 
		// Menu_Options
		// 
		Menu_Options.AccessibleDescription = "";
		Menu_Options.Image = Properties.Images.icon_settings_16;
		Menu_Options.Name = "Menu_Options";
		Menu_Options.Size = new Size(180, 22);
		Menu_Options.Text = "Options";
		Menu_Options.Click += Menu_Options_Click;
		// 
		// toolStripSeparator2
		// 
		toolStripSeparator2.Name = "toolStripSeparator2";
		toolStripSeparator2.Size = new Size(177, 6);
		// 
		// Menu_Exit
		// 
		Menu_Exit.AccessibleDescription = "";
		Menu_Exit.Image = Properties.Images.icon_close_16;
		Menu_Exit.Name = "Menu_Exit";
		Menu_Exit.Size = new Size(180, 22);
		Menu_Exit.Text = "Exit";
		Menu_Exit.Click += Menu_Exit_Click;
		// 
		// Menu_Edit
		// 
		Menu_Edit.DropDownItems.AddRange(new ToolStripItem[] { editSingleToolStripMenuItem, editMultipleToolStripMenuItem });
		Menu_Edit.Name = "Menu_Edit";
		Menu_Edit.Size = new Size(78, 20);
		Menu_Edit.Text = "Parameters";
		// 
		// editSingleToolStripMenuItem
		// 
		editSingleToolStripMenuItem.Image = Properties.Images.icon_edit_16;
		editSingleToolStripMenuItem.Name = "editSingleToolStripMenuItem";
		editSingleToolStripMenuItem.Size = new Size(129, 22);
		editSingleToolStripMenuItem.Text = "Single Edit";
		// 
		// editMultipleToolStripMenuItem
		// 
		editMultipleToolStripMenuItem.Image = Properties.Images.icon_form_16;
		editMultipleToolStripMenuItem.Name = "editMultipleToolStripMenuItem";
		editMultipleToolStripMenuItem.Size = new Size(129, 22);
		editMultipleToolStripMenuItem.Text = "Batch Edit";
		// 
		// Menu_Process
		// 
		Menu_Process.DropDownItems.AddRange(new ToolStripItem[] { startProcessToolStripMenuItem, stopProcessToolStripMenuItem });
		Menu_Process.Name = "Menu_Process";
		Menu_Process.Size = new Size(59, 20);
		Menu_Process.Text = "Process";
		// 
		// startProcessToolStripMenuItem
		// 
		startProcessToolStripMenuItem.Image = Properties.Images.icon_play_16;
		startProcessToolStripMenuItem.Name = "startProcessToolStripMenuItem";
		startProcessToolStripMenuItem.Size = new Size(141, 22);
		startProcessToolStripMenuItem.Text = "Start Process";
		// 
		// stopProcessToolStripMenuItem
		// 
		stopProcessToolStripMenuItem.Image = Properties.Images.icon_stop_16;
		stopProcessToolStripMenuItem.Name = "stopProcessToolStripMenuItem";
		stopProcessToolStripMenuItem.Size = new Size(141, 22);
		stopProcessToolStripMenuItem.Text = "Stop Process";
		// 
		// Menu_Help
		// 
		Menu_Help.DropDownItems.AddRange(new ToolStripItem[] { Menu_Help_GitHub, Menu_Help_Donate, Menu_Help_About });
		Menu_Help.Name = "Menu_Help";
		Menu_Help.Size = new Size(44, 20);
		Menu_Help.Text = "Help";
		// 
		// Menu_Help_GitHub
		// 
		Menu_Help_GitHub.Image = Properties.Images.icon_github_16;
		Menu_Help_GitHub.Name = "Menu_Help_GitHub";
		Menu_Help_GitHub.Size = new Size(112, 22);
		Menu_Help_GitHub.Text = "GitHub";
		// 
		// Menu_Help_Donate
		// 
		Menu_Help_Donate.Image = Properties.Images.icon_heart_16;
		Menu_Help_Donate.Name = "Menu_Help_Donate";
		Menu_Help_Donate.Size = new Size(112, 22);
		Menu_Help_Donate.Text = "Donate";
		// 
		// Menu_Help_About
		// 
		Menu_Help_About.Image = Properties.Images.icon_info_16;
		Menu_Help_About.Name = "Menu_Help_About";
		Menu_Help_About.Size = new Size(112, 22);
		Menu_Help_About.Text = "About";
		// 
		// panel1
		// 
		panel1.BackColor = SystemColors.ControlLight;
		panel1.Dock = DockStyle.Top;
		panel1.Location = new Point(0, 24);
		panel1.Name = "panel1";
		panel1.Size = new Size(784, 1);
		panel1.TabIndex = 2;
		// 
		// ToolBar
		// 
		ToolBar.GripStyle = ToolStripGripStyle.Hidden;
		ToolBar.ImageScalingSize = new Size(24, 24);
		ToolBar.Items.AddRange(new ToolStripItem[] { AddFiles, AddFolder, ClearList, toolStripSeparator3, SingleEdit, BatchEdit, toolStripSeparator4, StartProcess, StopProcess });
		ToolBar.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
		ToolBar.Location = new Point(0, 25);
		ToolBar.Name = "ToolBar";
		ToolBar.Padding = new Padding(6);
		ToolBar.Size = new Size(784, 40);
		ToolBar.TabIndex = 3;
		ToolBar.Text = "toolStrip1";
		// 
		// AddFiles
		// 
		AddFiles.Image = Properties.Images.icon_add_24;
		AddFiles.ImageTransparentColor = Color.Magenta;
		AddFiles.Margin = new Padding(0, 0, 6, 0);
		AddFiles.Name = "AddFiles";
		AddFiles.Size = new Size(86, 28);
		AddFiles.Text = " Add Files";
		AddFiles.ToolTipText = "Add Files";
		AddFiles.Click += AddFiles_Click;
		// 
		// AddFolder
		// 
		AddFolder.Image = Properties.Images.icon_add_folder_24;
		AddFolder.ImageTransparentColor = Color.Magenta;
		AddFolder.Margin = new Padding(0, 0, 6, 0);
		AddFolder.Name = "AddFolder";
		AddFolder.Size = new Size(96, 28);
		AddFolder.Text = " Add Folder";
		AddFolder.ToolTipText = "Add Folder";
		AddFolder.Click += AddFolder_Click;
		// 
		// ClearList
		// 
		ClearList.Image = Properties.Images.icon_erase_24;
		ClearList.ImageTransparentColor = Color.Magenta;
		ClearList.Margin = new Padding(0, 0, 6, 0);
		ClearList.Name = "ClearList";
		ClearList.Size = new Size(86, 28);
		ClearList.Text = " Clear List";
		ClearList.ToolTipText = "Clear List";
		ClearList.Click += ClearList_Click;
		// 
		// toolStripSeparator3
		// 
		toolStripSeparator3.Margin = new Padding(0, 0, 6, 0);
		toolStripSeparator3.Name = "toolStripSeparator3";
		toolStripSeparator3.Size = new Size(6, 28);
		// 
		// SingleEdit
		// 
		SingleEdit.Image = Properties.Images.icon_edit_24;
		SingleEdit.ImageTransparentColor = Color.Magenta;
		SingleEdit.Margin = new Padding(0, 0, 6, 0);
		SingleEdit.Name = "SingleEdit";
		SingleEdit.Size = new Size(93, 28);
		SingleEdit.Text = " Single Edit";
		SingleEdit.ToolTipText = "Single Edit";
		// 
		// BatchEdit
		// 
		BatchEdit.Image = Properties.Images.icon_form_24;
		BatchEdit.ImageTransparentColor = Color.Magenta;
		BatchEdit.Margin = new Padding(0, 0, 6, 0);
		BatchEdit.Name = "BatchEdit";
		BatchEdit.Size = new Size(91, 28);
		BatchEdit.Text = " Batch Edit";
		BatchEdit.ToolTipText = "Batch Edit";
		// 
		// toolStripSeparator4
		// 
		toolStripSeparator4.Margin = new Padding(0, 0, 6, 0);
		toolStripSeparator4.Name = "toolStripSeparator4";
		toolStripSeparator4.Size = new Size(6, 28);
		// 
		// StartProcess
		// 
		StartProcess.Image = Properties.Images.icon_play_24;
		StartProcess.ImageTransparentColor = Color.Magenta;
		StartProcess.Margin = new Padding(0, 0, 6, 0);
		StartProcess.Name = "StartProcess";
		StartProcess.Size = new Size(105, 28);
		StartProcess.Text = " Start Process";
		StartProcess.ToolTipText = "Start Process";
		// 
		// StopProcess
		// 
		StopProcess.Image = Properties.Images.icon_stop_24;
		StopProcess.ImageTransparentColor = Color.Magenta;
		StopProcess.Margin = new Padding(0, 0, 6, 0);
		StopProcess.Name = "StopProcess";
		StopProcess.Size = new Size(105, 28);
		StopProcess.Text = " Stop Process";
		StopProcess.ToolTipText = "Stop Process";
		// 
		// panel2
		// 
		panel2.BackColor = SystemColors.ControlLight;
		panel2.Dock = DockStyle.Top;
		panel2.Location = new Point(0, 65);
		panel2.Name = "panel2";
		panel2.Size = new Size(784, 1);
		panel2.TabIndex = 4;
		// 
		// ListView
		// 
		ListView.AllowDrop = true;
		ListView.BorderStyle = BorderStyle.None;
		ListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
		ListView.Dock = DockStyle.Fill;
		ListView.GridLines = true;
		ListView.Location = new Point(0, 66);
		ListView.Margin = new Padding(0, 3, 0, 0);
		ListView.Name = "ListView";
		ListView.Size = new Size(784, 495);
		ListView.TabIndex = 5;
		ListView.UseCompatibleStateImageBehavior = false;
		ListView.View = View.Details;
		ListView.DragDrop += ListView_DragDrop;
		ListView.DragEnter += ListView_DragEnter;
		// 
		// columnHeader1
		// 
		columnHeader1.Tag = "ID";
		columnHeader1.Text = "ID";
		columnHeader1.Width = 50;
		// 
		// columnHeader2
		// 
		columnHeader2.Tag = "Name";
		columnHeader2.Text = "Name";
		columnHeader2.Width = 200;
		// 
		// columnHeader3
		// 
		columnHeader3.Tag = "Path";
		columnHeader3.Text = "Path";
		columnHeader3.Width = 300;
		// 
		// columnHeader4
		// 
		columnHeader4.Tag = "Extension";
		columnHeader4.Text = "Extension";
		columnHeader4.Width = 80;
		// 
		// columnHeader5
		// 
		columnHeader5.Tag = "Size";
		columnHeader5.Text = "Size";
		columnHeader5.Width = 100;
		// 
		// AddFilesDialog
		// 
		AddFilesDialog.Multiselect = true;
		AddFilesDialog.Title = "Add Files";
		// 
		// AddFolderDialog
		// 
		AddFolderDialog.Description = "Add Folder";
		AddFolderDialog.ShowNewFolderButton = false;
		AddFolderDialog.UseDescriptionForTitle = true;
		// 
		// Main
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(784, 561);
		Controls.Add(ListView);
		Controls.Add(panel2);
		Controls.Add(ToolBar);
		Controls.Add(panel1);
		Controls.Add(Menu);
		MainMenuStrip = Menu;
		MinimumSize = new Size(800, 600);
		Name = "Main";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "Video Converter";
		Menu.ResumeLayout(false);
		Menu.PerformLayout();
		ToolBar.ResumeLayout(false);
		ToolBar.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private MenuStrip Menu;
	private ToolStripMenuItem Menu_File;
	private ToolStripMenuItem Menu_AddFiles;
	private ToolStripMenuItem Menu_AddFolder;
	private ToolStripMenuItem Menu_ClearList;
	private ToolStripSeparator toolStripSeparator1;
	private ToolStripMenuItem Menu_Options;
	private ToolStripSeparator toolStripSeparator2;
	private ToolStripMenuItem Menu_Exit;
	private ToolStripMenuItem Menu_Edit;
	private ToolStripMenuItem Menu_Process;
	private ToolStripMenuItem Menu_Help;
	private ToolStripMenuItem Menu_Help_GitHub;
	private ToolStripMenuItem Menu_Help_Donate;
	private ToolStripMenuItem Menu_Help_About;
	private Panel panel1;
	private ToolStrip ToolBar;
	private Panel panel2;
	private ToolStripButton AddFiles;
	private ToolStripButton AddFolder;
	private ToolStripButton ClearList;
	private ToolStripSeparator toolStripSeparator3;
	private ToolStripButton SingleEdit;
	private ToolStripMenuItem editSingleToolStripMenuItem;
	private ToolStripMenuItem editMultipleToolStripMenuItem;
	private ToolStripMenuItem startProcessToolStripMenuItem;
	private ToolStripMenuItem stopProcessToolStripMenuItem;
	private ToolStripButton BatchEdit;
	private ToolStripSeparator toolStripSeparator4;
	private ToolStripButton StartProcess;
	private ToolStripButton StopProcess;
	private ListView ListView;
	private ColumnHeader columnHeader1;
	private ColumnHeader columnHeader2;
	private ColumnHeader columnHeader3;
	private ColumnHeader columnHeader4;
	private ColumnHeader columnHeader5;
	private OpenFileDialog AddFilesDialog;
	private FolderBrowserDialog AddFolderDialog;
}
