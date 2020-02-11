using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SYNDIC_1._0
{
    public static class StringHelper
    {

        /// <summary>
        /// Checks if the TextBox has text and returns true else returns false
        /// </summary>

        public static bool hasText(this TextBox textBoxName)
        {
            return String.IsNullOrWhiteSpace(textBoxName.Text);
        }

        /// <summary>
        /// Checks if a string is numeric and returns true else returns false
        /// </summary>

        public static bool IsNumeric(this string numeric) // => numeric.All(char.IsDigit);
        {
            if (String.IsNullOrWhiteSpace(numeric))
            {
                return false;
            }
            foreach (char character in numeric)
            {
                if (!char.IsDigit(character))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Allow only numeric variables to be typed in input fields 
        /// To be used <em>only</em> in the <em>KeyPress</em> event of the control
        /// </summary>

        public static void NumericOnly(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Checks if a number is phone number and returns true else returns false
        /// </summary>

        public static bool IsPhoneNumber(this string phoneNumber)
        {
            if (!String.IsNullOrWhiteSpace(phoneNumber) && IsNumeric(phoneNumber) && phoneNumber.Length == 10) // StartsWith(+212)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Allow only text (varchar) to be typed in input fields, does not return anything .
        /// To be used <em>only</em> in the <em>KeyPress</em> event of the control
        /// </summary>

        public static void TextOnly(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Determines if the <em>Pressed Key</em> is the <em>Enter</em> key and returns true, else returns false
        /// </summary>

        public static bool EnterIsPressed(KeyEventArgs e)
        {
            return (e.KeyCode.Equals(Keys.Enter));
        }

        /// <summary>
        /// Sets the state of the control to the one passed in parameters 
        /// </summary>
        /// <param name="control"></param>
        /// <param name="controlState"> Set to true if you want the control to be enabled, else set to false</param>

        public static void ResetControl(this Control control, bool controlState)
        {
            string controlName = control.GetType().Name;

            switch (controlName)
            {
                case "TextBox":
                    control.Text = string.Empty;
                    control.Enabled = controlState;
                    return;
                case "Button":
                    control.Enabled = controlState;
                    return;
                case "Panel":
                    control.Enabled = controlState;
                    return;
                case "GroupBox":
                    control.Enabled = controlState;
                    return;
                case "ComboBox":
                    control.Enabled = controlState;
                    return;
            }

        }




        public static Regex regEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        public static bool IsValidEmailFormat(string emailInput)
        {
            return regEmail.IsMatch(emailInput);
        }

        public static Regex regTele = new Regex(@"\+(9[976]\d|8[987530]\d|6[987]\d|5[90]\d|42\d|3[875]\d|2[98654321]\d|9[8543210]|8[6421]|6[6543210]|5[87654321]|4[987654310]|3[9643210]|2[70]|7|1)\W*\d\W*\d\W*\d\W*\d\W*\d\W*\d\W*\d\W*\d\W*(\d{1,2})$");

        public static bool IsValidPhoneNumberFormat(string PhoneNumberInput)
        {
            return regTele.IsMatch(PhoneNumberInput);
        }

        public static bool IsDateTime(this string date)
        {
            date = date.Trim();

            string[] dateTime = date.Split('/');


            if (dateTime.Length != 3)
            {
                return false;
            }

            int day = int.Parse(dateTime[0]);
            int month = int.Parse(dateTime[1]);
            int year = int.Parse(dateTime[2]);

            if (day == 00 || month == 00 || year == 0000)
            {
                return false;
            }

            if (day.ToString().Length == 2 && month.ToString().Length == 2 && year.ToString().Length == 4)
            {
                if (day <= 31 && month <= 12)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Clear all the controls in the active form 
        /// Does not returns
        /// </summary>
        /// <param name="from">the specified from to be cleared</param>
        /// 
    }
}