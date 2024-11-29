namespace VideoConverter.Abstracts;

public abstract class ListViewHandler<T> : IListViewHandler<T> where T : IListViewHandlerItem {

	public ListView ListView { get; set; }
	public List<T> ListItems { get; set; } = [];
	public List<T> SelectedItems { get; set; } = [];
	protected bool NoEvents { get; set; } = false;

	public event Action<T>? ListItemAdded;
	public event Action<T>? ListItemUpdated;
	public event Action<T>? ListItemRemoved;
	public event Action<List<T>>? ListItemsAdded;
	public event Action<List<T>>? ListItemsUpdated;
	public event Action<List<T>>? ListItemsRemoved;
	public event Action<List<T>>? ListItemsLoaded;
	public event Action? ListItemsRefreshed;
	public event Action? ListItemsCleared;

	public ListViewHandler(ListView listview) {

		ListView = listview;
		ListView.SelectedIndexChanged += SelectionChanged;

	}

	public void Add(T item) {

		ListItems.Add(item);
		ListView.Items.Add(item.ToListViewItem());
		//if (!NoEvents) ListItemAdded?.Invoke(item);

	}

	public void Add(List<T> items) {

		PerformLongOperation(() => {

			foreach (var item in items) Add(item);
			ListItemsAdded?.Invoke(items);

		});

	}

	public void Update(T item) {

		Update(item.Key, item);

	}

	public void Update(string key, T item) {

		var listitem = GetListItem(i => i.Key.Equals(key));
		var viewitem = GetListViewItem(i => i.Tag != null && i.Tag.Equals(key));
		if (listitem is null || viewitem is null) return;

		item.Key = key;
		listitem = item;
		viewitem = item.ToListViewItem();
		if (!NoEvents) ListItemUpdated?.Invoke(item);

	}

	public void Update(List<T> items) {

		PerformLongOperation(() => {

			foreach (var item in items) Update(item.Key, item);
			ListItemsUpdated?.Invoke(items);

		});

	}

	public void Remove() {

		Remove(SelectedItems);

	}

	public void Remove(T item) {

		Remove(item.Key);

	}

	public void Remove(string key) {

		var listitem = GetListItem(i => i.Key.Equals(key));
		var viewitem = GetListViewItem(i => i.Tag != null && i.Tag.Equals(key));
		if (listitem is null || viewitem is null) return;

		ListItems.Remove(listitem);
		ListView.Items.Remove(viewitem);
		if (!NoEvents) ListItemRemoved?.Invoke(listitem);

	}

	public void Remove(List<T> items) {

		var i = new List<T>(items);

		PerformLongOperation(() => {

			foreach (var item in i) Remove(item.Key);
			ListItemsRemoved?.Invoke(i);

		});

	}

	public void Load(List<T> items) {

		ListItems.Clear();
		ListItems.AddRange(items);
		Refresh();

		ListItemsLoaded?.Invoke(items);

	}

	public void Refresh() {

		PerformLongOperation(() => {

			ListView.Items.Clear();
			foreach (var item in ListItems) ListView.Items.Add(item.ToListViewItem());
			ListItemsRefreshed?.Invoke();

		});

	}

	public void Clear() {

		PerformLongOperation(() => {

			ListItems = [];
			ListView.Items.Clear();
			ListItemsCleared?.Invoke();

		});

	}

	protected void PerformLongOperation(Action action) {

		NoEvents = true;
		ListView.BeginUpdate();
		Cursor.Current = Cursors.WaitCursor;

		try {

			action();

		} finally {

			Cursor.Current = Cursors.Default;
			ListView.EndUpdate();
			NoEvents = false;

		}

	}

	protected void SelectionChanged(object? sender, EventArgs e) {

		SelectedItems.Clear();

		if (ListView.SelectedItems.Count > 0) {

			var keys = ListView.SelectedItems.Cast<ListViewItem>().Select(item => item.Tag).OfType<string>();
			var items = ListItems.Where(item => keys.Contains(item.Key)).ToList();
			SelectedItems.AddRange(items.Cast<T>().ToList());

		}

	}

	protected ListViewItem GetListViewItem(Func<ListViewItem, bool> filter) {

		return ListView.Items.Cast<ListViewItem>().First(filter);

	}

	protected List<ListViewItem> GetListViewItems(Func<ListViewItem, bool> filter) {

		return ListView.Items.Cast<ListViewItem>().Where(filter).ToList();

	}

	protected T GetListItem(Func<T, bool> filter) {

		return ListItems.First(filter);

	}

	protected List<T> GetListItems(Func<T, bool> filter) {

		return ListItems.Where(filter).ToList();

	}

}