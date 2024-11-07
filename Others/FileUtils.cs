namespace VideoConverter.Others;

internal static class FileUtils {

	public static bool FileExistsInPath(string path, string fileName) {

		return File.Exists(Path.Combine(path, fileName));

	}

	public static bool FileExistsInApplicationPath(string fileName) {

		return File.Exists(Path.Combine(Application.StartupPath, fileName));

	}

	public static bool FileExistsInSystemPath(string fileName) {

		var paths = Environment.GetEnvironmentVariable("PATH")?.Split(Path.PathSeparator) ?? [];
		return paths.Any(path => File.Exists(Path.Combine(path, fileName)));

	}

}