using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.Models
{
    public class Feature
    {
        public int FeatureId { get; set; }
        public string Intelligence { get; set; } = string.Empty;
        public string Agility { get; set; } = string.Empty;
        public string Strength { get; set; } = string.Empty;

        public Hero Hero { get; set; }
        public override string ToString()
        {
            return $"{FeatureId} {Intelligence} {Agility} {Strength}";
        }
    }
}
