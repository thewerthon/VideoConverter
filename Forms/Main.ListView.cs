namespace VideoConverter.Forms;

public partial class Main : Form {

	private long Index = 0;
	private int SortColumn = -1;
	private SortOrder SortOrder = SortOrder.Ascending;

	private void ListItems_Load() {

		ListView.Items.Clear();
		ListView.Groups.Clear();

		PerformLongOperation(() => {

			foreach (var file in FileItemsProvider.FileItems) ListItems_Add(file);

		});

	}

	private void ListItems_Clear() {

		ListView.Items.Clear();
		ListView.Groups.Clear();

	}

	private void ListItems_Add(FileItem file) {

		Index = ListView.Items.Count > 0 ? Index + 1 : 1;

		var item = new ListViewItem(Index.ToString(" 00"));
		var group = ListView.Groups.Cast<ListViewGroup>().FirstOrDefault(g => g.Name == file.BasePath);

		if (Settings.Files.GroupByFolders) {

			if (group == null) {

				group = new ListViewGroup(file.BasePath, file.BasePath);
				ListView.Groups.Add(group);

			}

			item.Group = group;

		}

		item.SubItems.Add(file.Name);
		item.SubItems.Add(file.BasePath);
		item.SubItems.Add(file.GetSizeString());
		item.SubItems.Add(file.GetProgressString(), file.GetProgressColor(), item.BackColor, item.Font);

		item.Tag = file.Path;
		item.UseItemStyleForSubItems = false;

		ListView.Items.Add(item);

	}

	private void ListItems_Remove(FileItem file) {

		var item = ListView.Items.Cast<ListViewItem>().FirstOrDefault(i => i.Tag?.ToString() == file.Path);
		if (item != null) ListView.Items.Remove(item);

	}

	private void ListView_ColumnClick(object sender, ColumnClickEventArgs e) {

		if (e.Column == SortColumn) {

			SortOrder = SortOrder == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;

		} else {

			SortColumn = e.Column;
			SortOrder = SortOrder.Ascending;

		}

		ListView.ListViewItemSorter = new ListViewItemComparer(e.Column, SortOrder);
		ListView.Sort();

	}

	private void ListView_DragEnter(object sender, DragEventArgs e) {

		e.Effect = e.Data!.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;

	}

	private void ListView_DragDrop(object sender, DragEventArgs e) {

		var paths = e.Data!.GetData(DataFormats.FileDrop) as string[];
		var folders = paths?.Where(Directory.Exists).ToArray();
		var files = paths?.Where(File.Exists).ToArray();

		PerformLongOperation(() => {

			if (files != null && files.Length != 0) FileItemsProvider.AddFiles(files);
			if (folders != null && folders.Length != 0) FileItemsProvider.AddFolders(folders, true);

		});

	}

	private void ListView_KeyDown(object sender, KeyEventArgs e) {

		if (e.Control && e.KeyCode == Keys.A) {

			PerformLongOperation(() => {

				foreach (ListViewItem item in ListView.Items) item.Selected = true;
				e.Handled = true;

			});

		}

		if (e.KeyCode == Keys.Delete) {

			if (ListView.SelectedItems.Count == ListView.Items.Count) {

				PerformLongOperation(FileItemsProvider.ClearFiles);

			} else {

				PerformLongOperation(() => {

					var paths = ListView.SelectedItems.Cast<ListViewItem>().Select(item => item.Tag as string).Where(path => path != null).Select(path => path!).ToArray();
					FileItemsProvider.RemoveFiles(paths);

				});

			}

		}

	}

	private void PerformLongOperation(Action action) {

		ListView.BeginUpdate();
		Cursor.Current = Cursors.WaitCursor;

		try {

			action();

		} finally {

			Cursor.Current = Cursors.Default;
			ListView.EndUpdate();

		}

	}

}