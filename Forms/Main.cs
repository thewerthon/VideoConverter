namespace VideoConverter.Forms;

public partial class Main : Form {

	private readonly Setting Settings = SettingsProvider.Current;

	public Main() {

		InitializeComponent();

		FileItemsProvider.FileItemsLoaded += ListItems_Load;
		FileItemsProvider.FileItemsCleared += ListItems_Clear;
		FileItemsProvider.FileItemAdded += ListItems_Add;
		FileItemsProvider.FileItemRemoved += ListItems_Remove;
		FileItemsProvider.LoadFromDatabase();

	}

}