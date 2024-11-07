namespace VideoConverter.Database;

public static class DatabaseProvider {

	public static readonly DatabaseContext DatabaseContext = new();
	public static readonly string DatabaseName = "VideoConverter";
	public static readonly string DatabasePath = GetPath();

	private static string GetPath() {

		var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		var appPath = Path.Combine(appDataPath, DatabaseName);
		var dbPath = Path.Combine(appPath, $"{DatabaseName}.db");

		if (!Directory.Exists(appPath)) Directory.CreateDirectory(appPath);

		return dbPath;

	}

	public static void Migrate() {

		DatabaseContext.Database.Migrate();

	}

}