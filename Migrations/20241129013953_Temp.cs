using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoConverter.Migrations {
	/// <inheritdoc />
	public partial class Temp : Migration {
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder) {
			migrationBuilder.RenameColumn(
					name: "FFmpeg_Path",
					table: "Settings",
					newName: "FFplay_WindowSize");

			migrationBuilder.AddColumn<string>(
					name: "FFmpeg_CustomPath",
					table: "Settings",
					type: "TEXT",
					nullable: false,
					defaultValue: "");

			migrationBuilder.AddColumn<string>(
					name: "FFmpeg_EncoderPath",
					table: "Settings",
					type: "TEXT",
					nullable: false,
					defaultValue: "");

			migrationBuilder.AddColumn<string>(
					name: "FFmpeg_PlayerPath",
					table: "Settings",
					type: "TEXT",
					nullable: false,
					defaultValue: "");

			migrationBuilder.AddColumn<string>(
					name: "FFmpeg_ProbePath",
					table: "Settings",
					type: "TEXT",
					nullable: false,
					defaultValue: "");

			migrationBuilder.AddColumn<bool>(
					name: "FFplay_Fullscreen",
					table: "Settings",
					type: "INTEGER",
					nullable: false,
					defaultValue: false);

			migrationBuilder.AddColumn<int>(
					name: "FFplay_Volume",
					table: "Settings",
					type: "INTEGER",
					nullable: false,
					defaultValue: 0);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder) {
			migrationBuilder.DropColumn(
					name: "FFmpeg_CustomPath",
					table: "Settings");

			migrationBuilder.DropColumn(
					name: "FFmpeg_EncoderPath",
					table: "Settings");

			migrationBuilder.DropColumn(
					name: "FFmpeg_PlayerPath",
					table: "Settings");

			migrationBuilder.DropColumn(
					name: "FFmpeg_ProbePath",
					table: "Settings");

			migrationBuilder.DropColumn(
					name: "FFplay_Fullscreen",
					table: "Settings");

			migrationBuilder.DropColumn(
					name: "FFplay_Volume",
					table: "Settings");

			migrationBuilder.RenameColumn(
					name: "FFplay_WindowSize",
					table: "Settings",
					newName: "FFmpeg_Path");
		}
	}
}
