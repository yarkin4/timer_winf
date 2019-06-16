using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        int msec1;
        int msec2;
        int sec1;
        int sec2;
        int min1;
        int min2;
        int hr1;
        int hr2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10;

            msec1 = 0;
            msec2 = 0;
            sec1 = 0;
            sec2 = 0;
            min1 = 0;
            min2 = 0;
            hr1 = 0;
             hr2 = 0;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label11.Text = "0";
            label12.Text = "0";

             msec1 = 0;
             msec2 = 0;
             sec1 = 0;
             sec2 = 0;
             min1 = 0;
             min2 = 0;
             hr1 = 0;
             hr2 = 0;
        }

      
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (msec1 < 9)
                msec1++;
            else
            {
                msec1 = 0;
                if (msec2 < 9)
                    msec2++;
                else
                {
                    msec2 = 0;
                    if (sec1 < 9)
                        sec1++;
                    else
                    {
                        sec1 = 0;
                        if (sec2 < 9)
                            sec2++;
                        else
                        {
                            sec2 = 0;
                            if (min1 < 9)
                                min1++;
                            else
                            {
                                min1 = 0;
                                if (min2 < 9)
                                    min2++;
                                else
                                {
                                    min2 = 0;
                                    if (hr1 < 9)
                                        hr1++;
                                    else
                                    {
                                        hr1 = 0;
                                        if (hr2 < 9)
                                            hr2++;
                                        else
                                        {
                                            hr2 = 0;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            label12.Text = Convert.ToString(msec1);
            label11.Text = Convert.ToString(msec2);
            label1.Text = Convert.ToString(sec1);
            label2.Text = Convert.ToString(sec2);
            label3.Text = Convert.ToString(min1);
            label4.Text = Convert.ToString(min2);
            label5.Text = Convert.ToString(hr1);
            label6.Text = Convert.ToString(hr2);

        }
    }
}
