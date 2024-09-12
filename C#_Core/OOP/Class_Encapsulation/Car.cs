using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPresent
{
    public class Car
    {

        public string Brand;
        public string Model;

        public void StartEngine()
        {
            Console.WriteLine("Engine started!");
        }
        public void EndEngine()
        {
            Console.WriteLine("Engine ended!");
        }
    }
}
