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
    public partial class RunsList : Form
    {
        public RunsList()
        {
            InitializeComponent();
        }
        public void readDB()
        {
            SqlCeConnection myconnection = new SqlCeConnection();
            myconnection.ConnectionString = @"Data Source=" + Application.StartupPath + "\\scheduleDB.sdf";
            SqlCeCommand mycommand = new SqlCeCommand();
            mycommand.Connection = myconnection;

            mycommand.CommandText = " SELECT * from [student]";

            DataTable dataTable = new DataTable();
            SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter();
            dataAdapter.SelectCommand = mycommand;
            dataAdapter.Fill(dataTable);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dataTable;
        }
        private void RunsList_Load(object sender, EventArgs e)
        {
            readDB();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("آیا از پاک شدن سطر " + string.Format(dataGridView1.CurrentRow.Cells["idColumn"].Value.ToString(), "shode dg") + " مطمئن هستید ؟", "اخطار", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCeConnection myconnection = new SqlCeConnection();
                myconnection.ConnectionString = @"Data Source=" + Application.StartupPath + "\\scheduleDB.sdf";
                SqlCeCommand mycommand = new SqlCeCommand();
                mycommand.Connection = myconnection;

                mycommand.CommandText = "delete from [student] where Id=@Id";
                mycommand.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells["idColumn"].Value);

                myconnection.Open();
                mycommand.ExecuteNonQuery();
                myconnection.Close();


                readDB();

                MessageBox.Show("!! سطر مورد نظر با موفقیت پاک شد ");
            }
            else
            {

            }


        }

        private void editButton_Click(object sender, EventArgs e)
        {


            Forms.EditForm frmEdit = new EditForm();
            frmEdit.Id= Convert.ToInt32(dataGridView1.CurrentRow.Cells["idColumn"].Value);
            frmEdit.name = dataGridView1.CurrentRow.Cells["nameColumn"].Value.ToString();
            frmEdit.family= dataGridView1.CurrentRow.Cells["familyColumn"].Value.ToString();
            frmEdit.studentNum =Convert.ToInt32( dataGridView1.CurrentRow.Cells["studentNumColumn"].Value);
            frmEdit.teacher= dataGridView1.CurrentRow.Cells["teacherColumn"].Value.ToString();
            frmEdit.systemNum = dataGridView1.CurrentRow.Cells["systemNumColumn"].Value.ToString();
            frmEdit.startDate= dataGridView1.CurrentRow.Cells["startDateColumn"].Value.ToString();
            frmEdit.endDate= dataGridView1.CurrentRow.Cells["endDateColumn"].Value.ToString();
            frmEdit.cellphone= dataGridView1.CurrentRow.Cells["cellphoneColumn"].Value.ToString();
            frmEdit.note= dataGridView1.CurrentRow.Cells["noteColumn"].Value.ToString();
            if(dataGridView1.CurrentRow.Cells["endOrNotColumn"].Value==DBNull.Value )
            {//چه کردیم ، خدایا شکرت  DBNull.Value  thanks God
                frmEdit.endOrNot = false;
            }
            else
            { 
            frmEdit.endOrNot = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["endOrNotColumn"].Value);
            }


            frmEdit.ShowDialog();

            readDB();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {//compelete this

            SqlCeConnection myconnection = new SqlCeConnection();
            myconnection.ConnectionString = @"Data Source=" + Application.StartupPath + "\\scheduleDB.sdf";
            SqlCeCommand mycommand = new SqlCeCommand();
            mycommand.Connection = myconnection;

            mycommand.CommandText = "SELECT * from [student] where family like @family or name like @name or studentNum like @studentNum";
            mycommand.Parameters.AddWithValue("@name" ,"%"+searchTextBox.Text+"%");
            mycommand.Parameters.AddWithValue("@family", "%" + searchTextBox.Text + "%");
            mycommand.Parameters.AddWithValue("@studentNum", "%" + searchTextBox.Text + "%");

            DataTable dataTable = new DataTable();
            SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter();
            dataAdapter.SelectCommand = mycommand;
            dataAdapter.Fill(dataTable);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {// تاریخ ها باید انگلیسی باشند ولی در سیستم دانشکده که فارسی داره ، دوباره چک شود و راه حل پیدا شود
         //... در درس26  البرزکد نیز تاریخ ها فارسی بود ،چک شود
         // //lesson26 AlborzCode
         //DateExtentions Class in AlborzCode
            try
            {
                TimeSpan ts;
                ts = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["endDateColumn"].Value) - Convert.ToDateTime(dataGridView1.CurrentRow.Cells["startDateColumn"].Value);
                label10.Text = ts.TotalDays.ToString();
            }
            catch
            {
                MessageBox.Show("تاریخ شما اشتباه است");   
            }
        }
    }
}
