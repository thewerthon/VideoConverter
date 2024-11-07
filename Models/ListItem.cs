namespace VideoConverter.Models;

public class ListItem<TKey> {

	public required TKey Key { get; set; }
	public string Name { get; set; } = string.Empty;
	public override string ToString() => Name;

}