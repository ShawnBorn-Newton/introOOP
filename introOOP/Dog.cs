 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introOOP
{
    class Dog
    {
        private string hairLength;
        private int hight;
        private int runSpeed;
        private int weight;

        public string HairLength
        {
            get { return this.hairLength; }
        }
        public int Hight
        {
            get { return this.hight; }
            set { this.hight = value; }
        }
        public int RunSpeed
        {
            get { return this.runSpeed; }
        }
        public void Potty()
        {
            if (weight > hight)
            {
                Console.WriteLine("TAKE THE DOG OUTSIDE!!");
            }
        }
           public Dog(string hairLength, int runSpeed, int weight)
        {
            this.hairLength = hairLength;
            this.runSpeed = runSpeed;
            this.runSpeed = weight;
        }
               
            public int RUN()
        {
            Console.WriteLine("GO GO DOGO!");
            //RunSpeed -= 1;
            return RunSpeed;
        }
           public void Bark()
        {
            Console.WriteLine("BORK BORK BORK!");
        }
        public void Cuddle()
        {
            Console.WriteLine("Awww Happy Doggo!");
        }
        
    }
}
