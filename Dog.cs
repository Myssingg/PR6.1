using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР6._1
{
    internal class Dog : IAnimal
    {
        private string _name;

        public Dog(string name)
        {
            this.Name = name;
        }

        public string Name 
        { 
            get { return _name; } 
            set { _name = value; } 
        }

        public string MakeSound()
        {
            return "Гав-гав!";
        }
        public string GetHabits()
        {
            return "Собаки очень крутые и любят есть людей (и детей)";
        }
    }
}
