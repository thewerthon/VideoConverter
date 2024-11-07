namespace VideoConverter.Providers;

public static class SettingsProvider {

	private static readonly DatabaseContext Database = DatabaseProvider.DatabaseContext;

	public static Setting Current { get; set; } = LoadFromDatabase();
	public static Setting Temporary { get; set; } = LoadFromDatabase();

	private static Setting LoadFromDatabase() {

		return Database.Settings.FirstOrDefault() ?? new();

	}

}