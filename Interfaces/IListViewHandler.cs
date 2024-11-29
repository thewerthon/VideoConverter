namespace VideoConverter.Interfaces;

public interface IListViewHandler<T> where T : IListViewHandlerItem {

	public ListView ListView { get; set; }
	public List<T> ListItems { get; set; }
	public List<T> SelectedItems { get; set; }

	public event Action<T>? ListItemAdded;
	public event Action<T>? ListItemUpdated;
	public event Action<T>? ListItemRemoved;
	public event Action<List<T>>? ListItemsAdded;
	public event Action<List<T>>? ListItemsUpdated;
	public event Action<List<T>>? ListItemsRemoved;
	public event Action<List<T>>? ListItemsLoaded;
	public event Action? ListItemsRefreshed;
	public event Action? ListItemsCleared;

	public void Add(T item);
	public void Add(List<T> items);
	public void Update(T item);
	public void Update(string key, T item);
	public void Update(List<T> items);
	public void Remove();
	public void Remove(T item);
	public void Remove(string key);
	public void Remove(List<T> items);
	public void Load(List<T> items);
	public void Refresh();
	public void Clear();

}