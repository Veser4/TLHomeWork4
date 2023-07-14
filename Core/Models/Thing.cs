using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Thing
    {
        public int ThingId { get; set; }
        public string Name { get; set; }
        public int HeroId { get; set; }
        public Hero Hero { get; set; }
        public override string ToString()
        {
            if (Hero == null)
            {
                return $"{ThingId} {Name}";
            }
            return $"{ThingId} {Name} {Hero}";
        }

    }
}
