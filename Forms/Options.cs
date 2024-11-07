namespace VideoConverter.Forms;

public partial class Options : Form {

	private readonly Setting Settings = SettingsProvider.Temporary;

	public Options() {

		InitializeComponent();
		LoadSettings();

	}

	private void Options_Save_Click(object sender, EventArgs e) {

		SaveSettings();

	}

	private void Options_Cancel_Click(object sender, EventArgs e) {

		Close();

	}

}