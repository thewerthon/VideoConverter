namespace VideoConverter.Models;

public class FileItem(string path) {

	public int Id { get; set; }
	public string Name { get; set; } = System.IO.Path.GetFileName(path);
	public string Path { get; set; } = System.IO.Path.GetFullPath(path);
	public string BaseName { get; set; } = System.IO.Path.GetFileNameWithoutExtension(path);
	public string BasePath { get; set; } = System.IO.Path.GetDirectoryName(path) ?? string.Empty;
	public string Extension { get; set; } = System.IO.Path.GetExtension(path).ToLower();
	public long Size { get; set; } = new System.IO.FileInfo(path).Length;

}