using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.PromoveMigratoins
{
    /// <inheritdoc />
    public partial class changefieldname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Agents",
                newName: "Name_Changed");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name_Changed",
                table: "Agents",
                newName: "Name");
        }
    }
}
