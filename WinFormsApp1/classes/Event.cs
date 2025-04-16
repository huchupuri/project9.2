using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.classes
{
    public class Event
    {
        public int id { get; set; }
        private string Title;
        private DateTime Date;

        private string Place;

        private string Description;
        private string Participants;

        public string title
        {
            get
            {
                return Title;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EventValidationException("Название не может быть пустым или пробелом");
                }
                if (value.Length >= 50)
                {
                    throw new EventValidationException("Длина заголовка не должна превышать 50 символов");
                }
                if (value.StartsWith(" ") || value.Contains("\n"))
                {
                    throw new EventValidationException("Название не должно начинаться с пробела или содержать перенос строки");
                }
                Title = value;
            }
        }
        public string place
        {
            get
            {
                return Place;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EventValidationException("Место не может быть пустым или пробелом");
                }
                if (value.Length >= 50)
                {
                    throw new EventValidationException("Длина места не должна превышать 50 символов");
                }
                if (value.StartsWith(" "))
                {
                    throw new EventValidationException("Место не должно начинаться с пробела");
                }
                Place = value;
            }
        }
        public string description
        {
            get
            {
                return Description;
            }
            set
            {
                if (value.Length >= 500)
                {
                    throw new EventValidationException("Длина описания не должна превышать 500 символов");
                }
                Description = value;
            }
        }
        public string participants
        {
            get
            {
                return Participants;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EventValidationException("Участники не могут быть пустыми или пробелом");
                }
                if (value.Any(char.IsDigit))
                {
                    throw new EventValidationException("Участники не могут быть числами");
                }
                if (value.StartsWith(" "))
                {
                    throw new EventValidationException("Участники не должны начинаться с пробела");
                }
                Participants = value;
            }
        }
        public DateTime date
        {
            get
            {
                return Date;
            }
            set
            {
                Date = value;
            }
        }
    }
}
