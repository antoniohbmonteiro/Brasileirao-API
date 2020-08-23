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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int Round { get; set; }
        [Required]
        public string Day { get; set; }
        [Required]
        public string Hour { get; set; }
        [Required]
        public int HomeGols { get; set; } = 0;
        [Required]
        public int GuestGols { get; set; } = 0;


        [ForeignKey("HomeTeam")]
        public int HomeTeamId { get; set; }

        [ForeignKey("GuestTeam")]
        public int GuestTeamId { get; set; }

        public virtual Team HomeTeam { get; set; }
        public virtual Team GuestTeam { get; set; }

        public virtual ICollection<LiveGame> LiveGames { get; set; }
    }

}
