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
            Cat secondCat = new Cat("Oz", 3, "Orange and white");
            secondCat.Name = "Ozzy";
            Console.WriteLine(secondCat.Name);
            Console.WriteLine(secondCat.Age);
            secondCat.Eat();
        }
    }
}
