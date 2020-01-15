using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SYNDIC_1._0.Helpers
{
    public static class StringHelper
    {
        /// <summary>
        /// Checks if the TextBox has text and returns true else returns false
        /// </summary>

        public static bool IsEmpty(this TextBox textBoxName)
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
        /// Straight out of Microsoft docs a regular expression to validate emails
        /// Returns true if the sring is a valide email adress, else retruns false
        /// </summary>
        /// <param name="email"></param>
/*
        public static bool IsValidEmail(this string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                        RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        */
        /// <summary>
        /// Checks if the specified string is in a valide datetime format and returns true, else returns false
        /// </summary>

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

        static public void Clear(Form f)
        {
            if (f is null)
            {
                throw new ArgumentNullException(nameof(f));
            }

            foreach (ListBox c in f.Controls)
            {
                c.Items.Clear();
            }

            foreach (ComboBox c in f.Controls)
            {
                c.Items.Clear();
            }

            foreach (DataGridView c in f.Controls)
            {
                c.Rows.Clear();
            }

            foreach (TextBox c in f.Controls)
            {
                c.Clear();
            }

            foreach (ListView c in f.Controls)
            {
                c.Items.Clear();
            }

        }
    }
}
