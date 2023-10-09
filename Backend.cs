using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Backend : Developer
    {
        public Backend()
        {
            Console.Write("Enter SqlExperienceYear = ");
            int SqlExperienceYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Backend Developer's information was entered and created");
        }
        
    }
}
