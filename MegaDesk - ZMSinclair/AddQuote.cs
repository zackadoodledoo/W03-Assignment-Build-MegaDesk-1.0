using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk___ZMSinclair
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quote calculated successfully!");
        }

        // Add the missing event handler for label1_Click
        private void label1_Click(object sender, EventArgs e)
        {
            // Add your event handling code here
            MessageBox.Show("Label1 clicked!");
        }
    }
}