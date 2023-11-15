using RentCarApp.GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarApp.GUI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MoveSidePanel(Control control)
        {
            sidePanel.Top = control.Top;
            sidePanel.Height = control.Height;
        }

        private void SetPageToContentPanel(Control page)
        {
            page.Dock = DockStyle.Fill;
            contentPannel.Controls.Clear();
            contentPannel.Controls.Add(page);
        }

        private void homeMenuButton_Click(object sender, EventArgs e)
        {
            SetPageToContentPanel(new HomePageUserControl());
            MoveSidePanel(homeMenuButton);
        }

        private void rentsMenuButton_Click(object sender, EventArgs e)
        {
            SetPageToContentPanel(new RentsPageUserControl());
            MoveSidePanel(rentsMenuButton);
        }

        private void billsMenuButton_Click(object sender, EventArgs e)
        {
            SetPageToContentPanel(new BillsPageUserControl());
            MoveSidePanel(billsMenuButton);
        }

        private void carsMenuButton_Click(object sender, EventArgs e)
        {
            SetPageToContentPanel(new CarsPageUserControl());
            MoveSidePanel(carsMenuButton);
        }

        private void clientsMenuButton_Click(object sender, EventArgs e)
        {
            SetPageToContentPanel(new ClientsPageUserControl());
            MoveSidePanel(clientsMenuButton);
        }

        private void usersMenuButton_Click(object sender, EventArgs e)
        {
            SetPageToContentPanel(new UsersPageUserControl());
            MoveSidePanel(usersMenuButton);
        }

        private void settingsMenuButton_Click(object sender, EventArgs e)
        {
            SetPageToContentPanel(new SettingsPageUserControl());   
            MoveSidePanel(settingsMenuButton);
        }
    }
}
