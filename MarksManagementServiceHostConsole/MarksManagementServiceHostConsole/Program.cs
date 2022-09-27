using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MarksManagementServiceHostConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri http = new Uri("http://localhost:8000/MarksManageService");

            using (ServiceHost host = new ServiceHost(typeof(MarksManagementLibrary.MarksManageService), http))
            {
                host.Open();
                Console.WriteLine("Telephone directory service Started");
                Console.ReadLine();
            }
        }
    }
}
