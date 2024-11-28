namespace VideoConverter.Forms;

public partial class Main : Form {

	private readonly Settings Settings = SettingsProvider.Current;

	public Main() {

		InitializeComponent();

		FileItemsProvider.ListView = ListView;
		FileItemsProvider.FileItemsLoaded += ListItems_Load;
		FileItemsProvider.FileItemsCleared += ListItems_Clear;
		FileItemsProvider.FileItemAdded += ListItems_Add;
		FileItemsProvider.FileItemRemoved += ListItems_Remove;
		FileItemsProvider.LoadFromDatabase();

		ListView.SelectedIndexChanged += FileItemsProvider.OnSelectedIndexChanged;

	}

	private void ListView_SelectedIndexChanged(object sender, EventArgs e) {

		//ListView.SelectedIndexChanged

	}

}