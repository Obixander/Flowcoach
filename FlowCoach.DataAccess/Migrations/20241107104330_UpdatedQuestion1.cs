using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlowCoach.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedQuestion1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodyFlowCards_BodyFlowArticles_BodyFlowArticleId",
                table: "BodyFlowCards");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_SelfcareArticles_SelfcareArticleId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_SelfcareCards_SelfcareArticles_SelfCareArticleId",
                table: "SelfcareCards");

            migrationBuilder.DropIndex(
                name: "IX_SelfcareCards_SelfCareArticleId",
                table: "SelfcareCards");

            migrationBuilder.DropIndex(
                name: "IX_BodyFlowCards_BodyFlowArticleId",
                table: "BodyFlowCards");

            migrationBuilder.RenameColumn(
                name: "SelfcareArticleId",
                table: "Questions",
                newName: "SelfCareArticleId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_SelfcareArticleId",
                table: "Questions",
                newName: "IX_Questions_SelfCareArticleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_SelfcareArticles_SelfCareArticleId",
                table: "Questions",
                column: "SelfCareArticleId",
                principalTable: "SelfcareArticles",
                principalColumn: "SelfcareArticleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_SelfcareArticles_SelfCareArticleId",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "SelfCareArticleId",
                table: "Questions",
                newName: "SelfcareArticleId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_SelfCareArticleId",
                table: "Questions",
                newName: "IX_Questions_SelfcareArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_SelfcareCards_SelfCareArticleId",
                table: "SelfcareCards",
                column: "SelfCareArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyFlowCards_BodyFlowArticleId",
                table: "BodyFlowCards",
                column: "BodyFlowArticleId");

            migrationBuilder.AddForeignKey(
                name: "FK_BodyFlowCards_BodyFlowArticles_BodyFlowArticleId",
                table: "BodyFlowCards",
                column: "BodyFlowArticleId",
                principalTable: "BodyFlowArticles",
                principalColumn: "BodyFlowArticleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_SelfcareArticles_SelfcareArticleId",
                table: "Questions",
                column: "SelfcareArticleId",
                principalTable: "SelfcareArticles",
                principalColumn: "SelfcareArticleId");

            migrationBuilder.AddForeignKey(
                name: "FK_SelfcareCards_SelfcareArticles_SelfCareArticleId",
                table: "SelfcareCards",
                column: "SelfCareArticleId",
                principalTable: "SelfcareArticles",
                principalColumn: "SelfcareArticleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
