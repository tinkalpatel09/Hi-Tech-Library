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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btnchangepassword_Click(object sender, EventArgs e)
        {
            User user = new User();
       

            user = user.Getpassword(Convert.ToInt32(textBox1.Text.Trim()));
            MessageBox.Show(user.PassWord + "\n" + user.UserId);
            if (user.UserId.ToString() == textBox1.Text.Trim() && user.PassWord == textBox2.Text)
            {
               // MessageBox.Show("Hello word");
                user.NewPassword = textBox3.Text.Trim();
                user.UpdataPsw(user);
            }
            else
            {
                MessageBox.Show("Check your Id and Psw");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
