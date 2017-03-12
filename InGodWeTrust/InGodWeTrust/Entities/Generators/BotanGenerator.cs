using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InGodWeTrust.Entities.Generators
{
    internal class BotanGenerator : StudentGenerator
    {
        protected const double MinGPA = 3;
        protected const double MaxGPA = 5;
        public override Human CreateHuman(Gender sex)
        {
            return new Botan(GenerateName(sex), GenerateAge(MinStudentAge, MaxStudentAge), sex, GeneratePatronymic(GenerateName(Gender.Male), sex), GenerateGPA());
        }

        public override Human CreatePair(Human human)
        {
            var parent = human as CoolParent;
            if (parent == null) return null;
            var studentSex = GenerateSex();
            var studentName = GenerateName(studentSex);
            parent.AmountOfChildren++;
            return new Botan(studentName, GenerateAge(MinStudentAge, parent.Age - 18), studentSex, GeneratePatronymic(parent.Name, studentSex), GenerateGPA(parent));
        }

        protected double GenerateGPA()
        {
            return MinGPA + Random.NextDouble() * (MaxGPA - MinGPA);
        }

        protected double GenerateGPA(CoolParent coolParent)
        {
            return Math.Log(coolParent.AmountOfMoney, 10);
        }
    }
}
