using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.classes
{
    public class Event
    {
        public int id { get; set; }
        public string title 
        {
            get => title;
            set
            {
                if (value.Length > 50) 
                {
                    MessageBox.Show("Длина заголовка не может превышать 50 символов.");
                }
                else
                {
                    title = value;
                }
            }
        }
        public DateTime date  { get;set; }

        public string place 
        {
            get => place;
            set
            {
                if (value.Length > 50)
                {
                    MessageBox.Show("Текст не может превышать 50 символов.");
                }
                else
                {
                    place = value;
                }
            }
        }

        public string description { get; set; }
        public string participants { get; set; }
    }
}
