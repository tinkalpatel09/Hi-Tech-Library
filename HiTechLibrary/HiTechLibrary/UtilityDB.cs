using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HiTechLibrary.DataAccess
{
    class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {

            SqlConnection connDB = new SqlConnection();
            connDB.ConnectionString = "server= DESKTOP-PM122L9;database=HI-Tech;" +
                "user=SA;password=1234";
            connDB.Open();

            return connDB;

        }
    }
}


//connectionString="Data Source=DESKTOP-PM122L9;Initial Catalog=CollageDB;User ID=SA;Password=1234"