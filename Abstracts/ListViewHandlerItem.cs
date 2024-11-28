namespace VideoConverter.Abstracts;

public class ListViewHandlerItem : IListViewHandlerItem {

	public int Id { get; set; }

	public ListViewItem ToListViewItem() {

		return new ListViewItem {

			Text = ToString(),
			Tag = Id

		};

	}

}