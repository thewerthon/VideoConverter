namespace VideoConverter.Interfaces;

public interface IListViewHandlerItem {

	public string Key { get; set; }

	public ListViewItem ToListViewItem();

}