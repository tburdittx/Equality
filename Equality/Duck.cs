using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality
{
    public class Duck
    {

        Dictionary<Duck, int> ducks = new Dictionary<Duck, int>();
        public string Name { get; set; }
        public string Type { get; set; }
        public int WeightInGrams { get; set; }
        public int AgeInMonths { get; set; }

        public List<KeyValuePair<Duck, int>> sorted;
        public Duck(string name, string type, int weightInGrams)
        {
            Name = name;
            Type = type;
            WeightInGrams = weightInGrams;
        }

        public string CreatingDictionary()
        {
            ducks.Add(new Duck("Sir Quackalot", "Mallard", 100), 17);
            ducks.Add(new Duck("Peter", "decoy", 90), 5);
            ducks.Add(new Duck("Waddles", "Mallard", 150), 12);
            ducks.Add(new Duck("Pickle", "Mallard ", 63), 33);

            sorted = (from dd in ducks orderby dd.Value select dd).ToList();

            return sorted.ToString();
            
        }
        public Duck()
        {

        }

    }
}
