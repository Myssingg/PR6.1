using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР6._1
{
    internal class Cat : IAnimal
    {
        private string _name;

        public Cat(string name)
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
            return "Мяу!";
        }
        public string GetHabits()
        {
            return "Кошки любят охотиться, кушать и играть.";
        }
    }
}
