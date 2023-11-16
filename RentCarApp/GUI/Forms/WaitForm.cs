using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentCarApp.GUI.Forms
{
    public partial class WaitForm : Form
    {
        public WaitForm(Action worker)
        {
            InitializeComponent();
            Worker = worker ?? throw new ArgumentNullException(nameof(worker));
            progressBar.Value = 0;
        }

        public Action Worker { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            timer.Start();
            Task.Factory.StartNew(Worker)
                .ContinueWith(t =>
                {
                    timer.Dispose();
                    Close();
                }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
                progressBar.Value += 5;

        }
    }
}
