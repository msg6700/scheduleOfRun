using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace scheduleOfRun.Forms
{
    public partial class SystemList : Form
    {
        public SystemList()
        {
            InitializeComponent();
        }
        //public void readDB()
        //{
        //    SqlCeConnection myconnection = new SqlCeConnection();
        //    myconnection.ConnectionString = @"Data Source=" + Application.StartupPath + "\\scheduleDB.sdf";
        //    SqlCeCommand mycommand = new SqlCeCommand();
        //    mycommand.Connection = myconnection;

        //    mycommand.CommandText = " SELECT * from [student] ";

        //    DataTable dataTable = new DataTable();
        //    SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter();
        //    dataAdapter.SelectCommand = mycommand;
        //    dataAdapter.Fill(dataTable);

        //    dataGridView1.AutoGenerateColumns = false;
        //    dataGridView1.DataSource = dataTable;
        //}


        private void occupiedSystem()
        {
            SqlCeConnection myconnection = new SqlCeConnection();
            myconnection.ConnectionString = @"Data Source=" + Application.StartupPath + "\\scheduleDB.sdf";
            SqlCeCommand mycommand = new SqlCeCommand();
            mycommand.Connection = myconnection;

            mycommand.CommandText = "SELECT * from [student] where  endOrNot like 0";

            DataTable dataTable = new DataTable();
            SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter();
            dataAdapter.SelectCommand = mycommand;
            dataAdapter.Fill(dataTable);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dataTable;
        }

        private void emptySystems()
        {
            SqlCeConnection myconnection = new SqlCeConnection();
            myconnection.ConnectionString = @"Data Source=" + Application.StartupPath + "\\scheduleDB.sdf";
            SqlCeCommand mycommand = new SqlCeCommand();
            mycommand.Connection = myconnection;

            //how send my parameter to my commandss like 'a' instead of dateTime=1396/01/01 ????
            //  mycommand.CommandText = "SELECT * from [student] where  endOrNot like 1 and CAST(endDate as Binary) >= CAST('1396/01/01' as Binary) ";
           //  mycommand.CommandText = "SELECT * from [student] where  endOrNot like 1 and CAST(endDate as Binary) >= CONVERT(Binary , '1396/01/01' ) ";
            // mycommand.CommandText = "SELECT * from [student] where  endOrNot like 1 and CAST(endDate as Binary) >= CONVERT(Binary , @tarikh ) ";

            string tarikh = "1396/01/01";
            //DateTime tarikh = DateTime.Now;
           mycommand.Parameters.AddWithValue("@tarikh", tarikh);


            mycommand.CommandText = "SELECT * from [student] where  endOrNot like 1";


            DataTable dataTable = new DataTable();
            SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter();
            dataAdapter.SelectCommand = mycommand;
            dataAdapter.Fill(dataTable);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dataTable;
        }

        private void empty_Click(object sender, EventArgs e)
        {
            emptySystems();
        }

        private void occupied_Click(object sender, EventArgs e)
        {
            occupiedSystem();
        }

        private void SystemList_Load(object sender, EventArgs e)
        {
            emptySystems();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.CurrentRow.Cells["endDateColumn"].Equals(1396/02/02)
                //.DataGridView.Visible = false;

        }
    }
}
