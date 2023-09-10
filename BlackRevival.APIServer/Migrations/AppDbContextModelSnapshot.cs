﻿// <auto-generated />
using System;
using BlackRevival.APIServer.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlackRevival.APIServer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BlackRevival.APIServer.Database.Character", b =>
                {
                    b.Property<long>("CharacterNum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("ActiveCharacterSkinType")
                        .HasColumnType("int");

                    b.Property<bool>("ActiveLive2D")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("CharacterClass")
                        .HasColumnType("int");

                    b.Property<int>("CharacterGrade")
                        .HasColumnType("int");

                    b.Property<int>("CharacterPurchaseType")
                        .HasColumnType("int");

                    b.Property<int>("CharacterStatus")
                        .HasColumnType("int");

                    b.Property<int>("EnhanceExp")
                        .HasColumnType("int");

                    b.Property<bool>("Host")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("NormalPlayCount")
                        .HasColumnType("int");

                    b.Property<int>("NormalWinCount")
                        .HasColumnType("int");

                    b.Property<int>("Pfr")
                        .HasColumnType("int");

                    b.Property<int>("Pmn")
                        .HasColumnType("int");

                    b.Property<int>("PotentialSkillId")
                        .HasColumnType("int");

                    b.Property<int>("Psd")
                        .HasColumnType("int");

                    b.Property<int>("RankPlayCount")
                        .HasColumnType("int");

                    b.Property<int>("RankWinCount")
                        .HasColumnType("int");

                    b.Property<int>("TeamNumber")
                        .HasColumnType("int");

                    b.Property<int>("ToNormalRemainSeconds")
                        .HasColumnType("int");

                    b.Property<string>("UserNickname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long?>("UserNum")
                        .HasColumnType("bigint");

                    b.HasKey("CharacterNum");

                    b.HasIndex("UserNum");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("BlackRevival.APIServer.Database.OwnedSkin", b =>
                {
                    b.Property<long>("OwnedSkinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<bool>("ActiveLive2D")
                        .HasColumnType("tinyint(1)")
                        .HasAnnotation("Relational:JsonPropertyName", "live");

                    b.Property<int>("CharacterClass")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "cls");

                    b.Property<int>("CharacterSkinType")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "ckt");

                    b.Property<bool>("Owned")
                        .HasColumnType("tinyint(1)")
                        .HasAnnotation("Relational:JsonPropertyName", "own");

                    b.Property<int>("SkinEnableType")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "setp");

                    b.Property<long>("UserNum")
                        .HasColumnType("bigint")
                        .HasAnnotation("Relational:JsonPropertyName", "unm");

                    b.HasKey("OwnedSkinId");

                    b.HasIndex("UserNum");

                    b.ToTable("OwnedSkins");
                });

            modelBuilder.Entity("BlackRevival.APIServer.Database.User", b =>
                {
                    b.Property<long>("UserNum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("ActivatedPotentialSkillId")
                        .HasColumnType("int");

                    b.Property<long>("ActiveCharacterNum")
                        .HasColumnType("bigint");

                    b.Property<int>("AdViewCount")
                        .HasColumnType("int");

                    b.Property<string>("AppLanguageCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Aps")
                        .HasColumnType("int");

                    b.Property<bool>("Bgm")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Lastword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("League")
                        .HasColumnType("int");

                    b.Property<int>("LeaguePoint")
                        .HasColumnType("int");

                    b.Property<bool>("Lte")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Ltf")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lto")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Ltr")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Ltt")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Ltv")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("MatchingCardCode")
                        .HasColumnType("int");

                    b.Property<int>("MaxAdViewCount")
                        .HasColumnType("int");

                    b.Property<bool>("NewPostArrived")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("ReceivePushMsg")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("ResearcherExp")
                        .HasColumnType("int");

                    b.Property<int>("ResearcherTitleCode")
                        .HasColumnType("int");

                    b.Property<string>("Rtn")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Sigc")
                        .HasColumnType("int");

                    b.Property<int>("Sigg")
                        .HasColumnType("int");

                    b.Property<bool>("SoundEffect")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("TermsAgree")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("TutorialProgress")
                        .HasColumnType("int");

                    b.Property<string>("Watchword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserNum");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BlackRevival.APIServer.Database.UserAsset", b =>
                {
                    b.Property<long>("UserNum")
                        .HasColumnType("bigint");

                    b.Property<int>("AgliaScore")
                        .HasColumnType("int");

                    b.Property<int>("BearPoint")
                        .HasColumnType("int");

                    b.Property<int>("Credit")
                        .HasColumnType("int");

                    b.Property<int>("ExperimentMemory")
                        .HasColumnType("int");

                    b.Property<int>("Gem")
                        .HasColumnType("int");

                    b.Property<int>("Gold")
                        .HasColumnType("int");

                    b.Property<int>("LabyrinthPoint")
                        .HasColumnType("int");

                    b.Property<int>("Mileage")
                        .HasColumnType("int");

                    b.Property<int>("TournamentPoint")
                        .HasColumnType("int");

                    b.Property<int>("TournamentTicket")
                        .HasColumnType("int");

                    b.Property<int>("VoteStamp")
                        .HasColumnType("int");

                    b.Property<int>("VoteTicket")
                        .HasColumnType("int");

                    b.HasKey("UserNum");

                    b.ToTable("UserAssets");
                });

            modelBuilder.Entity("BlackRevival.APIServer.Database.Character", b =>
                {
                    b.HasOne("BlackRevival.APIServer.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserNum");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlackRevival.APIServer.Database.OwnedSkin", b =>
                {
                    b.HasOne("BlackRevival.APIServer.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserNum")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlackRevival.APIServer.Database.UserAsset", b =>
                {
                    b.HasOne("BlackRevival.APIServer.Database.User", "User")
                        .WithOne("UserAsset")
                        .HasForeignKey("BlackRevival.APIServer.Database.UserAsset", "UserNum")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlackRevival.APIServer.Database.User", b =>
                {
                    b.Navigation("UserAsset")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
