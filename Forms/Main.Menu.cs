namespace VideoConverter.Forms;

public partial class Main : Form {

	private void Menu_Options_Click(object sender, EventArgs e) {

		var group = Settings.Files.GroupByFolders;

		var options = new Options();
		options.ShowDialog();

		if (group != Settings.Files.GroupByFolders) ListItems_Load();

	}

	private void Menu_Exit_Click(object sender, EventArgs e) {

		Close();

	}

}