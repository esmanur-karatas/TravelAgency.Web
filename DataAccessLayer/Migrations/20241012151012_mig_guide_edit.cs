using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_guide_edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InstagramUrl",
                table: "Guides");

            migrationBuilder.RenameColumn(
                name: "TwitterUrl",
                table: "Guides",
                newName: "GuideDescription2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GuideDescription2",
                table: "Guides",
                newName: "TwitterUrl");

            migrationBuilder.AddColumn<string>(
                name: "InstagramUrl",
                table: "Guides",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
