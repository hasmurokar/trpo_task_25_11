using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace trpo_task_25_11.Migrations
{
    public partial class createTableEntr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Histories_EntrantId",
                table: "Histories",
                column: "EntrantId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_Entrants_EntrantId",
                table: "Histories",
                column: "EntrantId",
                principalTable: "Entrants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Histories_Entrants_EntrantId",
                table: "Histories");

            migrationBuilder.DropIndex(
                name: "IX_Histories_EntrantId",
                table: "Histories");
        }
    }
}
