using System;
using System.Windows.Forms;
using hw5.Entities;
using hw5.Views;

namespace hw5
{
    public partial class ExamForm : Form, IExamView
    {
        public event EventHandler ExamStarted;
        private int studentsNum = 0;

        public ExamForm()
        {
            InitializeComponent();
            startExamButton.Click += OnExamStarted;
            SetupListView();
        }

        private void SetupListView()
        {
            studentListView.Items.Clear();
            studentListView.Refresh();

            studentListView.Columns[0].Width = studentListView.Size.Width / 6;
            studentListView.Columns[2].Width = studentListView.Size.Width / 6;
            studentListView.Columns[1].Width = 
                studentListView.Size.Width
                - studentListView.Columns[0].Width
                - studentListView.Columns[2].Width;
        }

        public void SetMaxStudentNumber(int maxStudentNum)
        {
            studentsNum = maxStudentNum;
        }

        public void ShowMark(Student student, int number, int mark)
        {
            InvokeIfNeeded(studentListView, () => 
                studentListView.Items[(number - 1)].SubItems[2].Text = mark.ToString());
            InvokeIfNeeded(infoLabel, () => {
                infoLabel.Text = String.Format(
                    Properties.Resources.ShowProgress, number, studentsNum);
            });
        }

        public void ShowName(Student student, int number)
        {
            InvokeIfNeeded(studentListView, () => 
                studentListView.Items.Add(new ListViewItem(
                    new[] { number.ToString(), student.Name, " " })));
        }

        private void OnExamStarted(object sender, EventArgs e)
        {
            SetupListView();
            ExamStarted?.Invoke(this, e);
            InvokeIfNeeded(startExamButton, () => startExamButton.Enabled = false);
        }

        public void Finish()
        {
            InvokeIfNeeded(startExamButton, () => startExamButton.Enabled = true);
            InvokeIfNeeded(infoLabel, () => {
                infoLabel.Text = Properties.Resources.FinishExam;
            });
        }

        private static void InvokeIfNeeded(Control control, Action doit)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(doit);
            }
            else
            {
                doit();
            }
        }
    }
}
