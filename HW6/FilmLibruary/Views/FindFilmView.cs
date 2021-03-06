﻿using System;
using System.Drawing;
using System.Windows.Forms;
using FilmLibrary.CustomEventArgs;
using FilmLibrary.Model;

namespace FilmLibrary.Views
{
    internal sealed partial class FindFilmView : Form
    {
        private readonly FieldValidator.FieldValidator _validator = new FieldValidator.FieldValidator();
        public event EventHandler SearchDescriptorCompleted;

        public FindFilmView()
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

        private void FindButtonClick(object sender, EventArgs e)
        {
            var isValidForm = ValidateForm();
            if (!isValidForm)
            {
                return;
            }
            var searchDescriptor = MakeSearchDescriptor();

            SearchDescriptorCompleted?.Invoke(this, new SearchDescriptorEventArgs(searchDescriptor));
        }

        private void FindFilmViewLoad(object sender, EventArgs e)
        {
            if (Owner != null)
                Location = new Point(Owner.Location.X + Owner.Width / 2 - Width / 2,
                    Owner.Location.Y + Owner.Height / 2 - Height / 2);
        }

        private bool ValidateForm()
        {
            var isValid = true;
            if (!_validator.IsStringValid(FilmNameTextBox.Text, true))
            {
                FindErrorProvider.SetError(FilmNameTextBox, "String must be russian and not contains special simbols");
                FilmNameTextBox.Focus();
                isValid = false;
            }
            if (!YearFromTextBox.IsYearValid())
            {
                isValid = false;
            }
            if (!YearToTextBox.IsYearValid())
            {
                isValid = false;
            }
            if (!_validator.IsStringValid(CountryTextBox.Text, true))
            {
                FindErrorProvider.SetError(CountryTextBox, "String must be russian and not contains special simbols");
                CountryTextBox.Focus();
                isValid = false;
            }
            if (!_validator.IsStringValid(ProducerTextBox.Text, true))
            {
                ProducerTextBox.Focus();
                FindErrorProvider.SetError(ProducerTextBox, "String must be russian and not contains special simbols");
                isValid = false;
            }
            if (!_validator.IsStringValid(MainActorsTextBox.Text, true))
            {
                FindErrorProvider.SetError(MainActorsTextBox, "String must be russian and not contains special simbols");
                MainActorsTextBox.Focus();
                isValid = false;
            }
            else
            {
                FindErrorProvider.SetError(FilmNameTextBox, string.Empty);
            }
            return isValid;
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            FilmNameTextBox.Text = string.Empty;
            YearFromTextBox.Text = string.Empty;
            YearToTextBox.Text = string.Empty;
            CountryTextBox.Text = string.Empty;
            ProducerTextBox.Text = string.Empty;
            MainActorsTextBox.Text = string.Empty;
        }

        private SearchDescriptor MakeSearchDescriptor()
        {
            var filmName = FilmNameTextBox.Text.ToLower();
            var yearFrom = YearFromTextBox.InternalTextBox.Text != string.Empty ? Convert.ToInt32(YearFromTextBox.InternalTextBox.Text) : SearchDescriptor.MinYear;
            var yearTo = YearToTextBox.InternalTextBox.Text != string.Empty ? Convert.ToInt32(YearToTextBox.InternalTextBox.Text) : SearchDescriptor.MaxYear;
            var country = CountryTextBox.Text.ToLower();
            var producer = ProducerTextBox.Text.ToLower();
            var mainActors = MainActorsTextBox.Text.ToLower();

            var searchDescriptor = new SearchDescriptor()
            {
                FilmName = filmName,
                YearFrom = yearFrom,
                YearTo = yearTo,
                Country = country,
                Producer = producer,
                MainActors = mainActors
            };

            return searchDescriptor;
        }
    }
}
