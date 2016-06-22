using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayReminder
{
    public partial class Form1 : Form
    {
        string name = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void getMessage_Click(object sender, EventArgs e)
        {
            //get today's date
            DateTime today = DateTime.Now.Date;
            //get the difference in days between today's date
            //and the date in the date time picker
            TimeSpan ageDays = today - dateTimePicker1.Value;
            //work out age in years
            int years = ((int)ageDays.TotalDays) / 365;
            //get the day and month from the date time picker
            int day = dateTimePicker1.Value.Day;
            string month = dateTimePicker1.Value.ToString("MMMM");
            labelMessage.Text = "Hello, " + name + "! You will be "
                + (years + 1) + " years old on " + day + " " + month + ".";
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            //get name from text box
            name = textBoxName.Text;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
