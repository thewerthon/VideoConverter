using System.Globalization;
namespace VideoConverter;

internal static class Program {

	[STAThread]
	static void Main() {

		DatabaseProvider.Migrate();

		var language = SettingsProvider.Current.Language;
		Thread.CurrentThread.CurrentUICulture = new CultureInfo(language ?? "en");

		ApplicationConfiguration.Initialize();
		Application.Run(new Main());

	}

}