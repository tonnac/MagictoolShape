using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<List<Box>> Boxes = new List<List<Box>>();
        ulong current = 0;

        ulong Current
        {
            get => current;
            set
            {
                current = value;
                textBox1.Text = current.ToString();
                textBox2.Text = current.ToString("X");

                string mmm = "";
                for(int i = 0; i < 8; ++i)
                {
                    Byte qweasd = (Byte)((current >> i * 8) & 0xfful);
                    var ab = Convert.ToString(qweasd, 2).PadLeft(8, '0');
                    mmm = mmm.Insert(0, ab + " ");
                }
                textBox3.Text = mmm;

            }
        }

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 8; ++i)
            {
                var boxList = new List<Box>();
                Boxes.Add(boxList);
                for (int j = 0; j < 8; ++j)
                {
                    int j0 = 1 << 7 - j;
                    int i0 = (7 - i) * 8;

                    ulong num = (ulong)j0 << i0;

                    PictureBox pictureBox = new PictureBox();
                    ((ISupportInitialize)pictureBox).BeginInit();

                    pictureBox.Location = new System.Drawing.Point(13 + j * 51, 28 + i * 45);
                    pictureBox.Size = new System.Drawing.Size(45, 39);
                    pictureBox.TabIndex = j + i * 10;
                    pictureBox.TabStop = false;
                    pictureBox.Name = $"pictureBox{pictureBox.TabIndex}";
                    Controls.Add(pictureBox);
                    ((ISupportInitialize)pictureBox).EndInit();

                    Box box = new Box(pictureBox);
                    pictureBox.Click += delegate (object sender, EventArgs e)
                    {
                        ulong num00 = num;
                        box.IsActive = !box.IsActive;

                        if (box.IsActive)
                        {
                            Current |= num00;
                        }
                        else
                        {
                            Current &= ~num00;
                        }
                    };
                    boxList.Add(box);
                }
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bt = new Bitmap(310, 273);
            Graphics g = Graphics.FromImage(bt);

            var a = this.Location;
            g.CopyFromScreen(this.Location.X + 15, this.Location.Y + 54
                , 0, 0, new Size(bt.Width, bt.Height));

            Clipboard.SetImage(bt);

            float rr = 1.0f;
            if (int.TryParse(NumText.Text, out int r))
            {
                rr = r * 0.01f;
            }

            Bitmap newImage = new Bitmap((int)(310 * rr * 0.25f), (int)(273 * rr * 0.25f));
            g = Graphics.FromImage(newImage);
            g.FillRectangle(Brushes.Black, 0, 0, newImage.Width, newImage.Height);
            g.DrawImage(bt, 0, 0, (int)(310 * rr * 0.25f), (int)(273 * rr * 0.25f));

            Clipboard.SetImage(newImage);
        }
    }
}
