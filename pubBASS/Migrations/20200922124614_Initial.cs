using Microsoft.EntityFrameworkCore.Migrations;

namespace pubBASS.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pubs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Municipality = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pubs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pubs",
                columns: new[] { "Id", "Municipality", "Name" },
                values: new object[] { 1, "Liberec", "Svah" });

            migrationBuilder.InsertData(
                table: "Pubs",
                columns: new[] { "Id", "Municipality", "Name" },
                values: new object[] { 2, "Jablonec nad Nisou", "Techtle" });

            migrationBuilder.InsertData(
                table: "Pubs",
                columns: new[] { "Id", "Municipality", "Name" },
                values: new object[] { 3, "The Other End Of Universe", "Pub At The Other End Of Universe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pubs");
        }
    }
}
