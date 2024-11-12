using LibVLCSharp.Shared;
namespace VideoConverter.Forms;

public partial class Player : Form {

	private readonly LibVLC LibVLC;
	private readonly Media Media;
	private readonly MediaPlayer MediaPlayer;

	public Player(string filePath, int? videoStreamIndex = null, int? audioStreamIndex = null, int? subtitleStreamIndex = null, int audioVolume = 100) {

		InitializeComponent();
		Core.Initialize();

		LibVLC = new LibVLC();

		MediaPlayer = new MediaPlayer(LibVLC) {
			Volume = audioVolume
		};

		Media = new Media(LibVLC, new Uri(filePath));
		if (videoStreamIndex is not null) Media.AddOption($":video-track={videoStreamIndex}");
		if (audioStreamIndex is not null) Media.AddOption($":audio-track={audioStreamIndex}");
		if (subtitleStreamIndex is not null) Media.AddOption($":sub-track={subtitleStreamIndex}");

		VideoPlayer.MediaPlayer = MediaPlayer;
		MediaPlayer.Play(Media);

	}

	protected override void OnFormClosed(FormClosedEventArgs e) {

		MediaPlayer?.Dispose();
		LibVLC?.Dispose();

		base.OnFormClosed(e);

	}

	private void VideoPlayer_Click(object sender, EventArgs e) {

		switch (MediaPlayer.State) {

			case VLCState.Playing:
				MediaPlayer.Pause();
				break;

			case VLCState.Paused:
				MediaPlayer.Play();
				break;

			case VLCState.Stopped:
				MediaPlayer.Position = 0;
				MediaPlayer.Play();
				break;

			case VLCState.Ended:
				MediaPlayer.Position = 0;
				MediaPlayer.Play();
				break;

		}

	}

}