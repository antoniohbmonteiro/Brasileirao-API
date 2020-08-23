using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Brasileirao_API.Migrations
{
    public partial class VersaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Acronym = table.Column<string>(nullable: false),
                    Stadium = table.Column<string>(nullable: false),
                    Logo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Token",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Token", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Round = table.Column<int>(nullable: false),
                    Day = table.Column<string>(nullable: false),
                    Hour = table.Column<string>(nullable: false),
                    HomeTeamId = table.Column<int>(nullable: false),
                    GuestTeamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Game_Team_GuestTeamId",
                        column: x => x.GuestTeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Game_Team_HomeTeamId",
                        column: x => x.HomeTeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LiveGame",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Message = table.Column<string>(nullable: false),
                    GameId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiveGame", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LiveGame_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "Acronym", "Logo", "Name", "Stadium" },
                values: new object[,]
                {
                    { 1, "vas", "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/vasco_60x60.png", "Vasco", "Campo Vasco" },
                    { 17, "goi", "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/goias_60x60.png", "Goiás", "Campo Goiás" },
                    { 16, "fig", "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/figueirense_60x60.png", "Figueirense", "Campo Figueirense" },
                    { 15, "pon", "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/ponte_preta_60x60.png", "Ponte Preta", "Campo Ponte Preta" },
                    { 14, "cor", "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/corinthians_60x60.png", "Corinthians", "Campo Corinthians" },
                    { 13, "fla", "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/flamengo_60x60.png", "Flamengo", "Campo Flamengo" },
                    { 12, "sao", "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/sao_paulo_60x60.png", "São Paulo", "Campo São Paulo" },
                    { 11, "cap", "http://s.glbimg.com/es/sde/f/equipes/2015/06/24/atletico-pr_2015_65.png", "Athletico-PR", "Campo Athletico-PR" },
                    { 18, "flu", "http://s.glbimg.com/es/sde/f/equipes/2015/05/05/fluminense-logo-65x65.png", "Fluminense", "Campo Fluminense" },
                    { 10, "cru", "http://s.glbimg.com/es/sde/f/equipes/2015/04/29/cruzeiro_65.png", "Cruzeiro", "Campo Cruzeiro" },
                    { 8, "cfc", "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/coritiba_60x60.png", "Coritiba", "Campo Coritiba" },
                    { 7, "cam", "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/atletico_mg_60x60.png", "Atlético-MG", "Campo Atlético-MG" },
                    { 6, "cha", "http://s.glbimg.com/es/sde/f/equipes/2015/05/06/chapecoense_60x60.png", "Chapecoense", "Campo Chapecoense" },
                    { 5, "pal", "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/palmeiras_60x60.png", "Palmeiras", "Campo Palmeiras" },
                    { 4, "int", "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/internacional_60x60.png", "Internacional", "Campo Internacional" },
                    { 3, "spo", "http://s.glbimg.com/es/sde/f/equipes/2014/09/15/sport_60x60.png", "Sport", "Campo Sport" },
                    { 2, "ava", "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/avai_60x60_.png", "Avaí", "Campo Avaí" },
                    { 9, "gre", "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/gremio_60x60.png", "Grêmio", "Campo Grêmio" },
                    { 19, "san", "http://s.glbimg.com/es/sde/f/equipes/2014/04/14/santos_60x60.png", "Santos", "Campo Santos" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Game_GuestTeamId",
                table: "Game",
                column: "GuestTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_HomeTeamId",
                table: "Game",
                column: "HomeTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_LiveGame_GameId",
                table: "LiveGame",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LiveGame");

            migrationBuilder.DropTable(
                name: "Token");

            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
