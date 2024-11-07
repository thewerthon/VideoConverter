namespace VideoConverter.Forms;

public partial class Main : Form {

	private void Menu_Options_Click(object sender, EventArgs e) {

		var group = Settings.FilesList.GroupFolders;

		var options = new Options();
		options.ShowDialog();

		if (group != Settings.FilesList.GroupFolders) ListItems_Load();

	}

	private void Menu_Exit_Click(object sender, EventArgs e) {

		Close();

	}

}