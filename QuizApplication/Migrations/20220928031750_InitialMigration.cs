using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizApplication.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "choices",
                columns: table => new
                {
                    ChoicesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentQuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_choices", x => x.ChoicesId);
                });

            migrationBuilder.CreateTable(
                name: "Choice",
                columns: table => new
                {
                    ChoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacturalStatement = table.Column<bool>(type: "bit", nullable: false),
                    ChoicesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Choice", x => x.ChoiceId);
                    table.ForeignKey(
                        name: "FK_Choice_choices_ChoicesId",
                        column: x => x.ChoicesId,
                        principalTable: "choices",
                        principalColumn: "ChoicesId");
                });

            migrationBuilder.CreateTable(
                name: "questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionHeading = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChoicesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questions", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_questions_choices_ChoicesId",
                        column: x => x.ChoicesId,
                        principalTable: "choices",
                        principalColumn: "ChoicesId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Choice_ChoicesId",
                table: "Choice",
                column: "ChoicesId");

            migrationBuilder.CreateIndex(
                name: "IX_questions_ChoicesId",
                table: "questions",
                column: "ChoicesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Choice");

            migrationBuilder.DropTable(
                name: "questions");

            migrationBuilder.DropTable(
                name: "choices");
        }
    }
}
