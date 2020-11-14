using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiTechLibrary.DataAccess;
using System.Data.SqlClient;
using HiTechLibrary.Business;
using HiTechOrderApp.GUI;


namespace HiTechOrderApp.GUI
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void buttonCreatePsw_Click(object sender, EventArgs e)
        {
            User user = new User();
            MessageBox.Show("Create PSW sucessfully", "Create Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            user.CreatePassword();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string input;
            HiTechLibrary.Business.User user= new User();

            input = textBoxUserID.Text.Trim();
            if (!Validation.IsValidId(input, 4))
            {
                textBoxUserID.Clear();
                textBoxUserID.Focus();
                return;
            }
            int tempID = Convert.ToInt32(textBoxUserID.Text.Trim());
            if (!(HiTechOrderApp.GUI.Validation.IsValidId(tempID.ToString())))
            {

                MessageBox.Show("This User ID already exists!", "Duplicate User ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            input = textBoxUserFirstName.Text.Trim();
            if (!Validation.IsValidName(input))
            {
                textBoxUserFirstName.Clear();
                textBoxUserFirstName.Focus();
                return;
            }

            input = textBoxUserLastName.Text.Trim();
            if (!Validation.IsValidName(input))
            {
                textBoxUserLastName.Clear();
                textBoxUserLastName.Focus();
                return;
            }

            input = textBoxUserJobTitle.Text.Trim();
            if (!Validation.IsValidName(input))
            {
                textBoxUserJobTitle.Clear();
                textBoxUserJobTitle.Focus();
                return;
            }

            user.UserId = Convert.ToInt32(textBoxUserID.Text.Trim());
            user.FirstName = user.Toupper(textBoxUserFirstName.Text.Trim());
            user.LastName = user.Toupper(textBoxUserLastName.Text.Trim());
            user.JobTitle = user.Toupper(textBoxUserJobTitle.Text.Trim());
            user.AddUserInfo(user);
            MessageBox.Show("User record has been saved", "User Saved", MessageBoxButtons.OK);

            //MessageBox.Show("This User ID already exists!");

            textBoxUserID.Clear();
            textBoxUserFirstName.Clear();
            textBoxUserLastName.Clear();
            textBoxUserJobTitle.Clear();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            User user = new User();
            user.UserId = Convert.ToInt32(textBoxUserID.Text.Trim());
            user.FirstName = textBoxUserFirstName.Text.Trim();
            user.LastName = textBoxUserLastName.Text.Trim();
            user.JobTitle = textBoxUserJobTitle.Text.Trim();

            user.UpdataUser(user);
            MessageBox.Show("User Record updataed sucessfully", "Updata Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxUserID.Clear();
            textBoxUserFirstName.Clear();
            textBoxUserLastName.Clear();
            textBoxUserJobTitle.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to delete the User record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                User user = new User();
                try
                {
                    user.DeleteUser(Convert.ToInt32(textBoxUserID.Text));
                    MessageBox.Show("User Record delete sucessfully", "delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ei)
                {
                    MessageBox.Show(ei.ToString());
                }

            }
            else
            {
                return;
            }
            textBoxUserID.Clear();
            textBoxUserFirstName.Clear();
            textBoxUserLastName.Clear();
            textBoxUserJobTitle.Clear();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int selectdIndex = comboBox1.SelectedIndex;
            switch (selectdIndex)
            {
                case 1: //search by User id
                    {
                        if (!(Validation.IsValidId(textBox1Input.Text.Trim())))
                        {
                            textBox1Input.Clear();
                            textBox1Input.Focus();
                            return;
                        }
                        User user = new User();
                        user = user.SearchById(Convert.ToInt32(textBox1Input.Text.Trim()));
                        if (user != null)
                        {
                            textBox1Input.Clear();
                            textBoxUserID.Text = user.UserId.ToString();
                            textBoxUserFirstName.Text = user.FirstName;
                            textBoxUserLastName.Text = user.LastName;
                            textBoxUserJobTitle.Text = user.JobTitle;
                        }
                        else
                        {
                            textBoxUserID.Clear();
                            textBoxUserFirstName.Clear();
                            textBoxUserLastName.Clear();
                            textBoxUserJobTitle.Clear();
                            textBox1Input.Clear();
                            MessageBox.Show("User record not found", "Error", MessageBoxButtons.OK);
                        }
                        break;
                    }
                case 2://search by first name
                    {
                        if (!(Validation.IsValidName(textBox1Input.Text.Trim())))
                        {
                            textBox1Input.Clear();
                            textBox1Input.Focus();
                            return;
                        }
                        User temUser = new User();
                        List<User> listTemp = temUser.SearchBytext(textBox1Input.Text.Trim());
                        listViewEmployeeTable.Items.Clear();
                        if (listTemp != null)
                        {
                            foreach (User oneUser in listTemp)
                            {
                                ListViewItem item = new ListViewItem(oneUser.UserId.ToString());
                                item.SubItems.Add(oneUser.FirstName);
                                item.SubItems.Add(oneUser.LastName);
                                item.SubItems.Add(oneUser.JobTitle);
                                listViewEmployeeTable.Items.Add(item);
                            }

                        }
                        else
                        {
                            textBox1Input.Clear();
                            MessageBox.Show("User record not found", "Error", MessageBoxButtons.OK);

                        }

                        break;
                    }
                case 3://search by last name
                    {
                        if (!(Validation.IsValidName(textBox1Input.Text.Trim())))
                        {
                            textBox1Input.Clear();
                            textBox1Input.Focus();
                            return;
                        }
                        User tempEmp2 = new User();
                        List<User> listTemp2 = tempEmp2.SearchBytext(textBox1Input.Text.Trim());
                        listViewEmployeeTable.Items.Clear();
                        if (listTemp2 != null)
                        {
                            foreach (User oneUser in listTemp2)
                            {
                                ListViewItem item = new ListViewItem(oneUser.UserId.ToString());
                                item.SubItems.Add(oneUser.FirstName);
                                item.SubItems.Add(oneUser.LastName);
                                item.SubItems.Add(oneUser.JobTitle);
                                listViewEmployeeTable.Items.Add(item);
                            }

                        }
                        else
                        {
                            textBox1Input.Clear();
                            MessageBox.Show("User record not found", "Error", MessageBoxButtons.OK);
                        }

                        break;
                    }
                case 4:
                    {
                        if (!Validation.IsValidName(textBox1Input.Text.Trim()))
                        {
                            textBox1Input.Clear();
                            textBox1Input.Focus();
                            return;
                        }
                        User tmpEmp3 = new User();
                        List<User> listTmp3 = tmpEmp3.SearchBytext(textBox1Input.Text.Trim());
                        listViewEmployeeTable.Items.Clear();
                        if (listTmp3 != null)
                        {
                            foreach (User oneEmp in listTmp3)
                            {
                                ListViewItem item = new ListViewItem(oneEmp.UserId.ToString());
                                item.SubItems.Add(oneEmp.FirstName);
                                item.SubItems.Add(oneEmp.LastName);
                                item.SubItems.Add(oneEmp.JobTitle);
                                listViewEmployeeTable.Items.Add(item);
                            }
                        }
                        else
                        {
                            textBox1Input.Clear();
                            MessageBox.Show("User record not found", "Error", MessageBoxButtons.OK);
                        }

                        break;
                    }

                default:
                    break;
            }

        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            listViewEmployeeTable.Items.Clear();
            User user = new User();
            List<User> listUser = user.GetAllUser();

            if (listUser != null)
            {
                foreach (User useritem in listUser)
                {
                    ListViewItem item = new ListViewItem(useritem.UserId.ToString());
                    item.SubItems.Add(useritem.FirstName);
                    item.SubItems.Add(useritem.LastName);
                    item.SubItems.Add(useritem.JobTitle);
                    listViewEmployeeTable.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No User data in the databasse", "Not User data", MessageBoxButtons.OK);

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelected = comboBox1.SelectedIndex;  // to select context in the list

            switch (indexSelected)
            {
                case 1: //search by User ID
                    label6.Text = "Please enter User id";
                    textBox1Input.Clear();
                    textBox1Input.Focus();

                    break;
                case 2: //search by First name
                    label6.Text = "Please enter first name";
                    textBox1Input.Clear();
                    textBox1Input.Focus();
                    break;
                case 3: // search by last name
                    label6.Text = "Please enter last name";
                    textBox1Input.Clear();
                    textBox1Input.Focus();
                    break;
                case 4: // search by job title
                    label6.Text = "Please enter job title";
                    textBox1Input.Clear();
                    textBox1Input.Focus();
                    break;
                default:
                    break;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
