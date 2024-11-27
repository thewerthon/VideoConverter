namespace VideoConverter.Forms;

public partial class Options : Form {

	private void LoadFromDatabase() {

		// Load
		Settings.LoadFromDatabase();
		DataSource.DataSource = Settings;

		// ComboBox Sources
		Language.DataSource = ListItemsProvider.Languages;
		FFmpegLogLevel.DataSource = ListItemsProvider.LogLevels;

		// TextBox Bindings
		Bindings.AddTextBoxBinding(Extensions, DataSource, "Extensions");
		Bindings.AddTextBoxBinding(FFmpegPath, DataSource, "FFmpeg.CustomPath");
		Bindings.AddTextBoxBinding(MediaPlayerPath, DataSource, "MediaPlayer.CustomPath");

		// NumberBox Bindings
		Bindings.AddNumberBoxBinding(FFmpegThreads, DataSource, "FFmpeg.Threads");

		// ComboBox Bindings
		Bindings.AddComboBoxBinding(Language, DataSource, "Language");
		Bindings.AddComboBoxBinding(FFmpegLogLevel, DataSource, "FFmpeg.LogLevel");

		// CheckBox Bindings
		Bindings.AddCheckBoxBinding(GroupFolders, DataSource, "Files.GroupByFolders");

		// RadioGroup Bindings
		Bindings.AddRadioGrouxBinding(FFmpegMode, DataSource, "FFmpeg.Mode");
		Bindings.AddRadioGrouxBinding(MediaPlayerMode, DataSource, "MediaPlayer.Mode");

		// Enabled Bindings
		Bindings.AddEnabledBinding(FFmpegPath, DataSource, "FFmpeg.Mode", value => (int)value == 2);
		Bindings.AddEnabledBinding(FFmpegBrowse, DataSource, "FFmpeg.Mode", value => (int)value == 2);
		Bindings.AddEnabledBinding(MediaPlayerPath, DataSource, "MediaPlayer.Mode", value => (int)value == 2);
		Bindings.AddEnabledBinding(MediaPlayerBrowse, DataSource, "MediaPlayer.Mode", value => (int)value == 2);

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