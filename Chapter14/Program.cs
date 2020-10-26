using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    class Program
    {
        static void Main(string[] args)
        {
            var pets = new List<Object>();


            pets.Add(new FoodiePet("エイミー"));
            pets.Add(new FoodiePet("クー"));
            pets.Add(new FoodiePet("ライアン"));

            foreach (IVirtualPet pet in pets)
            {
                pet.Eat();
                pet.Sleep();
                pet.Rest();
                Console.WriteLine($"{pet.Name} 機嫌:{pet.Mood} エネルギー:{pet.Energy}");
            }
        }
    }
}
