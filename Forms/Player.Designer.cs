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
		((System.ComponentModel.ISupportInitialize)VideoPlayer).BeginInit();
		panel1.SuspendLayout();
		SuspendLayout();
		// 
		// VideoPlayer
		// 
		VideoPlayer.BackColor = Color.Black;
		VideoPlayer.Enabled = false;
		VideoPlayer.Location = new Point(28, 21);
		VideoPlayer.MediaPlayer = null;
		VideoPlayer.MinimumSize = new Size(320, 180);
		VideoPlayer.Name = "VideoPlayer";
		VideoPlayer.Size = new Size(363, 244);
		VideoPlayer.TabIndex = 0;
		VideoPlayer.Text = "VideoPlayer";
		VideoPlayer.Click += VideoPlayer_Click;
		// 
		// panel1
		// 
		panel1.BackColor = Color.Transparent;
		panel1.Controls.Add(VideoPlayer);
		panel1.Location = new Point(94, 39);
		panel1.Name = "panel1";
		panel1.Size = new Size(418, 285);
		panel1.TabIndex = 1;
		panel1.Click += VideoPlayer_Click;
		// 
		// Player
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(624, 391);
		Controls.Add(panel1);
		MinimumSize = new Size(320, 180);
		Name = "Player";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "Player";
		((System.ComponentModel.ISupportInitialize)VideoPlayer).EndInit();
		panel1.ResumeLayout(false);
		ResumeLayout(false);
	}

	#endregion

	private LibVLCSharp.WinForms.VideoView VideoPlayer;
	private Panel panel1;
}