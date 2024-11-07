namespace VideoConverter.Providers;

public static class FileItemsProvider {

	private static readonly DatabaseContext Database = DatabaseProvider.DatabaseContext;
	private static readonly Setting Settings = SettingsProvider.Current;

	public static List<FileItem> FileItems { get; set; } = LoadFromDatabase();
	public static event Action? FileItemsChanged;

	public static void AddFiles(string[] paths) {

		foreach (var path in paths) {

			if (File.Exists(path)) {

				if (Settings.Extensions.Contains(Path.GetExtension(path), StringComparison.CurrentCultureIgnoreCase)) {

					if (!FileItems.Any(i => i.Path == path)) {

						var file = new FileItem(path);
						FileItems.Add(file);

					}

				}

			}

		}

		FileItemsChanged?.Invoke();

	}

	public static void AddFolders(string[] paths, bool recurse = false) {

		foreach (var path in paths) {

			if (Directory.Exists(path)) {

				var filePaths = Directory.GetFiles(path, "*.*", recurse ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

				foreach (var filePath in filePaths) {

					if (Settings.Extensions.Contains(Path.GetExtension(path), StringComparison.CurrentCultureIgnoreCase)) {

						if (!FileItems.Any(i => i.Path == filePath)) {

							var file = new FileItem(filePath);
							FileItems.Add(file);

						}

					}

				}

			}

		}

		FileItemsChanged?.Invoke();

	}

	public static List<FileItem> LoadFromDatabase() {

		var files = Database.FileItems.AsNoTracking().ToList();
		return files;

	}

	public static void SaveToDatabase() {

		//foreach (var item in Items) if (Database.FileItems.Any(i => i.Id == item.Id)) { Database.FileItems.Update(item); } else { Database.FileItems.Add(item); }
		foreach (var item in FileItems) Database.FileItems.Update(item);
		Database.SaveChanges();

	}

}