
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
            this.SuspendLayout();
            // 
            // rchtxtbx_output
            // 
            this.rchtxtbx_output.Location = new System.Drawing.Point(43, 41);
            this.rchtxtbx_output.Name = "rchtxtbx_output";
            this.rchtxtbx_output.Size = new System.Drawing.Size(999, 569);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 701);
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
    }
}

