namespace VideoConverter.Providers;

public class FileItemsProvider : ListViewHandler<FileItem> {

	private static readonly Settings Settings = SettingsProvider.Current;
	private static readonly DatabaseContext Database = DatabaseProvider.DatabaseContext;

	public FileItemsProvider(ListView listView) : base(listView) {

		ListItemAdded += (item) => SaveToDatabase();
		ListItemUpdated += (item) => SaveToDatabase();
		ListItemRemoved += (item) => SaveToDatabase();
		ListItemsAdded += (items) => SaveToDatabase();
		ListItemsUpdated += (items) => SaveToDatabase();
		ListItemsRemoved += (items) => SaveToDatabase();
		ListItemsCleared += SaveToDatabase;

	}

	public void LoadFromDatabase() {

		Load([.. Database.FileItems]);

	}

	public void SaveToDatabase() {

		var items = Database.FileItems.ToList();

		var add = ListItems.Where(item => !items.Any(dbItem => dbItem.Path == item.Path)).ToList();
		var update = ListItems.Where(item => items.Any(dbItem => dbItem.Path == item.Path)).ToList();
		var remove = items.Where(dbItem => !ListItems.Any(file => file.Path == dbItem.Path)).ToList();

		if (add.Count > 0) Database.FileItems.AddRange(add);
		if (update.Count > 0) Database.FileItems.UpdateRange(update);
		if (remove.Count > 0) Database.FileItems.RemoveRange(remove);

		Database.SaveChanges();
		Database.ChangeTracker.Clear();

	}

	public static string[] AllowedExtensions() {

		return Settings.Extensions.Split(" ");

	}

	public static bool FileAllowed(string path) {

		var ext = Path.GetExtension(path);
		var exts = AllowedExtensions();

		return exts.Contains(ext, StringComparer.OrdinalIgnoreCase);

	}

	public void AddFiles(string[] paths) {

		var files = new List<FileItem>();

		foreach (var path in paths) {

			if (File.Exists(path) && FileAllowed(path)) {

				if (!ListItems.Any(i => i.Path == path)) {

					var item = new FileItem(path);
					files.Add(item);

				}

			}

		}

		if (files.Count > 0) Add(files);

	}

	public void AddFolders(string[] paths, bool recurse = false) {

		var files = new List<FileItem>();

		foreach (var path in paths) {

			if (Directory.Exists(path)) {

				var recursive = recurse ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
				var filepaths = Directory.GetFiles(path, "*.*", recursive);

				foreach (var filepath in filepaths) {

					if (File.Exists(filepath) && FileAllowed(filepath)) {

						if (!ListItems.Any(i => i.Path == filepath)) {

							var item = new FileItem(filepath);
							files.Add(item);

						}

					}

				}

			}

		}

		if (files.Count > 0) Add(files);

	}

	public void Play() {

		MessageBox.Show(SelectedItems.Count.ToString());

	}

}