namespace VideoConverter.Forms;

public partial class Main : Form {

	private void AddFiles_Click(object sender, EventArgs e) {

		AddFilesDialog.Filter = $"Files|*{string.Join("; *", FileItemsProvider.AllowedExtensions())}";

		if (AddFilesDialog.ShowDialog() == DialogResult.OK) {

			PerformLongOperation(() => {

				FileItemsProvider.AddFiles(AddFilesDialog.FileNames);

			});

			if (FileItemsProvider.FilesAdded == 0) MessageBox.Show("No files were added.", "Add Files", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

			PerformLongOperation(() => {

				FileItemsProvider.AddFolders([location], recurse);

			});

			if (FileItemsProvider.FilesAdded == 0) MessageBox.Show("No valid files were found.", "Add Folder", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

	}

	private void ClearFiles_Click(object sender, EventArgs e) {

		PerformLongOperation(FileItemsProvider.ClearFiles);

	}

}