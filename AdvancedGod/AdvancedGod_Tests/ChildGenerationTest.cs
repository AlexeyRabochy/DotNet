using System;
using System.Diagnostics.CodeAnalysis;
using AdvancedGod.Entities;
using AdvancedGod.Entities.Generators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdvancedGod_Tests 
{
    [TestClass]
    public class ChildGenerationTest
    {
        private readonly EntitiesGenerator _entitiesGenerator;
        public ChildGenerationTest()
        {
            this._entitiesGenerator = new EntitiesGenerator(d => true);
        }
        [TestMethod]
        public void TestStudentGirlCouple()
        {
            CheckCoupleChild(GenerateStudent(), GenerateGirl(), typeof(Girl), _childPatronymic);
        }
        [TestMethod]
        public void TestGirlStudentCouple()
        {
            CheckCoupleChild(GenerateGirl(), GenerateStudent(), typeof(Girl), _childPatronymic);
        }
        [TestMethod]
        public void TestStudentPrettyGirlCouple()
        {
            CheckCoupleChild(GenerateStudent(), GeneratePrettyGirl(), typeof(PrettyGirl), _childPatronymic);
        }
        [TestMethod]
        public void TestPrettyGirlStudentCouple()
        {
            CheckCoupleChild(GeneratePrettyGirl(), GenerateStudent(), typeof(PrettyGirl), _childPatronymic);
        }
        [TestMethod]
        public void TestStudentSmartGirlCouple()
        {
            CheckCoupleChild(GenerateStudent(), GenerateSmartGirl(), typeof(Girl), _childPatronymic);
        }
        [TestMethod]
        public void TestSmartGirlStudentCouple()
        {
            CheckCoupleChild(GenerateSmartGirl(), GenerateStudent(), typeof(Girl), _childPatronymic);
        }
        [TestMethod]
        public void TestBotanGirlCouple()
        {
            CheckCoupleChild(GenerateBotan(), GenerateGirl(), typeof(SmartGirl), _childPatronymic);
        }
        [TestMethod]
        public void TestGirlBotanCouple()
        {
            CheckCoupleChild(GenerateGirl(), GenerateBotan(), typeof(SmartGirl), _childPatronymic);
        }
        [TestMethod]
        public void TestBotanPrettyGirlCouple()
        {
            CheckCoupleChild(GenerateBotan(), GeneratePrettyGirl(), typeof(PrettyGirl), _childPatronymic);
        }
        [TestMethod]
        public void TestPrettyGirlBotanCouple()
        {
            CheckCoupleChild(GeneratePrettyGirl(), GenerateBotan(), typeof(PrettyGirl), _childPatronymic);
        }
        [TestMethod]
        public void TestBotanSmartGirlCouple()
        {
            CheckCoupleChild(GenerateBotan(), GenerateSmartGirl(), typeof(Book), null);
        }
        [TestMethod]
        public void TestSmartGirlBotanCouple()
        {
            CheckCoupleChild(GenerateSmartGirl(), GenerateBotan(), typeof(Book), null);
        }

        private void CheckCoupleChild(Human parent, Human anotherParent, Type expectedChildType, string expectedChildPatronymic)
        {
            var child = _entitiesGenerator.Couple(parent, anotherParent);
            Assert.AreEqual(expectedChildType, child.GetType());
            var humanChild = child as Human;
            Assert.AreEqual(expectedChildPatronymic, humanChild?.Patronymic);
        }

        private static Student GenerateStudent() => new Student("Петр", 25, "Петрович");
        private static Botan GenerateBotan() => new Botan("Петр", 25, "Петрович");
        private static Girl GenerateGirl() => new Girl("Василиса", 22, "Андреевна");
        private static Girl GeneratePrettyGirl() => new PrettyGirl("Василиса", 22, "Андреевна");
        private static Girl GenerateSmartGirl() => new SmartGirl("Василиса", 22, "Андреевна");

        private readonly string _childPatronymic = "Петровна";
    }
}
