using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using static EventManagementApp.MainForm;

namespace EventManagementApp
{
    public partial class EventDetailsForm : Form
    {
        private readonly ApplicationDbContext newFormContext;
        private MainForm _mainForm;
        public EventDetailsForm(MainForm mainForm)
        {
            InitializeComponent();
            newFormContext = new ApplicationDbContext();
            _mainForm = mainForm;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime date = dtpDate.Value;

            if (date.Kind == DateTimeKind.Unspecified)
            {
                date = DateTime.SpecifyKind(date, DateTimeKind.Utc);
            }
            var newEvent = new Event
            {
                Title = txtTitle.Text,
                Date = date,
                Place = "asd",
                Description = "Описание события",
                Participants = new List<string> { "Участник 1", "Участник 2" }
            };
            _mainForm.RefreshListBox();
            newFormContext.Events.Add(newEvent);
            newFormContext.SaveChanges();
        }
    }
}