using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace HiTechOrderApp.GUI
{
    public class Validation
    {
        public static bool IsValidId(string input)
        {
            if (!Regex.IsMatch(input, @"^\d{4}$"))
            {
                MessageBox.Show("Invalid Employee ID", "Invaild Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public static bool IsValidId(string input, int length)
        {
            if (!Regex.IsMatch(input, @"^\d{" + length + "}$"))
            {
                string error = "Employee ID must be " + length + "-digit number";
                MessageBox.Show(error, "Invaild Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool IsValidName(string input)
        {

            if (input.Length == 0)
            {

                MessageBox.Show("Name and Jod Tital must contain only letters or space ", "Invaild Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {

                    if (!(char.IsLetter(input[i]) && !(char.IsWhiteSpace(input[i]))))
                    {
                        MessageBox.Show("Name and Jod Tital must contain only letters or space ", "Invaild Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                }
                return true;
            }

        }
    }
}
