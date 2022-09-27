using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MarksManagementLibrary
{
    [ServiceContract]
    public interface IMarksManageService
    {
        [OperationContract]
        string Login(string ID, string password);

        [OperationContract]
        Boolean Register(UserDetails user);

        [OperationContract]
        string AddMarks(MarksRecords marks);

        [OperationContract]
        Boolean DeleteMarksRecordBySem(string ID,int sem);

        [OperationContract]
        string UpdateMarks(string ID,int sem, int subNo, int marks);

        [OperationContract]
        List<MarksRecords> SearchByID(string ID);

    }

    [DataContract]
    public class UserDetails
    {
        private string uid;
        private string uname;
        private string pwd;

        [DataMember]
        public string UserID
        {
            get { return uid; }
            set { uid = value; }
        }
        [DataMember]
        public string UserName
        {
            get { return uname; }
            set { uname = value; }
        }
        [DataMember]
        public string Password
        {
            get { return pwd; }
            set { pwd = value; }
        }
    }

    [DataContract]
    public class MarksRecords
    {
        private string uid;
        private int sem;
        private int sub1;
        private int sub2;
        private int sub3;

        [DataMember]
        public string UserID
        {
            get { return uid; }
            set { uid = value; }
        }
        [DataMember]
        public int Semester
        {
            get { return sem; }
            set { sem = value; }
        }
        [DataMember]
        public int Subject1
        {
            get { return sub1; }
            set { sub1 = value; }
        }
        [DataMember]
        public int Subject2
        {
            get { return sub2; }
            set { sub2 = value; }
        }
        [DataMember]
        public int Subject3
        {
            get { return sub3; }
            set { sub3 = value; }
        }
    }
}
