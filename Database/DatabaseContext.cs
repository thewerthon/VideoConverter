namespace VideoConverter.Database;

public class DatabaseContext : DbContext {

	private static readonly string DatabasePath = DatabaseProvider.DatabasePath;

	public required DbSet<FileItem> FileItems { get; set; }
	public required DbSet<Settings> Settings { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder options) {

		base.OnConfiguring(options);
		options.UseSqlite($"Data Source={DatabasePath}");
		options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

	}

	protected override void OnModelCreating(ModelBuilder model) {

		base.OnModelCreating(model);
		model.Entity<Settings>().OwnsOne(s => s.Files);
		model.Entity<Settings>().OwnsOne(s => s.FFmpeg);
		model.Entity<Settings>().OwnsOne(s => s.MediaPlayer);

	}

}