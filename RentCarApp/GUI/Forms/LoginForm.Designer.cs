namespace RentCarApp.GUI.Forms
{
    partial class LoginForm
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
            label2 = new Label();
            panel2 = new Panel();
            loginButton = new Button();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            validationLabel = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(228, 14);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(5, 6, 5, 6);
            label2.Size = new Size(272, 48);
            label2.TabIndex = 2;
            label2.Text = "Please login here";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(loginButton);
            panel2.Controls.Add(passwordTextBox);
            panel2.Controls.Add(usernameTextBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(validationLabel);
            panel2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(103, 75);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(561, 662);
            panel2.TabIndex = 2;
            // 
            // loginButton
            // 
            loginButton.FlatAppearance.BorderColor = Color.Black;
            loginButton.FlatAppearance.MouseDownBackColor = Color.Gold;
            loginButton.FlatAppearance.MouseOverBackColor = Color.LightGoldenrodYellow;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = SystemColors.ControlDarkDark;
            loginButton.Location = new Point(151, 403);
            loginButton.Margin = new Padding(4, 5, 4, 5);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(285, 66);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = SystemColors.Info;
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(93, 272);
            passwordTextBox.Margin = new Padding(4, 5, 4, 5);
            passwordTextBox.MaxLength = 64;
            passwordTextBox.MinimumSize = new Size(399, 30);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(399, 30);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = SystemColors.Info;
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTextBox.Location = new Point(93, 155);
            usernameTextBox.Margin = new Padding(4, 5, 4, 5);
            usernameTextBox.MaxLength = 64;
            usernameTextBox.MinimumSize = new Size(399, 30);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(399, 30);
            usernameTextBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(89, 225);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 24);
            label4.TabIndex = 0;
            label4.Text = "Password *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(88, 98);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 24);
            label3.TabIndex = 0;
            label3.Text = "Username *";
            // 
            // validationLabel
            // 
            validationLabel.AutoSize = true;
            validationLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            validationLabel.ForeColor = Color.Red;
            validationLabel.Location = new Point(91, 338);
            validationLabel.Margin = new Padding(4, 0, 4, 0);
            validationLabel.Name = "validationLabel";
            validationLabel.Size = new Size(287, 20);
            validationLabel.TabIndex = 4;
            validationLabel.Text = "username or password not valide";
            validationLabel.UseMnemonic = false;
            validationLabel.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(225, 63);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 846);
            panel1.TabIndex = 1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1685, 1048);
            Controls.Add(panel1);
            ForeColor = SystemColors.GrayText;
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1359, 861);
            Name = "LoginForm";
            Opacity = 0.99D;
            Text = "Rent Car";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label validationLabel;
        private Panel panel1;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
    }
}