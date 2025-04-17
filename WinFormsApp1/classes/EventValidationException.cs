using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.classes
{
    public class EventValidationException : Exception
    {
        /// <summary>
        /// класс с исключением
        /// </summary>
        /// <param name="message"></param>
        public EventValidationException(string message) : base(message) { }
    }
}
