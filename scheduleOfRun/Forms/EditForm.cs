using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using scheduleOfRun.Extentions;


namespace scheduleOfRun.Forms
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        #region properties
        public int Id { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public int studentNum { get; set; }
        public string teacher { get; set; }
        public string systemNum { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string cellphone { get; set; }
        public string note { get; set; }
        public bool endOrNot { get; set; }

        #endregion


        private void EditForm_Load(object sender, EventArgs e)
        {
            //try
            //{
            nameTextBox.Text = name;
            familyTextBox.Text = family;
            studentNumTextBox.Text = studentNum.ToString();
            teacherTextBox.Text = teacher;
            systemNumTextBox.Text = systemNum;
            // startDateTime.Value = Convert.ToDateTime(startDate);
            // endDateTime.Value = Convert.ToDateTime(endDate);


            startDateTextBox.Text = startDate.ToString();
            endDateTextBox.Text = endDate.ToString();

            cellphoneTextBox.Text = cellphone;
            noteTextBox.Text = note;
            endOrNotcheckBox.Checked = endOrNot;
            //    }
            //    catch
            //    {
            //        MessageBox.Show("!!!!!!! تاریخ یا آرگومان دیگری اشتباه است،حتما چک کنید", "!!!! هشداررر");
            //    }

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            SqlCeConnection myconnection = new SqlCeConnection();
            myconnection.ConnectionString = @"Data Source=" + Application.StartupPath + "\\scheduleDB.sdf";
            SqlCeCommand mycommand = new SqlCeCommand();
            mycommand.Connection = myconnection;

            mycommand.CommandText = "update [student] set [name]=@name,family=@family,studentNum=@studentNum,teacher=@teacher,systemNum=@systemNum,startDate=@startDate,endDate=@endDate,cellphone=@cellphone,note=@note,endOrNot=@endOrNot where Id=@Id ";
            mycommand.Parameters.AddWithValue("@name", nameTextBox.Text);
            mycommand.Parameters.AddWithValue("@family", familyTextBox.Text);
            mycommand.Parameters.AddWithValue("@studentNum", studentNumTextBox.Text);
            mycommand.Parameters.AddWithValue("@teacher", teacherTextBox.Text);
            mycommand.Parameters.AddWithValue("@systemNum", systemNumTextBox.Text);
            mycommand.Parameters.AddWithValue("@startDate", startDateTextBox.Text);
            mycommand.Parameters.AddWithValue("@endDate", endDateTextBox.Text);
            mycommand.Parameters.AddWithValue("@cellphone", cellphoneTextBox.Text);
            mycommand.Parameters.AddWithValue("@note", noteTextBox.Text);
            mycommand.Parameters.AddWithValue("@endOrNot", endOrNotcheckBox.Checked);
            mycommand.Parameters.AddWithValue("@Id", Id);

            myconnection.Open();
            mycommand.ExecuteNonQuery();
            myconnection.Close();

            MessageBox.Show("عملیات با موفقیت به پایان رسید");
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //if ("sdsf".Contains("d"))
            //{
            //    Application.Exit();
            //}    //چرا ارور میده ؟؟؟؟
        }

        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();   //چرا ارور می ده؟؟
        }
    }
}
