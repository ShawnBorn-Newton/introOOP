using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introOOP
{
    class SupperHero
    {
        //4 fields
        private string costume;
        private string name;
        private int strengthLevel;
        private string power;
        private bool hasCape;
        //4 properties
        public string Costume
        {
            get { return this.costume; }
            set { this.costume = value; }
        }
        public string Name
        {
            get { return this.name; }
        }
        public int StrengthLevel
        {
            get { return this.strengthLevel; }
            set { this.strengthLevel = value; }
        }
        public string Power
        {
            get { return this.power; }
        }
        public bool HasCape
        {
            get { return this.hasCape; }
            set { this.hasCape = value; }
        }


        //3 Constructors
        public SupperHero()
        {
            //this is my default constructor
        }

        public SupperHero(string name)
        {
            this.name = name;
            this.strengthLevel = 100;
        }
        public SupperHero(string costume, string name, int strengthLevel, string power, bool hasCape)
        {
            this.costume = costume;
            this.name = name;
            this.strengthLevel = strengthLevel;
            this.power = power;
            this.hasCape = hasCape;
        }
        //2 methods
        public void BattleNemesis()
        {
            this.StrengthLevel -= 10;
            this.HasCape = false;
            this.Costume = "tattered";
        }

        public void AllyGained()
        {
            this.StrengthLevel += 10;
            this.HasCape = false;
            Console.WriteLine("Thanks you for being a friend!");
        }
        public void GetHealthy(string costume, int strengthLevel)
        {
            this.StrengthLevel = +10;
            this.Costume = costume;
        }
    }
}
