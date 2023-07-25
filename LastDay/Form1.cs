using System;
using System.Reflection;
using System.Windows.Forms;

namespace LastDay
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Get the last date of the day of week and year that you choose. This is just an example to show how it is done.
        /// We get the last instance of teh day for every month.  
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            //set the day of week to present day
            string[] daysOfWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            DayOfWeek currentDayOfWeek = DateTime.Now.DayOfWeek;
            cmbobx_day.SelectedIndex = Array.IndexOf(daysOfWeek, currentDayOfWeek.ToString());

            // Set year to 2023.
            cmbobx_year.SelectedIndex = 23;
        }
        
        private void btn_go_Click(object sender, EventArgs e)
        {
            rchtxtbx_output.Clear();

            int year = Convert.ToInt32(cmbobx_year.Text);
            var myDayOfWeek = (DayOfWeek)(cmbobx_day.SelectedIndex + 1);

            DateTime date;

            for (int i = 1; i <= 12; i++) // 12 for num months in year
            {
                date = new DateTime(year, i, DateTime.DaysInMonth(year, i), System.Globalization.CultureInfo.CurrentCulture.Calendar);

                int daysOffset = date.DayOfWeek - myDayOfWeek; 
                if (daysOffset < 0) daysOffset += 7; // if the code is negative, we need to normalize them
                rchtxtbx_output.AppendText(date.AddDays(-daysOffset).ToLongDateString() + "\r"); // write days to the richtextbox.
            }
        }
    }
}
