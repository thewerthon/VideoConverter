namespace VideoConverter.Forms;

public partial class Options : Form {

	private void LoadSettings() {

		// Load
		Settings.LoadFromDatabase();
		DataSource.DataSource = Settings;

		// ComboBox Sources
		Language.DataSource = ListItemsProvider.Languages;
		FFmpegLogLevel.DataSource = ListItemsProvider.LogLevels;

		// TextBox Bindings
		Bindings.AddTextBoxBinding(Extensions, DataSource, "Extensions");
		Bindings.AddTextBoxBinding(FFmpegPath, DataSource, "FFmpeg.Path");

		// NumberBox Bindings
		Bindings.AddNumberBoxBinding(FFmpegThreads, DataSource, "FFmpeg.Threads");

		// ComboBox Bindings
		Bindings.AddComboBoxBinding(Language, DataSource, "Language");
		Bindings.AddComboBoxBinding(FFmpegLogLevel, DataSource, "FFmpeg.LogLevel");

		// RadioGroup Bindings
		Bindings.AddRadioGrouxBinding(FFmpegMode, DataSource, "FFmpeg.Mode");

		// Enabled Bindings
		Bindings.AddEnabledBinding(FFmpegPath, DataSource, "FFmpeg.Mode", value => (int)value == 2);
		Bindings.AddEnabledBinding(FFmpegBrowse, DataSource, "FFmpeg.Mode", value => (int)value == 2);

	}

	private void SaveSettings() {

		try {

			Settings.Validate();
			Settings.SaveToDatabase();
			SettingsProvider.Current.LoadFromDatabase();

			Close();

		} catch (ValidationException ex) {

			MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

		} catch (Exception ex) {

			MessageBox.Show(ex.Message, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}

	}

}