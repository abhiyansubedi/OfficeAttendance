namespace StandaloneSDKDemo
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.dbPasswordTextBox = new System.Windows.Forms.TextBox();
            this.dbUserTextBox = new System.Windows.Forms.TextBox();
            this.dbPasswordLabel = new System.Windows.Forms.Label();
            this.dbUserLabel = new System.Windows.Forms.Label();
            this.dbPortTextBox = new System.Windows.Forms.TextBox();
            this.dbHostTextBox = new System.Windows.Forms.TextBox();
            this.dbPortLabel = new System.Windows.Forms.Label();
            this.dbHostLabel = new System.Windows.Forms.Label();
            this.dbNameTextBox = new System.Windows.Forms.TextBox();
            this.dbNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(71, 36);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(71, 113);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(74, 62);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(237, 39);
            this.emailTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(74, 145);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(237, 39);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(878, 185);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(173, 64);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_ClickAsync);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(74, 317);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameTextBox.Multiline = true;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(237, 39);
            this.lastNameTextBox.TabIndex = 8;
            this.lastNameTextBox.UseSystemPasswordChar = true;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(74, 234);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTextBox.Multiline = true;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(237, 39);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(71, 285);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(74, 17);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(71, 209);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(74, 17);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First name";
            // 
            // dbPasswordTextBox
            // 
            this.dbPasswordTextBox.Location = new System.Drawing.Point(421, 317);
            this.dbPasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dbPasswordTextBox.Multiline = true;
            this.dbPasswordTextBox.Name = "dbPasswordTextBox";
            this.dbPasswordTextBox.Size = new System.Drawing.Size(237, 39);
            this.dbPasswordTextBox.TabIndex = 16;
            this.dbPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // dbUserTextBox
            // 
            this.dbUserTextBox.Location = new System.Drawing.Point(421, 234);
            this.dbUserTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dbUserTextBox.Multiline = true;
            this.dbUserTextBox.Name = "dbUserTextBox";
            this.dbUserTextBox.Size = new System.Drawing.Size(237, 39);
            this.dbUserTextBox.TabIndex = 15;
            // 
            // dbPasswordLabel
            // 
            this.dbPasswordLabel.AutoSize = true;
            this.dbPasswordLabel.Location = new System.Drawing.Point(418, 285);
            this.dbPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dbPasswordLabel.Name = "dbPasswordLabel";
            this.dbPasswordLabel.Size = new System.Drawing.Size(69, 17);
            this.dbPasswordLabel.TabIndex = 14;
            this.dbPasswordLabel.Text = "Password";
            // 
            // dbUserLabel
            // 
            this.dbUserLabel.AutoSize = true;
            this.dbUserLabel.Location = new System.Drawing.Point(418, 209);
            this.dbUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dbUserLabel.Name = "dbUserLabel";
            this.dbUserLabel.Size = new System.Drawing.Size(38, 17);
            this.dbUserLabel.TabIndex = 13;
            this.dbUserLabel.Text = "User";
            // 
            // dbPortTextBox
            // 
            this.dbPortTextBox.Location = new System.Drawing.Point(421, 145);
            this.dbPortTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dbPortTextBox.Multiline = true;
            this.dbPortTextBox.Name = "dbPortTextBox";
            this.dbPortTextBox.Size = new System.Drawing.Size(237, 39);
            this.dbPortTextBox.TabIndex = 12;
            this.dbPortTextBox.UseSystemPasswordChar = true;
            // 
            // dbHostTextBox
            // 
            this.dbHostTextBox.Location = new System.Drawing.Point(421, 62);
            this.dbHostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dbHostTextBox.Multiline = true;
            this.dbHostTextBox.Name = "dbHostTextBox";
            this.dbHostTextBox.Size = new System.Drawing.Size(237, 39);
            this.dbHostTextBox.TabIndex = 11;
            // 
            // dbPortLabel
            // 
            this.dbPortLabel.AutoSize = true;
            this.dbPortLabel.Location = new System.Drawing.Point(418, 113);
            this.dbPortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dbPortLabel.Name = "dbPortLabel";
            this.dbPortLabel.Size = new System.Drawing.Size(34, 17);
            this.dbPortLabel.TabIndex = 10;
            this.dbPortLabel.Text = "Port";
            // 
            // dbHostLabel
            // 
            this.dbHostLabel.AutoSize = true;
            this.dbHostLabel.Location = new System.Drawing.Point(418, 36);
            this.dbHostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dbHostLabel.Name = "dbHostLabel";
            this.dbHostLabel.Size = new System.Drawing.Size(37, 17);
            this.dbHostLabel.TabIndex = 9;
            this.dbHostLabel.Text = "Host";
            // 
            // dbNameTextBox
            // 
            this.dbNameTextBox.Location = new System.Drawing.Point(421, 400);
            this.dbNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dbNameTextBox.Multiline = true;
            this.dbNameTextBox.Name = "dbNameTextBox";
            this.dbNameTextBox.Size = new System.Drawing.Size(237, 39);
            this.dbNameTextBox.TabIndex = 18;
            this.dbNameTextBox.UseSystemPasswordChar = true;
            // 
            // dbNameLabel
            // 
            this.dbNameLabel.AutoSize = true;
            this.dbNameLabel.Location = new System.Drawing.Point(418, 368);
            this.dbNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dbNameLabel.Name = "dbNameLabel";
            this.dbNameLabel.Size = new System.Drawing.Size(45, 17);
            this.dbNameLabel.TabIndex = 17;
            this.dbNameLabel.Text = "Name";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dbNameTextBox);
            this.Controls.Add(this.dbNameLabel);
            this.Controls.Add(this.dbPasswordTextBox);
            this.Controls.Add(this.dbUserTextBox);
            this.Controls.Add(this.dbPasswordLabel);
            this.Controls.Add(this.dbUserLabel);
            this.Controls.Add(this.dbPortTextBox);
            this.Controls.Add(this.dbHostTextBox);
            this.Controls.Add(this.dbPortLabel);
            this.Controls.Add(this.dbHostLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.Size = new System.Drawing.Size(1876, 922);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox dbPasswordTextBox;
        private System.Windows.Forms.TextBox dbUserTextBox;
        private System.Windows.Forms.Label dbPasswordLabel;
        private System.Windows.Forms.Label dbUserLabel;
        private System.Windows.Forms.TextBox dbPortTextBox;
        private System.Windows.Forms.TextBox dbHostTextBox;
        private System.Windows.Forms.Label dbPortLabel;
        private System.Windows.Forms.Label dbHostLabel;
        private System.Windows.Forms.TextBox dbNameTextBox;
        private System.Windows.Forms.Label dbNameLabel;
    }
}