using System.Diagnostics;
namespace VideoConverter.Providers;

public static class FFplayProvider {

	private static readonly Settings Settings = SettingsProvider.Current;

	public static void Validate() {

		Settings.FFmpeg.Validate();
		Settings.FFplay.Validate();

	}

	public static void Play(string path, int? videoindex = null, int? audioindex = null, int? subindex = null) {

		Validate();

		if (!File.Exists(path))
			throw new FileNotFoundException($"The specified media file was not found: {path}");

		var file = Settings.FFmpeg.PlayerPath;
		var args = string.Empty;

		args += $"\"{path}\" ";
		args += $"-x {Settings.FFplay.WindowSize.Split("x")[0]} ";
		args += $"-y {Settings.FFplay.WindowSize.Split("x")[1]} ";
		args += $"-volume {Settings.FFplay.Volume} ";

		if (Settings.FFplay.Fullscreen) args += $"-fs ";
		if (videoindex != null) args += $"-vst {videoindex} ";
		if (audioindex != null) args += $"-ast {audioindex} ";
		if (subindex != null) args += $"-sst {subindex} ";

		var process = new Process {
			StartInfo = new ProcessStartInfo {
				FileName = file,
				Arguments = args,
				UseShellExecute = false,
				CreateNoWindow = true
			}
		};

		try {

			process.Start();
			process.WaitForExit();

		} catch (Exception ex) {

			throw new Exception($"Failed to play media using FFplay: {ex.Message}", ex);

		}

	}

}