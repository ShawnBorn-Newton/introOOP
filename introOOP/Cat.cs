using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introOOP
{
    class Cat
    {
        //Inside the class, we creat the blue print for an object.
        //Classes are templets used to creat objects
        //should always be in Pascel case.

        private string name;
        private int age;
        private string furColor;
        private bool isHungery;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
        }
    public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }
        public void Eat()
            {
            if(isHungery)
            {
                isHungery = false;
            }
            Console.WriteLine("Is the cat hungery?");
            }
    }
}
