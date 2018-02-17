using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace scheduleOfRun
{
    public partial class WellcomeScreen : Form
    {
        public WellcomeScreen()
        {
            InitializeComponent();
        }

        private void WellcomeScreen_Load(object sender, EventArgs e)
        {



            Opacity = .1;
            for (int i = 0; i < 50; i++)
            {
                Opacity += .02;
                Application.DoEvents();
                Thread.Sleep(30);

            }

            for(int j=0; j < 100; j++)
            {
                Opacity -= .02;
                Application.DoEvents();
                Thread.Sleep(10);
            }

            MainForm FrmMain = new MainForm();
            FrmMain.ShowDialog();

            //FrmMain.Opacity = .1;
            //for (int i = 0; i < 50; i++)
            //{
            //    FrmMain.Opacity += .02;
            //    Application.DoEvents();
            //    Thread.Sleep(10);

            //}
        }

    }
}
