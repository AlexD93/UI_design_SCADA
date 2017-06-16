using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_design_assignment_3
{
    public partial class Form1 : Form
    {
        int Capacity1, Capacity2, Capacity3, Capacity4, Capacity5, Capacity6, Capacity7, Capacity8;
        bool valve1closed, valve2closed, valve3closed, valve4closed, valve5closed, valve6closed, valve7closed, valve8closed;
        bool valve1released, valve2released, valve3released, valve4released, valve5released, valve6released, valve7released, valve8released;
        bool runAll, releaseAll;


        System.Timers.Timer Tank1Timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            valve1closed = false;
            valve2closed = false;
            valve3closed = false;
            valve4closed = false;
            valve5closed = false;
            valve6closed = false;
            valve7closed = false;
            valve8closed = false;

            valve1released = false;
            valve2released = false;
            valve3released = false;
            valve4released = false;
            valve5released = false;
            valve6released = false;
            valve7released = false;
            valve8released = false;

            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;
            progressBar5.Value = 0;
            progressBar6.Value = 0;
            progressBar7.Value = 0;
            progressBar8.Value = 0;

            //Capacity1 = 100;
            //Capacity2 = 100;
            //Capacity3 = 100;
            //Capacity4 = 100;
            //Capacity5 = 100;
            //Capacity6 = 100;
            //Capacity7 = 100;
            //Capacity8 = 100;

            Capacity1 = 0;
            Capacity2 = 0;
            Capacity3 = 0;
            Capacity4 = 0;
            Capacity5 = 0;
            Capacity6 = 0;
            Capacity7 = 0;
            Capacity8 = 0;

            //label1.Text = "100%";
            //label2.Text = "100%";
            //label3.Text = "100%";
            //label4.Text = "100%";
            //label5.Text = "100%";
            //label6.Text = "100%";
            //label7.Text = "100%";
            //label8.Text = "100%";

            label1.Text = "0%";
            label2.Text = "0%";
            label3.Text = "0%";
            label4.Text = "0%";
            label5.Text = "0%";
            label6.Text = "0%";
            label7.Text = "0%";
            label8.Text = "0%";


        }


        //--------------------------------------------------------------------------------------------------

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (valve1closed)
            {
                if (Capacity1 < 100)
                {
                    progressBar1.Increment(10);
                    //progressBar1.ForeColor = Color.Blue; // color of progress bar
                    label1.Text = (Capacity1 + 10).ToString() + "%";
                    label1.Refresh();
                    Capacity1 += 10;
                    System.Threading.Thread.Sleep(100);
                }
                else
                    timer1.Stop();
            }
            else
            {
                if (Capacity1 <= 100)
                {
                    if (progressBar1.Value == 0)
                    {
                        progressBar1.Value = 0;
                    }
                    else
                    {
                        progressBar1.Value -= 10;

                        label1.Text = (Capacity1 - 10).ToString() + "%";
                        label1.Refresh();
                        Capacity1 -= 10;

                        System.Threading.Thread.Sleep(0);
                    }
                }
                if (Capacity1 == 0)
                {
                    progressBar1.Value = 0;

                    timer1.Stop();
                    button1.BackgroundImage = (Properties.Resources.closed);
                    playSound();
                }
            }
            if (progressBar1.Value > 99)
                button1.BackgroundImage = (Properties.Resources.open);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valve1released = false;

            valve1closed = !valve1closed;

            if (valve1closed)
            {
                button1.BackgroundImage = (Properties.Resources.open);
                timer1.Start();
            }
            else
            {
                button1.BackgroundImage = (Properties.Resources.closed);
                timer1.Stop();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            valve1closed = false;

            valve1released = !valve1released;

            if (!valve1released)
            {
                timer1.Stop();
                playSound();
            }
            else
            {
                timer1.Start();
            }
        }

        //--------------------------------------------------------------------------------------------------

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (valve2closed)
            {
                if (Capacity2 < 100)
                {
                    progressBar2.Increment(10);
                    //progressBar2.ForeColor = Color.Red; // color of progress bar
                    label2.Text = (Capacity2 + 10).ToString() + "%";
                    label2.Refresh();
                    Capacity2 += 10;
                    System.Threading.Thread.Sleep(80);
                }
                else
                    timer2.Stop();

            }
            else
            {
                if (Capacity2 <= 100)
                {
                    if (progressBar2.Value == 0)
                    {
                        progressBar2.Value = 0;
                    }
                    else
                    {
                        progressBar2.Value -= 10;
                        label2.Text = (Capacity2 - 10).ToString() + "%";
                        label2.Refresh();
                        Capacity2 -= 10;
                        System.Threading.Thread.Sleep(80);
                    }
                }
                if (Capacity2 == 0)
                {
                    progressBar2.Value = 0;

                    timer2.Stop();
                    button2.BackgroundImage = (Properties.Resources.closed1);
                    playSound();
                }
            }
            if (progressBar2.Value > 99)
                button2.BackgroundImage = (Properties.Resources.open1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            valve2released = false;

            valve2closed = !valve2closed;

            if (valve2closed)
            {
                button2.BackgroundImage = (Properties.Resources.open1);
                timer2.Start();
            }
            else
            {
                button2.BackgroundImage = (Properties.Resources.closed1);
                timer2.Stop();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valve2closed = false;

            valve2released = !valve2released;

            if (!valve2released)
            {
                timer2.Stop();
                playSound();
            }
            else
            {
                timer2.Start();
            }
        }


        //---------------------------------------------------------------------------------------------------------

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (valve3closed)
            {
                if (Capacity3 < 100)
                {
                    progressBar3.Increment(10);

                    label3.Text = (Capacity3 + 10).ToString() + "%";
                    label3.Refresh();
                    Capacity3 += 10;
                    System.Threading.Thread.Sleep(60);
                }
                else
                    timer3.Stop();

            }
            else
            {
                if (Capacity3 <= 100)
                {
                    if (progressBar3.Value == 0)
                    {
                        progressBar3.Value = 0;
                    }
                    else
                    {
                        progressBar3.Value -= 10;

                        label3.Text = (Capacity3 - 10).ToString() + "%";
                        label3.Refresh();
                        Capacity3 -= 10;
                        System.Threading.Thread.Sleep(60);
                    }
                }
                if (Capacity3 == 0)
                {
                    progressBar3.Value = 0;

                    timer3.Stop();
                    button3.BackgroundImage = (Properties.Resources.closed);
                    playSound();
                }
            }
            if (progressBar3.Value > 99)
                button3.BackgroundImage = (Properties.Resources.open2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valve3released = false;

            valve3closed = !valve3closed;

            if (valve3closed)
            {
                button3.BackgroundImage = (Properties.Resources.open2);
                timer3.Start();
            }
            else
            {
                button3.BackgroundImage = (Properties.Resources.closed2);
                timer3.Stop();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valve3closed = false;

            valve3released = !valve3released;

            if (!valve3released)
            {
                timer3.Stop();
                playSound();
            }
            else
            {
                timer3.Start();
            }
        }

        //----------------------------------------------------------------------------------------------------------

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (valve4closed)
            {
                if (Capacity4 < 100)
                {
                    progressBar4.Increment(10);

                    label4.Text = (Capacity4 + 10).ToString() + "%";
                    label4.Refresh();
                    Capacity4 += 10;
                    System.Threading.Thread.Sleep(50);
                }
                else
                    timer4.Stop();

            }
            else
            {
                if (Capacity4 <= 100)
                {
                    if (progressBar4.Value == 0)
                    {
                        progressBar4.Value = 0;
                    }
                    else
                    {
                        progressBar4.Value -= 10;

                        label4.Text = (Capacity4 - 10).ToString() + "%";
                        label4.Refresh();
                        Capacity4 -= 10;
                        System.Threading.Thread.Sleep(50);
                    }
                }
                if (Capacity4 == 0)
                {
                    progressBar4.Value = 0;

                    timer4.Stop();
                    button4.BackgroundImage = (Properties.Resources.closed);
                    playSound();
                }
            }
            if (progressBar4.Value > 99)
                button4.BackgroundImage = (Properties.Resources.open3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valve4released = false;

            valve4closed = !valve4closed;

            if (valve4closed)
            {
                button4.BackgroundImage = (Properties.Resources.open3);
                timer4.Start();
            }
            else
            {
                button4.BackgroundImage = (Properties.Resources.closed3);
                timer4.Stop();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valve4closed = false;

            valve4released = !valve4released;

            if (!valve4released)
            {
                timer4.Stop();
                playSound();
            }
            else
            {
                timer4.Start();
            }
        }


        //--------------------------------------------------------------------------------------------------------

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (valve5closed)
            {
                if (Capacity5 < 100)
                {
                    progressBar5.Increment(10);

                    label5.Text = (Capacity5 + 10).ToString() + "%";
                    label5.Refresh();
                    Capacity5 += 10;
                    System.Threading.Thread.Sleep(40);
                }
                else
                    timer5.Stop();

            }
            else
            {
                if (Capacity5 <= 100)
                {
                    if (progressBar5.Value == 0)
                    {
                        progressBar5.Value = 0;
                    }
                    else
                    {
                        progressBar5.Value -= 10;

                        label5.Text = (Capacity5 - 10).ToString() + "%";
                        label5.Refresh();
                        Capacity5 -= 10;
                        System.Threading.Thread.Sleep(40);
                    }
                }
                if (Capacity5 == 0)
                {
                    progressBar5.Value = 0;

                    timer5.Stop();
                    button5.BackgroundImage = (Properties.Resources.closed4);
                    playSound();
                }
            }
            if (progressBar5.Value > 99)
                button5.BackgroundImage = (Properties.Resources.open4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            valve5released = false;

            valve5closed = !valve5closed;

            if (valve5closed)
            {
                button5.BackgroundImage = (Properties.Resources.open4);
                timer5.Start();
            }
            else
            {
                button5.BackgroundImage = (Properties.Resources.closed4);
                timer5.Stop();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valve5closed = false;

            valve5released = !valve5released;

            if (!valve5released)
            {
                timer5.Stop();
                playSound();
            }
            else
            {
                timer5.Start();
            }
        }

        //--------------------------------------------------------------------------------------------------------

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (valve6closed)
            {
                if (Capacity6 < 100)
                {
                    progressBar6.Increment(10);

                    label6.Text = (Capacity6 + 10).ToString() + "%";
                    label6.Refresh();
                    Capacity6 += 10;
                    System.Threading.Thread.Sleep(40);
                }
                else
                    timer6.Stop();

            }
            else
            {
                if (Capacity6 <= 100)
                {
                    if (progressBar6.Value == 0)
                    {
                        progressBar6.Value = 0;
                    }
                    else
                    {
                        progressBar6.Value -= 10;

                        label6.Text = (Capacity6 - 10).ToString() + "%";
                        label6.Refresh();
                        Capacity6 -= 10;
                        System.Threading.Thread.Sleep(40);
                    }
                }
                if (Capacity6 == 0)
                {
                    progressBar6.Value = 0;

                    timer6.Stop();
                    button6.BackgroundImage = (Properties.Resources.closed5);
                    playSound();
                }
            }
            if (progressBar6.Value > 99)
                button6.BackgroundImage = (Properties.Resources.open5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            valve6released = false;

            valve6closed = !valve6closed;

            if (valve6closed)
            {
                button6.BackgroundImage = (Properties.Resources.open5);
                timer6.Start();
            }
            else
            {
                button6.BackgroundImage = (Properties.Resources.closed5);
                timer6.Stop();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valve6closed = false;

            valve6released = !valve6released;

            if (!valve6released)
            {
                timer6.Stop();
                playSound();
            }
            else
            {
                timer6.Start();
            }
        }

        //--------------------------------------------------------------------------------------------------------

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (valve7closed)
            {
                if (Capacity7 < 100)
                {
                    progressBar7.Increment(10);

                    label7.Text = (Capacity7 + 10).ToString() + "%";
                    label7.Refresh();
                    Capacity7 += 10;
                    System.Threading.Thread.Sleep(40);
                }
                else
                    timer7.Stop();

            }
            else
            {
                if (Capacity7 <= 100)
                {
                    if (progressBar7.Value == 0)
                    {
                        progressBar7.Value = 0;
                    }
                    else
                    {
                        progressBar7.Value -= 10;

                        label7.Text = (Capacity7 - 10).ToString() + "%";
                        label7.Refresh();
                        Capacity7 -= 10;
                        System.Threading.Thread.Sleep(40);
                    }
                }
                if (Capacity7 == 0)
                {
                    progressBar7.Value = 0;

                    timer7.Stop();
                    button7.BackgroundImage = (Properties.Resources.closed6);
                    playSound();
                }
            }
            if (progressBar7.Value > 99)
                button7.BackgroundImage = (Properties.Resources.open6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            valve7released = false;

            valve7closed = !valve7closed;

            if (valve7closed)
            {
                button7.BackgroundImage = (Properties.Resources.open6);
                timer7.Start();
            }
            else
            {
                button7.BackgroundImage = (Properties.Resources.closed6);
                timer7.Stop();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            valve7closed = false;

            valve7released = !valve7released;

            if (!valve7released)
            {
                timer7.Stop();
                playSound();
            }
            else
            {
                timer7.Start();
            }
        }

        //--------------------------------------------------------------------------------------------------------

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (valve8closed)
            {
                if (Capacity8 < 100)
                {
                    progressBar8.Increment(10);

                    label8.Text = (Capacity8 + 10).ToString() + "%";
                    label8.Refresh();
                    Capacity8 += 10;
                    System.Threading.Thread.Sleep(40);
                }
                else
                    timer8.Stop();

            }
            else
            {
                if (Capacity8 <= 100)
                {
                    if (progressBar8.Value == 0)
                    {
                        progressBar8.Value = 0;
                    }
                    else
                    {
                        progressBar8.Value -= 10;

                        label8.Text = (Capacity8 - 10).ToString() + "%";
                        label8.Refresh();
                        Capacity8 -= 10;
                        System.Threading.Thread.Sleep(40);
                    }
                }
                if (Capacity8 == 0)
                {
                    progressBar8.Value = 0;

                    timer8.Stop();
                    button8.BackgroundImage = (Properties.Resources.closed7);
                    playSound();
                }
            }
            if (progressBar8.Value > 99)
                button8.BackgroundImage = (Properties.Resources.open7);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            valve8released = false;

            valve8closed = !valve8closed;

            if (valve8closed)
            {
                button8.BackgroundImage = (Properties.Resources.open7);
                timer8.Start();
            }
            else
            {
                button8.BackgroundImage = (Properties.Resources.closed7);
                timer8.Stop();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            valve8closed = false;

            valve8released = !valve8released;

            if (!valve8released)
            {
                timer8.Stop();
                playSound();
            }
            else
            {
                timer8.Start();
            }
        }

        //--------------------------------------------------------------------------------------------------------

        private void button9_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }   // Exit

        //--------------------------------------------------------------------------------------------------------

        private void button18_Click(object sender, EventArgs e)
        {
            Form1_Load(null, null);
            button19.BackgroundImage = (Properties.Resources.offAll);
            button1.BackgroundImage = (Properties.Resources.closed);
            button2.BackgroundImage = (Properties.Resources.closed1);
            button3.BackgroundImage = (Properties.Resources.closed2);
            button4.BackgroundImage = (Properties.Resources.closed3);
            button5.BackgroundImage = (Properties.Resources.closed4);
            button6.BackgroundImage = (Properties.Resources.closed5);
            button7.BackgroundImage = (Properties.Resources.closed6);
            button8.BackgroundImage = (Properties.Resources.closed7);
            play_Sound();
        }    // Reset

        //--------------------------------------------------------------------------------------------------------

        private void button19_Click(object sender, EventArgs e)
        {
            runAll = !runAll;

            if (runAll)
            {
                valve1closed = false;
                valve2closed = false;
                valve3closed = false;
                valve2closed = false;
                valve4closed = false;
                valve5closed = false;
                valve6closed = false;
                valve7closed = false;
                valve8closed = false;

                button19.BackgroundImage = (Properties.Resources.onAll);
                button1.PerformClick();
                button2.PerformClick();
                button3.PerformClick();
                button4.PerformClick();
                button5.PerformClick();
                button6.PerformClick();
                button7.PerformClick();
                button8.PerformClick();
            }
            else
            {
                button19.BackgroundImage = (Properties.Resources.offAll);

                timer1.Stop();
                button1.BackgroundImage = (Properties.Resources.closed);

                timer2.Stop();
                button2.BackgroundImage = (Properties.Resources.closed1);

                timer3.Stop();
                button3.BackgroundImage = (Properties.Resources.closed2);

                timer4.Stop();
                button4.BackgroundImage = (Properties.Resources.closed3);

                timer5.Stop();
                button5.BackgroundImage = (Properties.Resources.closed4);

                timer6.Stop();
                button6.BackgroundImage = (Properties.Resources.closed5);

                timer7.Stop();
                button7.BackgroundImage = (Properties.Resources.closed6);

                timer8.Stop();
                button8.BackgroundImage = (Properties.Resources.closed7);
            }

        }   // Run all

        //--------------------------------------------------------------------------------------------------------
        private void playSound()
        {
            System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(Environment.CurrentDirectory + "\\wavlibrary.wav");
            simpleSound.Play();
        }

        private void play_Sound()
        {
            System.Media.SoundPlayer simple_Sound = new System.Media.SoundPlayer(Environment.CurrentDirectory + "\\full.wav");
            simple_Sound.Play();
        }
        //---------------------------------------------------------------------------------------------------------

        private void button20_Click(object sender, EventArgs e)
        {
            releaseAll = !releaseAll;
            if (releaseAll)
            {
                button20.BackgroundImage = (Properties.Resources.releaseall);
                button19.BackgroundImage = (Properties.Resources.offAll);
                button10.PerformClick();
                button1.BackgroundImage = (Properties.Resources.closed);
                button11.PerformClick();
                button2.BackgroundImage = (Properties.Resources.closed1);
                button12.PerformClick();
                button3.BackgroundImage = (Properties.Resources.closed2);
                button13.PerformClick();
                button4.BackgroundImage = (Properties.Resources.closed3);
                button14.PerformClick();
                button5.BackgroundImage = (Properties.Resources.closed4);
                button15.PerformClick();
                button6.BackgroundImage = (Properties.Resources.closed5);
                button16.PerformClick();
                button7.BackgroundImage = (Properties.Resources.closed6);
                button17.PerformClick();
                button8.BackgroundImage = (Properties.Resources.closed7);
            }

            if (!releaseAll)
            {
                button20.BackgroundImage = (Properties.Resources.releaseall);
                button19.BackgroundImage = (Properties.Resources.offAll);
                button10.PerformClick();
                button1.BackgroundImage = (Properties.Resources.closed);
                button11.PerformClick();
                button2.BackgroundImage = (Properties.Resources.closed1);
                button12.PerformClick();
                button3.BackgroundImage = (Properties.Resources.closed2);
                button13.PerformClick();
                button4.BackgroundImage = (Properties.Resources.closed3);
                button14.PerformClick();
                button5.BackgroundImage = (Properties.Resources.closed4);
                button15.PerformClick();
                button6.BackgroundImage = (Properties.Resources.closed5);
                button16.PerformClick();
                button7.BackgroundImage = (Properties.Resources.closed6);
                button17.PerformClick();
                button8.BackgroundImage = (Properties.Resources.closed7);

            }


        }   // Release all


        //--------------------------------------------------------------------------------------------------------

    }
}