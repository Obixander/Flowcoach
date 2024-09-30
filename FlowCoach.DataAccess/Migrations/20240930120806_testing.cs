using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlowCoach.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class testing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BodyFlowArticles",
                columns: table => new
                {
                    BodyFlowArticleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyFlowArticles", x => x.BodyFlowArticleId);
                });

            migrationBuilder.CreateTable(
                name: "Coachings",
                columns: table => new
                {
                    CoachingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coachings", x => x.CoachingId);
                });

            migrationBuilder.CreateTable(
                name: "SelfcareArticles",
                columns: table => new
                {
                    SelfcareArticleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoundfileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelfcareArticles", x => x.SelfcareArticleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "BodyFlowCards",
                columns: table => new
                {
                    BodyFlowCardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BodyFlowArticleId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyFlowCards", x => x.BodyFlowCardId);
                    table.ForeignKey(
                        name: "FK_BodyFlowCards_BodyFlowArticles_BodyFlowArticleId",
                        column: x => x.BodyFlowArticleId,
                        principalTable: "BodyFlowArticles",
                        principalColumn: "BodyFlowArticleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmotionCards",
                columns: table => new
                {
                    EmotionCardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoachingId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmotionCards", x => x.EmotionCardId);
                    table.ForeignKey(
                        name: "FK_EmotionCards_Coachings_CoachingId",
                        column: x => x.CoachingId,
                        principalTable: "Coachings",
                        principalColumn: "CoachingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSaveAble = table.Column<bool>(type: "bit", nullable: false),
                    CoachingId = table.Column<int>(type: "int", nullable: true),
                    SelfcareArticleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_Questions_Coachings_CoachingId",
                        column: x => x.CoachingId,
                        principalTable: "Coachings",
                        principalColumn: "CoachingId");
                    table.ForeignKey(
                        name: "FK_Questions_SelfcareArticles_SelfcareArticleId",
                        column: x => x.SelfcareArticleId,
                        principalTable: "SelfcareArticles",
                        principalColumn: "SelfcareArticleId");
                });

            migrationBuilder.CreateTable(
                name: "SelfcareCards",
                columns: table => new
                {
                    SelfCareCardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SelfCareArticleId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelfcareCards", x => x.SelfCareCardId);
                    table.ForeignKey(
                        name: "FK_SelfcareCards_SelfcareArticles_SelfCareArticleId",
                        column: x => x.SelfCareArticleId,
                        principalTable: "SelfcareArticles",
                        principalColumn: "SelfcareArticleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JournalEntries",
                columns: table => new
                {
                    JournalEntryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalEntries", x => x.JournalEntryId);
                    table.ForeignKey(
                        name: "FK_JournalEntries_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JournalEntries_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BodyFlowCards_BodyFlowArticleId",
                table: "BodyFlowCards",
                column: "BodyFlowArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_EmotionCards_CoachingId",
                table: "EmotionCards",
                column: "CoachingId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalEntries_QuestionId",
                table: "JournalEntries",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalEntries_UserId",
                table: "JournalEntries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CoachingId",
                table: "Questions",
                column: "CoachingId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SelfcareArticleId",
                table: "Questions",
                column: "SelfcareArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_SelfcareCards_SelfCareArticleId",
                table: "SelfcareCards",
                column: "SelfCareArticleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BodyFlowCards");

            migrationBuilder.DropTable(
                name: "EmotionCards");

            migrationBuilder.DropTable(
                name: "JournalEntries");

            migrationBuilder.DropTable(
                name: "SelfcareCards");

            migrationBuilder.DropTable(
                name: "BodyFlowArticles");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Coachings");

            migrationBuilder.DropTable(
                name: "SelfcareArticles");
        }
    }
}
