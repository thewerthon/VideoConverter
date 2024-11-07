namespace VideoConverter.Forms;

public partial class Main : Form {

	private void Menu_Options_Click(object sender, EventArgs e) {

		var options = new Options();
		options.ShowDialog();

	}

	private void Menu_Exit_Click(object sender, EventArgs e) {

		Close();

	}

}