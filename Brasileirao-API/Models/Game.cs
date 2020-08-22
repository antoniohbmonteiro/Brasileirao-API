using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Brasileirao_API.Models
{
    public class Game
    {
        public int Id { get; set; }
        [Required]
        public int Round { get; set; }
        [Required]
        public string Day { get; set; }
        [Required]
        public string Hour { get; set; }


        [ForeignKey("HomeTeam")]
        public int HomeTeamId { get; set; }

        [ForeignKey("GuestTeam")]
        public int GuestTeamId { get; set; }

        public virtual Team HomeTeam { get; set; }
        public virtual Team GuestTeam { get; set; }

    }

}
