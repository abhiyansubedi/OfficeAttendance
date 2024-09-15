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
    public partial class AddEmployee : UserControl
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form hostForm = new Form();
            AddEmployee2 addEmployee2Control = new AddEmployee2();
            addEmployee2Control.Dock = DockStyle.Fill; // Optional: make the control fill the form
            hostForm.Controls.Add(addEmployee2Control);
            hostForm.Text = "Add Employee2";
            hostForm.Size = new Size(214, 23); // Set the size of the form
            hostForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form hostForm = new Form();
            AddEmployee3 addEmployee3Control = new AddEmployee3();
            addEmployee3Control.Dock = DockStyle.Fill; // Optional: make the control fill the form
            hostForm.Controls.Add(addEmployee3Control);
            hostForm.Text = "Add Employee2";
            hostForm.Size = new Size(214, 23); // Set the size of the form
            hostForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
