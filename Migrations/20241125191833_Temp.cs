using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoConverter.Migrations
{
    /// <inheritdoc />
    public partial class Temp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FFmpeg_Path",
                table: "Settings",
                newName: "MediaPlayer_MediaPlayerPath");

            migrationBuilder.AddColumn<string>(
                name: "FFmpeg_CustomPath",
                table: "Settings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FFmpeg_FFmpegPath",
                table: "Settings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FFmpeg_FFprobePath",
                table: "Settings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MediaPlayer_CustomPath",
                table: "Settings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MediaPlayer_Mode",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FFmpeg_CustomPath",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "FFmpeg_FFmpegPath",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "FFmpeg_FFprobePath",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "MediaPlayer_CustomPath",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "MediaPlayer_Mode",
                table: "Settings");

            migrationBuilder.RenameColumn(
                name: "MediaPlayer_MediaPlayerPath",
                table: "Settings",
                newName: "FFmpeg_Path");
        }
    }
}
