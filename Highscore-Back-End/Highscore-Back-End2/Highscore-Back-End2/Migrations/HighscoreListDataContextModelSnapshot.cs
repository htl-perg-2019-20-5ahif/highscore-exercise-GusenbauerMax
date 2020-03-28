﻿// <auto-generated />
using System;
using Highscore_Back_End2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Highscore_Back_End2.Migrations
{
    [DbContext(typeof(HighscoreListDataContext))]
    partial class HighscoreListDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Highscore_Back_End2.Model.HighscoreList", b =>
                {
                    b.Property<int>("HighscoreListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("HighscoreListId");

                    b.ToTable("HighscoreLists");

                    b.HasData(
                        new
                        {
                            HighscoreListId = 1
                        });
                });

            modelBuilder.Entity("Highscore_Back_End2.Model.Score", b =>
                {
                    b.Property<int>("ScoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HighscoreListId")
                        .HasColumnType("int");

                    b.Property<int>("HighsoreListId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.HasKey("ScoreId");

                    b.HasIndex("HighscoreListId");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("Highscore_Back_End2.Model.Score", b =>
                {
                    b.HasOne("Highscore_Back_End2.Model.HighscoreList", "HighscoreList")
                        .WithMany("Scores")
                        .HasForeignKey("HighscoreListId");
                });
#pragma warning restore 612, 618
        }
    }
}
