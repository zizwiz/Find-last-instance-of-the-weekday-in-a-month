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
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            DayOfWeek currentDayOfWeek = DateTime.Now.DayOfWeek;
            cmbobx_day.SelectedIndex = Array.IndexOf(daysOfWeek, currentDayOfWeek.ToString());

            // Set year to 2023.
            cmbobx_year.SelectedIndex = 23;

            // set date picker to todays date.
            dtTmPicker.Value = DateTime.Today;
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            workOutDates(12);
        }

        private void workOutDates(int months)
        {
            rchtxtbx_output.Clear();

            bool flag = false;
            int year = Convert.ToInt32(cmbobx_year.Text);
            var myDayOfWeek = (DayOfWeek)(cmbobx_day.SelectedIndex + 1);
            int month;
            DateTime date;
            string answer;

            for (int i = 1; i <= months; i++) 
            {
                if (flag) //if we want all the months or just when we change to and from BST
                {
                    month = (months == 2) ? 10 : i;
                }
                else
                {
                    month = (months == 2) ? 3 : i; 
                }

                myDayOfWeek = (months == 2)? DayOfWeek.Sunday : myDayOfWeek; //clocks change on a Sunday

               date = new DateTime(year, month, DateTime.DaysInMonth(year, month), System.Globalization.CultureInfo.CurrentCulture.Calendar);

                int daysOffset = date.DayOfWeek - myDayOfWeek;
                if (daysOffset < 0) daysOffset += 7; // if the code is negative, we need to normalize them

                answer = date.AddDays(-daysOffset).ToLongDateString();

                rchtxtbx_output.AppendText(answer + "\r"); // write days to the richtextbox.

                if ((months == 2) && (flag))
                {
                    lbl_date_to_change_to_GMT.Text = answer;
                }
                else if ((months == 2) && (!flag))
                {
                    lbl_date_to_change_to_BST.Text = answer;
                }

                flag = true;
            }
        }

        private void btn_time_in_use_in_UK_Click(object sender, EventArgs e)
        {
            workOutDates(2);

            DateTime dateToCheck = dtTmPicker.Value;
            //DateTime startDate = DateTime.ParseExact(lbl_date_to_change_to_BST.Text, "dd-mmm-yyyy");
            //DateTime endDate = (DateTime)lbl_date_to_change_to_GMT.Text;

            //DateTime.ParseExact("2009-05-08 14:40:52,531", "yyyy-MM-dd HH:mm:ss,fff",

            //bool isBST = (dateToCheck >= startDate && dateToCheck <= endDate);



        }
    }
}
