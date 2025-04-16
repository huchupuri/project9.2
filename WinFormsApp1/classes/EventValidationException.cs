using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.classes
{
    public class EventValidationException : Exception
    {
        public EventValidationException(string message) : base(message) { }
    }
}
