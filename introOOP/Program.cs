using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cat secondCat = new Cat("Oz", 3, "Orange and white");
            //secondCat.Name = "Ozzy";
            //Console.WriteLine(secondCat.Name);
            //Console.WriteLine(secondCat.Age);
            //secondCat.Eat();

            //SupperHero firstHero = new SupperHero();
            //firstHero.StrengthLevel = 100;
            //firstHero.HasCape = true;

            //firstHero.BattleNemesis();
            //Console.WriteLine(firstHero.HasCape);
            //Console.WriteLine(firstHero.StrengthLevel);

            //firstHero.BattleNemesis();
            //Console.WriteLine(firstHero.HasCape);
            //Console.WriteLine(firstHero.StrengthLevel);

            //SupperHero secondHero = new SupperHero("Speff");
            //Console.WriteLine(secondHero.StrengthLevel);

            //secondHero.AllyGained();
            //Console.WriteLine(secondHero.StrengthLevel);


            SupperHero thiredHero = new SupperHero("blask unitard", "Herph", 1000, "spigetti fingers", false);
            thiredHero.BattleNemesis();
            Console.WriteLine("OH no! Now my costume is " + thiredHero.Costume + "\n and my strenth is down to " + thiredHero.StrengthLevel);
        }
    }
}
