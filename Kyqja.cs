using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projekti_CSharp
{
    public partial class Kyqja : Form
    {
        public static string username;
        public Kyqja()
        {
            InitializeComponent();
        }

        private void btnKyquKyqja_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-91SR54J\\SQLEXPRESS;Initial Catalog=ProjekiEM;Integrated Security=True");
            string query = "Select * from dbo.regjistrohu Where perdoruesi = '" + perdoruesiboxKyqja.Text.Trim() + "' and fjalekalimi = '" + fjalekalimiboxKyqja.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);

            if (perdoruesiboxKyqja.Text.Trim().Length == 0 && perdoruesiboxKyqja.Text.Trim().Length == 0)
            {
                MessageBox.Show("Fushat jane te zbrazura ju lutem plotesioni");
            }

            else if (dtb.Rows.Count == 1)
            {
                username = perdoruesiboxKyqja.Text;
                this.Hide();
                var dritarja = new Ballina();
                dritarja.Show();
            }

            else
            {
                MessageBox.Show("Perdoruesi ose fjalekalimi jane gabim!");
            }
        }

        private void btnRegjistrohuKyqja_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dritarja = new Regjistrohu();
            dritarja.Show();
        }

        private void btnDilKyqja_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}