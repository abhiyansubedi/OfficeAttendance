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
    public partial class Employees : UserControl
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form hostForm = new Form();
            AddEmployee addEmployeeControl = new AddEmployee();
            addEmployeeControl.Dock = DockStyle.Fill; // Optional: make the control fill the form
            hostForm.Controls.Add(addEmployeeControl);
            hostForm.Text = "Add Employee";
            hostForm.Size = new Size(1739, 790); // Set the size of the form
            hostForm.Show();
        }
    }
}
