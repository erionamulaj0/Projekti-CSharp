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
    public partial class Shënime : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;
        public Shënime()
        {
            InitializeComponent();
        }

        private void Shënime_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Titulli");
            notes.Columns.Add("Shënimi");

            previousNotes.DataSource = notes;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex) { Console.WriteLine("Ky shënim nuk është valid"); }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Titulli"] = titleBox.Text;
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Shënimi"] = noteBox.Text;
            }
            else
            {
                notes.Rows.Add(titleBox.Text, noteBox.Text);
                titleBox.Text = "";
                noteBox.Text = "";
                editing = false;
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void newNotesButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = "";
            noteBox.Text = "";
        }

        private void previousNotes_DoubleClick(object sender, EventArgs e)
        {
                titleBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
                noteBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
                editing = true;
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
    }
}
