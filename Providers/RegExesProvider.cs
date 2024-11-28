namespace VideoConverter.Providers;

public static partial class RegExesProvider {

	[GeneratedRegex(@"^(\.[a-zA-Z0-9]+)(\s(\.[a-zA-Z0-9]+))*$")]
	public static partial Regex AllowedExtensions();

	[GeneratedRegex(@"^(?<width>[1-9]\d*)x(?<height>[1-9]\d*)$")]
	public static partial Regex WindowSizeFormat();

}