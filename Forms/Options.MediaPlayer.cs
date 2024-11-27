namespace VideoConverter.Forms;

public partial class Options : Form {

	private void MediaPlayerPath_Validate() {

		try {

			Settings.MediaPlayer.ValidatePath();

		} catch (ValidationException ex) {

			MessageBox.Show(ex.Message, "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}

	}

	private void MediaPlayerSystem_Click(object sender, EventArgs e) {

		if (MediaPlayerSystem.Checked) MediaPlayerPath_Validate();

	}

	private void MediaPlayerPrograms_Click(object sender, EventArgs e) {

		if (MediaPlayerPrograms.Checked) MediaPlayerPath_Validate();

	}

	private void MediaPlayerBrowse_Click(object sender, EventArgs e) {

		if (FolderBrowser.ShowDialog() == DialogResult.OK) {

			MediaPlayerPath.Text = FolderBrowser.SelectedPath;
			MediaPlayerPath_Validate();

		}

	}

}