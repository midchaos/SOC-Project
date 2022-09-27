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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void confirmaddmarks_Click(object sender, EventArgs e)
        {
            ServiceReference1.MarksRecords marks = new ServiceReference1.MarksRecords();
            marks.UserID = Form1.CID;
            marks.Semester = (int)sem_a.Value;
            marks.Subject1 = (int)sub1_a.Value;
            marks.Subject2 = (int)sub2_a.Value;
            marks.Subject3 = (int)sub3_a.Value;

            string result = Form1.proxy.AddMarks(marks);

            if (result == null)
            {
                MessageBox.Show("Invalid Updation");
            }
            else
            {
                Form1.myMarks = Form1.proxy.SearchByID(Form1.CID);
                MessageBox.Show(result);
            }
        }
    }
}
