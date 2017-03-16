using System;
using System.Drawing;
using System.Windows.Forms;
using FilmLibrary.CustomEventArgs;
using FilmLibrary.Model;

namespace FilmLibrary.Views
{
    internal partial class EditFilmView : Form
    {
        private char backSpace = (char)8;
        public event EventHandler EditFilmCompleted;
        private readonly FieldValidator.FieldValidator _validator = new FieldValidator.FieldValidator();
        public FilmViewModel EditedFilm { get; set; }

        public EditFilmView()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += Form_KeyDown;
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void InitTextBoxes()
        {
            ProducerTextBox.Text = EditedFilm.Producer;
            editYearTextBox.InternalTextBox.Text = EditedFilm.Year.ToString();
            FilmNameTextBox.Text = EditedFilm.Name;
        }

        #region EventsHandlers
        private void EditFilmViewLoad(object sender, EventArgs e)
        {
            if (sender == null || e == null) return;
            if (Owner != null)
                Location = new Point(Owner.Location.X + Owner.Width / 2 - Width / 2,
                    Owner.Location.Y + Owner.Height / 2 - Height / 2);
            InitTextBoxes();
        }

        private void SaveFilmButtonClick(object sender, EventArgs e)
        {
            if (sender == null || e == null) return;
            var isValid = ValidateForm();
            if (!isValid)
            {
                return;
            }

            var editedFilmDescriptor = new FilmEditDescriptor
            {
                Producer = ProducerTextBox.Text,
                Year = editYearTextBox.InternalTextBox.Text == string.Empty ? 0 : Convert.ToInt32(editYearTextBox.InternalTextBox.Text),
                Name = FilmNameTextBox.Text,
                FilmId = EditedFilm.Id
            };

            EditFilmCompleted?.Invoke(this, new FilmEditDescriptorEventArgs(editedFilmDescriptor));
            Close();
        }
        #endregion

        #region Validation
        private bool ValidateForm()
        {
            var isValid = true;
            if (!_validator.IsStringValid(FilmNameTextBox.Text, false))
            {
                EditFilmErrorProvider.SetError(FilmNameTextBox,
                    FilmNameTextBox.Text == "" ? "Name can't be empty." : "Wrong chars");
                FilmNameTextBox.Focus();
                isValid = false;
            }
            else
            {
                EditFilmErrorProvider.SetError(FilmNameTextBox, String.Empty);
            }

            if (!editYearTextBox.IsYearValid())
            {
                EditFilmErrorProvider.SetError(editYearTextBox, "Incorrect year");
                ProducerTextBox.Focus();
                isValid = false;
            }
            else
            {
                EditFilmErrorProvider.SetError(editYearTextBox, String.Empty);
            }

            if (!_validator.IsStringValid(ProducerTextBox.Text, false))
            {
                EditFilmErrorProvider.SetError(ProducerTextBox,
                    FilmNameTextBox.Text == "" ? "Name can't be empty." : "Wrong chars");
                ProducerTextBox.Focus();
                isValid = false;
            }
            else
            {
                EditFilmErrorProvider.SetError(ProducerTextBox, String.Empty);
            }
            return isValid;
        }
        #endregion
    }
}
