using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace EventManagementApp
{
    /// <summary>
    /// класс событий 
    /// </summary>

    /// <summary>
    /// класс главной формы
    /// </summary>
    public partial class MainForm : Form
    {

        /// <summary>
        /// класс работы с БД
        /// </summary>
        private readonly ApplicationDbContext _context;
        public MainForm()
        {
            InitializeComponent();
            //this.BackgroundImageLayout = ImageLayout.Stretch;
            _context = new ApplicationDbContext();
            PopulateEventList();   
            
            buttonSort.Click += buttonSort_Click;// Привязка обработчика события для кнопки сортировки
            listBoxEvents.SelectedIndexChanged += listBoxEvents_SelectedIndexChanged;
            btnEdit.Enabled = false;//кнопка редактирование не работает
        }
        public void EventDelete(Event _event)
        {
            if (_event != null)
            {
                _context.Events.Remove(_event);
                _context.SaveChanges();
                RefreshListBox();
            }
        }

        private void PopulateEventList()
        {
            var events = _context.Events.ToList();
            foreach (Event e in events) { listBoxEvents.Items.Add(e); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedEvent = listBoxEvents.SelectedItem as Event;

            EventDelete(selectedEvent);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EventDetailsForm newForm = new EventDetailsForm(this, listBoxEvents.SelectedItem as Event);
            newForm.Show();
        }

        public void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedIndex != -1)
            {
                var selectedItem = listBoxEvents.SelectedItem;
                if (selectedItem is Event selectedEvent)
                {
                    labelTitle.Text = selectedEvent.title;
                    labelDate.Text = selectedEvent.date.ToString("dd.MM.yyyy");
                    labelPlace.Text = selectedEvent.place;
                    labelDescription.Text = selectedEvent.description;
                    labelParticipants.Text = string.Join(", ", selectedEvent.participants);
                }
                btnEdit.Enabled = true;//кнопка редактирование работает если что тоо выбрано
            }
            else
            {
                btnEdit.Enabled = false;//кнопка редактирование не работает если ничего не выбрано
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
        private void btnAddEvent_Click_1(object sender, EventArgs e)
        {
            EventDetailsForm newForm = new EventDetailsForm(this, null);
            newForm.Show();
        }
        private void PopulateEventList(bool sortByDate = false) //сортирует если передается тру , по умолчанию фалс добавляет событие без сортировки 
        {
            var events = sortByDate
                ? _context.Events.OrderBy(e => e.date).ToList()
                : _context.Events.ToList();

            listBoxEvents.Items.Clear();//очищает сначала весь листбокс
            foreach (var eventItem in events)
            {
                listBoxEvents.Items.Add(eventItem);//добавялет как надо
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            PopulateEventList(sortByDate: true);//сортирует
            MessageBox.Show("Сортировка по дате выполнена");
        }
    }
}