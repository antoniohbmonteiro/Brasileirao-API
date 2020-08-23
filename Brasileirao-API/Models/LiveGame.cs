using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Brasileirao_API.Models
{
    public class LiveGame
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Type{ get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Message { get; set; }

        public int GameId { get; set; }
        public virtual Game Game{ get; set; }

    }
}
