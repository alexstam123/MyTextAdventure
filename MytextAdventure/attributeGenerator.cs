using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MytextAdventure
{
    public class AttributeGenerator
    {
        Random myRandomGenerator = new Random();
        public Hero Generate(Hero myHero)
        {
            myHero.Strength = myRandomGenerator.Next(1, 21);
            if (myHero.HeroClass.ToLower() == "warrior")
                myHero.Strength = myHero.Strength + 3;
            else if (myHero.HeroClass.ToLower() == "wizard")
                myHero.Strength--;
            myHero.Dexterity = myRandomGenerator.Next(1, 21);
            myHero.Wisdom = myRandomGenerator.Next(1, 21);
            myHero.Intelligence = myRandomGenerator.Next(1, 21);
            myHero.Constitution = myRandomGenerator.Next(1, 21);
            myHero.Charisma = myRandomGenerator.Next(1, 21);
            myHero.HitPoints = (myHero.Strength + myHero.Constitution) / 2;
            return myHero;
        }
    }
}
