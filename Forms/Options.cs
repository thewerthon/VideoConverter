namespace VideoConverter.Forms;

public partial class Options : Form {

	private readonly Settings Settings = SettingsProvider.Temporary;

	public Options() {

		InitializeComponent();
		LoadFromDatabase();

	}

	private void Options_Save_Click(object sender, EventArgs e) {

		SaveToDatabase();

	}

	private void Options_Cancel_Click(object sender, EventArgs e) {

		Close();

	}

}