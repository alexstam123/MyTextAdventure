using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MytextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            // my first commit in VS 2017
            Console.WriteLine("What's your character name?");
            string name = Console.ReadLine();
            Hero myAwesomeHero = new Hero(name);
            Console.WriteLine("What's your character race?");
            string race = Console.ReadLine();
            myAwesomeHero.Race = race;
            Console.WriteLine("What's your character class?");
            string heroclass = Console.ReadLine();
            myAwesomeHero.HeroClass = heroclass;
            AttributeGenerator at = new AttributeGenerator();
            myAwesomeHero= at.Generate(myAwesomeHero);
            Console.WriteLine(myAwesomeHero.ToString());
            
        }
    }
}
