namespace VideoConverter.Providers;

public static class SettingsProvider {

	private static readonly DatabaseContext Database = DatabaseProvider.DatabaseContext;

	public static Settings Current { get; set; } = LoadFromDatabase();
	public static Settings Temporary { get; set; } = LoadFromDatabase();

	private static Settings LoadFromDatabase() {

		return Database.Settings.FirstOrDefault() ?? new();

	}

}