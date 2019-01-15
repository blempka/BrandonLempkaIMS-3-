using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BrandonLempkaIMS
{
    public static class Validation
    {
        public static bool ValidateNumeric(TextBox testText, Button btnSave)
        {
            int i;
            var testCase = int.TryParse(testText.Text, out i);
            if (testCase == false || string.IsNullOrWhiteSpace(testText.Text))
            {
                testText.BackColor = Color.Salmon;
                //btnSave.Enabled = false;
                return false;
            }
            else
            {
                testText.BackColor = Color.White;
                //btnSave.Enabled = true;
                return true;
            }

        }

        public static bool ValidateString(TextBox testText, Button btnSave)
        {
            if (string.IsNullOrWhiteSpace(testText.Text))
            {
                testText.BackColor = Color.Salmon;
                //btnSave.Enabled = false;
                return false;
            }
            else
            {
                testText.BackColor = Color.White;
                //btnSave.Enabled = true;
                return true;
            }
        }
        public static bool ValidateAllNumeric(TextBox testText, Button btnSave)
        {
            int i;
            var testCase = int.TryParse(testText.Text, out i);
            if (testCase == false || string.IsNullOrWhiteSpace(testText.Text))
            {
                //btnSave.Enabled = false;
                return false;
            }
            else
            {
                //btnSave.Enabled = true;
                return true;
            }

        }

        public static bool ValidateAllString(TextBox testText, Button btnSave)
        {
            if (string.IsNullOrWhiteSpace(testText.Text))
            {
                //btnSave.Enabled = false;
                return false;
            }
            else
            {
                //btnSave.Enabled = true;
                return true;
            }
        }
    }
}
