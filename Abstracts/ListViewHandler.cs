namespace VideoConverter.Abstracts;

public abstract class ListViewHandler : IListViewHandler {

	public ListView ListView { get; set; } = null!;
	public List<IListViewHandlerItem> ListItems { get; set; } = [];
	public List<IListViewHandlerItem> SelectedItems { get; set; } = [];

	public event Action<IListViewHandlerItem>? ListItemAdded;
	public event Action<IListViewHandlerItem>? ListItemUpdated;
	public event Action<IListViewHandlerItem>? ListItemRemoved;
	public event Action? ListItemsLoaded;
	public event Action? ListItemsCleared;

	public void Load() {

		ListItems = [];
		ListView.Clear();
		ListItemsLoaded?.Invoke();

	}

	public void Clear() {

		ListItems = [];
		ListView.Clear();
		ListItemsCleared?.Invoke();

	}

	public void Refresh() {

		ListView.Clear();

		foreach (var item in ListItems) {

			ListView.Items.Add(item.ToListViewItem());

		}

	}

	public void Add(IListViewHandlerItem item) {

		ListItems.Add(item);
		ListView.Items.Add(item.ToListViewItem());
		ListItemAdded?.Invoke(item);

	}

	public void Add(List<IListViewHandlerItem> items) {

		foreach (var item in items) {

			Add(item);

		}

	}

	public void Update(IListViewHandlerItem item) {

		var i = ListView.Items.Cast<ListViewItem>().FirstOrDefault(i => i.Tag != null && i.Tag.Equals(item.Id));
		if (i != null) i = item.ToListViewItem();
		ListItemUpdated?.Invoke(item);

	}

	public void Update(List<IListViewHandlerItem> items) {

		if (items.Count > 0) {

			//foreach (var i in items) ListItems[ListItems.IndexOf(i)] = item;
			//ListItemsUpdated?.Invoke(items);

		}

	}

	public void Remove(IListViewHandlerItem item) {
		throw new NotImplementedException();
	}

	public void Remove(List<IListViewHandlerItem> items) {
		throw new NotImplementedException();
	}

	public void SelectionChanged(object? sender, EventArgs e) {
		throw new NotImplementedException();
	}

}