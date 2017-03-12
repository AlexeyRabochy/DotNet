using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InGodWeTrust.Helpers;
using InGodWeTrust.Properties;
namespace InGodWeTrust
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(Resources.About);
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine(Resources.SundayGreeting);
            }
            else
            {
                Console.WriteLine(Resources.WorkDayGreeting);

                var god = new God();
                var humans = god.CreateHumans(ReadHumansAmount());
                var pairs = humans.ConvertAll(h =>
                {
                    var pair = god.CreatePair(h);
                    Throw.IfNull(pair, nameof(pair));
                    return pair;
                });

                humans.ForEach(h => h.ToConsole());

                var amount = pairs.Count;
                pairs.Reverse();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                for (var i = 0; i < amount; i++)
                {
                    pairs[i].ToConsoleAsPair();
                    Console.SetCursorPosition(0, Console.CursorTop - 2);
                }
                Console.SetCursorPosition(0, Console.CursorTop + 1 + 2 * amount);

                WriteMoneyToFile("total_money.txt", god.GetTotalMoney());
            }
            Console.WriteLine(Resources.Exit);
            Console.ReadLine();
        }

        private static int ReadHumansAmount()
        {
            int humansAmount;
            Console.WriteLine(Resources.HumansAmountInput);
            int.TryParse(Console.ReadLine(), out humansAmount);
            while (humansAmount < 1)
            {
                Console.WriteLine(Resources.IncorrectHumansAmount);
                int.TryParse(Console.ReadLine(), out humansAmount);
            }
            return humansAmount;
        }
        private static void WriteMoneyToFile(string filename, double money)
        {
            File.WriteAllText(filename, string.Format(Resources.MoneyFormat, money));
        }
    }
}
