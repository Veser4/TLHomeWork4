using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Race
    {
        public int RaceId { get; set; }
        public string Name { get; set; }
        public List<Hero> Heroes { get; set; } = new List<Hero>();
        public override string ToString()
        {
            return $"{RaceId} {Name}";
        }
    }
}
