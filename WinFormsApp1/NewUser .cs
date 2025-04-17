using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementApp
{
    public partial class NewUser : Form
    {
        EventDetailsForm EventDetails;
        public NewUser(EventDetailsForm EventDetails)
        {
            this.EventDetails = EventDetails;
            InitializeComponent();
        }

        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            EventDetails.AddParti(textBoxName.Text , textBoxSurname.Text);
            this.Close();
        }

    }
}
