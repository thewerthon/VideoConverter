namespace VideoConverter.Models;

public class FFmpeg {

	public int Mode { get; set; } = 0;
	public string Path { get; set; } = string.Empty;
	public string LogLevel { get; set; } = "error";
	public int Threads { get; set; } = 0;

	public void Validate() {

		ValidateMode();
		ValidatePath();
		ValidateLogLevel();
		ValidateThreads();

	}

	public void ValidateMode() {

		if (Mode is < 0 or > 2)
			throw new ValidationException("FFmpeg mode must be between 0 and 2.");

	}

	public void ValidatePath() {

		var files = new[] { "ffmpeg.exe", "ffplay.exe", "ffprobe.exe" };

		switch (Mode) {

			case 0: // System Path
				foreach (var file in files) if (!FileUtils.FileExistsInSystemPath(file)) throw new ValidationException($"File {file} is not present in system path.");
				break;

			case 1: // Application Path
				foreach (var file in files) if (!FileUtils.FileExistsInApplicationPath(file)) throw new ValidationException($"File {file} is not present in application path.");
				break;

			case 2: // Custom Path
				if (!Directory.Exists(Path)) throw new ValidationException("Specified FFmpeg path does not exist.");
				foreach (var file in files) if (!FileUtils.FileExistsInPath(Path, file)) throw new ValidationException($"File {file} is not present in the specified path.");
				break;

			default:
				throw new ValidationException("Invalid FFmpeg mode.");

		}

	}

	public void ValidateLogLevel() {

		if (!ListItemsProvider.LogLevels.Any(item => item.Key == LogLevel))
			throw new ValidationException("FFmpeg log level is invalid.");

	}

	public void ValidateThreads() {

		if (Threads is < 0 or > 32)
			throw new ValidationException("FFmpeg threads must be between 0 and 32.");

	}

}