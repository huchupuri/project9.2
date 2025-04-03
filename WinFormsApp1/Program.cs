using System;
using System.Windows.Forms;
using EventManagementApp;

namespace WinFormsApp1
{

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}