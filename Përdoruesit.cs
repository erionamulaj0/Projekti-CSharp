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
    public partial class Përdoruesit : Form
    {
        public Përdoruesit()
        {
            InitializeComponent();
        }

        private void Përdoruesit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projekiEMDataSet.regjistrohu' table. You can move, or remove it, as needed.
            this.regjistrohuTableAdapter.Fill(this.projekiEMDataSet.regjistrohu);

        }

        private void btnktheuR_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dritarja = new Regjistrohu();
            dritarja.Show();
        }
    }
}
