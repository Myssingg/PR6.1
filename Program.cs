using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ПР6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Введите имя собаки: ");
            string dogName = Console.ReadLine();

            Console.Write("\nВведите имя кошки: ");
            string catName = Console.ReadLine();

            Cat cat = new Cat(catName);
            Dog dog = new Dog(dogName);

            Console.WriteLine("\nСобака " + dog.Name + " говорит " + dog.MakeSound() + "\n" + dog.GetHabits());
            Console.WriteLine("\nКошка " + cat.Name + " говорит " + cat.MakeSound() + "\n" + cat.GetHabits());

            Console.Read();
        }
    }
}
