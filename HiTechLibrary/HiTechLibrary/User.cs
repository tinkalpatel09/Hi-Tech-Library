using HiTechLibrary.Business;
using HiTechLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechLibrary;


namespace HiTechLibrary.Business
{
    public class User
    {
        int userId;
        string firstName;
        string lastName;
        string jobTitle;
        string passWord;
        string newPassword;

        public int UserId { get => userId; set => userId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string NewPassword { get => newPassword; set => newPassword = value; }

        public bool IsUniqueUserId(int id)
        {
            return (UserDB.IsUniqueId(id));
        }

        public string Toupper(string input)
        {
            return (UserDB.FirstCharToupper(input));
        }
        public void AddUserInfo(User user)
        {
            UserDB.AddUser(user);
        }
        public User Getpassword(int id)
        {
            return (UserDB.GetPassword(id));
        }

        public void UpdataPsw(User user)
        {
            UserDB.UpdataPasword(user);
        }

        public User GetNewPassword(int id)
        {
            return (UserDB.GetNewPassword(id));
        }

  
        public void UpdataUser(User user)
        {
            UserDB.UpdataUser(user);
        }

        public List<User> GetAllUser()
        {
            return (UserDB.GetRecordList());
        }

        public User SearchById(int id)
        {
            return (UserDB.SearchUser(id));
        }

        public List<User> SearchBytext(string text)
        {
            return (UserDB.SearchUserList(text));
        }

        public void DeleteUser(int id)
        {
            UserDB.DeleteUser(id);
        }
        public void CreatePassword()
        {
            UserDB.CreatePassword();
        }

      

    }

}
namespace HiTechLibrary.DataAccess
{
    public class UserDB
    {
        public static void AddUser(User user)
        {

            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "INSERT INTO Users (UserId,FirstName,LastName,JobTitle)" +
                "VALUES(@UserId,@FirstName,@LastName,@JobTitle)";
            cmd.Parameters.AddWithValue("@UserId", user.UserId);
            cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
            cmd.Parameters.AddWithValue("@LastName", user.LastName);
            cmd.Parameters.AddWithValue("@JobTitle", user.JobTitle);
            cmd.ExecuteNonQuery();
            connDB.Close();

        }

        public static void CreatePassword()
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "UPDATE Users " +
                              "SET Password= CONCAT(SUBSTRING(FirstName,1,1), LastName)";

            cmd.ExecuteNonQuery();
            connDB.Close();

        }
        
        public static User GetNewPassword(int id)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "SELECT UserId, NewPassword from Users where UserId = @UserId";
            cmd.Parameters.AddWithValue("@UserId", id);
            SqlDataReader reader = cmd.ExecuteReader();
            User user = new User();

            if (reader.Read())
            {

                user.UserId = Convert.ToInt32(reader["UserId"]);
                user.NewPassword = reader["NewPassword"].ToString();
            }

            else
            {
                user = null;
            }
            reader.Close();
            connDB.Close();
            return user;
        }
        public static User GetPassword(int id)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            User user = new User();
            cmd.Connection = connDB;
            cmd.CommandText = "SELECT UserId, Password FROM Users " +
                            "WHERE UserId = @UserId ";
            cmd.Parameters.AddWithValue("@UserId", id);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                user.UserId = Convert.ToInt32(reader["UserId"]);
                user.PassWord = Convert.ToString(reader["Password"]);

            }
            else
            {
                user = null;
            }

            reader.Close();
            connDB.Close();
            return user;
        }

        public static void UpdataUser(User user)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connDB;
            cmd.CommandText = "Update Users " +
                              "SET FirstName= @FirstName, " +
                              "LastName= @LastName, " +
                              "JobTitle= @JobTitle " +
                              "WHERE UserId=@UserId";

            cmd.Parameters.AddWithValue("@UserId", user.UserId);
            cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
            cmd.Parameters.AddWithValue("@LastName", user.LastName);
            cmd.Parameters.AddWithValue("@JobTitle", user.JobTitle);

            cmd.ExecuteNonQuery();
            connDB.Close();
        }

        public static void UpdataPasword(User user)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "UPDATE Users " +
                              "SET NewPassword= @NewPassword where UserId= @UserId";
            cmd.Parameters.AddWithValue("@UserId", user.UserId);
            cmd.Parameters.AddWithValue("@NewPassword", user.NewPassword);

            cmd.ExecuteNonQuery();
            connDB.Close();
        }

        public static List<User> GetRecordList()
        {
            List<User> listUser = new List<User>();
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmb = new SqlCommand("SELECT * FROM Users", connDB);
            SqlDataReader reader = cmb.ExecuteReader();//check table have databas inside
            User user;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = new User();//create the object here,not outside
                    user.UserId = Convert.ToInt32(reader["UserId"]);
                    user.FirstName = reader["FirstName"].ToString();
                    user.LastName = reader["LastName"].ToString();
                    user.JobTitle = reader["JobTitle"].ToString();
                    listUser.Add(user);
                }
            }
            else
            {
                listUser = null;
            }
            reader.Close();
            connDB.Close();
            return listUser;
        }

        public static User SearchUser(int id)
        {
            User user = new User();
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "SELECT * FROM Users " +
                            "WHERE UserId = @UserId ";
            cmd.Parameters.AddWithValue("@UserId", id);


            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                user.UserId = Convert.ToInt32(reader["UserId"]);
                user.FirstName = Convert.ToString(reader["FirstName"]);
                user.LastName = Convert.ToString(reader["LastName"]);
                user.JobTitle = Convert.ToString(reader["JobTitle"]);
            }
            else
            {
                user = null;
            }
            reader.Close();
            connDB.Close();
            return user;
        }

        public static List<User> SearchUserList(string text)
        {
            List<User> ListUser = new List<User>();
            List<User> listTmp = new List<User>();

            User user = new User();

            ListUser = user.GetAllUser();

            User userTmp;

            if (ListUser != null)
            {
                foreach (User oneUser in ListUser)
                {
                    if (text.ToUpper() == oneUser.FirstName.ToUpper() || text.ToUpper() == oneUser.LastName.ToUpper() || text.ToUpper() == oneUser.JobTitle.ToUpper())
                    {
                        userTmp = new User();
                        userTmp.UserId = Convert.ToInt32(oneUser.UserId);
                        userTmp.FirstName = oneUser.FirstName;
                        userTmp.LastName = oneUser.LastName;
                        userTmp.JobTitle = oneUser.JobTitle;

                        listTmp.Add(userTmp);
                    }
                }
            }
            return listTmp;

        }

        public static void DeleteUser(int id)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "DELETE FROM Users WHERE UserId=@UserId";
            cmd.Parameters.AddWithValue("@UserId", id);
            cmd.ExecuteNonQuery();
            connDB.Close();
        }

        public static string FirstCharToupper(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;
            string str = input.First().ToString().ToUpper() + input.Substring(1);

            return str;
        }

        public static bool IsUniqueId(int tempid)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "SELECT * FROM Users " +
                            "WHERE UserId = " + tempid;
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            if (id != 0)
            {
                connDB.Close();
                return false;
            }
            return true;
        }
    }
}
