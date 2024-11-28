namespace VideoConverter.Forms;

public partial class Options : Form {

	private void LoadFromDatabase() {

		// Load
		Settings.LoadFromDatabase();
		DataSource.DataSource = Settings;

		// ComboBox Sources
		Language.DataSource = ListItemsProvider.Languages;
		FFmpegLogLevel.DataSource = ListItemsProvider.LogLevels;
		FFplayWindowSize.DataSource = ListItemsProvider.WindowSizes;

		// TextBox Bindings
		Bindings.AddTextBoxBinding(Extensions, DataSource, "Extensions");
		Bindings.AddTextBoxBinding(FFmpegPath, DataSource, "FFmpeg.CustomPath");

		// NumberBox Bindings
		Bindings.AddNumberBoxBinding(FFmpegThreads, DataSource, "FFmpeg.Threads");
		Bindings.AddNumberBoxBinding(FFplayVolume, DataSource, "FFplay.Volume");

		// ComboBox Bindings
		Bindings.AddComboBoxBinding(Language, DataSource, "Language");
		Bindings.AddComboBoxBinding(FFmpegLogLevel, DataSource, "FFmpeg.LogLevel");
		Bindings.AddComboBoxBinding(FFplayWindowSize, DataSource, "FFplay.WindowSize");

		// CheckBox Bindings
		Bindings.AddCheckBoxBinding(FilesGroupByFolders, DataSource, "Files.GroupByFolders");
		Bindings.AddCheckBoxBinding(FFplayFullscreen, DataSource, "FFplay.Fullscreen");

		// RadioGroup Bindings
		Bindings.AddRadioGrouxBinding(FFmpegMode, DataSource, "FFmpeg.Mode");

		// Enabled Bindings
		Bindings.AddEnabledBinding(FFmpegPath, DataSource, "FFmpeg.Mode", value => (int)value == 2);
		Bindings.AddEnabledBinding(FFmpegBrowse, DataSource, "FFmpeg.Mode", value => (int)value == 2);

	}

	private void SaveToDatabase() {

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