namespace GPA_calulator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonfacebook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBoxNumCourses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonProcced = new System.Windows.Forms.Button();
            this.textBoxCredit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxGpa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUNI = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxUNI = new System.Windows.Forms.ComboBox();
            this.buttonOkay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(-5, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(554, 34);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "GPA CALCULATOR FOR PAKISTANI UNIVERSITIES";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            this.textBox1.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // buttonfacebook
            // 
            this.buttonfacebook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonfacebook.BackgroundImage")));
            this.buttonfacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonfacebook.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonfacebook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonfacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonfacebook.Location = new System.Drawing.Point(54, 432);
            this.buttonfacebook.Name = "buttonfacebook";
            this.buttonfacebook.Size = new System.Drawing.Size(141, 122);
            this.buttonfacebook.TabIndex = 1;
            this.buttonfacebook.UseVisualStyleBackColor = true;
            this.buttonfacebook.Click += new System.EventHandler(this.buttonfacebook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(168, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contact Developer :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(315, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 110);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxNumCourses
            // 
            this.comboBoxNumCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNumCourses.FormattingEnabled = true;
            this.comboBoxNumCourses.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxNumCourses.Location = new System.Drawing.Point(132, 244);
            this.comboBoxNumCourses.Name = "comboBoxNumCourses";
            this.comboBoxNumCourses.Size = new System.Drawing.Size(99, 28);
            this.comboBoxNumCourses.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(128, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "How many Courses do you have ?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(128, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Including labs (if there is any)";
            // 
            // buttonProcced
            // 
            this.buttonProcced.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonProcced.BackgroundImage")));
            this.buttonProcced.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonProcced.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonProcced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProcced.Location = new System.Drawing.Point(316, 223);
            this.buttonProcced.Name = "buttonProcced";
            this.buttonProcced.Size = new System.Drawing.Size(78, 71);
            this.buttonProcced.TabIndex = 7;
            this.buttonProcced.UseVisualStyleBackColor = true;
            this.buttonProcced.Click += new System.EventHandler(this.buttonProcced_Click);
            this.buttonProcced.MouseLeave += new System.EventHandler(this.buttonProcced_MouseLeave);
            this.buttonProcced.MouseHover += new System.EventHandler(this.buttonProcced_MouseHover);
            // 
            // textBoxCredit
            // 
            this.textBoxCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCredit.Location = new System.Drawing.Point(427, 102);
            this.textBoxCredit.MaxLength = 4;
            this.textBoxCredit.Name = "textBoxCredit";
            this.textBoxCredit.Size = new System.Drawing.Size(64, 26);
            this.textBoxCredit.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(383, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter Number of Credit(Hours) For the Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(366, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enter Number of Point(Gpa) For The Subject";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSubmit.BackgroundImage")));
            this.buttonSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Location = new System.Drawing.Point(400, 267);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 71);
            this.buttonSubmit.TabIndex = 12;
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxGpa
            // 
            this.textBoxGpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGpa.Location = new System.Drawing.Point(427, 192);
            this.textBoxGpa.MaxLength = 4;
            this.textBoxGpa.Name = "textBoxGpa";
            this.textBoxGpa.Size = new System.Drawing.Size(64, 26);
            this.textBoxGpa.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(166, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(142, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(127, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "CONGRATULATIONS !!";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(127, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "CONGRATULATIONS !!";
            // 
            // textBoxUNI
            // 
            this.textBoxUNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUNI.Location = new System.Drawing.Point(171, 123);
            this.textBoxUNI.MaxLength = 15;
            this.textBoxUNI.Multiline = true;
            this.textBoxUNI.Name = "textBoxUNI";
            this.textBoxUNI.Size = new System.Drawing.Size(345, 39);
            this.textBoxUNI.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 21);
            this.label10.TabIndex = 19;
            this.label10.Text = "Enter Your name :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Select Your Uni  :";
            // 
            // comboBoxUNI
            // 
            this.comboBoxUNI.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUNI.FormattingEnabled = true;
            this.comboBoxUNI.Items.AddRange(new object[] {
            "Bahria University (BU), Islamabad",
            "Air University (AU), Islamabad",
            "Allama Iqbal Open University (AIOU), Islamabad",
            "COMSATS Institute of Information Technology, Islamabad",
            "Federal Urdu University of Arts, Sciences and Technology (FUUAST), Islamabad",
            "Foundation University, Islamabad",
            "Institute of Space Technology (IST), Islamabad",
            "International Islamic University (IIU), Islamabad",
            "National University of Computer and Emerging Sciences (NUCES), Islamabad",
            "National University of Modern Languages (NUML), Islamabad ",
            "Pakistan Institute of Engineering & Applied Sciences (PIEAS), Islamabad",
            "Quaid-i-Azam University (QAU), Islamabad",
            "Riphah International University (RIU), Islamabad",
            "Bahauddin Zakariya University (BZU), Multan",
            "Beaconhouse National University (BNU), Lahore",
            "College of Buisness Administration& Economics (NCBA&E) Lahore",
            "Fatima Jinnah Women University (FJWU), Rawalpindi",
            "Forman Christian College (FCC), Lahore",
            "GIFT University, Gujranwala",
            "Government College University (GCU), Faisalabad",
            "Government College University (GCU), Lahore",
            "Hajvery University (HU), Lahore",
            "Imperial College of Business Studies, Lahore",
            "Institute of Management Sciences (IMS), Lahore",
            "Islamia University, Bahawalp",
            "Kinnaird College for Women, Lahore",
            "Lahore College for Women University (LCWU), Lahore",
            "Lahore School of Economics (LSE), Lahore",
            "Lahore University of Management Sciences (LUMS), Lahore",
            "Minhaj University, Lahore",
            "National College of Arts (NCA), Lahore",
            "National Textile University (NTU), Faisalabad (Federal Chartered)",
            "National University of Sciences & Technology (NUST), Rawalpindi",
            "The Superior College, Lahore ",
            "The University of Management & Technology (UMT), Lahore   ",
            "University of Agriculture, Faisalabad",
            "University of Arid Agriculture, Murree Road, Rawalpindi",
            "University of Central Punjab (UCP), Lahore",
            "University of Education, Lahore",
            "University of Engineering & Technology (UET), Lahore",
            "University of Engineering & Technology (UET), Taxila ",
            "University of Faisalabad, Faisalabad",
            "University of Gujrat , Gujrat",
            "University of Health Sciences (UHS), Lahore",
            "University of Lahore, Lahore",
            "University of Sargodha, Sargodha",
            "University of South Asia (USA), Lahore",
            "University of Veterinary and Animal Sciences (UVAS), Lahore",
            "Virtual University of Pakistan (VU), Lahore",
            "Agha Khan University (AKU), Karachi",
            "Baqai Medical University, Karachi",
            "Dadabhoy Institute of Higher Education, Karachi",
            "Dow University of Health Sciences Karachi",
            "Greenwich University, Karachi",
            "Hamdard University, Karachi",
            "Indus Institute of Higher Education, Karachi",
            "Indus Valley School of Art and Architecture, Karachi",
            "Institute of Business & Technology BIZTEK, Karachi",
            "Institute of Business Administration (IBA), Karachi",
            "Institute of Business Management (IoBM), Karachi",
            "Iqra University, Karachi",
            "Isra University, Hyderabad",
            "Jinnah University for Women, Karachi",
            "Karachi Institute of Economics & Technology (KIET), Karachi",
            "KASB (Khadim Ali Shah Bukhari) Institute of Technology, Karachi",
            "Liaquat University of Medical and Health Sciences (LUMHS), Jamshoro Sindh",
            "Mehran University of Eng. & Technology, Jamshoro",
            "Mohammad Ali Jinnah University (MAJU), Karachi",
            "NED University of Engineering & Technology, Karachi",
            "Newports Institute of Communications and Economics, Karachi",
            "Pakistan Naval Academy, Karachi",
            "Preston Institute of Management Sciences and Technology (PIMSAT), Karachi",
            "Preston University, Karachi",
            "Quaid-e-Awam University of Engineering, Science & Technology, Nawabshah",
            "Shah Abdul Latif University, Khairpur",
            "Shaheed Zulfikar Ali Bhutto Institute of Science & Technology (SZABIST), Karachi",
            "Sindh Agriculture University, Tandojam",
            "Sir Syed University of Engg. & Technology (SSUET), Karachi",
            "Sukkur Institute of Business Administration, Sukkur",
            "Textile Institute of Pakistan (TIP), Karachi",
            "University of East, Hyderabad ",
            "University of Karachi (UoK), Karachi",
            "University of Sindh, Jamshoro ",
            "Zia-ud-Din Medical University, Karachi",
            "Balochistan University of Engineering and Technology, Khuzdar",
            "Balochistan University of Information Technology and Management Sciences, Quetta",
            "Iqra University, Quetta",
            "Sardar Bahadur Khan Women University, Quetta",
            "University of Balochistan, Quetta",
            "Khyber Pakhtunkhwa (formerly NWFP)",
            "Frontier Women University, Peshawar",
            "CECOS University of Information Technology and Emerging Sciences, Peshawar",
            "City University of Science & Information Technology, Peshawar",
            "Gandhara University, Peshawar",
            "Ghulam Ishaq Khan Institute of Engineering Sciences & Technology, Swabi",
            "Gomal University, D.I. Khan",
            "Hazara University, Dodhial, Mansehra",
            "Institute of Management Sciences (IMSciences), Peshawar",
            "Karakuram International University, Gilgit",
            "Kohat University of Science & Technology (KUST), Kohat",
            "Lasbelaa University of Agriculture, Water & Marine Science, Othal",
            "Northern University, Nowshera Cantonment",
            "NWFP Agriculture University, Peshawar",
            "NWFP University of Engineering & Technology, Peshawar",
            "Pakistan Military Academy, Abbottabad",
            "Preston University, Kohat",
            "Qurtaba University of Science & Information Technology, D. I. Khan",
            "Sarhad University of Science & Information Technology",
            "University of Malakand, Chakdara, Dir. Malakand",
            "University of Peshawar, Peshawar ",
            "University of Science & Technology, Bannu"});
            this.comboBoxUNI.Location = new System.Drawing.Point(171, 207);
            this.comboBoxUNI.Name = "comboBoxUNI";
            this.comboBoxUNI.Size = new System.Drawing.Size(345, 29);
            this.comboBoxUNI.TabIndex = 21;
            // 
            // buttonOkay
            // 
            this.buttonOkay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonOkay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonOkay.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOkay.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonOkay.Location = new System.Drawing.Point(203, 298);
            this.buttonOkay.Name = "buttonOkay";
            this.buttonOkay.Padding = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.buttonOkay.Size = new System.Drawing.Size(105, 40);
            this.buttonOkay.TabIndex = 22;
            this.buttonOkay.Text = "OKAY";
            this.buttonOkay.UseVisualStyleBackColor = true;
            this.buttonOkay.Click += new System.EventHandler(this.buttonOkay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(549, 566);
            this.Controls.Add(this.buttonOkay);
            this.Controls.Add(this.comboBoxUNI);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxUNI);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxGpa);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCredit);
            this.Controls.Add(this.buttonProcced);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxNumCourses);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonfacebook);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GPA_CALULATOR_BY_Dk4K_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonfacebook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBoxNumCourses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonProcced;
        private System.Windows.Forms.TextBox textBoxCredit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxGpa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUNI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxUNI;
        private System.Windows.Forms.Button buttonOkay;
    }
}

