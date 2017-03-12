using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InGodWeTrust.Helpers;

namespace InGodWeTrust.Entities
{
    internal abstract class Human
    {
        public string Name { get; }
        public int Age { get; }
        public Gender Sex { get; }

        protected readonly ConsoleColor DefaultForegroundConsoleColor = ConsoleColor.Gray;

        protected Human(string name, int age, Gender sex)
        {
            Throw.IfNull(name, nameof(name));
            Throw.IfNull(sex, nameof(sex));
            Name = name;
            Age = age;
            Sex = sex;
        }

        public virtual void ToConsole()
        {
            Console.ForegroundColor = GetForegroundColor();
            Console.Write(this);
            Console.WriteLine(Environment.NewLine);
            Console.ForegroundColor = DefaultForegroundConsoleColor;
        }

        public virtual void ToConsoleAsPair()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = GetForegroundColor();
            Console.Write(this);
            Console.ForegroundColor = DefaultForegroundConsoleColor;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public abstract ConsoleColor GetForegroundColor();
    }
}
