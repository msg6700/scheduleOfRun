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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void searchDB()
        {

            SqlCeConnection myconnection = new SqlCeConnection();
            myconnection.ConnectionString = @"Data Source=" + Application.StartupPath + "\\scheduleDB.sdf";
            SqlCeCommand mycommand = new SqlCeCommand();
            mycommand.Connection = myconnection;


            mycommand.CommandText = "SELECT * from [student] where  studentNum like @studentNum1";
            mycommand.Parameters.AddWithValue("@studentNum1", studentNumTextBox.Text);



            DataTable dataTable = new DataTable();
            SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter();
            dataAdapter.SelectCommand = mycommand;
            dataAdapter.Fill(dataTable);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dataTable;
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCeConnection myConnection = new SqlCeConnection();
            myConnection.ConnectionString = @"Data Source=" + Application.StartupPath + "\\scheduleDB.sdf";
            SqlCeCommand mycommand = new SqlCeCommand();
            mycommand.Connection = myConnection;

            mycommand.CommandText = "INSERT into [student](name,family,studentNum,teacher,systemNum,startDate,endDate,cellphone,endOrNot,note) Values(@name,@family,@studentNum,@teacher,@systemNum,@startDate,@endDate,@cellphone,@endOrNot,@note)";
            mycommand.Parameters.AddWithValue("@name", nameTextBox.Text);
            mycommand.Parameters.AddWithValue("@family", familyTextBox.Text);
            mycommand.Parameters.AddWithValue("@studentNum", studentNumTextBox.Text);
            mycommand.Parameters.AddWithValue("@teacher", teacherTextBox.Text);
            mycommand.Parameters.AddWithValue("@systemNum", systemNumTextBox.Text);
            mycommand.Parameters.AddWithValue("@startDate", startDateTextBox.Text);
            mycommand.Parameters.AddWithValue("@endDate", endDateTextBox.Text);
            mycommand.Parameters.AddWithValue("@cellphone", cellphoneTextBox.Text);
            mycommand.Parameters.AddWithValue("@endOrNot", endOrNotcheckBox.Checked);
            mycommand.Parameters.AddWithValue("@note", noteTextBox.Text);

            //ما باید سرچ کنیم ببینیم فلان نام سیستم که زدیم آیا در دیتا بیس بدون تیک-استفاده
            //است یا خیر، بنابراین یه تابع سرچ با ورودی تکست باکس  شماره سیستم نیاز داریم


            myConnection.Open();
            mycommand.ExecuteNonQuery();
            myConnection.Close();

            searchDB();

            MessageBox.Show("ثبت با موفقیت انجام شد");
            DateTime temp = DateTime.Now;

            nameTextBox.Text = string.Empty;
            familyTextBox.Text = string.Empty;
            studentNumTextBox.Text = string.Empty;
            teacherTextBox.Text = string.Empty;
            systemNumTextBox.Text = string.Empty;
            startDateTextBox.Text = Extentions.ConvertDate.ToPersianDateString(temp).ToString();
            endDateTextBox.Text = string.Empty;
            cellphoneTextBox.Text = string.Empty;
            noteTextBox.Text = string.Empty;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            searchDB();

            TimeSpan ts1, sum;
            sum = TimeSpan.Zero;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    ts1 = Convert.ToDateTime(dataGridView1.Rows[i].Cells["endDateColumn"].Value) - Convert.ToDateTime(dataGridView1.Rows[i].Cells["startDateColumn"].Value);
                    sum = ts1 + sum;
                }
                catch
                {
                    MessageBox.Show("احتمالا نوع تاریخ اشتباه است");
                }

            }
            label10.Text = sum.TotalDays.ToString();
            //  label10.Text = dataGridView1.Rows.Count.ToString();

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            DateTime temp = DateTime.Now;
            startDateTextBox.Text = Extentions.ConvertDate.ToPersianDateString(temp).ToString();   //زمان اکنون روی این قسمت زده شود



        }
    }
}
