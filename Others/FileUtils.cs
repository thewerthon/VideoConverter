namespace VideoConverter.Others;

internal static class FileUtils {

	public static string GetCustomPath(string path) {

		return Directory.Exists(path) ? path : throw new ValidationException("Specified path does not exist.");

	}

	public static string GetFilePathInCustomPath(string path, string file) {

		var fullpath = Path.Combine(path, file);
		return Path.Exists(path) && File.Exists(fullpath) ? fullpath : throw new ValidationException($"Could not find {file} at the specified path");

	}

	public static string GetFilePathInCustomPaths(string[] paths, string file) {

		foreach (var path in paths) {

			var fullpath = Path.Combine(path, file);
			if (Path.Exists(path) && File.Exists(fullpath)) return fullpath;

		}

		throw new ValidationException($"Could not find {file} at the specified path");

	}

	public static string GetFilePathInApplicationPath(string file) {

		return GetFilePathInCustomPath(Application.StartupPath, file);

	}

	public static string GetFilePathInProgramFilesPath(string file) {

		var paths = new[] {
				Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
				Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
		};

		return GetFilePathInCustomPaths(paths, file);

	}

	public static string GetFilePathInSystemPath(string file) {

		var paths = Environment.GetEnvironmentVariable("PATH")?.Split(Path.PathSeparator) ?? [];
		return GetFilePathInCustomPaths(paths, file);

	}

}