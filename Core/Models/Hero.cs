using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Hero
    {
        public int HeroId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int RaceId { get; set; }
        public Race Race { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public int FeatureId { get; set; }
        public Feature Feature { get; set; }

        public Thing Thing { get; set; }

        public override string ToString()
        {
            if (Feature == null || Race == null || Class == null)
            {
                return $"{HeroId} {FirstName} {LastName}";
            }
            return $"{HeroId} {FirstName} {LastName} {Race} {Class} {Feature}";
        }
    }
}
