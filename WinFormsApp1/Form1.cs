

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
        public void AddParti(string name, string surname)
        {
            listBoxParticipants.Items.Add($"{name} {surname}");
        }
        private void btnSave_Click(object sender, EventArgs e)
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
                    title = txtTitle.Text.Length == 0 ? "ЗАГЛОВОК" : txtTitle.Text,
                    date = date,
                    place = txtLocation.Text.Length == 0 ? "ЗАГЛОВОК" : txtTitle.Text,
                    description = txtDescription.Text,
                    participants = string.Join(", ", listBoxParticipants.Items.Cast<string>())
                };
                newFormContext.Events.Add(newEvent);
            }
            else
            {
                _mainForm.EventDelete(_event);
                var NewEvent = new Event();
                NewEvent.title = txtTitle.Text.Length == 0 ? "ЗАГJKJОК" : txtTitle.Text;
                NewEvent.date = date;
                NewEvent.place = txtLocation.Text;
                NewEvent.description = txtDescription.Text;
                NewEvent.participants = string.Join(", ", listBoxParticipants.Items.Cast<string>());
                newFormContext.Events.Add(NewEvent);
            }

            newFormContext.SaveChanges();
            this.Close();
            MessageBox.Show("Все успешно сохранено");
            _mainForm.RefreshListBox();
        }

        private void txtTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                MessageBox.Show("Нельзя использовать перенос в заголовке");
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