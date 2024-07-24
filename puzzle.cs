using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Projekti_CSharp
{
    public partial class puzzle : Form
    {
        Point EmptyPoint;
        ArrayList images = new ArrayList();
        public puzzle()
        {
            EmptyPoint.X = 180;
            EmptyPoint.Y = 180;
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            foreach (Button b in panel1.Controls)
                b.Enabled = true;

            Image orginal = Image.FromFile(@"C:\Users\Admin\Desktop\Projekti C# -Eriona Mulaj\Projekti CSharp\img\img.jpg");
            cropImageTomages(orginal, 270, 270);
            AddImagesToButtons(images);
        }

        private void puzzle_Load(object sender, EventArgs e)
        {

        }
        private void AddImagesToButtons(ArrayList images)
        {
            int i = 0;
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7 };

            arr = suffle(arr);

            foreach (Button b in panel1.Controls)
            {
                if (i < arr.Length)
                {
                    b.Image = (Image)images[arr[i]];
                    i++;
                }
            }
        }
        private int[] suffle(int[] arr)
        {
            Random rand = new Random();
            arr = arr.OrderBy(x => rand.Next()).ToArray();
            return arr;
        }
        private void cropImageTomages(Image original, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);

            Graphics graphic = Graphics.FromImage(bmp);

            graphic.DrawImage(original, 0, 0, w, h);

            graphic.Dispose();

            int movr = 0, movd = 0;

            for (int x = 0; x < 8; x++)
            {
                Bitmap piece = new Bitmap(90, 90);

                for (int i = 0; i < 90; i++)
                    for (int j = 0; j < 90; j++)
                        piece.SetPixel(i, j,
                            bmp.GetPixel(i + movr, j + movd));

                images.Add(piece);

                movr += 90;

                if (movr == 270)
                {
                    movr = 0;
                    movd += 90;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MoveButton((Button)sender);
        }

        private void MoveButton(Button btn)
        {
            if (((btn.Location.X == EmptyPoint.X - 90 || btn.Location.X == EmptyPoint.X + 90)
                && btn.Location.Y == EmptyPoint.Y)
                || (btn.Location.Y == EmptyPoint.Y - 90 || btn.Location.Y == EmptyPoint.Y + 90)
                && btn.Location.X == EmptyPoint.X)
            {
                Point swap = btn.Location;
                btn.Location = EmptyPoint;
                EmptyPoint = swap;
            }

            if (EmptyPoint.X == 180 && EmptyPoint.Y == 180)
                CheckValid();
        }

        private void CheckValid()
        {
            int count = 0, index;
            foreach (Button btn in panel1.Controls)
            {
                index = (btn.Location.Y / 90) * 3 + btn.Location.X / 90;
                if (images[index] == btn.Image)
                    count++;
            }
            if (count == 8)
                MessageBox.Show("Urime,Ju Fituat!");
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
