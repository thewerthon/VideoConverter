using System.Collections;
namespace VideoConverter.Controls;

public class ListViewItemComparer(int column, SortOrder order) : IComparer {

	private readonly int Column = column;
	private readonly SortOrder Order = order;

	public int Compare(object? x, object? y) {

		if (x is ListViewItem itemX && y is ListViewItem itemY) {

			var textX = itemX.SubItems[Column].Text;
			var textY = itemY.SubItems[Column].Text;
			var result = double.TryParse(textX, out var numX) && double.TryParse(textY, out var numY) ? numX.CompareTo(numY) : string.Compare(textX, textY);
			return Order == SortOrder.Ascending ? result : -result;

		}

		return 0;

	}

}