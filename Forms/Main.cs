namespace VideoConverter.Forms;

public partial class Main : Form {

	private readonly Setting Settings = SettingsProvider.Current;

	public Main() {

		InitializeComponent();
		FileItemsProvider.FileItemsChanged += ListItems_Fill;

	}

}