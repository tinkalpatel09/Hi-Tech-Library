using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HiTechLibrary.Business;
using HiTechLibrary.DataAccess;
using HiTechLibrary.DataAcces;

namespace HiTechLibrary.Business
{
   public class Employee
    {
       
            int employeeId;
            string firstName;
            string lastName;
            string jobTitle;

            public int EmployeeId { get => employeeId; set => employeeId = value; }
            public string FirstName { get => firstName; set => firstName = value; }
            public string LastName { get => lastName; set => lastName = value; }
            public string JobTitle { get => jobTitle; set => jobTitle = value; }

        public void AddEmployee(Employee emp)
        {
            EmployeeDB.AddEmployee(emp);
        }

        public void UpdataEmployee(Employee emp)
        {
            EmployeeDB.UpdataEmployee(emp);
        }

        public Employee SearchByID(int id)
        {
            return (EmployeeDB.SearchEmployee(id));
        }

        public List<Employee> GetemployeeList()
        {
            return (EmployeeDB.GetRecordList());
        }

        public List<Employee> SearchBytext(string text)
        {
            return (EmployeeDB.SearchEmployeeList(text));
        }

        public bool IsUniqueEmployeeId(int empId)
        {
            return (EmployeeDB.IsUniqueId(empId));
        }

        public void DelectEmployee(int id)
        {
            EmployeeDB.DeleteEmployee(id);
        }

        public string Toupper(string input)
        {
            return (EmployeeDB.FirstCharToupper(input));
        }




    }


}

namespace HiTechLibrary.DataAcces
{
    public class EmployeeDB
    {
        public static void AddEmployee(Employee emp)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connDB;
            cmd.CommandText = "INSERT INTO Employees " +
                               "VALUES (" + emp.EmployeeId +
                               ", '" +
                               emp.FirstName +
                               "','" +
                               emp.LastName +
                               "','" +
                               emp.JobTitle +
                               "')";

            cmd.ExecuteNonQuery();
            connDB.Close();
        }

        public static void UpdataEmployee(Employee emp)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connDB;
            cmd.CommandText = "Update Employees " +
                              "SET FirstName= @FirstName, " +
                              "LastName= @LastName, " +
                              "JobTitle= @JobTitle " +
                              "WHERE EmployeeID=@EmployeeID";

            cmd.Parameters.AddWithValue("@EmployeeID", emp.EmployeeId);
            cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmd.Parameters.AddWithValue("@LastName", emp.LastName);
            cmd.Parameters.AddWithValue("@JobTitle", emp.JobTitle);

            cmd.ExecuteNonQuery();
            connDB.Close();
        }

        public static Employee SearchEmployee(int id)
        {
            Employee emp = new Employee();
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "SELECT * FROM Employees " +
                            "WHERE EmployeeID = @EmployeeID ";
            cmd.Parameters.AddWithValue("@EmployeeID", id);


            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                emp.EmployeeId = Convert.ToInt32(reader["EmployeeID"]);
                emp.FirstName = Convert.ToString(reader["FirstName"]);
                emp.LastName = Convert.ToString(reader["LastName"]);
                emp.JobTitle = Convert.ToString(reader["JobTitle"]);
            }
            else
            {
                emp = null;
            }
            connDB.Close();
            return emp;
        }

        public static List<Employee> GetRecordList()
        {
            List<Employee> listEmp = new List<Employee>();
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmb = new SqlCommand("SELECT * FROM Employees", connDB);
            SqlDataReader reader = cmb.ExecuteReader();//check table have databas inside
            Employee emp;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    emp = new Employee();//create the object here,not outside
                    emp.EmployeeId = Convert.ToInt32(reader["EmployeeID"]);
                    emp.FirstName = reader["FirstName"].ToString();
                    emp.LastName = reader["LastName"].ToString();
                    emp.JobTitle = reader["JobTitle"].ToString();
                    listEmp.Add(emp);
                }
            }
            else
            {
                listEmp = null;
            }
            connDB.Close();
            return listEmp;
        }
        public static List<Employee> SearchEmployeeList(string text)
        {
            List<Employee> listEmp = new List<Employee>();
            List<Employee> listTmp = new List<Employee>();

            Employee emp = new Employee();

            listEmp = emp.GetemployeeList();

            Employee empTmp;

            if (listEmp != null)
            {
                foreach (Employee oneEmp in listEmp)
                {
                    if (text.ToUpper() == oneEmp.FirstName.ToUpper() || text.ToUpper() == oneEmp.LastName.ToUpper() || text.ToUpper() == oneEmp.JobTitle.ToUpper())
                    {
                        empTmp = new Employee();
                        empTmp.EmployeeId = Convert.ToInt32(oneEmp.EmployeeId);
                        empTmp.FirstName = oneEmp.FirstName;
                        empTmp.LastName = oneEmp.LastName;
                        empTmp.JobTitle = oneEmp.JobTitle;

                        listTmp.Add(empTmp);
                    }
                }
            }
            return listTmp;

        }

        public static void DeleteEmployee(int id)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "DELETE FROM Employees WHERE EmployeeID=@EmployeeID";
            cmd.Parameters.AddWithValue("@EmployeeID", id);
            cmd.ExecuteNonQuery();
            connDB.Close();
        }

        public static bool IsUniqueId(int tempid)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "SELECT * FROM Employees " +
                            "WHERE EmployeeID = " + tempid;
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            if (id != 0)
            {
                connDB.Close();
                return false;
            }
            return true;
        }

        public static string FirstCharToupper(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;
            string str = input.First().ToString().ToUpper() + input.Substring(1);

            return str;
        }

    }
}
