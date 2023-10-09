using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Developer
    {
        public Developer()
        {
            Console.Write("Enter Name = ");
            string Name = Console.ReadLine();
            Console.Write("Enter Surname = ");
            string Surname = Console.ReadLine();
            Console.Write("Enter Age = ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Experience = ");
            int Experience = Convert.ToInt32(Console.ReadLine());
        }
        
    }
}
