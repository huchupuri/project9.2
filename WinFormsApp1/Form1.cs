

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
                txtParticipants.Text = _event.participants;
                dtpDate.Value = _event.date;
            }
            else
            {
                txtTitle.PlaceholderText = "ЗАГОЛОВОК";
                txtLocation.PlaceholderText = "МЕСТО";
                txtParticipants.PlaceholderText = "УЧАСТНИКИ";
                txtDescription.PlaceholderText = "ОПИСАНИЕ";
            }
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
                    title = txtTitle.Text,
                    date = date,
                    place = txtLocation.Text,
                    description = txtDescription.Text,
                    participants = txtParticipants.Text
                };
                newFormContext.Events.Add(newEvent);
            }
            else
            {
                _mainForm.EventDelete(_event);
                var NewEvent = new Event();
                NewEvent.title = txtTitle.Text;
                NewEvent.date = date;
                NewEvent.place = txtLocation.Text;
                NewEvent.description = txtDescription.Text;
                NewEvent.participants = txtParticipants.Text;
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
    }
}