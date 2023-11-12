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

        private void homeMenuButton_Click(object sender, EventArgs e)
        {
            SetPageToContentPanel(new HomePageUserControl());
            MoveSidePanel(homeMenuButton);
        }
    }
}
