using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EmbeddedProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            hour.Text = DateTime.Now.Hour.ToString();
            minute.Text = DateTime.Now.Minute.ToString();
        }

        static bool click = false;
        
        private void addhour_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;

            addhour.ForeColor = Color.Gray;

            int time = Int32.Parse(hour.Text);

            if (time == 23)
            {
                time = 0;
            }
            else
            {
                time++;
            }

            hour.Text = time.ToString().PadLeft(2, '0');

            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(500);

                while (click)
                {
                    if (time == 23)
                    {
                        time = 0;
                    }
                    else
                    {
                        time++;
                    }

                    MethodInvoker inv = delegate
                    {
                        this.hour.Text = time.ToString().PadLeft(2, '0');
                    };

                    this.Invoke(inv);

                    Thread.Sleep(100);
                }
            });
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            click = false;

            addhour.ForeColor = Color.Black;
            addmin.ForeColor = Color.Black;
            subhour.ForeColor = Color.Black;
            submin.ForeColor = Color.Black;
        }

        private void subhour_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;

            subhour.ForeColor = Color.Gray;

            int time = Int32.Parse(hour.Text);

            if (time == 0)
            {
                time = 23;
            }
            else
            {
                time--;
            }

            hour.Text = time.ToString().PadLeft(2, '0');

            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(500);

                while (click)
                {
                    if (time == 0)
                    {
                        time = 23;
                    }
                    else
                    {
                        time--;
                    }

                    MethodInvoker inv = delegate
                    {
                        this.hour.Text = time.ToString().PadLeft(2, '0');
                    };

                    this.Invoke(inv);

                    Thread.Sleep(100);
                }
            });
        }

        private void addmin_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;

            addmin.ForeColor = Color.Gray;

            int time = Int32.Parse(minute.Text);

            if(time == 59)
            {
                time = 0;
            }
            else
            {
                time++;
            }

            minute.Text = time.ToString().PadLeft(2, '0');

            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(500);

                while (click)
                {
                    if (time == 59)
                    {
                        time = 0;
                    }
                    else
                    {
                        time++;
                    }

                    MethodInvoker inv = delegate
                    {
                        this.minute.Text = time.ToString().PadLeft(2, '0');
                    };

                    this.Invoke(inv);
                    Thread.Sleep(100);
                }
            });
        }

        private void submin_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;

            submin.ForeColor = Color.Gray;

            int time = Int32.Parse(minute.Text);

            if (time == 0)
            {
                time = 59;
            }
            else
            {
                time--;
            }

            minute.Text = time.ToString().PadLeft(2, '0');

            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(500);

                while (click)
                {
                    if (time == 0)
                    {
                        time = 59;
                    }
                    else
                    {
                        time--;
                    }

                    MethodInvoker inv = delegate
                    {
                        this.minute.Text = time.ToString().PadLeft(2, '0');
                    };

                    this.Invoke(inv);
                    Thread.Sleep(100);
                }
            });
        }

        private async void sendbutton_Click(object sender, EventArgs e)
        {
            int alarmhour = Int32.Parse(hour.Text);
            int alarmmin = Int32.Parse(minute.Text);
            int start = Int32.Parse(startbefore.Text);

            await ApiWrite.SaveFields(alarmhour, alarmmin, start);
            MessageBox.Show("Alarm is set.");
        }

        private async void close_Click(object sender, EventArgs e)
        {
            await ApiWrite.SaveFields(99, 0, 0);
            MessageBox.Show("Alarm is cancelled.");
        }
    }
}
