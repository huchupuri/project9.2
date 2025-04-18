﻿

using Microsoft.Extensions.Logging;
using WinFormsApp1.classes;

namespace EventManagementApp
{
    /// <summary>
    /// формы экрана добавления
    /// </summary>
    public partial class EventDetailsForm : Form
    {
        private readonly ApplicationDbContext newFormContext;
        private MainForm _mainForm;
        private Event _event;
        public EventDetailsForm(MainForm mainForm, Event Event1)
        {
            InitializeComponent();
            newFormContext = new ApplicationDbContext();
            _mainForm = mainForm;
            Shown += _mainForm!.FormOpened!;
            FormClosed += _mainForm.FormClosed!;
            _event = Event1;
            if (_event != null)
            {
                txtTitle.Text = _event.title;
                txtDescription.Text = _event.description;
                txtLocation.Text = _event.place;
                foreach (var partiItem in _event.participants.Split(", "))
                {
                    listBoxParticipants.Items.Add(partiItem);
                }
                dtpDate.Value = _event.date;
            }
            else
            {
                txtTitle.PlaceholderText = "ЗАГОЛОВОК";
                txtLocation.PlaceholderText = "МЕСТО";
                txtDescription.PlaceholderText = "ОПИСАНИЕ";
            }
        }
        /// <summary>
        /// добавление участника
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        public void AddParti(string name, string surname)
        {
            listBoxParticipants.Items.Add($"{name} {surname}");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dtpDate.Value;
                if (date.Kind == DateTimeKind.Unspecified)
                {
                    date = DateTime.SpecifyKind(date, DateTimeKind.Utc);
                }
                if (_event == null)
                {

                    var newEvent = new Event
                    {
                        title = txtTitle.Text.Length == 0 ? "ЗАГОЛОВОК" : txtTitle.Text,
                        date = date,
                        place = txtLocation.Text.Length == 0 ? "МЕСТО" : txtLocation.Text,
                        description = txtDescription.Text,
                        participants = string.Join(", ", listBoxParticipants.Items.Cast<string>()).Length == 0 ? "УЧАСТНИКИ" : string.Join(", ", listBoxParticipants.Items.Cast<string>())
                    };
                    newFormContext.Events.Add(newEvent);
                }
                else
                {
                    _mainForm.EventDelete(_event);
                    var NewEvent = new Event();
                    NewEvent.title = txtTitle.Text.Length == 0 ? "ЗАГОЛОВОК" : txtTitle.Text;
                    NewEvent.date = date;
                    NewEvent.place = txtLocation.Text;
                    NewEvent.description = txtDescription.Text;
                    NewEvent.participants = string.Join(", ", listBoxParticipants.Items.Cast<string>());
                    newFormContext.Events.Add(NewEvent);
                }
                
                newFormContext.SaveChanges();
                this.Close();
                _mainForm.Show();
                MessageBox.Show("Все успешно сохранено");
                _mainForm.RefreshListBox();
                _mainForm.SelectLastEvent();
            }
            catch (EventValidationException ex)
            {
                MessageBox.Show($"Ошибка валидации: {ex.Message}");
            }
        }

        private void txtTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string currentText = txtTitle.Text;
                e.SuppressKeyPress = true;
                e.Handled = true;
                MessageBox.Show("Нельзя использовать перенос в заголовке");
                txtTitle.Text = currentText;
                txtTitle.SelectionStart = txtTitle.Text.Length;
                txtTitle.SelectionLength = 0; 
                txtTitle.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newUser = new NewUser(this);
            newUser.Show();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxParticipants.SelectedIndex != -1)
            {
                listBoxParticipants.Items.RemoveAt(listBoxParticipants.SelectedIndex);
            }
            else
            {
                MessageBox.Show("участник не выбран");
            }
        }
    }
}