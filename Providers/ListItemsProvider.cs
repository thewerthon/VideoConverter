namespace VideoConverter.Providers;

public static class ListItemsProvider {

	public static List<ListItem<string>> Languages { get; } = [

		new ListItem<string> { Key = "en", Name = "English" }

	];

	public static List<ListItem<string>> LogLevels { get; } = [

		new ListItem<string> { Key = "quiet", Name = "Quiet" },
		new ListItem<string> { Key = "panic", Name = "Panic" },
		new ListItem<string> { Key = "fatal", Name = "Fatal" },
		new ListItem<string> { Key = "error", Name = "Error" },
		new ListItem<string> { Key = "warning", Name = "Warning" },
		new ListItem<string> { Key = "info", Name = "Info" },
		new ListItem<string> { Key = "verbose", Name = "Verbose" },
		new ListItem<string> { Key = "debug", Name = "Debug" },
		new ListItem<string> { Key = "trace", Name = "Trace" }

	];

}