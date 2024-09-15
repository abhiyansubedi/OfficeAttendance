using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandaloneSDKDemo
{
    public partial class Leave : UserControl
    {
        public Leave()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form hostForm = new Form();
            AddLeave addLeaveControl = new AddLeave();
            addLeaveControl.Dock = DockStyle.Fill; // Optional: make the control fill the form
            hostForm.Controls.Add(addLeaveControl);
            hostForm.Text = "Add Leave";
            hostForm.Size = new Size(214, 23); // Set the size of the form
            hostForm.Show();
        }
    }
}
