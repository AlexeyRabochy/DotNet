using System;
using hw5.Entities;

namespace hw5.Views
{
    public interface IExamView
    {
        event EventHandler ExamStarted;
        void ShowName(Student student, int number);
        void ShowMark(Student student, int number, int mark);
        void SetMaxStudentNumber(int maxStudentNum);
        void Finish();
    }
}
