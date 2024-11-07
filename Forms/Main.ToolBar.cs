namespace VideoConverter.Forms;

public partial class Main : Form {

	private void AddFiles_Click(object sender, EventArgs e) {

		AddFilesDialog.Filter = $"Files|*{Settings.Extensions.Replace(" ", "; *")}";

		if (AddFilesDialog.ShowDialog() == DialogResult.OK) {

			FileItemsProvider.AddFiles(AddFilesDialog.FileNames);

		}

	}

	private void AddFolder_Click(object sender, EventArgs e) {

		if (AddFolderDialog.ShowDialog() == DialogResult.OK) {

			FileItemsProvider.AddFolders([AddFolderDialog.SelectedPath]);

		}

	}

	private void ClearList_Click(object sender, EventArgs e) {

		ListItems_Clear();

	}

}