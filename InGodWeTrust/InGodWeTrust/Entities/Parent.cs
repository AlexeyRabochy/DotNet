using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InGodWeTrust.Entities
{
    internal class Parent : Human
    {
        public int AmountOfChildren { get; set; }

        public Parent(string name, int age, Gender sex, int amountOfChildren) : base(name, age, sex)
        {
            AmountOfChildren = amountOfChildren;
        }

        public override string ToString()
        {
            return $"Parent, Name: {Name}, Age: {Age}, Sex: {Sex}, AmountOfChildren: {AmountOfChildren}";
        }

        public override ConsoleColor GetForegroundColor()
        {
            return ConsoleColor.DarkRed;
        }
    }
}
