namespace VideoConverter.Forms;

public partial class Main : Form {

	private void AddFiles_Click(object sender, EventArgs e) {

		AddFilesDialog.Filter = $"Files|*{string.Join("; *", FileItemsProvider.AllowedExtensions())}";

		if (AddFilesDialog.ShowDialog() == DialogResult.OK) {

			FileItems.AddFiles(AddFilesDialog.FileNames);

		}

	}

	private void AddFolder_Click(object sender, EventArgs e) {

		if (AddFolderDialog.ShowDialog() == DialogResult.OK) {

			var recurse = false;
			var location = AddFolderDialog.SelectedPath;

			if (Directory.GetDirectories(location).Length > 0) {

				var question = MessageBox.Show("Search for files in all subfolders?", "Add Folder", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (question == DialogResult.Cancel) return;
				recurse = question == DialogResult.Yes;

			}

			FileItems.AddFolders([location], recurse);

		}

	}

	private void ClearFiles_Click(object sender, EventArgs e) {

		FileItems.Clear();

	}

}