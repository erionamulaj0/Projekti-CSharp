using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekti_CSharp
{
    public partial class Ballina : Form
    {
        public Ballina()
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

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dritarja = new Kyqja();
            dritarja.Show();
        }

        private void Ballina_Load(object sender, EventArgs e)
        {
            usernamelbl.Text = Kyqja.username;
        }
    }
}
