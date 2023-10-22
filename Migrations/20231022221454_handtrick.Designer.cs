﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using spades.Data;

#nullable disable

namespace spades.Migrations
{
    [DbContext(typeof(SpadesContext))]
    [Migration("20231022221454_handtrick")]
    partial class handtrick
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("spades.Models.Bid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("HandId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TrickCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("HandId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Bids");
                });

            modelBuilder.Entity("spades.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Suit")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Value")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Suit = 1,
                            Value = 2
                        },
                        new
                        {
                            Id = 2,
                            Suit = 1,
                            Value = 3
                        },
                        new
                        {
                            Id = 3,
                            Suit = 1,
                            Value = 4
                        },
                        new
                        {
                            Id = 4,
                            Suit = 1,
                            Value = 5
                        },
                        new
                        {
                            Id = 5,
                            Suit = 1,
                            Value = 6
                        },
                        new
                        {
                            Id = 6,
                            Suit = 1,
                            Value = 7
                        },
                        new
                        {
                            Id = 7,
                            Suit = 1,
                            Value = 8
                        },
                        new
                        {
                            Id = 8,
                            Suit = 1,
                            Value = 9
                        },
                        new
                        {
                            Id = 9,
                            Suit = 1,
                            Value = 10
                        },
                        new
                        {
                            Id = 10,
                            Suit = 1,
                            Value = 11
                        },
                        new
                        {
                            Id = 11,
                            Suit = 1,
                            Value = 12
                        },
                        new
                        {
                            Id = 12,
                            Suit = 1,
                            Value = 13
                        },
                        new
                        {
                            Id = 13,
                            Suit = 1,
                            Value = 14
                        },
                        new
                        {
                            Id = 14,
                            Suit = 2,
                            Value = 2
                        },
                        new
                        {
                            Id = 15,
                            Suit = 2,
                            Value = 3
                        },
                        new
                        {
                            Id = 16,
                            Suit = 2,
                            Value = 4
                        },
                        new
                        {
                            Id = 17,
                            Suit = 2,
                            Value = 5
                        },
                        new
                        {
                            Id = 18,
                            Suit = 2,
                            Value = 6
                        },
                        new
                        {
                            Id = 19,
                            Suit = 2,
                            Value = 7
                        },
                        new
                        {
                            Id = 20,
                            Suit = 2,
                            Value = 8
                        },
                        new
                        {
                            Id = 21,
                            Suit = 2,
                            Value = 9
                        },
                        new
                        {
                            Id = 22,
                            Suit = 2,
                            Value = 10
                        },
                        new
                        {
                            Id = 23,
                            Suit = 2,
                            Value = 11
                        },
                        new
                        {
                            Id = 24,
                            Suit = 2,
                            Value = 12
                        },
                        new
                        {
                            Id = 25,
                            Suit = 2,
                            Value = 13
                        },
                        new
                        {
                            Id = 26,
                            Suit = 2,
                            Value = 14
                        },
                        new
                        {
                            Id = 27,
                            Suit = 3,
                            Value = 2
                        },
                        new
                        {
                            Id = 28,
                            Suit = 3,
                            Value = 3
                        },
                        new
                        {
                            Id = 29,
                            Suit = 3,
                            Value = 4
                        },
                        new
                        {
                            Id = 30,
                            Suit = 3,
                            Value = 5
                        },
                        new
                        {
                            Id = 31,
                            Suit = 3,
                            Value = 6
                        },
                        new
                        {
                            Id = 32,
                            Suit = 3,
                            Value = 7
                        },
                        new
                        {
                            Id = 33,
                            Suit = 3,
                            Value = 8
                        },
                        new
                        {
                            Id = 34,
                            Suit = 3,
                            Value = 9
                        },
                        new
                        {
                            Id = 35,
                            Suit = 3,
                            Value = 10
                        },
                        new
                        {
                            Id = 36,
                            Suit = 3,
                            Value = 11
                        },
                        new
                        {
                            Id = 37,
                            Suit = 3,
                            Value = 12
                        },
                        new
                        {
                            Id = 38,
                            Suit = 3,
                            Value = 13
                        },
                        new
                        {
                            Id = 39,
                            Suit = 3,
                            Value = 14
                        },
                        new
                        {
                            Id = 40,
                            Suit = 4,
                            Value = 2
                        },
                        new
                        {
                            Id = 41,
                            Suit = 4,
                            Value = 3
                        },
                        new
                        {
                            Id = 42,
                            Suit = 4,
                            Value = 4
                        },
                        new
                        {
                            Id = 43,
                            Suit = 4,
                            Value = 5
                        },
                        new
                        {
                            Id = 44,
                            Suit = 4,
                            Value = 6
                        },
                        new
                        {
                            Id = 45,
                            Suit = 4,
                            Value = 7
                        },
                        new
                        {
                            Id = 46,
                            Suit = 4,
                            Value = 8
                        },
                        new
                        {
                            Id = 47,
                            Suit = 4,
                            Value = 9
                        },
                        new
                        {
                            Id = 48,
                            Suit = 4,
                            Value = 10
                        },
                        new
                        {
                            Id = 49,
                            Suit = 4,
                            Value = 11
                        },
                        new
                        {
                            Id = 50,
                            Suit = 4,
                            Value = 12
                        },
                        new
                        {
                            Id = 51,
                            Suit = 4,
                            Value = 13
                        },
                        new
                        {
                            Id = 52,
                            Suit = 4,
                            Value = 14
                        });
                });

            modelBuilder.Entity("spades.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("EndStamp")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("StartStamp")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("spades.Models.Hand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("EndStamp")
                        .HasColumnType("TEXT");

                    b.Property<int>("GameId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartStamp")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Hands");
                });

            modelBuilder.Entity("spades.Models.HandPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("HandId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("HandId");

                    b.HasIndex("PlayerId");

                    b.ToTable("HandPlayers");
                });

            modelBuilder.Entity("spades.Models.HandPlayerCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HandPlayerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("HandPlayerId");

                    b.ToTable("HandPlayerCards");
                });

            modelBuilder.Entity("spades.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nickname")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("spades.Models.Trick", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("EndStamp")
                        .HasColumnType("TEXT");

                    b.Property<int>("HandId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartStamp")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("HandId");

                    b.ToTable("Tricks");
                });

            modelBuilder.Entity("spades.Models.TrickElement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("HandPlayerCardId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("PlayStamp")
                        .HasColumnType("TEXT");

                    b.Property<int>("TrickId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("HandPlayerCardId");

                    b.HasIndex("TrickId");

                    b.ToTable("TrickElements");
                });

            modelBuilder.Entity("spades.Models.Bid", b =>
                {
                    b.HasOne("spades.Models.Hand", "Hand")
                        .WithMany()
                        .HasForeignKey("HandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("spades.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hand");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("spades.Models.Hand", b =>
                {
                    b.HasOne("spades.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("spades.Models.HandPlayer", b =>
                {
                    b.HasOne("spades.Models.Hand", "Hand")
                        .WithMany()
                        .HasForeignKey("HandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("spades.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hand");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("spades.Models.HandPlayerCard", b =>
                {
                    b.HasOne("spades.Models.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("spades.Models.HandPlayer", "HandPlayer")
                        .WithMany()
                        .HasForeignKey("HandPlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("HandPlayer");
                });

            modelBuilder.Entity("spades.Models.Trick", b =>
                {
                    b.HasOne("spades.Models.Hand", "Hand")
                        .WithMany()
                        .HasForeignKey("HandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hand");
                });

            modelBuilder.Entity("spades.Models.TrickElement", b =>
                {
                    b.HasOne("spades.Models.HandPlayerCard", "HandPlayerCard")
                        .WithMany()
                        .HasForeignKey("HandPlayerCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("spades.Models.Trick", "Trick")
                        .WithMany()
                        .HasForeignKey("TrickId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HandPlayerCard");

                    b.Navigation("Trick");
                });
#pragma warning restore 612, 618
        }
    }
}
