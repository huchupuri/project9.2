using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using static EventManagementApp.MainForm;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
        private void LoadData()
        {
            try
            {
                // �������� ������ �� ���� ������
                var events = _context.Events.ToList();

                // �������� ������ � DataGridView
                dataGridView1.DataSource = events;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������: {ex.Message}");
            }   
        }
        public class ApplicationDbContext : DbContext
        {
            public DbSet<Event> Events { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                // ��������� ������ ����������� �� appsettings.json ��� App.config
                var connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=2343;";
                optionsBuilder.UseNpgsql(connectionString);
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                // ��������� ����� (���� ����������)
                modelBuilder.Entity<Event>().ToTable("Events", "public");
            }
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
                MessageBox.Show($"������: {ex.Message}");
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

                // ���� ������ ������� ���� Event
                if (selectedItem is Event selectedEvent)
                {
                    txtTitle.Text = selectedEvent.Title;
                    txtDate.Text = selectedEvent.Date.ToString("dd.MM.yyyy"); // ����������� ����
                    txtLocation.Text = selectedEvent.Place;
                    txtDescription.Text = selectedEvent.Description;
                    txtParticipants.Text = string.Join(", ", selectedEvent.Participants); // ���������� ���������� � ������
                }
            }
        }
        public void RefreshListBox()
        {
            listBoxEvents.Items.Clear(); 

            // ��������� ������ �� ����
            var events = _context.Events.ToList();

            // ��������� �� � ListBox
            foreach (var eventItem in events)
            {
                listBoxEvents.Items.Add(eventItem);
            }
        }

        public class Event
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public DateTime Date { get; set; }

            public string Place { get; set; }

            public string Description { get; set; }

            public List<string> Participants { get; set; } = new List<string>();
        }

        private void txtParticipants_TextChanged(object sender, EventArgs e)
        {

        }
    }
}