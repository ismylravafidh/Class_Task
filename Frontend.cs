using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Frontend : Developer
    {
        public Frontend()
        {
            Console.Write("Enter ReactExperienceYear= ");
            int ReactExperienceYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Frontend Developer's information was entered and created");
        }
    }
}
