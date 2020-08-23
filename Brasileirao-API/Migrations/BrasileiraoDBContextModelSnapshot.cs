﻿// <auto-generated />
using Brasileirao_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Brasileirao_API.Migrations
{
    [DbContext(typeof(BrasileiraoDBContext))]
    partial class BrasileiraoDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Brasileirao_API.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("GuestTeamId")
                        .HasColumnType("int");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<string>("Hour")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Round")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GuestTeamId");

                    b.HasIndex("HomeTeamId");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("Brasileirao_API.Models.LiveGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("LiveGame");
                });

            modelBuilder.Entity("Brasileirao_API.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Acronym")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Stadium")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Team");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Acronym = "vas",
                            Logo = "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/vasco_60x60.png",
                            Name = "Vasco",
                            Stadium = "Campo Vasco"
                        },
                        new
                        {
                            Id = 2,
                            Acronym = "ava",
                            Logo = "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/avai_60x60_.png",
                            Name = "Avaí",
                            Stadium = "Campo Avaí"
                        },
                        new
                        {
                            Id = 3,
                            Acronym = "spo",
                            Logo = "http://s.glbimg.com/es/sde/f/equipes/2014/09/15/sport_60x60.png",
                            Name = "Sport",
                            Stadium = "Campo Sport"
                        },
                        new
                        {
                            Id = 4,
                            Acronym = "int",
                            Logo = "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/internacional_60x60.png",
                            Name = "Internacional",
                            Stadium = "Campo Internacional"
                        },
                        new
                        {
                            Id = 5,
                            Acronym = "pal",
                            Logo = "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/palmeiras_60x60.png",
                            Name = "Palmeiras",
                            Stadium = "Campo Palmeiras"
                        },
                        new
                        {
                            Id = 6,
                            Acronym = "cha",
                            Logo = "http://s.glbimg.com/es/sde/f/equipes/2015/05/06/chapecoense_60x60.png",
                            Name = "Chapecoense",
                            Stadium = "Campo Chapecoense"
                        },
                        new
                        {
                            Id = 7,
                            Acronym = "cam",
                            Logo = "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/atletico_mg_60x60.png",
                            Name = "Atlético-MG",
                            Stadium = "Campo Atlético-MG"
                        },
                        new
                        {
                            Id = 8,
                            Acronym = "cfc",
                            Logo = "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/coritiba_60x60.png",
                            Name = "Coritiba",
                            Stadium = "Campo Coritiba"
                        },
                        new
                        {
                            Id = 9,
                            Acronym = "gre",
                            Logo = "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/gremio_60x60.png",
                            Name = "Grêmio",
                            Stadium = "Campo Grêmio"
                        },
                        new
                        {
                            Id = 10,
                            Acronym = "cru",
                            Logo = "http://s.glbimg.com/es/sde/f/equipes/2015/04/29/cruzeiro_65.png",
                            Name = "Cruzeiro",
                            Stadium = "Campo Cruzeiro"
                        },
                        new
                        {
                            Id = 11,
                            Acronym = "cap",
                            Logo = "http://s.glbimg.com/es/sde/f/equipes/2015/06/24/atletico-pr_2015_65.png",
                            Name = "Athletico-PR",
                            Stadium = "Campo Athletico-PR"
                        },
                        new
                        {
                            Id = 12,
                            Acronym = "sao",
                            Logo = "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/sao_paulo_60x60.png",
                            Name = "São Paulo",
                            Stadium = "Campo São Paulo"
                        },
                        new
                        {
                            Id = 13,
                            Acronym = "fla",
                            Logo = "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/flamengo_60x60.png",
                            Name = "Flamengo",
                            Stadium = "Campo Flamengo"
                        },
                        new
                        {
                            Id = 14,
                            Acronym = "cor",
                            Logo = "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/corinthians_60x60.png",
                            Name = "Corinthians",
                            Stadium = "Campo Corinthians"
                        },
                        new
                        {
                            Id = 15,
                            Acronym = "pon",
                            Logo = "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/ponte_preta_60x60.png",
                            Name = "Ponte Preta",
                            Stadium = "Campo Ponte Preta"
                        },
                        new
                        {
                            Id = 16,
                            Acronym = "fig",
                            Logo = "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/figueirense_60x60.png",
                            Name = "Figueirense",
                            Stadium = "Campo Figueirense"
                        },
                        new
                        {
                            Id = 17,
                            Acronym = "goi",
                            Logo = "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/goias_60x60.png",
                            Name = "Goiás",
                            Stadium = "Campo Goiás"
                        },
                        new
                        {
                            Id = 18,
                            Acronym = "flu",
                            Logo = "http://s.glbimg.com/es/sde/f/equipes/2015/05/05/fluminense-logo-65x65.png",
                            Name = "Fluminense",
                            Stadium = "Campo Fluminense"
                        },
                        new
                        {
                            Id = 19,
                            Acronym = "san",
                            Logo = "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/santos_60x60.png",
                            Name = "Santos",
                            Stadium = "Campo Santos"
                        });
                });

            modelBuilder.Entity("Brasileirao_API.Models.Game", b =>
                {
                    b.HasOne("Brasileirao_API.Models.Team", "GuestTeam")
                        .WithMany()
                        .HasForeignKey("GuestTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Brasileirao_API.Models.Team", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Brasileirao_API.Models.LiveGame", b =>
                {
                    b.HasOne("Brasileirao_API.Models.Game", "Game")
                        .WithMany("LiveGames")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
