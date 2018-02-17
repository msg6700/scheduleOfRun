using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scheduleOfRun
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           

            Opacity = .1;
            for (int i = 0; i < 50; i++)
            {Opacity += .02;
                Application.DoEvents();
                Thread.Sleep(10);

            }
            DateTime temp = DateTime.Now;
            
            toolStripStatusLabel1.Text = Extentions.ConvertDate.ToPersianDateString(temp).ToString()+"  "+DateTime.Now.DayOfWeek + "                                      verson1.0";
        }

        private void ثبتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.RegisterForm FrmReg = new Forms.RegisterForm();
            Visible = false;
            FrmReg.ShowDialog();
            Visible = true;
        }

        

        private void لیستافرادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.RunsList frmRunsList = new Forms.RunsList();
            frmRunsList.ShowDialog();
        }

        private void سیستمهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.SystemList systemList = new Forms.SystemList();
            systemList.Show();
        }
    }
}
