using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InGodWeTrust.Entities
{
    internal class CoolParent : Parent
    {
        public double AmountOfMoney { get; }

        public CoolParent(string name, int age, Gender sex, int amountOfChildren, double amountOfMoney) : base(name, age, sex, amountOfChildren)
        {
            AmountOfMoney = amountOfMoney;
        }

        public override string ToString()
        {
            return GetBasePart() + GetAmountOfMoneyPart();
        }

        private string GetBasePart()
        {
            return $"CoolParent, Name: {Name}, Age: {Age}, Sex: {Sex}, AmountOfChildren: {AmountOfChildren}, ";
        }

        private string GetAmountOfMoneyPart()
        {
            return $"AmountOfMoney: {AmountOfMoney:C}";
        }

        public override ConsoleColor GetForegroundColor()
        {
            return ConsoleColor.Red;
        }

        public override void ToConsole()
        {
            Console.ForegroundColor = GetForegroundColor();

            Console.Write(GetBasePart());
            PrintMoneyToConsole(GetAmountOfMoneyPart());

            Console.WriteLine(Environment.NewLine);
            Console.ForegroundColor = DefaultForegroundConsoleColor;
        }

        public override void ToConsoleAsPair()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = GetForegroundColor();

            Console.Write(GetBasePart());
            PrintMoneyToConsole(GetAmountOfMoneyPart());

            Console.ForegroundColor = DefaultForegroundConsoleColor;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        private static void PrintMoneyToConsole(string amountOfMoney)
        {
            var prevColor = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(amountOfMoney);
            Console.BackgroundColor = prevColor;
        }
    }
}
