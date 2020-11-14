using HiTechLibrary.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiTechOrderApp.GUI
{
    public partial class ManagerLoginForm : Form
    {
        public ManagerLoginForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxEmployeeID.Text.Trim());
            string password = textBoxPassWord.Text;

            User user = new User();

            user = user.GetNewPassword(id);




            if (id == 1111 && password == "12345")
            {
                
                EmployeeandUserForm employeeAndUser = new EmployeeandUserForm();
                //MessageBox.Show(user.NewPassword);
                employeeAndUser.ShowDialog();

            }
            else
            {
                MessageBox.Show("you can not login...only MIS Manager can login ");
            }
        }

        private void btnChangepass_Click(object sender, EventArgs e)
        {
            
            ChangePasswordForm changePsw = new ChangePasswordForm();

            changePsw.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
