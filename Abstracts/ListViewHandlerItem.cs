namespace VideoConverter.Abstracts;

public class ListViewHandlerItem : IListViewHandlerItem {

	public string Key { get; set; } = string.Empty;

	public ListViewItem ToListViewItem() {

		return new ListViewItem {

			Text = ToString(),
			Tag = Key

		};

	}

}