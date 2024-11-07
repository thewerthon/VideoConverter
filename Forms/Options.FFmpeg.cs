namespace VideoConverter.Forms;

public partial class Options : Form {

	private void FFmpegPath_Validate() {

		try {

			Settings.FFmpeg.ValidatePath();

		} catch (ValidationException ex) {

			MessageBox.Show(ex.Message, "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}

	}

	private void FFmpegSystem_Click(object sender, EventArgs e) {

		if (FFmpegSystem.Checked) FFmpegPath_Validate();

	}

	private void FFmpegApplication_Click(object sender, EventArgs e) {

		if (FFmpegApplication.Checked) FFmpegPath_Validate();

	}

	private void FFmpegBrowse_Click(object sender, EventArgs e) {

		if (FolderBrowser.ShowDialog() == DialogResult.OK) {

			FFmpegPath.Text = FolderBrowser.SelectedPath;
			FFmpegPath_Validate();

		}

	}

}