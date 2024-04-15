using DataAccess.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.DependencyInjection;
using System.Security.AccessControl;

#nullable disable

namespace DataAccess.PromoveMigratoins
{
    /// <inheritdoc />
    public partial class changeagedatatype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"UPDATE [dbo].[Customers]
                            SET [Age] = CASE
                            WHEN ISNUMERIC([Age]) = 1 THEN COALESCE(TRY_CAST(Age AS int), 0)
                            ELSE 0
                    END;");

            using var dbcontext = new MigrationServiceManager().ServiceProvider.GetRequiredService<PromoveDbContext>();
            var customer = dbcontext.Set<Customer_old>().ToList();
            

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }

    public class Customer_old
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
    }

}
