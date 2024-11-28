namespace VideoConverter.Interfaces;

public interface IListViewHandlerItem {

	public int Id { get; set; }

	public ListViewItem ToListViewItem();

}