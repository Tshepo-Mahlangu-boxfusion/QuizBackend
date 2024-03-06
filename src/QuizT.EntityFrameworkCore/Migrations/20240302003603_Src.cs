using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizT.Migrations
{
    /// <inheritdoc />
    public partial class Src : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Src",
                table: "Quizzes",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Src",
                table: "Quizzes");
        }
    }
}
