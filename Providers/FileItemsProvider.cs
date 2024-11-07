namespace VideoConverter.Providers;

public static class FileItemsProvider {

	private static readonly Setting Settings = SettingsProvider.Current;
	private static readonly DatabaseContext Database = DatabaseProvider.DatabaseContext;

	public static List<FileItem> FileItems { get; set; } = [];
	public static long FilesAdded { get; private set; } = 0;
	public static long FilesRemoved { get; private set; } = 0;

	public static event Action? FileItemsLoaded;
	public static event Action? FileItemsSynced;
	public static event Action? FileItemsCleared;
	public static event Action<FileItem>? FileItemAdded;
	public static event Action<FileItem>? FileItemRemoved;

	public static void LoadFromDatabase() {

		FileItems = [.. Database.FileItems];
		FileItemsLoaded?.Invoke();

	}

	public static void SyncWithDatabase() {

		var dbItems = Database.FileItems.ToList();

		var itemsToAdd = FileItems.Where(item => !dbItems.Any(dbItem => dbItem.Path == item.Path)).ToList();
		var itemsToUpdate = FileItems.Where(item => dbItems.Any(dbItem => dbItem.Path == item.Path)).ToList();
		var itemsToRemove = dbItems.Where(dbItem => !FileItems.Any(file => file.Path == dbItem.Path)).ToList();

		if (itemsToAdd.Count > 0) Database.FileItems.AddRange(itemsToAdd);
		if (itemsToUpdate.Count > 0) Database.FileItems.UpdateRange(itemsToUpdate);
		if (itemsToRemove.Count > 0) Database.FileItems.RemoveRange(itemsToRemove);

		Database.SaveChanges();
		Database.ChangeTracker.Clear();
		FileItemsSynced?.Invoke();

	}

	public static void ClearFiles() {

		FileItems.Clear();
		FileItemsCleared?.Invoke();

		SyncWithDatabase();

	}

	public static void AddFiles(string[] paths) {

		FilesAdded = 0;

		foreach (var path in paths) {

			if (File.Exists(path)) {

				if (FileAllowed(path)) {

					if (!FileItems.Any(i => i.Path == path)) {

						var file = new FileItem(path);

						FilesAdded++;
						FileItems.Add(file);
						FileItemAdded?.Invoke(file);

					}

				}

			}

		}

		if (FilesAdded > 0) SyncWithDatabase();

	}

	public static void AddFolders(string[] paths, bool recurse = false) {

		FilesAdded = 0;

		foreach (var path in paths) {

			if (Directory.Exists(path)) {

				var filePaths = Directory.GetFiles(path, "*.*", recurse ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

				foreach (var filePath in filePaths) {

					if (FileAllowed(filePath)) {

						if (!FileItems.Any(i => i.Path == filePath)) {

							var file = new FileItem(filePath);

							FilesAdded++;
							FileItems.Add(file);
							FileItemAdded?.Invoke(file);

						}

					}

				}

			}

		}

		if (FilesAdded > 0) SyncWithDatabase();

	}

	public static void RemoveFile(string path) {

		FilesRemoved = 0;

		var file = FileItems.FirstOrDefault(i => i.Path == path);

		if (file != null) {

			FilesRemoved++;
			FileItems.Remove(file);
			FileItemRemoved?.Invoke(file);

		}

		if (FilesRemoved > 0) SyncWithDatabase();

	}

	public static void RemoveFiles(string[] paths) {

		FilesRemoved = 0;

		foreach (var path in paths) {

			var file = FileItems.FirstOrDefault(i => i.Path == path);

			if (file != null) {

				FilesRemoved++;
				FileItems.Remove(file);
				FileItemRemoved?.Invoke(file);

			}

		}

		if (FilesRemoved > 0) SyncWithDatabase();

	}

	public static bool FileAllowed(string path) {

		var ext = Path.GetExtension(path);
		var exts = AllowedExtensions();

		return exts.Contains(ext, StringComparer.OrdinalIgnoreCase);

	}

	public static string[] AllowedExtensions() {

		return Settings.Extensions.Split(" ");

	}

}