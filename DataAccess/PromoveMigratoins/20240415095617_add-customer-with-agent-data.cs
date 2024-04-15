using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.DependencyInjection;

#nullable disable

namespace DataAccess.PromoveMigratoins
{
    /// <inheritdoc />
    public partial class addcustomerwithagentdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            using var dbContext = new MigrationServiceManager().ServiceProvider.GetRequiredService<PromoveDbContext>();
            var agents = dbContext.Agents.ToList();

            object[,] array = new object[agents.Count, 3];

            for (int i = 0; i < agents.Count; i++)
            {
                var obj = agents[i];
                array[i, 0] = obj.Id; // Assuming Id is in the first column
                array[i, 1] = obj.Name_Changed; // Assuming Name is in the second column
                array[i, 2] = i.ToString();
            }

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Name", "Age" },
                values: array);

            //   migrationBuilder.InsertData(
            //       table: "Customers",
            //       columns: new[] { "Id", "Name" , "Age" },
            //       values: new object[,]
            //       {
            //         { 1, "Bill" , "23" },
            //         { 2, "Abbas" , "24" }
            //       });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

        }
    }


 
}
