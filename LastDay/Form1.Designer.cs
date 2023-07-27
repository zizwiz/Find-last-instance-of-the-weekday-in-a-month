
namespace LastDay
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rchtxtbx_output = new System.Windows.Forms.RichTextBox();
            this.btn_cls = new System.Windows.Forms.Button();
            this.btn_go = new System.Windows.Forms.Button();
            this.cmbobx_year = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbobx_day = new System.Windows.Forms.ComboBox();
            this.lbl_season_time = new System.Windows.Forms.Label();
            this.lbl_season_hours = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtTmPicker = new System.Windows.Forms.DateTimePicker();
            this.btn_time_in_use_in_UK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_date_to_change_to_BST = new System.Windows.Forms.Label();
            this.lbl_date_to_change_to_GMT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rchtxtbx_output
            // 
            this.rchtxtbx_output.Location = new System.Drawing.Point(43, 41);
            this.rchtxtbx_output.Name = "rchtxtbx_output";
            this.rchtxtbx_output.Size = new System.Drawing.Size(783, 591);
            this.rchtxtbx_output.TabIndex = 0;
            this.rchtxtbx_output.Text = "";
            // 
            // btn_cls
            // 
            this.btn_cls.Location = new System.Drawing.Point(882, 638);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(159, 47);
            this.btn_cls.TabIndex = 1;
            this.btn_cls.Text = "Close";
            this.btn_cls.UseVisualStyleBackColor = true;
            this.btn_cls.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(43, 638);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(159, 47);
            this.btn_go.TabIndex = 2;
            this.btn_go.Text = "Go";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // cmbobx_year
            // 
            this.cmbobx_year.FormattingEnabled = true;
            this.cmbobx_year.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050",
            "2051",
            "2052",
            "2053",
            "2054",
            "2055",
            "2056",
            "2057",
            "2058",
            "2059",
            "2060",
            "2061",
            "2062",
            "2063",
            "2064",
            "2065",
            "2066",
            "2067"});
            this.cmbobx_year.Location = new System.Drawing.Point(686, 648);
            this.cmbobx_year.Name = "cmbobx_year";
            this.cmbobx_year.Size = new System.Drawing.Size(140, 28);
            this.cmbobx_year.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 651);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 651);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose Day of Week";
            // 
            // cmbobx_day
            // 
            this.cmbobx_day.FormattingEnabled = true;
            this.cmbobx_day.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cmbobx_day.Location = new System.Drawing.Point(398, 648);
            this.cmbobx_day.Name = "cmbobx_day";
            this.cmbobx_day.Size = new System.Drawing.Size(140, 28);
            this.cmbobx_day.TabIndex = 5;
            // 
            // lbl_season_time
            // 
            this.lbl_season_time.AutoSize = true;
            this.lbl_season_time.Location = new System.Drawing.Point(26, 411);
            this.lbl_season_time.Name = "lbl_season_time";
            this.lbl_season_time.Size = new System.Drawing.Size(155, 20);
            this.lbl_season_time.TabIndex = 8;
            this.lbl_season_time.Text = "British Summer Time";
            // 
            // lbl_season_hours
            // 
            this.lbl_season_hours.AutoSize = true;
            this.lbl_season_hours.Location = new System.Drawing.Point(26, 438);
            this.lbl_season_hours.Name = "lbl_season_hours";
            this.lbl_season_hours.Size = new System.Drawing.Size(164, 20);
            this.lbl_season_hours.TabIndex = 9;
            this.lbl_season_hours.Text = "Time in GMT + 1 hour ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_date_to_change_to_GMT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_date_to_change_to_BST);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_time_in_use_in_UK);
            this.groupBox1.Controls.Add(this.dtTmPicker);
            this.groupBox1.Controls.Add(this.lbl_season_hours);
            this.groupBox1.Controls.Add(this.lbl_season_time);
            this.groupBox1.Location = new System.Drawing.Point(855, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 591);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time in use in UK on";
            // 
            // dtTmPicker
            // 
            this.dtTmPicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtTmPicker.CustomFormat = "dd-MM-yyyy";
            this.dtTmPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTmPicker.Location = new System.Drawing.Point(27, 38);
            this.dtTmPicker.Name = "dtTmPicker";
            this.dtTmPicker.Size = new System.Drawing.Size(151, 26);
            this.dtTmPicker.TabIndex = 10;
            this.dtTmPicker.Value = new System.DateTime(2023, 7, 22, 21, 44, 0, 0);
            // 
            // btn_time_in_use_in_UK
            // 
            this.btn_time_in_use_in_UK.Location = new System.Drawing.Point(22, 526);
            this.btn_time_in_use_in_UK.Name = "btn_time_in_use_in_UK";
            this.btn_time_in_use_in_UK.Size = new System.Drawing.Size(159, 47);
            this.btn_time_in_use_in_UK.TabIndex = 11;
            this.btn_time_in_use_in_UK.Text = "Find Answer";
            this.btn_time_in_use_in_UK.UseVisualStyleBackColor = true;
            this.btn_time_in_use_in_UK.Click += new System.EventHandler(this.btn_time_in_use_in_UK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Change to BST:";
            // 
            // lbl_date_to_change_to_BST
            // 
            this.lbl_date_to_change_to_BST.AutoSize = true;
            this.lbl_date_to_change_to_BST.Location = new System.Drawing.Point(26, 133);
            this.lbl_date_to_change_to_BST.Name = "lbl_date_to_change_to_BST";
            this.lbl_date_to_change_to_BST.Size = new System.Drawing.Size(53, 20);
            this.lbl_date_to_change_to_BST.TabIndex = 13;
            this.lbl_date_to_change_to_BST.Text = "Date1";
            // 
            // lbl_date_to_change_to_GMT
            // 
            this.lbl_date_to_change_to_GMT.AutoSize = true;
            this.lbl_date_to_change_to_GMT.Location = new System.Drawing.Point(26, 267);
            this.lbl_date_to_change_to_GMT.Name = "lbl_date_to_change_to_GMT";
            this.lbl_date_to_change_to_GMT.Size = new System.Drawing.Size(53, 20);
            this.lbl_date_to_change_to_GMT.TabIndex = 15;
            this.lbl_date_to_change_to_GMT.Text = "Date2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Change to GMT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Chosen Date is in:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "2am becomes 1am";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "1am becomes 2am";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 701);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbobx_day);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbobx_year);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.btn_cls);
            this.Controls.Add(this.rchtxtbx_output);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Last instance of day of week in the month";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtbx_output;
        private System.Windows.Forms.Button btn_cls;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.ComboBox cmbobx_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbobx_day;
        private System.Windows.Forms.Label lbl_season_time;
        private System.Windows.Forms.Label lbl_season_hours;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtTmPicker;
        private System.Windows.Forms.Button btn_time_in_use_in_UK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_date_to_change_to_GMT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_date_to_change_to_BST;
        private System.Windows.Forms.Label label3;
    }
}

