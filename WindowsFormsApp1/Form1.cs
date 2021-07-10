using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static T Clamp<T>(T val, T min, T max) where T : IComparable<T>
        {
            if (val.CompareTo(min) < 0) return min;
            return val.CompareTo(max) > 0 ? max : val;
        }
        
        private readonly List<List<Box>> _boxes = new List<List<Box>>();
        private ulong _current;

        private ulong Current
        {
            get => _current;
            set
            {
                _current = value;
                if (_current == 0)
                {
                    textBox2.Text = string.Empty;
                    textBox3.Text = string.Empty;
                }
                else
                {
                    string mmm = "";
                    for(int i = 0; i < 8; ++i)
                    {
                        Byte queasy = (Byte)((_current >> i * 8) & 0xfful);
                        var ab = Convert.ToString(queasy, 2).PadLeft(8, '0');
                        mmm = i != 0 ? mmm.Insert(0, ab + " ") : mmm.Insert(0, ab);

                    }
                    textBox2.Text = _current.ToString("X");
                    textBox3.Text = mmm;
                }
                
                foreach (List<Box> boxes in _boxes)
                {
                    foreach (Box box in boxes)
                    {
                        ulong a = box.Value & _current;
                        box.IsActive = a > 0;
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

            for (int i = 0; i < 8; ++i)
            {
                var boxList = new List<Box>();
                _boxes.Add(boxList);
                for (int j = 0; j < 8; ++j)
                {
                    int j0 = 1 << 7 - j;
                    int i0 = (7 - i) * 8;

                    ulong num = (ulong)j0 << i0;

                    PictureBox pictureBox = new PictureBox();
                    ((ISupportInitialize)pictureBox).BeginInit();

                    pictureBox.Location = new Point(13 + j * 51, 28 + i * 45);
                    pictureBox.Size = new Size(45, 39);
                    pictureBox.TabIndex = j + i * 10;
                    pictureBox.TabStop = false;
                    pictureBox.Name = $"pictureBox{pictureBox.TabIndex}";
                    Controls.Add(pictureBox);
                    ((ISupportInitialize)pictureBox).EndInit();

                    Box box = new Box(pictureBox, num);
                    pictureBox.Click += delegate
                    {
                        if (!box.IsActive)
                        {
                            Current |= box.Value;
                        }
                        else
                        {
                            Current &= ~box.Value;
                        }

                        decimalText.Text = Current.ToString();
                    };
                    boxList.Add(box);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bt = new Bitmap(310, 273);
            Graphics g = Graphics.FromImage(bt);

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

        private void decimalText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void decimalText_TextChanged(object sender, EventArgs e)
        {
            if (!ulong.TryParse(decimalText.Text, out var value))
            {
                value = string.IsNullOrEmpty(decimalText.Text) ? 0 : ulong.MaxValue;
            }
            else
            {
                value = Clamp(value, ulong.MinValue, ulong.MaxValue);
            }

            decimalText.Text = value.ToString();
            Current = value;
        }
    }
}
