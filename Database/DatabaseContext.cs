namespace VideoConverter.Database;

public class DatabaseContext : DbContext {

	private static readonly string DatabasePath = DatabaseProvider.DatabasePath;

	public DbSet<FileItem> FileItems { get; set; }
	public DbSet<Setting> Settings { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder options) {

		options.UseSqlite($"Data Source={DatabasePath}");

	}

	protected override void OnModelCreating(ModelBuilder modelBuilder) {

		modelBuilder.Entity<Setting>().OwnsOne(s => s.FFmpeg);

		base.OnModelCreating(modelBuilder);

	}

}