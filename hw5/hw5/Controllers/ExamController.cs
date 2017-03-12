using System;
using System.Threading;
using hw5.Entities;
using hw5.Helpers;
using hw5.Views;

namespace hw5.Controllers
{
    public sealed class ExamController
    {
        private Deanery deanery;
        private int studentsNum;
        private IExamView view;

        public ExamController(IExamView view)
        {
            deanery = new Deanery(this);
            this.view = view;
            view.ExamStarted += OnExamStarted;
        }

        public void OnStudentReady(Student student, int studentNum)
        {
            view.ShowName(student, studentNum);
        }

        public void OnMarkSet(Student student, int studentNum, int mark)
        {
            view.ShowMark(student, studentNum, mark);
            if (studentsNum <= studentNum)
            {
                OnExamFinished();
            }
        }

        public void OnExamFinished()
        {
            view.Finish();
        }

        public void OnExamStarted(object sender, EventArgs e)
        {
            studentsNum = Randomizer.GenerateStudentsNumber();
            view.SetMaxStudentNumber(studentsNum);
            for (int i = 0; i < studentsNum; ++i)
            {
                new Thread(new Student(deanery).TryPass).Start();
            }
            deanery.StartExam();
        }
    }
}
