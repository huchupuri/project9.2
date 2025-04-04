using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using static EventManagementApp.MainForm;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using WinFormsApp1.classes;

namespace EventManagementApp
{
    public partial class MainForm : Form
    {
        private readonly ApplicationDbContext _context;
        public MainForm()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            PopulateEventList();

        }
        public class ApplicationDbContext : DbContext
        {
            public DbSet<Event> Events { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                // Получение строки подключения из appsettings.json или App.config
                var connectionString = "Host=localhost;Port=2006;Database=postgres;Username=postgres;Password=351025846;";
                optionsBuilder.UseNpgsql(connectionString);
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                // Настройка схемы (если необходимо)
                modelBuilder.Entity<Event>().ToTable("events", "public");
            }
        }
        public class Event
        {
            public int id { get; set; }
            public string title { get; set; }
            public DateTime date { get; set; }

            public string place { get; set; }

            public string description { get; set; }

            public string participants { get; set; }
        }
        private void PopulateEventList()
        {
            try
            {
                var events = _context.Events.ToList();
                foreach (Event e in events) { listBoxEvents.Items.Add(e); }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            EventDetailsForm newForm = new EventDetailsForm(this);
            newForm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete functionality would be implemented here.");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit functionality would be implemented here.");
        }

        public void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedIndex != -1)
            {
                var selectedItem = listBoxEvents.SelectedItem;

                // Если выбран элемент типа Event
                if (selectedItem is Event selectedEvent)
                {
                    textBoxTitle.Text = selectedEvent.title;
                    txtBoxDate.Text = selectedEvent.date.ToString("dd.MM.yyyy"); // Форматируем дату
                    txtBoxPlace.Text = selectedEvent.place;
                    txtDescription.Text = selectedEvent.description;
                    txtParticipants.Text = string.Join(", ", selectedEvent.participants); // Объединяем участников в строку
                }
            }
        }
        public void RefreshListBox()
        {
            listBoxEvents.Items.Clear();
            var events = _context.Events.ToList();
            foreach (var eventItem in events)
            {
                listBoxEvents.Items.Add(eventItem);
            }
        }
        private void txtParticipants_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtParticipants.Text))
            {
                txtParticipants.Text = "УЧАСТНИКИ";
            }
        }

        private void panelLeftSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddEvent_Click_1(object sender, EventArgs e)
        {
            EventDetailsForm newForm = new EventDetailsForm(this);
            newForm.Show();
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTitle.Text))
            {
                textBoxTitle.Text = "ЗАГОЛОВОК";
            }
        }

        private void txtBoxDate_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxDate.Text))
            {
                txtBoxDate.Text = "ДАТА";
            }
        }

        private void txtBoxPlace_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxPlace.Text))
            {
                txtBoxPlace.Text = "МЕСТО";
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                txtDescription.Text = "ОПИСАНИЕ";
            }
        }
    }
}