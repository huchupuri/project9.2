using Microsoft.EntityFrameworkCore;
using MongoDB.Driver.Core.Configuration;
using OfficeOpenXml;
using System.Data;
using WinFormsApp1.classes;


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
            _context = new ApplicationDbContext();
            PopulateEventList();
            listBoxEvents.SelectedIndexChanged += listBoxEvents_SelectedIndexChanged;
            listBoxParticipants.Enabled = false;
            btnEdit.Enabled = false;//кнопка редактирование не работает
            btnDelete.Enabled = false;
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
        public void FormOpened(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnAddEvent.Enabled = false;
        }
        public void FormClosed(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            btnAddEvent.Enabled = true;
        }

        private void PopulateEventList()
        {
            var events = _context.Events.ToList();
            foreach (Event e in events) { listBoxEvents.Items.Add(e); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedEvent = listBoxEvents.SelectedItem as Event;

            DialogResult result = MessageBox.Show(
            "Вы уверены, что хотите удалить это событие?",
            "Подтверждение удаления",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            EventDelete(selectedEvent);
            if (listBoxEvents.Items.Count > 0)
            {
                listBoxEvents.SelectedIndex = 0;
                listBoxEvents_SelectedIndexChanged(listBoxEvents, EventArgs.Empty);
            }
            else
            {
                labelPlace.Text = "МЕСТО";
                labelDescription.Text = "ОПИСАНИЕ";
                labelTitle.Text = "ЗАГОЛОВОК";
                labelDate.Text = "ДАТА";
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedIndex == -1)
            {
                listBoxEvents.SelectedIndex = 0;
                listBoxEvents_SelectedIndexChanged(listBoxEvents, EventArgs.Empty);
            }
            else
            {
                EventDetailsForm newForm = new EventDetailsForm(this, listBoxEvents.SelectedItem as Event);

                newForm.Show();
            }
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
                    listBoxParticipants.Items.Clear();
                    foreach (var participant in selectedEvent.participants.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        listBoxParticipants.Items.Add(participant);
                    }
                }
                btnEdit.Enabled = true;//кнопка редактирование работает если что то выбрано
                btnDelete.Enabled = true;
                listBoxParticipants.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;//кнопка редактирование не работает если ничего не выбрано
                btnDelete.Enabled = false;
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
        public void SelectLastEvent()
        {
            if (listBoxEvents.Items.Count > 0)
            {
                listBoxEvents.SelectedIndex = listBoxEvents.Items.Count - 1;
            }
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            PopulateEventList(sortByDate: true);//сортирует
            MessageBox.Show("Сортировка по дате выполнена");
        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            using (var excelPackage = new ExcelPackage())
            {
                var tablica = excelPackage.Workbook.Worksheets.Add("События");//создание листа в экселе
                string[] headers = { "Заголовок", "Дата", "Место", "Описание", "Участники" };

                for (int col = 0; col < headers.Length; col++) //делаем шапочку
                {
                    tablica.Cells[1, col + 1].Value = headers[col];
                }

                int rowIn = 2; //вторая строчка начало тк первая это шапочка
                foreach (var item in listBoxEvents.Items)
                {
                    if (item is Event eventItem)
                    {
                        tablica.Cells[rowIn, 1].Value = eventItem.title;
                        tablica.Cells[rowIn, 2].Value = eventItem.date.ToString("dd.MM.yyyy");
                        tablica.Cells[rowIn, 3].Value = eventItem.place;
                        tablica.Cells[rowIn, 4].Value = eventItem.description;
                        tablica.Cells[rowIn, 5].Value = eventItem.participants;

                        rowIn++; // Переходим к следующей строке
                    }
                }
                tablica.Cells[tablica.Dimension.Address].AutoFitColumns();
                using (var saveDialog = new SaveFileDialog())
                {
                    saveDialog.FileName = $"Отчет.xlsx";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        excelPackage.SaveAs(new FileInfo(saveDialog.FileName));
                    }
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxEvents.DataSource = _context.Events
        .Where(conf => conf.title.ToLower()
        .Contains(textBoxSearch.Text.ToLower()))
        .ToList();
        }
    }
}