using Microsoft.EntityFrameworkCore.Migrations;

namespace RISKZERO.Infra.Data.Migrations
{
    public partial class AddNewFKs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdQuestion",
                table: "Answers",
                newName: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionID",
                table: "Answers",
                column: "QuestionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionID",
                table: "Answers",
                column: "QuestionID",
                principalTable: "Questions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionID",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_QuestionID",
                table: "Answers");

            migrationBuilder.RenameColumn(
                name: "QuestionID",
                table: "Answers",
                newName: "IdQuestion");
        }
    }
}
