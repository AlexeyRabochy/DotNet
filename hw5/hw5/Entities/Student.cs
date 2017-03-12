using System;
using System.Threading;
using hw5.Helpers;

namespace hw5.Entities
{
    public sealed class Student
    {
        private readonly Deanery deanery;
        public string Name { get;  }
        private readonly int maxSleepingTime = 10;

        public Student(Deanery deanery)
        {
            if (deanery == null)
            {
                throw new ArgumentNullException();
            }
            this.deanery = deanery;
            Name = Randomizer.GenerateStudentName();
        }

        public void TryPass()
        {
            deanery.ExamStartedEvent.WaitOne();
            Thread.Sleep(Randomizer.GenerateSleepingTime(maxSleepingTime));
            deanery.Evaluate(this);
        }
    }
}
