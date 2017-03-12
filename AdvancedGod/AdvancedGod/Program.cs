using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedGod.Entities;
using AdvancedGod.Entities.Generators;
using AdvancedGod.Properties;

namespace AdvancedGod
{
    internal class Program
    {
        private static bool IsContinueKey(ConsoleKey key) => key == ConsoleKey.Enter;
        private static bool IsInterruptKey(ConsoleKey key) => key == ConsoleKey.Q || key == ConsoleKey.F10;
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(Resources.About);
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine(Resources.SundayGreeting);
                return;
            }

            Console.WriteLine(Resources.WorkDayGreeting);
            Console.WriteLine(Resources.HowToUse);

            var entitiesGenerator = new EntitiesGenerator();
            ConsoleKey pressedKey;
            do
            {
                Human parent = entitiesGenerator.CreateRandomHuman();
                Human anotherParent = entitiesGenerator.CreateRandomHuman();
                parent.ToConsole();
                anotherParent.ToConsole();
                try
                {
                    IHasName child = entitiesGenerator.Couple(parent, anotherParent);
                    if (child == null) Console.WriteLine(Resources.FailedCoupleCreation);
                    else child.ToConsole();
                }
                catch (SameSexException exception)
                {
                    Console.WriteLine(exception.Message);
                }
                Console.WriteLine();
                pressedKey = ReadControlKey();
            } while (!IsInterruptKey(pressedKey));
        }

        private static ConsoleKey ReadControlKey()
        {
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
            } while (!(IsContinueKey(key) || IsInterruptKey(key)));
            return key;
        }
    }
}
