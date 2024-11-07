using System.Reflection;
namespace VideoConverter.Models;

public class Setting {

	public int Id { get; set; }
	public string Language { get; set; } = "en";
	public string Extensions { get; set; } = ".avi .mkv .mov .mp4 .mpeg .mpg .ts .vob .webm .wmv";
	public FFmpeg FFmpeg { get; set; } = new();

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

		using var dbContext = new DatabaseContext();
		var setting = dbContext.Settings.FirstOrDefault();

		if (setting != null) {

			var properties = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
			foreach (var property in properties) property.SetValue(this, property.GetValue(setting));

		}

	}

	public void SaveToDatabase() {

		using var dbContext = new DatabaseContext();
		dbContext.Settings.Update(this);
		dbContext.SaveChanges();

	}

}