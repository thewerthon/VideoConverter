using System.Diagnostics;
namespace VideoConverter.Forms;

public partial class Main : Form {

	private void ContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e) {

		var count = ListView.SelectedItems.Count;
		if (count == 0) { e.Cancel = true; return; }

		var single = count == 1;
		var multi = count > 1;

		ContextMenuPlay.Visible = single;
		ContextMenuEdit.Visible = single;
		ContextMenuLocate.Visible = single;

		ContextMenuPlaySequence.Visible = multi;
		ContextMenuEditSequence.Visible = multi;
		ContextMenuBatchEdit.Visible = multi;

	}

	private void ContextMenuPlay_Click(object sender, EventArgs e) {

		FileItems.Play();

	}

	private void ContextMenuLocate_Click(object sender, EventArgs e) {

		var item = ListView.SelectedItems.Cast<ListViewItem>().FirstOrDefault();

		if (item?.Tag is string path && !string.IsNullOrEmpty(path) && File.Exists(path)) {

			var argument = $"/select,\"{path}\"";
			Process.Start("explorer.exe", argument);

		} else {

			MessageBox.Show("Could not find the file.", "Locate", MessageBoxButtons.OK, MessageBoxIcon.Warning);

		}

	}

}