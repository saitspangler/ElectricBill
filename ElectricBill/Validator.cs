using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ElectricBill
{
    /// <summary>
    /// a repository of validation methods
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// checks if a textbox has text in it
        /// </summary>
        /// <param name="textBox">text box to check (Tag Property is set)</param>
        /// <returns>True if valid, false if not</returns>
        public static bool IsPresent(TextBox textBox)
        {
            bool isValid = true;
            if(textBox.Text == "") //bad
            {
                MessageBox.Show(textBox.Tag + " is required");
                textBox.Focus();
                isValid = false;
            }
            return isValid;
        }
        /// <summary>
        /// checks if textbox contains an non-negative int value
        /// </summary>
        /// <param name="textBox">text box to check (Tag Property is set)</param>
        /// <returns>True if valid, false if not</returns>
        public static bool IsNonNegativeInt(TextBox textBox)
        {
            bool isValid = true;

            int result;

            if(!Int32.TryParse(textBox.Text, out result)) // not an int
            {
                MessageBox.Show(textBox.Tag + " has to be a whole number");
                textBox.SelectAll(); //select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            else if(result < 0) // is an int but negative
            {
                MessageBox.Show(textBox.Tag + " has to be a postive number or zero");
                textBox.SelectAll(); //select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// checks if textbox contains an non-negative double value
        /// </summary>
        /// <param name="textBox">text box to check (Tag Property is set)</param>
        /// <returns>True if valid, false if not</returns>
        public static bool IsNonNegativeDouble(TextBox textBox)
        {
            bool isValid = true;

            double result;

            if (!Double.TryParse(textBox.Text, out result)) // not a double
            {
                MessageBox.Show(textBox.Tag + " has to be a  number");
                textBox.SelectAll(); //select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            else if (result < 0) // is an double but negative
            {
                MessageBox.Show(textBox.Tag + " has to be a postive number or zero");
                textBox.SelectAll(); //select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// checks if textbox contains an int value in a given range
        /// </summary>
        /// <param name="textBox">text box to check</param>
        /// <param name="minVal">minimum value for range</param>
        /// <param name="maxVal">maximum value for range</param>
        /// <returns>true if valid, false if not</returns>
        public static bool isIntInRange(TextBox textBox, int minVal, int maxVal)
        {
            bool isValid = true;

            int result;

            if (!Int32.TryParse(textBox.Text, out result)) // not an int
            {
                MessageBox.Show(textBox.Tag + " has to be a whole number");
                textBox.SelectAll(); //select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            else if (result < minVal || result > maxVal) // is an int but out of range
            {
                MessageBox.Show(textBox.Tag + " has to be a between" + minVal + "and" + maxVal);
                textBox.SelectAll(); //select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }

            return isValid;
        }
    }
}
