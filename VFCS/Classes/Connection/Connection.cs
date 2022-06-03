using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VFCS
{
    public class Connection
    {
        static string DBUserConID = "Ilya";
        static string DBUserConPassword = "cefooK4co";
        //internal static string ConnectionStr = @"Data Source=MSSQLSTUD;Initial Catalog=Marathon_Revkin;User ID=9po11-18-18;Password=cefooK4co;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        internal static string ConnectionStr = @"Data Source = PC\EX;Initial Catalog = NewDB; User ID =" + DBUserConID +";Password="+ DBUserConPassword + ";Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        internal static SqlConnection connection = new SqlConnection(ConnectionStr);

        internal static int userEmployeeId = 0;
        internal static string userRole = "";
        //internal static int adminId = 0;
    }
}
