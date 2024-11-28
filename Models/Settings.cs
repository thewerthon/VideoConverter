using System.Reflection;
namespace VideoConverter.Models;

public class Settings {

	private static readonly DatabaseContext Database = DatabaseProvider.DatabaseContext;

	// General
	public int Id { get; set; }
	public string Language { get; set; } = "en";
	public string Extensions { get; set; } = ".avi .mkv .mov .mp4 .mpeg .mpg .ts .vob .webm .wmv";

	// Complexes
	public Settings_Files Files { get; set; } = new();
	public Settings_FFmpeg FFmpeg { get; set; } = new();
	public Settings_FFplay FFplay { get; set; } = new();

	public void Validate() {

		ValidateLanguage();
		ValidateExtensions();

		FFmpeg.Validate();

	}

	public void ValidateLanguage() {

		if (!ListItemsProvider.Languages.Any(item => item.Key == Language))
			throw new ValidationException("Language is invalid.");

	}

	public void ValidateExtensions() {

		if (!RegExesProvider.AllowedExtensions().IsMatch(Extensions))
			throw new ValidationException("Invalid allowed file extensions.\nPlease, check if extensions are punctuated and space separated. They must look like this: .avi .mp4 .mkv .ts");

	}

	public void LoadFromDatabase() {

		var setting = Database.Settings.FirstOrDefault();

		if (setting != null) {

			var properties = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
			foreach (var property in properties) property.SetValue(this, property.GetValue(setting));

		}

	}

	public void SaveToDatabase() {

		Database.Settings.Update(this);
		Database.SaveChanges();

	}

}

public class Settings_Files {

	public bool GroupByFolders { get; set; } = false;

}

public class Settings_FFmpeg {

	public int Mode { get; set; } = 0;
	public string CustomPath { get; set; } = string.Empty;
	public string EncoderPath { get; private set; } = string.Empty;
	public string PlayerPath { get; private set; } = string.Empty;
	public string ProbePath { get; private set; } = string.Empty;
	public string LogLevel { get; set; } = "error";
	public int Threads { get; set; } = 0;

	public const string FFMPEG_FILE = "ffmpeg.exe";
	public const string FFPLAY_FILE = "ffplay.exe";
	public const string FFPROBE_FILE = "ffprobe.exe";

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

		switch (Mode) {

			case 0: // System Path
				EncoderPath = FileUtils.GetFilePathInSystemPath(FFMPEG_FILE);
				PlayerPath = FileUtils.GetFilePathInSystemPath(FFPLAY_FILE);
				ProbePath = FileUtils.GetFilePathInSystemPath(FFPROBE_FILE);
				break;

			case 1: // Application Path
				EncoderPath = FileUtils.GetFilePathInApplicationPath(FFMPEG_FILE);
				PlayerPath = FileUtils.GetFilePathInApplicationPath(FFPLAY_FILE);
				ProbePath = FileUtils.GetFilePathInApplicationPath(FFPROBE_FILE);
				break;

			case 2: // Custom Path
				CustomPath = FileUtils.GetCustomPath(CustomPath);
				EncoderPath = FileUtils.GetFilePathInCustomPath(CustomPath, FFMPEG_FILE);
				PlayerPath = FileUtils.GetFilePathInCustomPath(CustomPath, FFPLAY_FILE);
				ProbePath = FileUtils.GetFilePathInCustomPath(CustomPath, FFPROBE_FILE);
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

		if (Threads is < 0 or > 64)
			throw new ValidationException("FFmpeg threads must be between 0 and 64.");

	}

}

public class Settings_FFplay {

	public string WindowSize { get; set; } = "640x480";
	public bool Fullscreen { get; set; } = false;
	public int Volume { get; set; } = 100;

	public void Validate() {

		ValidateWindowSize();
		ValidateVolume();

	}

	public void ValidateWindowSize() {

		if (!RegExesProvider.WindowSizeFormat().IsMatch(WindowSize))
			throw new ValidationException("FFplay window size must be in the format WIDTHxHEIGHT (e.g., 640x480).");

		var match = RegExesProvider.WindowSizeFormat().Match(WindowSize);
		var width = int.Parse(match.Groups["width"].Value);
		var height = int.Parse(match.Groups["height"].Value);

		if (width is < 60 or > 7680 || height is < 60 or > 7680)
			throw new ValidationException("FFplay width and height must be between 60 and 7680.");

	}

	public void ValidateVolume() {

		if (Volume is < 0 or > 100)
			throw new ValidationException("FFplay volume must be between 0 and 100.");

	}

}