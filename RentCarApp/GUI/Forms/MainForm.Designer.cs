namespace RentCarApp.GUI.Forms
{
    partial class MainForm
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
            leftPanel = new Panel();
            panel1 = new Panel();
            menuPanel = new Panel();
            billsMenuButton = new Button();
            settingsMenuButton = new Button();
            homeMenuButton = new Button();
            usersMenuButton = new Button();
            clientsMenuButton = new Button();
            carsMenuButton = new Button();
            rentsMenuButton = new Button();
            datetimeLabel = new Label();
            sidePanel = new Panel();
            infoPanel = new Panel();
            userInfoPanel = new Panel();
            appUserRoleLabel = new Label();
            label2 = new Label();
            contentPannel = new Panel();
            leftPanel.SuspendLayout();
            menuPanel.SuspendLayout();
            infoPanel.SuspendLayout();
            userInfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.DimGray;
            leftPanel.Controls.Add(panel1);
            leftPanel.Controls.Add(menuPanel);
            leftPanel.Controls.Add(infoPanel);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Margin = new Padding(4, 5, 4, 5);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(293, 1055);
            leftPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(0, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 14);
            panel1.TabIndex = 3;
            // 
            // menuPanel
            // 
            menuPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuPanel.BackColor = SystemColors.ControlDarkDark;
            menuPanel.Controls.Add(billsMenuButton);
            menuPanel.Controls.Add(settingsMenuButton);
            menuPanel.Controls.Add(homeMenuButton);
            menuPanel.Controls.Add(usersMenuButton);
            menuPanel.Controls.Add(clientsMenuButton);
            menuPanel.Controls.Add(carsMenuButton);
            menuPanel.Controls.Add(rentsMenuButton);
            menuPanel.Controls.Add(datetimeLabel);
            menuPanel.Controls.Add(sidePanel);
            menuPanel.Location = new Point(2, 185);
            menuPanel.Margin = new Padding(4, 5, 4, 5);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(287, 865);
            menuPanel.TabIndex = 2;
            // 
            // billsMenuButton
            // 
            billsMenuButton.BackColor = SystemColors.ControlDarkDark;
            billsMenuButton.Cursor = Cursors.Hand;
            billsMenuButton.FlatAppearance.BorderSize = 0;
            billsMenuButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(115, 122, 136);
            billsMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 40, 42);
            billsMenuButton.FlatStyle = FlatStyle.Flat;
            billsMenuButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            billsMenuButton.ForeColor = Color.White;
            billsMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            billsMenuButton.Location = new Point(7, 192);
            billsMenuButton.Margin = new Padding(4, 5, 4, 5);
            billsMenuButton.Name = "billsMenuButton";
            billsMenuButton.RightToLeft = RightToLeft.No;
            billsMenuButton.Size = new Size(280, 92);
            billsMenuButton.TabIndex = 10;
            billsMenuButton.Text = "   Bills";
            billsMenuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            billsMenuButton.UseVisualStyleBackColor = false;
            billsMenuButton.Click += billsMenuButton_Click;
            // 
            // settingsMenuButton
            // 
            settingsMenuButton.BackColor = SystemColors.ControlDarkDark;
            settingsMenuButton.Cursor = Cursors.Hand;
            settingsMenuButton.FlatAppearance.BorderSize = 0;
            settingsMenuButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(115, 122, 136);
            settingsMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 40, 42);
            settingsMenuButton.FlatStyle = FlatStyle.Flat;
            settingsMenuButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            settingsMenuButton.ForeColor = Color.White;
            settingsMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            settingsMenuButton.Location = new Point(7, 568);
            settingsMenuButton.Margin = new Padding(4, 5, 4, 5);
            settingsMenuButton.Name = "settingsMenuButton";
            settingsMenuButton.RightToLeft = RightToLeft.No;
            settingsMenuButton.Size = new Size(280, 92);
            settingsMenuButton.TabIndex = 5;
            settingsMenuButton.Text = "   Settings";
            settingsMenuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            settingsMenuButton.UseVisualStyleBackColor = false;
            settingsMenuButton.Click += settingsMenuButton_Click;
            // 
            // homeMenuButton
            // 
            homeMenuButton.BackColor = SystemColors.ControlDarkDark;
            homeMenuButton.Cursor = Cursors.Hand;
            homeMenuButton.FlatAppearance.BorderSize = 0;
            homeMenuButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(115, 122, 136);
            homeMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 40, 42);
            homeMenuButton.FlatStyle = FlatStyle.Flat;
            homeMenuButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            homeMenuButton.ForeColor = Color.White;
            homeMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            homeMenuButton.Location = new Point(7, 5);
            homeMenuButton.Margin = new Padding(4, 5, 4, 5);
            homeMenuButton.Name = "homeMenuButton";
            homeMenuButton.RightToLeft = RightToLeft.No;
            homeMenuButton.Size = new Size(280, 92);
            homeMenuButton.TabIndex = 6;
            homeMenuButton.Text = "   Home";
            homeMenuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            homeMenuButton.UseVisualStyleBackColor = false;
            homeMenuButton.Click += homeMenuButton_Click;
            // 
            // usersMenuButton
            // 
            usersMenuButton.BackColor = SystemColors.ControlDarkDark;
            usersMenuButton.Cursor = Cursors.Hand;
            usersMenuButton.FlatAppearance.BorderSize = 0;
            usersMenuButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(115, 122, 136);
            usersMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 40, 42);
            usersMenuButton.FlatStyle = FlatStyle.Flat;
            usersMenuButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            usersMenuButton.ForeColor = Color.White;
            usersMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            usersMenuButton.Location = new Point(7, 474);
            usersMenuButton.Margin = new Padding(4, 5, 4, 5);
            usersMenuButton.Name = "usersMenuButton";
            usersMenuButton.RightToLeft = RightToLeft.No;
            usersMenuButton.Size = new Size(280, 92);
            usersMenuButton.TabIndex = 7;
            usersMenuButton.Text = "   Users";
            usersMenuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            usersMenuButton.UseVisualStyleBackColor = false;
            usersMenuButton.Click += usersMenuButton_Click;
            // 
            // clientsMenuButton
            // 
            clientsMenuButton.BackColor = SystemColors.ControlDarkDark;
            clientsMenuButton.Cursor = Cursors.Hand;
            clientsMenuButton.FlatAppearance.BorderSize = 0;
            clientsMenuButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(115, 122, 136);
            clientsMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 40, 42);
            clientsMenuButton.FlatStyle = FlatStyle.Flat;
            clientsMenuButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            clientsMenuButton.ForeColor = Color.White;
            clientsMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            clientsMenuButton.Location = new Point(7, 380);
            clientsMenuButton.Margin = new Padding(4, 5, 4, 5);
            clientsMenuButton.Name = "clientsMenuButton";
            clientsMenuButton.RightToLeft = RightToLeft.No;
            clientsMenuButton.Size = new Size(280, 92);
            clientsMenuButton.TabIndex = 8;
            clientsMenuButton.Text = "   Clients";
            clientsMenuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            clientsMenuButton.UseVisualStyleBackColor = false;
            clientsMenuButton.Click += clientsMenuButton_Click;
            // 
            // carsMenuButton
            // 
            carsMenuButton.BackColor = SystemColors.ControlDarkDark;
            carsMenuButton.Cursor = Cursors.Hand;
            carsMenuButton.FlatAppearance.BorderSize = 0;
            carsMenuButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(115, 122, 136);
            carsMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 40, 42);
            carsMenuButton.FlatStyle = FlatStyle.Flat;
            carsMenuButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            carsMenuButton.ForeColor = Color.White;
            carsMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            carsMenuButton.Location = new Point(7, 286);
            carsMenuButton.Margin = new Padding(4, 5, 4, 5);
            carsMenuButton.Name = "carsMenuButton";
            carsMenuButton.RightToLeft = RightToLeft.No;
            carsMenuButton.Size = new Size(280, 92);
            carsMenuButton.TabIndex = 9;
            carsMenuButton.Text = "   Cars";
            carsMenuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            carsMenuButton.UseVisualStyleBackColor = false;
            carsMenuButton.Click += carsMenuButton_Click;
            // 
            // rentsMenuButton
            // 
            rentsMenuButton.BackColor = SystemColors.ControlDarkDark;
            rentsMenuButton.Cursor = Cursors.Hand;
            rentsMenuButton.FlatAppearance.BorderSize = 0;
            rentsMenuButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(115, 122, 136);
            rentsMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 40, 42);
            rentsMenuButton.FlatStyle = FlatStyle.Flat;
            rentsMenuButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            rentsMenuButton.ForeColor = Color.White;
            rentsMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            rentsMenuButton.Location = new Point(7, 98);
            rentsMenuButton.Margin = new Padding(4, 5, 4, 5);
            rentsMenuButton.Name = "rentsMenuButton";
            rentsMenuButton.RightToLeft = RightToLeft.No;
            rentsMenuButton.Size = new Size(280, 92);
            rentsMenuButton.TabIndex = 10;
            rentsMenuButton.Text = "   Rents";
            rentsMenuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            rentsMenuButton.UseVisualStyleBackColor = false;
            rentsMenuButton.Click += rentsMenuButton_Click;
            // 
            // datetimeLabel
            // 
            datetimeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datetimeLabel.AutoSize = true;
            datetimeLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            datetimeLabel.ForeColor = Color.Silver;
            datetimeLabel.Location = new Point(49, 819);
            datetimeLabel.Margin = new Padding(0);
            datetimeLabel.Name = "datetimeLabel";
            datetimeLabel.Size = new Size(171, 20);
            datetimeLabel.TabIndex = 11;
            datetimeLabel.Text = "Tue 23 2019- 23:52";
            datetimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.White;
            sidePanel.Location = new Point(0, 5);
            sidePanel.Margin = new Padding(4, 5, 4, 5);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(13, 92);
            sidePanel.TabIndex = 4;
            // 
            // infoPanel
            // 
            infoPanel.BackColor = SystemColors.ControlDarkDark;
            infoPanel.Controls.Add(userInfoPanel);
            infoPanel.Dock = DockStyle.Top;
            infoPanel.Location = new Point(0, 0);
            infoPanel.Margin = new Padding(4, 5, 4, 5);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(293, 151);
            infoPanel.TabIndex = 1;
            // 
            // userInfoPanel
            // 
            userInfoPanel.Anchor = AnchorStyles.None;
            userInfoPanel.BackColor = SystemColors.ControlDarkDark;
            userInfoPanel.Controls.Add(appUserRoleLabel);
            userInfoPanel.Controls.Add(label2);
            userInfoPanel.Location = new Point(0, 24);
            userInfoPanel.Margin = new Padding(4, 5, 4, 5);
            userInfoPanel.Name = "userInfoPanel";
            userInfoPanel.Size = new Size(293, 97);
            userInfoPanel.TabIndex = 1;
            // 
            // appUserRoleLabel
            // 
            appUserRoleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            appUserRoleLabel.AutoSize = true;
            appUserRoleLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            appUserRoleLabel.ForeColor = Color.White;
            appUserRoleLabel.Location = new Point(128, 74);
            appUserRoleLabel.Margin = new Padding(4, 0, 4, 0);
            appUserRoleLabel.MinimumSize = new Size(157, 23);
            appUserRoleLabel.Name = "appUserRoleLabel";
            appUserRoleLabel.Size = new Size(157, 23);
            appUserRoleLabel.TabIndex = 3;
            appUserRoleLabel.Text = "ADMINISTRATOR";
            appUserRoleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Handwriting", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 17);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 27);
            label2.TabIndex = 3;
            label2.Text = "Rent Luxury";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contentPannel
            // 
            contentPannel.BackColor = SystemColors.Control;
            contentPannel.Dock = DockStyle.Fill;
            contentPannel.Location = new Point(293, 0);
            contentPannel.Margin = new Padding(4, 5, 4, 5);
            contentPannel.Name = "contentPannel";
            contentPannel.Size = new Size(1403, 1055);
            contentPannel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(1220, 700);
            ClientSize = new Size(1696, 1055);
            Controls.Add(contentPannel);
            Controls.Add(leftPanel);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1359, 861);
            Name = "MainForm";
            Opacity = 0.99D;
            RightToLeft = RightToLeft.No;
            Text = "Rent Luxury";
            WindowState = FormWindowState.Maximized;
            leftPanel.ResumeLayout(false);
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            infoPanel.ResumeLayout(false);
            userInfoPanel.ResumeLayout(false);
            userInfoPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private Panel infoPanel;
        private Label label2;
        private Label appUserRoleLabel;
        //private Timer menuTimer;
        private Panel userInfoPanel;
        //private Timer datetimeTimer;
        private Panel menuPanel;
        private Label datetimeLabel;
        private Panel sidePanel;
        private Button settingsMenuButton;
        private Button homeMenuButton;
        private Button usersMenuButton;
        private Button clientsMenuButton;
        private Button carsMenuButton;
        private Button rentsMenuButton;
        private Button billsMenuButton;
        private Panel contentPannel;
        private Panel panel1;
    }
}