namespace VideoConverter.Forms;

public partial class Main : Form {

	//private long Index = 0;
	private int SortColumn = -1;
	private SortOrder SortOrder = SortOrder.Ascending;

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

		if (files != null && files.Length != 0) FileItems.AddFiles(files);
		if (folders != null && folders.Length != 0) FileItems.AddFolders(folders, true);

	}

	private void ListView_KeyDown(object sender, KeyEventArgs e) {

		if (e.Control && e.KeyCode == Keys.A) {

			foreach (ListViewItem item in ListView.Items) item.Selected = true;
			e.Handled = true;

		}

		if (e.KeyCode == Keys.Delete) {

			FileItems.Remove();

		}

	}

}