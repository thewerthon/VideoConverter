namespace VideoConverter.Models;

public class FileItem(string path) {

	// Generals
	public int Id { get; set; }
	public string Name { get; set; } = System.IO.Path.GetFileName(path);
	public string Path { get; set; } = System.IO.Path.GetFullPath(path);
	public string BaseName { get; set; } = System.IO.Path.GetFileNameWithoutExtension(path);
	public string BasePath { get; set; } = System.IO.Path.GetDirectoryName(path) ?? string.Empty;
	public string Extension { get; set; } = System.IO.Path.GetExtension(path).ToLower();
	public long Size { get; set; } = new System.IO.FileInfo(path).Length;

	// Progress
	public float Progress { get; set; } = 0;

	public string GetSizeString() {

		var i = 0;
		double size = Size;
		string[] unities = ["B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB"];

		while (size >= 1024 && i < unities.Length - 1) {

			size /= 1024;
			i++;

		}

		return size >= 100 ? $"{size:F0} {unities[i]}"
			: size >= 10 ? $"{size:F1} {unities[i]}"
			: $"{size:F2} {unities[i]}";

	}

	public string GetProgressString() {

		return Progress switch {
			-1 => "Failed",
			0 => "Pending",
			1 => "Completed",
			_ => "Incomplete",
		};

	}

	public Color GetProgressColor() {

		return Progress switch {
			-1 => Color.Red,
			0 => Color.Black,
			1 => Color.Green,
			_ => Color.DarkOrange,
		};

	}

}