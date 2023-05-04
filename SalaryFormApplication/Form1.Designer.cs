namespace SalaryFormApplication
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
            this.FullName = new System.Windows.Forms.Label();
            this.TotalHours = new System.Windows.Forms.Label();
            this.HourlyRate = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.Label();
            this.HoursWorked = new System.Windows.Forms.TextBox();
            this.Dollars = new System.Windows.Forms.TextBox();
            this.longname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Record1 = new System.Windows.Forms.Label();
            this.textShow = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CharacterBox = new System.Windows.Forms.TextBox();
            this.mostChar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Get = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Replace = new System.Windows.Forms.Button();
            this.LineNumber = new System.Windows.Forms.Label();
            this.LineContent = new System.Windows.Forms.Label();
            this.TextBoxContent = new System.Windows.Forms.TextBox();
            this.TextBoxNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchString = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OpenFrom2 = new System.Windows.Forms.Button();
            this.Save2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.TextSave = new System.Windows.Forms.TextBox();
            this.Open = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.AppendFile = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Location = new System.Drawing.Point(8, 19);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(33, 13);
            this.FullName.TabIndex = 0;
            this.FullName.Text = "name";
            this.FullName.Click += new System.EventHandler(this.label1_Click);
            // 
            // TotalHours
            // 
            this.TotalHours.AutoSize = true;
            this.TotalHours.Location = new System.Drawing.Point(8, 96);
            this.TotalHours.Name = "TotalHours";
            this.TotalHours.Size = new System.Drawing.Size(76, 13);
            this.TotalHours.TabIndex = 1;
            this.TotalHours.Text = "Hours Worked";
            // 
            // HourlyRate
            // 
            this.HourlyRate.AutoSize = true;
            this.HourlyRate.Location = new System.Drawing.Point(8, 248);
            this.HourlyRate.Name = "HourlyRate";
            this.HourlyRate.Size = new System.Drawing.Size(63, 13);
            this.HourlyRate.TabIndex = 2;
            this.HourlyRate.Text = "Hourly Rate";
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Location = new System.Drawing.Point(8, 448);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(36, 13);
            this.Salary.TabIndex = 3;
            this.Salary.Text = "Salary";
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Location = new System.Drawing.Point(8, 482);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(48, 13);
            this.Results.TabIndex = 4;
            this.Results.Text = "Earnings";
            // 
            // HoursWorked
            // 
            this.HoursWorked.Location = new System.Drawing.Point(2, 126);
            this.HoursWorked.Name = "HoursWorked";
            this.HoursWorked.Size = new System.Drawing.Size(82, 20);
            this.HoursWorked.TabIndex = 5;
            this.HoursWorked.TextChanged += new System.EventHandler(this.HoursWorked_TextChanged);
            this.HoursWorked.LostFocus += new System.EventHandler(this.HoursWorked_LostFocus);
            // 
            // Dollars
            // 
            this.Dollars.Location = new System.Drawing.Point(11, 264);
            this.Dollars.Name = "Dollars";
            this.Dollars.Size = new System.Drawing.Size(73, 20);
            this.Dollars.TabIndex = 6;
            this.Dollars.TextChanged += new System.EventHandler(this.Dollars_TextChanged);
            // 
            // longname
            // 
            this.longname.Location = new System.Drawing.Point(2, 35);
            this.longname.Name = "longname";
            this.longname.Size = new System.Drawing.Size(82, 20);
            this.longname.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(712, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculating pay Slip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Record1
            // 
            this.Record1.AutoSize = true;
            this.Record1.Location = new System.Drawing.Point(544, 9);
            this.Record1.Name = "Record1";
            this.Record1.Size = new System.Drawing.Size(86, 13);
            this.Record1.TabIndex = 9;
            this.Record1.Text = "What Happened";
            // 
            // textShow
            // 
            this.textShow.Location = new System.Drawing.Point(547, 35);
            this.textShow.MaxLength = 40000;
            this.textShow.Multiline = true;
            this.textShow.Name = "textShow";
            this.textShow.ReadOnly = true;
            this.textShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textShow.Size = new System.Drawing.Size(422, 324);
            this.textShow.TabIndex = 11;
            this.textShow.TextChanged += new System.EventHandler(this.textShow_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(734, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Count this character:  ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(712, 448);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(257, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Clear List Record";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CharacterBox
            // 
            this.CharacterBox.Location = new System.Drawing.Point(869, 411);
            this.CharacterBox.Name = "CharacterBox";
            this.CharacterBox.Size = new System.Drawing.Size(100, 20);
            this.CharacterBox.TabIndex = 14;
            this.CharacterBox.TextChanged += new System.EventHandler(this.CharacterBox_TextChanged);
            // 
            // mostChar
            // 
            this.mostChar.Location = new System.Drawing.Point(722, 482);
            this.mostChar.Name = "mostChar";
            this.mostChar.Size = new System.Drawing.Size(257, 23);
            this.mostChar.TabIndex = 15;
            this.mostChar.Text = "Show me the most frequent character";
            this.mostChar.UseVisualStyleBackColor = true;
            this.mostChar.Click += new System.EventHandler(this.mostChar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(527, 482);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Numbers, Letters";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(527, 448);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "# of lines";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Get
            // 
            this.Get.Location = new System.Drawing.Point(6, 115);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(75, 23);
            this.Get.TabIndex = 18;
            this.Get.Text = "Get";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.Get_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(87, 115);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 19;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(168, 115);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 20;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(249, 116);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 21;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Replace
            // 
            this.Replace.Location = new System.Drawing.Point(330, 116);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(75, 23);
            this.Replace.TabIndex = 22;
            this.Replace.Text = "Replace";
            this.Replace.UseVisualStyleBackColor = true;
            this.Replace.Click += new System.EventHandler(this.Replace_Click);
            // 
            // LineNumber
            // 
            this.LineNumber.AutoSize = true;
            this.LineNumber.Location = new System.Drawing.Point(73, 46);
            this.LineNumber.Name = "LineNumber";
            this.LineNumber.Size = new System.Drawing.Size(67, 13);
            this.LineNumber.TabIndex = 23;
            this.LineNumber.Text = "Line Number";
            // 
            // LineContent
            // 
            this.LineContent.AutoSize = true;
            this.LineContent.Location = new System.Drawing.Point(73, 76);
            this.LineContent.Name = "LineContent";
            this.LineContent.Size = new System.Drawing.Size(67, 13);
            this.LineContent.TabIndex = 24;
            this.LineContent.Text = "Line Content";
            // 
            // TextBoxContent
            // 
            this.TextBoxContent.Location = new System.Drawing.Point(146, 69);
            this.TextBoxContent.Name = "TextBoxContent";
            this.TextBoxContent.Size = new System.Drawing.Size(274, 20);
            this.TextBoxContent.TabIndex = 25;
            // 
            // TextBoxNumber
            // 
            this.TextBoxNumber.Location = new System.Drawing.Point(146, 43);
            this.TextBoxNumber.Name = "TextBoxNumber";
            this.TextBoxNumber.Size = new System.Drawing.Size(274, 20);
            this.TextBoxNumber.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchString);
            this.groupBox1.Controls.Add(this.Sort);
            this.groupBox1.Controls.Add(this.Insert);
            this.groupBox1.Controls.Add(this.LineContent);
            this.groupBox1.Controls.Add(this.TextBoxContent);
            this.groupBox1.Controls.Add(this.LineNumber);
            this.groupBox1.Controls.Add(this.TextBoxNumber);
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.Get);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.Replace);
            this.groupBox1.Location = new System.Drawing.Point(115, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 180);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Line Manipulation";
            // 
            // SearchString
            // 
            this.SearchString.Location = new System.Drawing.Point(249, 144);
            this.SearchString.Name = "SearchString";
            this.SearchString.Size = new System.Drawing.Size(75, 23);
            this.SearchString.TabIndex = 28;
            this.SearchString.Text = "Search Line";
            this.SearchString.UseVisualStyleBackColor = true;
            this.SearchString.Click += new System.EventHandler(this.SearchString_Click);
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(330, 145);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(75, 23);
            this.Sort.TabIndex = 27;
            this.Sort.Text = "Sort";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AppendFile);
            this.groupBox2.Controls.Add(this.OpenFrom2);
            this.groupBox2.Controls.Add(this.Save2);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.TextSave);
            this.groupBox2.Controls.Add(this.Open);
            this.groupBox2.Controls.Add(this.SaveAs);
            this.groupBox2.Location = new System.Drawing.Point(90, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 131);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Manipulation";
            // 
            // OpenFrom2
            // 
            this.OpenFrom2.Location = new System.Drawing.Point(274, 71);
            this.OpenFrom2.Name = "OpenFrom2";
            this.OpenFrom2.Size = new System.Drawing.Size(75, 23);
            this.OpenFrom2.TabIndex = 5;
            this.OpenFrom2.Text = "Open ";
            this.OpenFrom2.UseVisualStyleBackColor = true;
            this.OpenFrom2.Click += new System.EventHandler(this.OpenFrom2_Click_1);
            // 
            // Save2
            // 
            this.Save2.Location = new System.Drawing.Point(193, 100);
            this.Save2.Name = "Save2";
            this.Save2.Size = new System.Drawing.Size(75, 23);
            this.Save2.TabIndex = 4;
            this.Save2.Text = "Save";
            this.Save2.UseVisualStyleBackColor = true;
            this.Save2.Click += new System.EventHandler(this.Save2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(355, 71);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Fun";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // TextSave
            // 
            this.TextSave.Location = new System.Drawing.Point(6, 33);
            this.TextSave.Name = "TextSave";
            this.TextSave.ReadOnly = true;
            this.TextSave.Size = new System.Drawing.Size(399, 20);
            this.TextSave.TabIndex = 2;
            this.TextSave.TextChanged += new System.EventHandler(this.TextSave_TextChanged);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(274, 100);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 1;
            this.Open.Text = "Open From";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Location = new System.Drawing.Point(193, 71);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(75, 23);
            this.SaveAs.TabIndex = 0;
            this.SaveAs.Text = "Save as";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.Save_Click);
            // 
            // AppendFile
            // 
            this.AppendFile.AutoSize = true;
            this.AppendFile.Location = new System.Drawing.Point(1, 86);
            this.AppendFile.Name = "AppendFile";
            this.AppendFile.Size = new System.Drawing.Size(168, 17);
            this.AppendFile.TabIndex = 8;
            this.AppendFile.Text = "Append to ListBox when open";
            this.AppendFile.UseVisualStyleBackColor = true;
            this.AppendFile.CheckedChanged += new System.EventHandler(this.AppendFile_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 525);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.mostChar);
            this.Controls.Add(this.CharacterBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textShow);
            this.Controls.Add(this.Record1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.longname);
            this.Controls.Add(this.Dollars);
            this.Controls.Add(this.HoursWorked);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.HourlyRate);
            this.Controls.Add(this.TotalHours);
            this.Controls.Add(this.FullName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label TotalHours;
        private System.Windows.Forms.Label HourlyRate;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.TextBox HoursWorked;
        private System.Windows.Forms.TextBox Dollars;
        private System.Windows.Forms.TextBox longname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Record1;
        private System.Windows.Forms.TextBox textShow;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox CharacterBox;
        private System.Windows.Forms.Button mostChar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Get;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Replace;
        private System.Windows.Forms.Label LineNumber;
        private System.Windows.Forms.Label LineContent;
        private System.Windows.Forms.TextBox TextBoxContent;
        private System.Windows.Forms.TextBox TextBoxNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Button SearchString;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextSave;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button SaveAs;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Save2;
        private System.Windows.Forms.Button OpenFrom2;
        private System.Windows.Forms.CheckBox AppendFile;
    }
}

