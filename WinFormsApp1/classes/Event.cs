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
        public string title { get; set; }
        public DateTime date { get; set; }

        public string place { get; set; }

        public string description { get; set; }
        public string participants { get; set; }
    }
}
