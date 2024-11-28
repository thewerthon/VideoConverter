namespace VideoConverter.Interfaces;

public interface IListViewHandler {

	public ListView ListView { get; set; }
	public List<IListViewHandlerItem> ListItems { get; set; }
	public List<IListViewHandlerItem> SelectedItems { get; set; }

	public event Action? ListItemsLoaded;
	public event Action? ListItemsCleared;
	public event Action<IListViewHandlerItem>? ListItemAdded;
	public event Action<IListViewHandlerItem>? ListItemUpdated;
	public event Action<IListViewHandlerItem>? ListItemRemoved;

	public void Load();
	public void Clear();
	public void Refresh();

	public void Add(IListViewHandlerItem item);
	public void Add(List<IListViewHandlerItem> items);
	public void Update(IListViewHandlerItem item);
	public void Update(List<IListViewHandlerItem> items);
	public void Remove(IListViewHandlerItem item);
	public void Remove(List<IListViewHandlerItem> items);

	public void SelectionChanged(object? sender, EventArgs e);

}