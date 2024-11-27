using System;
using System.Drawing;
using System.Windows.Forms;

namespace StandaloneSDKDemo
{
    public partial class Main : Form
    {
        String demoVersion = "1.1.15";//Please set correct demo version when code be changed; 
       
        public Main()
        {
            InitializeComponent();
            string ver = null;
            SDK.axCZKEM1.GetSDKVersion(ref ver);
            lbVer.Text = "Demo Version:" + demoVersion + "  SDK Version:" + ver;
        }
              




        //public bool connected = false;
        public SDKHelper SDK = new SDKHelper();

        FirstMenu firstMenu = new FirstMenu();

        Point mouseOffset;
        Point FormLocation;
        bool isMouseDown;
        private void PnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            int _x = 0;
            int _y = 0;
            if (isMouseDown)
            {
                Point pt = Control.MousePosition;
                _x = mouseOffset.X - pt.X;
                _y = mouseOffset.Y - pt.Y;
                this.Location = new Point(FormLocation.X - _x, FormLocation.Y - _y);
            }
        }

        private void PnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void PnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                FormLocation = this.Location;
                mouseOffset = Control.MousePosition;
            }
        }

        private void firstMenu1_MouseSelected(object sender, EventArgs e)
        {
            //firstMenu2.BackColor = Color.Transparent;
            //firstMenu3.BackColor = Color.Transparent;
            //firstMenu4.BackColor = Color.Transparent;
            //firstMenu5.BackColor = Color.Transparent;
            //firstMenu6.BackColor = Color.Transparent;

            //firstMenu1.TextColor = Color.White;
            //firstMenu2.TextColor = Color.Black;
            //firstMenu3.TextColor = Color.Black;
            //firstMenu4.TextColor = Color.Black;
            //firstMenu5.TextColor = Color.Black;
            //firstMenu6.TextColor = Color.Black;

            //pnlTerminal.Visible = true;
            //pnlUser.Visible = false;
            //pnlPersonalize.Visible = false;
            //pnlData.Visible = false;
            //pnlAccess.Visible = false;
            //pnlOther.Visible = false;

            //pnlTerminal.Dock = DockStyle.Fill;

            //if (pnlTerminal.Controls.Count == 0)
            //{
            //    TerminalForm terminalForm = new TerminalForm(this);
            //    //terminalForm.TopLevel = false;
            //    this.pnlTerminal.Controls.Add(terminalForm);
            //    terminalForm.Show();
            //}
        }

        private void firstMenu2_MouseSelected(object sender, EventArgs e)
        {
            //firstMenu1.BackColor = Color.Transparent;
            //firstMenu3.BackColor = Color.Transparent;
            //firstMenu4.BackColor = Color.Transparent;
            //firstMenu5.BackColor = Color.Transparent;
            //firstMenu6.BackColor = Color.Transparent;

            //firstMenu1.TextColor = Color.Black;
            //firstMenu2.TextColor = Color.White;
            //firstMenu3.TextColor = Color.Black;
            //firstMenu4.TextColor = Color.Black;
            //firstMenu5.TextColor = Color.Black;
            //firstMenu6.TextColor = Color.Black;

            //pnlTerminal.Visible = false;
            //pnlUser.Visible = true;
            //pnlPersonalize.Visible = false;
            //pnlData.Visible = false;
            //pnlAccess.Visible = false;
            //pnlOther.Visible = false;

            //pnlUser.Dock = DockStyle.Fill;

            //if (pnlUser.Controls.Count == 0)
            //{
            //    UserMngForm UserMng = new UserMngForm(this);
            //    UserMng.TopLevel = false;
            //    this.pnlUser.Controls.Add(UserMng);
            //    UserMng.Show();
            //}
        }

        private void firstMenu3_MouseSelected(object sender, EventArgs e)
        {
            //firstMenu1.BackColor = Color.Transparent;
            //firstMenu2.BackColor = Color.Transparent;
            //firstMenu4.BackColor = Color.Transparent;
            //firstMenu5.BackColor = Color.Transparent;
            //firstMenu6.BackColor = Color.Transparent;

            //firstMenu1.TextColor = Color.Black;
            //firstMenu2.TextColor = Color.Black;
            //firstMenu3.TextColor = Color.White;
            //firstMenu4.TextColor = Color.Black;
            //firstMenu5.TextColor = Color.Black;
            //firstMenu6.TextColor = Color.Black;

            //pnlTerminal.Visible = false;
            //pnlUser.Visible = false;
            //pnlPersonalize.Visible = true;
            //pnlData.Visible = false;
            //pnlAccess.Visible = false;
            //pnlOther.Visible = false;

            //pnlPersonalize.Dock = DockStyle.Fill;

            //if (pnlPersonalize.Controls.Count == 0)
            //{
            //    PersonalizeMngForm personalizeMng = new PersonalizeMngForm(this);
            //    //personalizeMng.TopLevel = false;
            //    this.pnlPersonalize.Controls.Add(personalizeMng);
            //    personalizeMng.Show();
            //}
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close if Device is connected
            if (SDK.GetConnectState())
            {
                DialogResult dr = MessageBox.Show("Are you sure to exit system?"
                    + System.Environment.NewLine +
                    "Your device will be disconnected.", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                    SDK.sta_DisConnect();
                if (dr == DialogResult.Cancel)
                    e.Cancel = true;
            }
            Application.Exit();

        }

        /*private void PicSmall_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PicClose_MouseClick(object sender, MouseEventArgs e)
        {
            //DialogResult dr = MessageBox.Show("Are you sure to exit system?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            DialogResult dr = ZKMessgeBox.Show("Exit the program?", "Warning!", ZKMessgeBox.I8Buttons.OKCancel);
           
            if (dr == DialogResult.OK)
            {
                SDK.sta_DisConnect();
                Application.Exit();
            }
        }*/

        private void PicHome_MouseClick(object sender, MouseEventArgs e)
        {
            //firstMenu1.BackColor = Color.Transparent;
            //firstMenu2.BackColor = Color.Transparent;
            //firstMenu3.BackColor = Color.Transparent;
            //firstMenu4.BackColor = Color.Transparent;
            //firstMenu5.BackColor = Color.Transparent;
            //firstMenu6.BackColor = Color.Transparent;

            //firstMenu1.TextColor = Color.Black;
            //firstMenu2.TextColor = Color.Black;
            //firstMenu3.TextColor = Color.Black;
            //firstMenu4.TextColor = Color.Black;
            //firstMenu5.TextColor = Color.Black;
            //firstMenu6.TextColor = Color.Black;

            //pnlTerminal.Visible = false;
            //pnlUser.Visible = false;
            //pnlPersonalize.Visible = false;
            //pnlData.Visible = false;
            //pnlAccess.Visible = false;
            //pnlOther.Visible = false;

            //this.PnlMiddle.Controls.Add(labAD);
        }

        private void lbSysOutputInfo_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();

                if (lbSysOutputInfo.Items[e.Index].ToString().Substring(0, 1) == "*")//if begin with *, the font color is red   
                {
                    e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, new SolidBrush(Color.Red), e.Bounds);
                }
                else
                {
                    e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
                }
                e.DrawFocusRectangle();
            }
        }

        private void firstMenu4_MouseSelected(object sender, EventArgs e)
        {
            //firstMenu1.BackColor = Color.Transparent;
            //firstMenu2.BackColor = Color.Transparent;
            //firstMenu3.BackColor = Color.Transparent;
            //firstMenu5.BackColor = Color.Transparent;
            //firstMenu6.BackColor = Color.Transparent;

            //firstMenu1.TextColor = Color.Black;
            //firstMenu2.TextColor = Color.Black;
            //firstMenu3.TextColor = Color.Black;
            //firstMenu4.TextColor = Color.White;
            //firstMenu5.TextColor = Color.Black;
            //firstMenu6.TextColor = Color.Black;

            //pnlTerminal.Visible = false;
            //pnlUser.Visible = false;
            //pnlPersonalize.Visible = false;
            //pnlData.Visible = true;
            //pnlAccess.Visible = false;
            //pnlOther.Visible = false;

            //pnlData.Dock = DockStyle.Fill;

            //if (pnlData.Controls.Count == 0)
            //{
            //    DataMngForm dataMngFrom = new DataMngForm(this);
            //    //dataMngFrom.TopLevel = false;
            //    this.pnlData.Controls.Add(dataMngFrom);
            //    dataMngFrom.Show();
            //}
        }

        private void firstMenu5_MouseSelected(object sender, EventArgs e)
        {
            //firstMenu1.BackColor = Color.Transparent;
            //firstMenu2.BackColor = Color.Transparent;
            //firstMenu3.BackColor = Color.Transparent;
            //firstMenu4.BackColor = Color.Transparent;
            //firstMenu6.BackColor = Color.Transparent;

            //firstMenu1.TextColor = Color.Black;
            //firstMenu2.TextColor = Color.Black;
            //firstMenu3.TextColor = Color.Black;
            //firstMenu4.TextColor = Color.Black;
            //firstMenu5.TextColor = Color.White;
            //firstMenu6.TextColor = Color.Black;

            //pnlTerminal.Visible = false;
            //pnlUser.Visible = false;
            //pnlPersonalize.Visible = false;
            //pnlData.Visible = false;
            //pnlAccess.Visible = true;
            //pnlOther.Visible = false;

            //pnlAccess.Dock = DockStyle.Fill;

            //if (pnlAccess.Controls.Count == 0)
            //{
            //    AccessMngForm accessMngFrom = new AccessMngForm(this);
            //    //accessMngFrom.TopLevel = false;
            //    this.pnlAccess.Controls.Add(accessMngFrom);
            //    accessMngFrom.Show();
            //}
        }

        private void firstMenu6_MouseSelected(object sender, EventArgs e)
        {
            //firstMenu1.BackColor = Color.Transparent;
            //firstMenu2.BackColor = Color.Transparent;
            //firstMenu3.BackColor = Color.Transparent;
            //firstMenu4.BackColor = Color.Transparent;
            //firstMenu5.BackColor = Color.Transparent;

            //firstMenu1.TextColor = Color.Black;
            //firstMenu2.TextColor = Color.Black;
            //firstMenu3.TextColor = Color.Black;
            //firstMenu4.TextColor = Color.Black;
            //firstMenu5.TextColor = Color.Black;
            //firstMenu6.TextColor = Color.White;

            //pnlTerminal.Visible = false;
            //pnlUser.Visible = false;
            //pnlPersonalize.Visible = false;
            //pnlData.Visible = false;
            //pnlAccess.Visible = false;
            //pnlOther.Visible = true;

            //pnlOther.Dock = DockStyle.Fill;

            //if (pnlOther.Controls.Count == 0)
            //{
            //    OtherMngForm otherMngFrom = new OtherMngForm(this);
            //    //otherMngFrom.TopLevel = false;
            //    this.pnlOther.Controls.Add(otherMngFrom);
            //    otherMngFrom.Show();
            //}
        }

       
        private void firstMenu8_MouseSelected(object sender, EventArgs e)
        {
            //firstMenu1.BackColor = Color.Transparent;
            //firstMenu2.BackColor = Color.Transparent;
            //firstMenu3.BackColor = Color.Transparent;
            //firstMenu4.BackColor = Color.Transparent;
            //firstMenu5.BackColor = Color.Transparent;
            //firstMenu6.BackColor = Color.Transparent;

            //firstMenu1.TextColor = Color.Black;
            //firstMenu2.TextColor = Color.Black;
            //firstMenu3.TextColor = Color.Black;
            //firstMenu4.TextColor = Color.Black;
            //firstMenu5.TextColor = Color.Black;
            //firstMenu6.TextColor = Color.Black;
            //firstMenu6.TextColor = Color.Black;

            //pnlTerminal.Visible = false;
            //pnlUser.Visible = false;
            //pnlPersonalize.Visible = false;
            //pnlData.Visible = false;
            //pnlAccess.Visible = false;
            //pnlOther.Visible = true;

            //pnlOther.Dock = DockStyle.Fill;

            //if (pnlOther.Controls.Count == 0)
            //{
            //    RegisterForm registerForm = new RegisterForm(this);
            //    //registerForm.TopLevel = false;
            //    this.pnlOther.Controls.Add(registerForm);
            //    registerForm.Show();
            //}
        }

        public ListBox RealTimeEventListBox()
        {
            ListBox dtg = lbRTOutputInfo;
            return dtg;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            SDK.sta_SetRTLogListBox(RealTimeEventListBox);

            Cursor = Cursors.Default;
        }

        private void ClearInfoMenuItem_Click(object sender, EventArgs e)
        {
            this.lbSysOutputInfo.Items.Clear();
        }

        private void ClearInfoMenuItem1_Click(object sender, EventArgs e)
        {
            this.lbRTOutputInfo.Items.Clear();
        }

        private void OnMainNavButtonClicked(object sender, EventArgs e)
        {
          

            var button = (Button)sender;
            if (button == btnTerminal) LoadPags(button, new TerminalForm(this));
            else if (button == btnUsers) LoadPags(button, new UserMngForm(this));
            else if (button == btnSettings) LoadPags(button, new PersonalizeMngForm(this));
            
            
            else if (button == btnEmployees) LoadPags(button, new UserMngForm(this));
            else if (button == btnMonthlyReports) LoadPags(button, new MonthlyReport2(this));
            else if (button == btnAttendance) LoadPags(button, new MonthlyReportForm(this));
            else if (button == btnHomepage) LoadPags(button, new Homepage());
            else if (button == btnLeave) LoadPags(button, new Leave());
            else if (button == btnRole) LoadPags(button, new Role());


            
           
        }

     

        public void LoadPags(Button sourceButton, UserControl userControl)
        {
            PnlMiddle.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            PnlMiddle.Controls.Add(userControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlMiddle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlTop_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {

        }

        private void lbSysOutputInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PnlMiddle_AutoSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
