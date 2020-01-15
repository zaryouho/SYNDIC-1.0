using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYNDIC_1._0.Helpers
{
    public static class InitializeControls
    {

        /// <summary>
        /// A method that loops through the controls in the active from and returns them in a format of an IEnumerable var
        /// </summary>
        /// <typeparam name="TControl"> the control type</typeparam>
        /// <param name="control">local variable and control name</param>
        /// <returns>List of IEnumerable of type Control</returns>
        public static IEnumerable<TControl> GetChildControls<TControl>(this Control control) where TControl : Control
        {
            var children = (control.Controls != null) ? control.Controls.OfType<TControl>() : Enumerable.Empty<TControl>();

            return children.SelectMany(c => GetChildControls<TControl>(c)).Concat(children);
        }
        /// <summary>
        /// Clear all the TextBoxes in the specified form
        /// Does not retrn
        /// </summary>
        /// <param name="form">The active from</param>
        public static void cleatText(Form form)
        {
            var textBoxes = form.GetChildControls<TextBox>();
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Clear();
            }
        }
        /// <summary>
        /// Clear all the DataGridViews in the specified form
        /// Does not retrn
        /// </summary>
        /// <param name="form">The active from</param>
        public static void clearDataGridView(Form form)
        {
            var dataGrids = form.GetChildControls<DataGridView>();
            foreach (DataGridView dataGrid in dataGrids)
            {
                dataGrid.Rows.Clear();
            }
        }
        /// <summary>
        /// Clear all the ComboBoxes in the specified form
        /// Does not retrn
        /// </summary>
        /// <param name="form">The active from</param>
        public static void clearComboBox(Form form)
        {
            var comboBoxes = form.GetChildControls<ComboBox>();
            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.Items.Clear();
            }
        }
        /// <summary>
        /// Clear all the DateTimePickers in the specified form
        /// Does not retrn
        /// </summary>
        /// <param name="form">The active from</param>
        public static void resetDateTimePicker(Form form)
        {
            var dateTimePickers = form.GetChildControls<DateTimePicker>();
            foreach (DateTimePicker dateTimePicker in dateTimePickers)
            {
                dateTimePicker.ResetText();
            }
        }
        /// <summary>
        /// Clear all the ListBoxes in the specified form
        /// Does not retrn
        /// </summary>
        /// <param name="form">The active from</param>
        public static void clearListBox(Form form)
        {
            var listBoxes = form.GetChildControls<ListBox>();
            foreach (ListBox listBox in listBoxes)
            {
                listBox.Items.Clear();
            }
        }
    }
}
