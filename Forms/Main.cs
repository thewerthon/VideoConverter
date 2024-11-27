namespace VideoConverter.Forms;

public partial class Main : Form {

	private readonly Settings Settings = SettingsProvider.Current;

	public Main() {

		InitializeComponent();

		FileItemsProvider.FileItemsLoaded += ListItems_Load;
		FileItemsProvider.FileItemsCleared += ListItems_Clear;
		FileItemsProvider.FileItemAdded += ListItems_Add;
		FileItemsProvider.FileItemRemoved += ListItems_Remove;
		FileItemsProvider.LoadFromDatabase();

	}

	private void ContextMenuPlay_Click(object sender, EventArgs e) {

		//var path = ListView.SelectedItems[0].Tag?.ToString() ?? string.Empty;

	}

}