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
         ""logo"":""http://s.glbimg.com/es/sde/f/equipes/2015/05/05/fluminense-logo-65x65.png""
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

        public DbSet<LiveGame> LiveGame{ get; set; }
    }
}
