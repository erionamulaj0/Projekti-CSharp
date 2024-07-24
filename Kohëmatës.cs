using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Projekti_CSharp
{
    public partial class Kohëmatës : Form
    {
        System.Timers.Timer t;
        int h, m, s;
        public Kohëmatës()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dritarja = new Ballina();
            dritarja.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dritarja = new Shënime();
            dritarja.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dritarja = new Lista();
            dritarja.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dritarja = new Kohëmatës();
            dritarja.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dritarja = new puzzle();
            dritarja.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dritarja = new Regjistrohu();
            dritarja.Show();
        }

        private void Kohëmatës_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                txtResult.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));

            }));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dritarja = new Kyqja();
            dritarja.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            t.Start();
        }
        private void Kohëmatës_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
            Application.DoEvents();
        }
    }
}
