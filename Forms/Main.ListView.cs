namespace VideoConverter.Forms;

public partial class Main : Form {

	private void ListItems_Clear() {

		ListView.Items.Clear();

	}

	private void ListItems_Fill() {

		ListItems_Clear();

		foreach (var file in FileItemsProvider.FileItems) {

			var item = new ListViewItem(file.Id.ToString());
			item.SubItems.Add(file.Name);
			item.SubItems.Add(file.Path);
			item.SubItems.Add(file.Extension);
			item.SubItems.Add(file.Size.ToString());

			ListView.Items.Add(item);

		}

	}

	private void ListView_DragEnter(object sender, DragEventArgs e) {

		e.Effect = e.Data!.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;

	}

	private void ListView_DragDrop(object sender, DragEventArgs e) {

		var paths = e.Data!.GetData(DataFormats.FileDrop) as string[];
		var folders = paths?.Where(Directory.Exists).ToArray();
		var files = paths?.Where(File.Exists).ToArray();

		if (folders != null && folders.Length != 0) FileItemsProvider.AddFolders(folders);
		if (files != null && files.Length != 0) FileItemsProvider.AddFiles(files);

		ListItems_Fill();

	}

}