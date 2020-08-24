using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Brasileirao_API.Models;
using Newtonsoft.Json;

namespace Brasileirao_API.Data
{
    public class BrasileiraoDBContext : DbContext
    {
        public BrasileiraoDBContext(DbContextOptions<BrasileiraoDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var teams = JsonConvert.DeserializeObject<List<Team>>(GetTeams());
            modelBuilder.Entity<Team>().HasData(teams);

            var games = JsonConvert.DeserializeObject<List<Game>>(GetGames());
            modelBuilder.Entity<Game>().HasData(games);

            var liveGames = JsonConvert.DeserializeObject<List<LiveGame>>(GetLiveGames());
            modelBuilder.Entity<LiveGame>().HasData(liveGames);
        }

        private string GetLiveGames()
        {
            return @"[
    {
        ""id"":1,
        ""type"":""text"",
        ""title"":""VAI NO VAR!"",
        ""message"":""O árbitro Rafael Traci para o jogo e vai até a cabine de vídeo. Jogada revisada é do chute de Vitinho, desviado na mão de Kannemann."",
        ""time"":""1º Tempo"",
        ""minutes"":""33'"",
        ""gameId"":1
    },{
        ""id"":2,
        ""type"":""text"",
        ""title"":""FALA, GALHARDO"",
        ""message"":""É um ataque mais leve, sem um jogador de referência, até porque temos jogadores rápidos. O lance do gol foi assim."",
        ""time"":""1º Tempo"",
        ""minutes"":""40'"",
        ""gameId"":1
    },{
        ""id"":3,
        ""type"":""text"",
        ""title"":""NO REBOTE... PRA FORA!"",
        ""message"":""Atlético bombardeia o Cruzeiro em busca do gol de empate. Após uma série de finalizações em sequências (bloqueadas), Allan fica com o rebote e tenta um chute de primeira, mas a bola sobe muito e vai pra fora."",
        ""time"":""2º Tempo"",
        ""minutes"":""12'"",
        ""gameId"":1
    },{
        ""id"":4,
        ""type"":""text"",
        ""title"":""DE NOVO..."",
        ""message"":""Mensagem de quem faz este Tempo Real: vou deixar 'escanteio marcado' aqui no 'Ctrl + C'... Mais um!"",
        ""time"":""2º Tempo"",
        ""minutes"":""26'"",
        ""gameId"":1
    },
    {
        ""id"":5,
        ""type"":""text"",
        ""title"":""ESPIRROU O TACO!"",
        ""message"":""Matheuzinho tenta afastar, mas chuta o vento"",
        ""time"":""1º Tempo"",
        ""minutes"":""7'"",
        ""gameId"":2
    },
    {
        ""id"":6,
        ""type"":""text"",
        ""title"":""OLHA O RODINEI!"",
        ""message"":""Lateral do Inter entorta o marcador do Dragão"",
        ""time"":""2º Tempo"",
        ""minutes"":""22'"",
        ""gameId"":2
    }
]";
        }

