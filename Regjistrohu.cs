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
using System.Text.RegularExpressions;

namespace Projekti_CSharp
{
    public partial class Regjistrohu : Form
    {
        public Regjistrohu()
        {
            InitializeComponent();
        }

        private void btnRegjistrohuR_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-91SR54J\\SQLEXPRESS;Initial Catalog=ProjekiEM;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[regjistrohu]
 ([id]
 ,[emri]
       ,[mbiemri]
       ,[email]
       ,[fjalekalimi]
       ,[punesimi]
       ,[gjinia]
       ,[qyteti]
       ,[perdoruesi]
       ,[nrtel]
       ,[datelindja])
 VALUES
 ('" + idboxR.Text + "','" + emriboxR.Text + "','" + mbiemriboxR.Text + "','" + emailboxR.Text + "','" + fjalekalimiboxR.Text + "','" + jobtnR.Text + "','" + fbtnR.Text + "','" + qytetiboxR.Text + "','" + perdoruesiboxR.Text + "','" + nrtelboxR.Text + "','" + datelindjaboxR.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Urime,ju u regjistruat me sukses!");
        }

        private void klikoketu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var dritarja = new Përdoruesit();
            dritarja.Show();
        }

        private void btnktheuR_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dritarja = new Kyqja();
            dritarja.Show();
        }

        private void emailboxR_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            if(Regex.IsMatch(emailboxR.Text,pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.emailboxR, "Ju lutem shkruani një email valid!");
                return;
            }
        }
    }
}
