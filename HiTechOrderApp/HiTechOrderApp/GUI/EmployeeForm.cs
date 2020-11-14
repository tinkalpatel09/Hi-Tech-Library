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
using HiTechOrderApp.GUI;
using HiTechLibrary.Business;
//using HiTechLibrary.Business;
//using HiTechOrderApp.GUI;

namespace HiTechOrderApp
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelected = comboBox1.SelectedIndex;  // to select context in the list

            switch (indexSelected)
            {
                case 1: //search by Employee ID
                    label6.Text = "Please enter Employee id";
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

        private void btnList_Click(object sender, EventArgs e)
        {
            listViewEmployeeTable.Items.Clear();
            Employee emp = new Employee();
            List<Employee> listEmp = emp.GetemployeeList();

            if (listEmp != null)
            {
                foreach (Employee empItem in listEmp)
                {
                    ListViewItem item = new ListViewItem(empItem.EmployeeId.ToString());
                    item.SubItems.Add(empItem.FirstName);
                    item.SubItems.Add(empItem.LastName);
                    item.SubItems.Add(empItem.JobTitle);
                    listViewEmployeeTable.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No employee data in the databasse", "Not Employee data", MessageBoxButtons.OK);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int selectdIndex = comboBox1.SelectedIndex;
            switch (selectdIndex)
            {
                case 1: //search by employee id
                    {
                        if (!(Validation.IsValidId(textBox1Input.Text.Trim())))
                        {
                            textBox1Input.Clear();
                            textBox1Input.Focus();
                            return;
                        }
                        Employee emp = new Employee();
                        emp = emp.SearchByID(Convert.ToInt32(textBox1Input.Text.Trim()));
                        if (emp != null)
                        {
                            textBox1Input.Clear();
                            textBoxEmpID.Text = emp.EmployeeId.ToString();
                            textBoxFirstName.Text = emp.FirstName;
                            textBoxLastName.Text = emp.LastName;
                            textBoxJobTitle.Text = emp.JobTitle;
                        }
                        else
                        {
                            textBoxEmpID.Clear();
                            textBoxFirstName.Clear();
                            textBoxLastName.Clear();
                            textBoxJobTitle.Clear();
                            textBox1Input.Clear();
                            MessageBox.Show("Employee record not found", "Error", MessageBoxButtons.OK);
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
                        Employee tempEmp = new Employee();
                        List<Employee> listTemp = tempEmp.SearchBytext(textBox1Input.Text.Trim());
                        listViewEmployeeTable.Items.Clear();
                        if (listTemp != null)
                        {
                            foreach (Employee anEmp in listTemp)
                            {
                                ListViewItem item = new ListViewItem(anEmp.EmployeeId.ToString());
                                item.SubItems.Add(anEmp.FirstName);
                                item.SubItems.Add(anEmp.LastName);
                                item.SubItems.Add(anEmp.JobTitle);
                                listViewEmployeeTable.Items.Add(item);
                            }

                        }
                        else
                        {
                            textBox1Input.Clear();
                            MessageBox.Show("Employee record not found", "Error", MessageBoxButtons.OK);

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
                        Employee tempEmp2 = new Employee();
                        List<Employee> listTemp2 = tempEmp2.SearchBytext(textBox1Input.Text.Trim());
                        listViewEmployeeTable.Items.Clear();
                        if (listTemp2 != null)
                        {
                            foreach (Employee anEmp in listTemp2)
                            {
                                ListViewItem item = new ListViewItem(anEmp.EmployeeId.ToString());
                                item.SubItems.Add(anEmp.FirstName);
                                item.SubItems.Add(anEmp.LastName);
                                item.SubItems.Add(anEmp.JobTitle);
                                listViewEmployeeTable.Items.Add(item);
                            }

                        }
                        else
                        {
                            textBox1Input.Clear();
                            MessageBox.Show("Employee record not found", "Error", MessageBoxButtons.OK);
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
                        Employee tmpEmp3 = new Employee();
                        List<Employee> listTmp3 = tmpEmp3.SearchBytext(textBox1Input.Text.Trim());
                        listViewEmployeeTable.Items.Clear();
                        if (listTmp3 != null)
                        {
                            foreach (Employee oneEmp in listTmp3)
                            {
                                ListViewItem item = new ListViewItem(oneEmp.EmployeeId.ToString());
                                item.SubItems.Add(oneEmp.FirstName);
                                item.SubItems.Add(oneEmp.LastName);
                                item.SubItems.Add(oneEmp.JobTitle);
                                listViewEmployeeTable.Items.Add(item);
                            }
                        }
                        else
                        {
                            textBox1Input.Clear();
                            MessageBox.Show("Employee record not found", "Error", MessageBoxButtons.OK);
                        }

                        break;
                    }

                default:
                    break;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(textBoxEmpID.Text.Trim());
            emp.FirstName = textBoxFirstName.Text.Trim();
            emp.LastName = textBoxLastName.Text.Trim();
            emp.JobTitle = textBoxJobTitle.Text.Trim();

            emp.UpdataEmployee(emp);
            MessageBox.Show("Employee Record updataed sucessfully", "Updata Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxEmpID.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxJobTitle.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string input;
            Employee emp = new Employee();

            input = textBoxEmpID.Text.Trim();
            if (!Validation.IsValidId(input, 4))
            {
                textBoxEmpID.Clear();
                textBoxEmpID.Focus();
                return;
            }
            int tempID = Convert.ToInt32(textBoxEmpID.Text.Trim());
            if (!(emp.IsUniqueEmployeeId(tempID)))
            {

                MessageBox.Show("This Employee ID already exists!", "Duplicate Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            input = textBoxFirstName.Text.Trim();
            if (!Validation.IsValidName(input))
            {
                textBoxFirstName.Clear();
                textBoxFirstName.Focus();
                return;
            }

            input = textBoxLastName.Text.Trim();
            if (!Validation.IsValidName(input))
            {
                textBoxLastName.Clear();
                textBoxLastName.Focus();
                return;
            }

            input = textBoxJobTitle.Text.Trim();
            if (!Validation.IsValidName(input))
            {
                textBoxJobTitle.Clear();
                textBoxJobTitle.Focus();
                return;
            }
            try
            {
                emp.EmployeeId = Convert.ToInt32(textBoxEmpID.Text.Trim());
                emp.FirstName = emp.Toupper(textBoxFirstName.Text.Trim());
                emp.LastName = emp.Toupper(textBoxLastName.Text.Trim());
                emp.JobTitle = emp.Toupper(textBoxJobTitle.Text.Trim());
                emp.AddEmployee(emp);
                MessageBox.Show("Employee record has been saved", "Employee Saved", MessageBoxButtons.OK);
            }
            catch (Exception u)
            {
                //MessageBox.Show("This Employee ID already exists!");
            }

            textBoxEmpID.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxJobTitle.Clear();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to delete the employee record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                Employee emp = new Employee();
                try
                {
                    emp.DelectEmployee(Convert.ToInt32(textBoxEmpID.Text));
                    MessageBox.Show("Employee Record delete sucessfully", "delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            textBoxEmpID.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxJobTitle.Clear();
        }
    }
}
