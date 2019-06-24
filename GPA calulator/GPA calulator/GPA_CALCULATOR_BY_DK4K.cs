using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_calulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "GPA CALCULATOR BY Dk4K";
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void buttonfacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com/dk4klike");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public static int i = 0;
        public static int NumOfCourses;
        public static int arrayvalue;
        double[] credit;
        double[] point;
        double limit = 4.1;
        public static string Output;
        double creditnumber;
        double pointnumber;
        private void buttonProcced_MouseHover(object sender, EventArgs e)
        {
            buttonProcced.Height = buttonProcced.Height + 10;
            buttonProcced.Width = buttonProcced.Width + 10;
        }

        private void buttonProcced_MouseLeave(object sender, EventArgs e)
        {
            buttonProcced.Height = buttonProcced.Height - 10;
            buttonProcced.Width = buttonProcced.Width - 10;
        }

        // ArrayList balance = new ArrayList();
        int lableint = 1;
        private void buttonProcced_Click(object sender, EventArgs e)
        {
            try
            {
                NumOfCourses = Convert.ToInt32(comboBoxNumCourses.Text);
                comboBoxNumCourses.Hide();
                buttonProcced.Hide();
                label2.Hide();
                label3.Hide();
                arrayvalue = NumOfCourses;
                credit = new double[arrayvalue];
                point = new double[arrayvalue];
                label4.Show();
                label5.Show();
                buttonSubmit.Show();
                textBoxCredit.Show();
                textBoxGpa.Show();
                label4.Text = "Enter Number of Credit(Hours) of the Subject : " + lableint + " : ";
                label5.Text = "Enter Number of Point(Gpa) Of The Subject    : " + lableint + " : ";
                //  label6.Text = Convert.ToString(i);
                //  label7.Text = Convert.ToString(credit.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select your Course Credit Hour");
            }

        }


        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (i < NumOfCourses)
            {
                if (textBoxCredit.Text == "" || textBoxGpa.Text == "" || limit < Convert.ToDouble(textBoxGpa.Text) || limit < Convert.ToDouble(textBoxCredit.Text))
                {
                    string message = "Please Enter Valid  Credit and Point";
                    MessageBox.Show(message);
                }
                else
                {
                    if (i == NumOfCourses - 1)
                    {
                        label4.Hide();
                        label5.Hide();
                        textBoxCredit.Hide();
                        textBoxGpa.Hide();
                        userfunction();
                        i++;
                        buttonSubmit.PerformClick();
                        buttonSubmit.PerformClick();
                        buttonSubmit.Hide();
                    }
                    else
                    {
                        userfunction();
                        i++;
                    }
                }


            }
            else
            {
                label4.Hide();
                label5.Hide();
                buttonSubmit.Hide();
                textBoxCredit.Hide();
                textBoxGpa.Hide();
                double sum = 0;
                double tot;
                for (int j = 0; j < NumOfCourses; j++)
                {
                    tot = credit[j] * point[j];
                    sum = sum + tot;
                }
                double totCr = 0;
                double finalgpa;
                finalgpa = sum / totCr;
                for (int k = 0; k < NumOfCourses; k++)
                {
                    totCr = totCr + credit[k];
                }
                double totalgpa = sum / totCr;
                //cout << "\n\n\nTotal Points: " << sum << " . Total Credits: " << totCr << " .Total GPA: " << sum / totCr << " ." << endl;


                label8.Show();
                label9.Show();
                label6.Text = "Share it with others :) ";
                label6.Show();
                label9.Text = name+" YOUR GPA is : " + totalgpa;

            }
        }



        private void userfunction()
        {
            //label6.Text = Convert.ToString(i);
            //label7.Text = Convert.ToString(credit.Length);

            if (textBoxCredit.Text == "" || textBoxGpa.Text == "" || limit < Convert.ToDouble(textBoxGpa.Text) || limit < Convert.ToDouble(textBoxCredit.Text))
            {
                string message = "Please Enter Valid  Credit and Point";
                MessageBox.Show(message);
            }
            else
            {
                lableint++;
                // below two lines are for the lable control
                label4.Text = "Enter Number of Credit(Hours) of the Subject : " + lableint + " : ";
                label5.Text = "Enter Number of Point(Gpa) Of The Subject    : " + lableint + " : ";
                //  label6.Text = Convert.ToString(i);
                // label7.Text = Convert.ToString(credit.Length);
                creditnumber = Convert.ToDouble(textBoxCredit.Text);
                pointnumber = Convert.ToDouble(textBoxGpa.Text);
                credit[i] = creditnumber;
                point[i] = pointnumber;
                textBoxCredit.Clear();
                textBoxGpa.Clear();
            }




        }


        private void GPA_CALULATOR_BY_Dk4K_Load(object sender, EventArgs e)
        {
            label4.Hide();
            label5.Hide();
            buttonSubmit.Hide();
            textBoxCredit.Hide();
            textBoxGpa.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            //  askatAsync();
            comboBoxNumCourses.Focus();
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = "This Software is Developed by 'DK4K' ";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "GPA CALCULATOR FOR PAKISTANI UNIVERSITIES";
        }
        Thread th;

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.youtube.com/dk4klike");
        }

        private void GPA_CALULATOR_BY_Dk4K_Load_1(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Hide();
            buttonProcced.Hide();
            comboBoxNumCourses.Hide();
            label4.Hide();
            label5.Hide();
            buttonSubmit.Hide();
            textBoxCredit.Hide();
            textBoxGpa.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            // askatAsync();
            comboBoxNumCourses.Focus();
        }
        public static string name;
        public static string uni;
        private void buttonOkay_Click(object sender, EventArgs e)
        {
            name = textBoxUNI.Text;
            uni = Convert.ToString(comboBoxUNI.SelectedItem);
            textBoxUNI.Hide();
            comboBoxUNI.Hide();
            buttonOkay.Hide();
            label10.Hide();
            label11.Hide();
            label2.Show();
            label3.Show();
            buttonProcced.Show();
            comboBoxNumCourses.Show();
        }
    }
}
