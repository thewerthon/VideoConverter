namespace VideoConverter.Forms;

public partial class Main : Form {

	private readonly FileItemsProvider FileItems;

	public Main() {

		InitializeComponent();

		FileItems = new(ListView);
		FileItems.LoadFromDatabase();

	}

}