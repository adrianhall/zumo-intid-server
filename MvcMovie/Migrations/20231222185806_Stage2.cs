using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    /// <inheritdoc />
    public partial class Stage2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Movie",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MobileId",
                table: "Movie",
                type: "nvarchar(450)",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "Movie",
                type: "datetimeoffset",
                nullable: true,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<byte[]>(
                name: "Version",
                table: "Movie",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: Array.Empty<byte>());

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Deleted",
                table: "Movie",
                column: "Deleted");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_MobileId",
                table: "Movie",
                column: "MobileId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_UpdatedAt",
                table: "Movie",
                column: "UpdatedAt");

            migrationBuilder.Sql(@"
                CREATE TRIGGER [trg_Movie_Mobile] ON [Movie]
                AFTER UPDATE AS
                    UPDATE [Movie]
                    SET [UpdatedAt] = GETUTCDATE()
                    WHERE ID IN (SELECT [Id] FROM Inserted)
            ");

            migrationBuilder.Sql(@"
                UPDATE [Movie]
                SET
                    [MobileId] = NEWID(),
                    [UpdatedAt] = GETUTCDATE()
                WHERE [UpdatedAt] IS NULL
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP TRIGGER [trg_Movie_Mobile]");

            migrationBuilder.DropIndex(
                name: "IX_Movie_Deleted",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_MobileId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_UpdatedAt",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "MobileId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Movie");
        }
    }
}
