using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlowCoach.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmotionCards_Coachings_CoachingId",
                table: "EmotionCards");

            migrationBuilder.DropIndex(
                name: "IX_EmotionCards_CoachingId",
                table: "EmotionCards");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_EmotionCards_CoachingId",
                table: "EmotionCards",
                column: "CoachingId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmotionCards_Coachings_CoachingId",
                table: "EmotionCards",
                column: "CoachingId",
                principalTable: "Coachings",
                principalColumn: "CoachingId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
