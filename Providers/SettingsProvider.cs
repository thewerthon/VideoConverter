namespace VideoConverter.Providers;

public static class SettingsProvider {

	public static Setting Current { get; set; } = LoadFromDatabase();
	public static Setting Temporary { get; set; } = LoadFromDatabase();

	private static Setting LoadFromDatabase() {

		using var dbContext = new DatabaseContext();
		return dbContext.Settings.FirstOrDefault() ?? new();

	}

}