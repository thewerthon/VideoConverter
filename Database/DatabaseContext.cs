namespace VideoConverter.Database;

public class DatabaseContext : DbContext {

	private static readonly string DatabasePath = DatabaseProvider.DatabasePath;

	public DbSet<FileItem> FileItems { get; set; }
	public DbSet<Setting> Settings { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder options) {

		base.OnConfiguring(options);
		options.UseSqlite($"Data Source={DatabasePath}");
		options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

	}

	protected override void OnModelCreating(ModelBuilder model) {

		base.OnModelCreating(model);
		model.Entity<Setting>().OwnsOne(s => s.FilesList);
		model.Entity<Setting>().OwnsOne(s => s.FFmpeg);

	}

}