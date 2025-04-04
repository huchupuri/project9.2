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
                title = txtTitle.Text,
                date = date,
                place = "asd",
                description = "Описание события",
                participants = "asd"
            };

            newFormContext.Events.Add(newEvent);
            newFormContext.SaveChanges();
            this.Close();
            _mainForm.RefreshListBox();
        }

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            if (txtTitle.Text == "ЗАГОЛОВОК")
            {
                txtTitle.Text = string.Empty;
            }
        }

        private void txtTitle_Leave(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                txtTitle.Text = "ЗАГОЛОВОК";
            }
        }

        private void txtLocation_Enter(object sender, EventArgs e)
        {
            if (txtTitle.Text == "МЕСТО")
            {
                txtTitle.Text = string.Empty;
            }
        }

        private void txtLocation_Leave(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                txtTitle.Text = "МЕСТО";
            }
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            if (txtTitle.Text == "ОПИСАНИЕ")
            {
                txtTitle.Text = string.Empty;
            }
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                txtTitle.Text = "ОПИСАНИЕ";
            }
        }
    }
}