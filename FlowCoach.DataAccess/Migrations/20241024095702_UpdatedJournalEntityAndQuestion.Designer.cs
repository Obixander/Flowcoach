﻿// <auto-generated />
using System;
using FlowCoach.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlowCoach.DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241024095702_UpdatedJournalEntityAndQuestion")]
    partial class UpdatedJournalEntityAndQuestion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FlowCoach.Entities.BodyFlowArticle", b =>
                {
                    b.Property<int>("BodyFlowArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BodyFlowArticleId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Images")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BodyFlowArticleId");

                    b.ToTable("BodyFlowArticles");
                });

            modelBuilder.Entity("FlowCoach.Entities.BodyFlowCard", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BodyFlowCardId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardId"));

                    b.Property<int>("BodyFlowArticleId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CardId");

                    b.HasIndex("BodyFlowArticleId");

                    b.ToTable("BodyFlowCards");
                });

            modelBuilder.Entity("FlowCoach.Entities.Coaching", b =>
                {
                    b.Property<int>("CoachingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoachingId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntroText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CoachingId");

                    b.ToTable("Coachings");
                });

            modelBuilder.Entity("FlowCoach.Entities.EmotionCard", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EmotionCardId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardId"));

                    b.Property<int>("CoachingId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CardId");

                    b.ToTable("EmotionCards");
                });

            modelBuilder.Entity("FlowCoach.Entities.FlowCoachCard", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FlowCoachCardId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CardId");

                    b.ToTable("FlowCoachCards");
                });

            modelBuilder.Entity("FlowCoach.Entities.JournalEntry", b =>
                {
                    b.Property<int>("JournalEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JournalEntryId"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("JournalEntryId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("UserId");

                    b.ToTable("JournalEntries");
                });

            modelBuilder.Entity("FlowCoach.Entities.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"));

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CoachingId")
                        .HasColumnType("int");

                    b.Property<bool>("IsSaveAble")
                        .HasColumnType("bit");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionType")
                        .HasColumnType("int");

                    b.Property<int?>("SelfcareArticleId")
                        .HasColumnType("int");

                    b.HasKey("QuestionId");

                    b.HasIndex("CoachingId");

                    b.HasIndex("SelfcareArticleId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("FlowCoach.Entities.SelfCareArticle", b =>
                {
                    b.Property<int>("SelfcareArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SelfcareArticleId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoundfileUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SelfcareArticleId");

                    b.ToTable("SelfcareArticles");
                });

            modelBuilder.Entity("FlowCoach.Entities.SelfCareCard", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SelfCareCardId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardId"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SelfCareArticleId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CardId");

                    b.HasIndex("SelfCareArticleId");

                    b.ToTable("SelfcareCards");
                });

            modelBuilder.Entity("FlowCoach.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FlowCoach.Entities.BodyFlowCard", b =>
                {
                    b.HasOne("FlowCoach.Entities.BodyFlowArticle", "BodyFlowArticle")
                        .WithMany()
                        .HasForeignKey("BodyFlowArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BodyFlowArticle");
                });

            modelBuilder.Entity("FlowCoach.Entities.JournalEntry", b =>
                {
                    b.HasOne("FlowCoach.Entities.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlowCoach.Entities.User", null)
                        .WithMany("JournalEntries")
                        .HasForeignKey("UserId");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("FlowCoach.Entities.Question", b =>
                {
                    b.HasOne("FlowCoach.Entities.Coaching", null)
                        .WithMany("Questions")
                        .HasForeignKey("CoachingId");

                    b.HasOne("FlowCoach.Entities.SelfCareArticle", null)
                        .WithMany("Questions")
                        .HasForeignKey("SelfcareArticleId");
                });

            modelBuilder.Entity("FlowCoach.Entities.SelfCareCard", b =>
                {
                    b.HasOne("FlowCoach.Entities.SelfCareArticle", "SelfcareArticle")
                        .WithMany()
                        .HasForeignKey("SelfCareArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SelfcareArticle");
                });

            modelBuilder.Entity("FlowCoach.Entities.Coaching", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("FlowCoach.Entities.SelfCareArticle", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("FlowCoach.Entities.User", b =>
                {
                    b.Navigation("JournalEntries");
                });
#pragma warning restore 612, 618
        }
    }
}
