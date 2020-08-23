using Newtonsoft.Json;
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
        [JsonProperty("id")]
        public int Id { get; set; }
        [Required]
        [JsonProperty("type")]
        public string Type { get; set; }
        [Required]
        [JsonProperty("time")]
        public string Time{ get; set; }
        [Required]
        [JsonProperty("minutes")]
        public string Minutes { get; set; }
        [Required]
        [JsonProperty("title")]
        public string Title { get; set; }
        [Required]
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("gameId")]
        public int GameId { get; set; }
        public virtual Game Game{ get; set; }

    }
}
