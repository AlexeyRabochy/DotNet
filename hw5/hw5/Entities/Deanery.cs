using System;
using System.Threading;
using hw5.Helpers;
using hw5.Controllers;

namespace hw5.Entities
{
    public sealed class Deanery
    {
        public ManualResetEvent ExamStartedEvent = new ManualResetEvent(false);
        private const int maxSleepingTime = 3;
        private int currentStudentNum = 0;
        private readonly object syncLock = new object();
        private ExamController controller;

        public Deanery(ExamController controller)
        {
            this.controller = controller;
        }

        public void StartExam()
        {
            currentStudentNum = 0;
            ExamStartedEvent.Set();
        }

        public void Evaluate(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException();
            }
            lock (syncLock)
            {
                controller.OnStudentReady(student, ++currentStudentNum);
                Thread.Sleep(Randomizer.GenerateSleepingTime(maxSleepingTime));
                controller.OnMarkSet(student, currentStudentNum, Randomizer.GenerateRandomMark());
            }
        }
    }
}
