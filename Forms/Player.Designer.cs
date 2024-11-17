namespace VideoConverter.Forms;

partial class Player {
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
		VideoPlayer = new LibVLCSharp.WinForms.VideoView();
		panel1 = new Panel();
		trackBar1 = new TrackBar();
		((System.ComponentModel.ISupportInitialize)VideoPlayer).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
		SuspendLayout();
		// 
		// VideoPlayer
		// 
		VideoPlayer.BackColor = Color.Black;
		VideoPlayer.Dock = DockStyle.Fill;
		VideoPlayer.Enabled = false;
		VideoPlayer.Location = new Point(0, 0);
		VideoPlayer.MediaPlayer = null;
		VideoPlayer.MinimumSize = new Size(320, 180);
		VideoPlayer.Name = "VideoPlayer";
		VideoPlayer.Size = new Size(470, 300);
		VideoPlayer.TabIndex = 0;
		VideoPlayer.Text = "VideoPlayer";
		VideoPlayer.Click += VideoPlayer_Click;
		// 
		// panel1
		// 
		panel1.BackColor = Color.Transparent;
		panel1.Controls.Add(VideoPlayer);
		panel1.Location = new Point(51, 12);
		panel1.Name = "panel1";
		panel1.Size = new Size(470, 300);
		panel1.TabIndex = 1;
		panel1.Click += VideoPlayer_Click;
		// 
		// trackBar1
		// 
		trackBar1.Location = new Point(51, 318);
		trackBar1.Maximum = 100;
		trackBar1.Name = "trackBar1";
		trackBar1.Size = new Size(470, 45);
		trackBar1.TabIndex = 2;
		trackBar1.Scroll += trackBar1_Scroll;
		// 
		// Player
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(624, 391);
		Controls.Add(trackBar1);
		Controls.Add(panel1);
		MinimumSize = new Size(320, 180);
		Name = "Player";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "Player";
		((System.ComponentModel.ISupportInitialize)VideoPlayer).EndInit();
		panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private LibVLCSharp.WinForms.VideoView VideoPlayer;
	private Panel panel1;
	private TrackBar trackBar1;
}