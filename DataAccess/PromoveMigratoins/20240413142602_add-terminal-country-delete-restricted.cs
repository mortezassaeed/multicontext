using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.PromoveMigratoins
{
    /// <inheritdoc />
    public partial class addterminalcountrydeleterestricted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Terminals_Country_CountryId",
                table: "Terminals");

            migrationBuilder.AddForeignKey(
                name: "FK_Terminals_Country_CountryId",
                table: "Terminals",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Terminals_Country_CountryId",
                table: "Terminals");

            migrationBuilder.AddForeignKey(
                name: "FK_Terminals_Country_CountryId",
                table: "Terminals",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
