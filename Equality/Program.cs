using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck quack = new Duck();

            quack.CreatingDictionary();

            Console.WriteLine("Ducks sorted from youngest to oldest: \n");

            foreach (KeyValuePair<Duck, int> duck in quack.sorted)
            {
                Console.WriteLine(duck.Key.Name.ToString() + ", Months Old: " + duck.Value.ToString() + ", Duck type: " + duck.Key.Type.ToString() + ", Duck weight: " + duck.Key.WeightInGrams.ToString() + "\n");
            }

            Console.WriteLine("End of ducks!!");
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
