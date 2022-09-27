using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarksManagementClient
{
    public partial class Form1 : Form
    {
        public static string CID;
        private string Username;
        public static ServiceReference1.MarksRecords[] myMarks;
        public static ServiceReference1.MarksManageServiceClient proxy;
        List<Panel> listPanel = new List<Panel>();
        int index ;

        public Form1()
        {
            InitializeComponent();
            index = 0;
            proxy = new ServiceReference1.MarksManageServiceClient();
            listPanel.Add(Page1);
            listPanel.Add(Page2);
            listPanel.Add(Page3);
            listPanel.Add(Page4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0;
            for(i=0;i<4;i++)
            {
                listPanel[i].Visible = false;
            }
            listPanel[index].Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void SU_Click(object sender, EventArgs e)
        {
            ServiceReference1.UserDetails user = new ServiceReference1.UserDetails();

            string pass = Password_SU.Text;
            string pass2 = Password2_SU.Text;

            if (pass == pass2)
            {
                user.UserID = CID_SU.Text;
                user.UserName = Name_SU.Text;
                user.Password = pass;

                if (proxy.Register(user))
                {
                    CID = CID_SU.Text;
                    index = 1;
                }
                else
                {
                    listView1.Items.Clear();
                    index = 0;
                    MessageBox.Show("Already Registered! Try Logging in.");
                }

            }
            else
            {
                listView1.Items.Clear();
                index = 0;
                MessageBox.Show("Passwords don't match.");
            }
        }

        private void LI_Click(object sender, EventArgs e)
        {
            string ID = CID_LI.Text;
            string Password = Password_LI.Text;
            Username = proxy.Login(ID, Password);

            if (Username != null)
            {
                CID = ID;
                myMarks = proxy.SearchByID(CID);

                listView1.Items.Clear();
                foreach (var marksRecord in myMarks)
                {
                    var row = new string[] { marksRecord.Semester.ToString(), marksRecord.Subject1.ToString(), marksRecord.Subject2.ToString(), marksRecord.Subject3.ToString() };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = marksRecord;
                    listView1.Items.Add(lvi);
                }
                index = 1;
            }
            else
            {
                listView1.Items.Clear();
                index = 0;
                MessageBox.Show("Invaid Credentials..");
            }
            index = 0;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string search_ID = SearchID.Text;
            ServiceReference1.MarksRecords[] Marks;
            Marks = proxy.SearchByID(search_ID);
            if(Marks==null)
            {
                listView1.Items.Clear();
            }
            else { 
            listView1.Items.Clear();
            foreach (var marksRecord in Marks)
            {
                var row = new string[] { marksRecord.Semester.ToString(), marksRecord.Subject1.ToString(), marksRecord.Subject2.ToString(), marksRecord.Subject3.ToString() };
                var lvi = new ListViewItem(row);
                lvi.Tag = marksRecord;
                listView1.Items.Add(lvi);
            }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int delete_sem = (int)DelSem.Value;

            proxy.DeleteMarksRecordBySem(CID, delete_sem);
            myMarks = proxy.SearchByID(CID);

            listView1.Items.Clear();
            foreach (var marksRecord in myMarks)
            {
                var row = new string[] { marksRecord.Semester.ToString(), marksRecord.Subject1.ToString(), marksRecord.Subject2.ToString(), marksRecord.Subject3.ToString() };
                var lvi = new ListViewItem(row);
                lvi.Tag = marksRecord;
                listView1.Items.Add(lvi);
            }
            index = 1;

            MessageBox.Show("Record deleted successfully");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int sem = (int)sem_u.Value;
            int sub = (int)sub_u.Value;
            int mar = (int)mar_u.Value;

            string result = proxy.UpdateMarks(CID, sem, sub, mar);

            if (result == null)
            {
                MessageBox.Show("Invalid Updation");
            }
            else
            {
                myMarks = proxy.SearchByID(CID);

                listView1.Items.Clear();
                foreach (var marksRecord in myMarks)
                {
                    var row = new string[] { marksRecord.Semester.ToString(), marksRecord.Subject1.ToString(), marksRecord.Subject2.ToString(), marksRecord.Subject3.ToString() };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = marksRecord;
                    listView1.Items.Add(lvi);
                }
                index = 1;
                MessageBox.Show(result);
            }


        }

        private void addmarks_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void BackHome_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        
    }
}
