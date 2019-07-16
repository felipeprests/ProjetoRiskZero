using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RISKZERO.Infra.Data.Migrations
{
    public partial class AddRelationals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Users",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CRP",
                table: "Users",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientID",
                table: "Appoiments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Appoiments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Statistic",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PatientID = table.Column<int>(nullable: false),
                    Tendency = table.Column<string>(nullable: true),
                    Reference = table.Column<string>(nullable: true),
                    QuantityAnswered = table.Column<int>(nullable: false),
                    TotalAnsweredYes = table.Column<int>(nullable: false),
                    TotalAnsweredNo = table.Column<int>(nullable: false),
                    PercentageYes = table.Column<float>(nullable: false),
                    PercentageNo = table.Column<float>(nullable: false),
                    Level = table.Column<string>(nullable: true),
                    DateHour = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistic", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Statistic_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appoiments_PatientID",
                table: "Appoiments",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Appoiments_UserID",
                table: "Appoiments",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Statistic_PatientID",
                table: "Statistic",
                column: "PatientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appoiments_Patients_PatientID",
                table: "Appoiments",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appoiments_Users_UserID",
                table: "Appoiments",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appoiments_Patients_PatientID",
                table: "Appoiments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appoiments_Users_UserID",
                table: "Appoiments");

            migrationBuilder.DropTable(
                name: "Statistic");

            migrationBuilder.DropIndex(
                name: "IX_Appoiments_PatientID",
                table: "Appoiments");

            migrationBuilder.DropIndex(
                name: "IX_Appoiments_UserID",
                table: "Appoiments");

            migrationBuilder.DropColumn(
                name: "PatientID",
                table: "Appoiments");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Appoiments");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Users",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "CRP",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15);
        }
    }
}
