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
    public partial class Role : UserControl
    {
        public Role()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form hostForm = new Form();
            AddRole addRoleControl = new AddRole();
            addRoleControl.Dock = DockStyle.Fill; // Optional: make the control fill the form
            hostForm.Controls.Add(addRoleControl);
            hostForm.Text = "Add Role";
            hostForm.Size = new Size(824, 485); // Set the size of the form
            hostForm.Show();
        }
    }
}
