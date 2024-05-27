using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class SplashScreen : Form
    {
        Timer timer = new Timer();
        public SplashScreen()
        {
            InitializeComponent();
        }
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer.Interval = 200;
            timer.Tick += new EventHandler(Timer1_Tick);
            timer.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //this.Close();
            Calculator calculator = new Calculator();
            calculator.Show();
            timer.Stop();
            this.Hide();

            //timer.Tick += new System.EventHandler(OnTimerEvent);
        }

    }
}
