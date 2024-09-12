using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Core.OOP.Constructor_Polymorphism.Polymorphism;

namespace C__Core.OOP.Constructor_Polymorphism.Polymorphism.Outfits
{
    public class TShirt : IOutfit
    {
        public void Wear()
        {
            Console.WriteLine("She is wearing T-Shirt");
        }
    }
}
