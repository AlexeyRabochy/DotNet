using System;

namespace hw5.Helpers
{
    public sealed class Randomizer
    {
        private static Random Rnd = new Random();
        private static readonly int millis = 100;//0;

        private static readonly string[] names = new string[]
        { "Анна", "Анастасия", "Алиса", "Ксения", "Татьяна",
          "Александр", "Олег", "Владимир", "Кирилл", "Федор" };

        internal static int GenerateRandomMark() => Rnd.Next(3) + 2;

        internal static int GenerateSleepingTime(int n) => Rnd.Next(n * millis);

        internal static int GenerateStudentsNumber() => Rnd.Next(29) + 1;

        internal static string GenerateStudentName() => names[Rnd.Next(names.Length)];
    }
}
