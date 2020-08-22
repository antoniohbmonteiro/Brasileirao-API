using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brasileirao_API.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Acronym { get; set; }
        public string Stadium { get; set; }
        public string Logo { get; set; }
    }
}
