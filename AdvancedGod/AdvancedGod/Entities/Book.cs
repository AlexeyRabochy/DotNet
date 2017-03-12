using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedGod.Helpers;

namespace AdvancedGod.Entities
{
    public class Book : IHasName
    {
        public string Name { get; }

        public Book(string name)
        {
            Throw.IfNull(name, nameof(name));
            Name = name;
        }

        public override string ToString()
        {
            return $"Book: Name: {Name}";
        }

        public void ToConsole()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(this);
            Console.Write(Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
