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
    public partial class AboutHiTech : Form
    {
        public AboutHiTech()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            ManagerLoginForm manager = new  ManagerLoginForm();
            manager.ShowDialog();
          
        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void labelProductName_Click(object sender, EventArgs e)
        {

        }

        private void labelVersion_Click(object sender, EventArgs e)
        {

        }

        private void labelCopyright_Click(object sender, EventArgs e)
        {

        }

        private void labelCompanyName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