        private string GetGames()
        {
            return @"[
    {
        ""id"":1,
        ""round"":1,
        ""day"":""26/08"",
        ""hour"":""17:00"",
        ""homeTeamId"":7,
        ""guestTeamId"":10
    },
    {
        ""id"":2,
        ""round"":1,
        ""day"":""26/08"",
        ""hour"":""19:00"",
        ""homeTeamId"":3,
        ""guestTeamId"":4
    },
    {
        ""id"":3,
        ""round"":1,
        ""day"":""27/08"",
        ""hour"":""15:00"",
        ""homeTeamId"":1,
        ""guestTeamId"":8
    },
    {
        ""id"":4,
        ""round"":1,
        ""day"":""27/08"",
        ""hour"":""17:00"",
        ""homeTeamId"":9,
        ""guestTeamId"":15
    },
    {
        ""id"":5,
        ""round"":1,
        ""day"":""27/08"",
        ""hour"":""19:00"",
        ""homeTeamId"":19,
        ""guestTeamId"":16
    },
    {
        ""id"":6,
        ""round"":1,
        ""day"":""28/08"",
        ""hour"":""15:00"",
        ""homeTeamId"":18,
        ""guestTeamId"":5
    },
    {
        ""id"":7,
        ""round"":1,
        ""day"":""28/08"",
        ""hour"":""17:00"",
        ""homeTeamId"":11,
        ""guestTeamId"":6
    },
    {
        ""id"":8,
        ""round"":1,
        ""day"":""28/08"",
        ""hour"":""19:00"",
        ""homeTeamId"":17,
        ""guestTeamId"":13
    },
    {
        ""id"":9,
        ""round"":1,
        ""day"":""29/08"",
        ""hour"":""15:00"",
        ""homeTeamId"":2,
        ""guestTeamId"":14
    }
]";
        }

        private string GetTeams()
        {
            return @"[
      {
         ""id"":1,
         ""name"":""Vasco"",
         ""acronym"":""vas"",
         ""stadium"":""Campo Vasco"",
         ""logo"":""http://s.glbimg.com/es/sde/f/equipes/2014/04/14/vasco_60x60.png""
      },
      {
         ""id"":2,
         ""name"":""Avaí"",
         ""acronym"":""ava"",
         ""stadium"":""Campo Avaí"",
         ""logo"":""http://s.glbimg.com/es/sde/f/equipes/2014/04/14/avai_60x60_.png""
      },
      {
         ""id"":3,
         ""name"":""Sport"",
         ""acronym"":""spo"",
         ""stadium"":""Campo Sport"",
         ""logo"":""http://s.glbimg.com/es/sde/f/equipes/2014/09/15/sport_60x60.png""
      },
      {
         ""id"":4,
         ""name"":""Internacional"",
         ""acronym"":""int"",
         ""stadium"":""Campo Internacional"",
         ""logo"":""http://s.glbimg.com/es/sde/f/equipes/2014/04/14/internacional_60x60.png""
      },
      {
         ""id"":5,
         ""name"":""Palmeiras"",
         ""acronym"":""pal"",
         ""stadium"":""Campo Palmeiras"",
         ""logo"":""http://s.glbimg.com/es/sde/f/equipes/2014/04/14/palmeiras_60x60.png""
      },
      {
         ""id"":6,
         ""name"":""Chapecoense"",
         ""acronym"":""cha"",
         ""stadium"":""Campo Chapecoense"",
         ""logo"":""http://s.glbimg.com/es/sde/f/equipes/2015/05/06/chapecoense_60x60.png""
      },
      {
         ""id"":7,
         ""name"":""Atlético-MG"",
         ""acronym"":""cam"",
         ""stadium"":""Campo Atlético-MG"",
         ""logo"":""http://s.glbimg.com/es/sde/f/equipes/2014/04/14/atletico_mg_60x60.png""
      },
      {
         ""id"":8,
         ""name"":""Coritiba"",
         ""acronym"":""cfc"",
         ""stadium"":""Campo Coritiba"",
         ""logo"":""http://s.glbimg.com/es/sde/f/equipes/2014/04/14/coritiba_60x60.png""
      },
      {
         ""id"":9,
         ""name"":""Grêmio"",
         ""acronym"":""gre"",
         ""stadium"":""Campo Grêmio"",
         ""logo"":""http://s.glbimg.com/es/sde/f/equipes/2014/04/14/gremio_60x60.png""
      },
      {
         ""id"":10,
         ""name"":""Cruzeiro"",
         ""acronym"":""cru"",
         ""stadium"":""Campo Cruzeiro"",
         ""logo"":""http://s.glbimg.com/es/sde/f/equipes/2015/04/29/cruzeiro_65.png""
      },
      {
         ""id"":11,
         ""name"":""Athletico-PR"",
         ""acronym"":""cap"",
         ""stadium"":""Campo Athletico-PR"",
         ""logo"":""http://s.glbimg.com/es/sde/f/equipes/2015/06/24/atletico-pr_2015_65.png""
      },
      {
         ""id"":12,
         ""name"":""São Paulo"",
         ""acronym"":""sao"",
         ""stadium"":""Campo São Paulo"",
         ""logo"":""http://s.glbimg.com/es/sde/f/equipes/2014/04/14/sao_paulo_60x60.png""
      },
      {
         ""id"":13,
         ""name"":""Flamengo"",
         ""acronym"":""fla"",
         ""stadium"":""Campo Flamengo"",
         ""logo"":""http://s.glbimg.com/es/sde/f/equipes/2014/04/14/flamengo_60x60.png""
      },
      {
         ""id"":14,
         ""name"":""Corinthians"",
         ""acronym"":""cor"",
         ""stadium"":""Campo Corinthians"",
         ""logo"":""http://s.glbimg.com/es/sde/f/equipes/2014/04/14/corinthians_60x60.png""
      },
      {
         ""id"":15,
         ""name"":""Ponte Preta"",
         ""acronym"":""pon"",
         ""stadium"":""Campo Ponte Preta"",
         ""logo"":""http://s.glbimg.com/es/sde/f/equipes/2014/04/14/ponte_preta_60x60.png""
      },
      {
         ""id"":16,
         ""name"":""Figueirense"",
         ""acronym"":""fig"",
         ""stadium"":""Campo Figueirense"",
         ""logo"":""http://s.glbimg.com/es/sde/f/equipes/2014/04/14/figueirense_60x60.png""
      },
      {
         ""id"":17,
         ""name"":""Goiás"",
         ""acronym"":""goi"",
         ""stadium"":""Campo Goiás"",
         ""logo"":""http://s.glbimg.com/es/sde/f/equipes/2014/04/14/goias_60x60.png""
      },
      {
         ""id"":18,
         ""name"":""Fluminense"",
         ""acronym"":""flu"",
         ""stadium"":""Campo Fluminense"",
         ""logo"":""http://s.glbimg.com/es/sde/f/equipes/2015/05/05/fluminense-escudo-65x65.png""
      },
      {
         ""id"":19,
         ""name"":""Santos"",
         ""acronym"":""san"",
         ""stadium"":""Campo Santos"",
         ""logo"":""http://s.glbimg.com/es/sde/f/equipes/2014/04/14/santos_60x60.png""
      }
   ]";
        }

        public DbSet<Team> Team { get; set; }

        public DbSet<Game> Game { get; set; }

        public DbSet<PushToken> Token { get; set; }

        public DbSet<LiveGame> LiveGame { get; set; }
    }
}
