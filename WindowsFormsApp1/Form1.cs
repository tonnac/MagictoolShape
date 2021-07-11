using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Nevron.Nov.Graphics;
using Nevron.Nov.UI;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
#if !DEBUG
        readonly ulong MaxValue = 0xFCFCFCFCFCFC0000ul;
#else
        readonly ulong MaxValue = ulong.MaxValue;
#endif
        private readonly string _fileName = "save";
        private readonly List<Item> _items = new List<Item>();
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
                    decimalText.Text = 0.ToString();
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
            SetLocationAndSize();
            DisableResize();
            CreateCells();
            LoadFile();
        }

        private void LoadFile_Imple(ItemShapeFileIO itemShapeFileIo)
        {
            itemListBox.Items.Clear();
            _items.Clear();
            Current = 0;
            List<ItemShapeFileIO.LoadedObject> loadedObjects = itemShapeFileIo.LoadFile();
            if (loadedObjects == null) return;
            foreach (var loadedObject in loadedObjects)
            {
                AddNewItem(loadedObject.ImageBytes, loadedObject.Value);
            }
        }

        private void LoadFile()
        {
            LoadFile_Imple(new ItemShapeFileIO(_fileName));
        }

        private void LoadFile(string fullPath)
        {
            LoadFile_Imple(new ItemShapeFileIO(fullPath, true));
        }

        private NListBoxItem MakeBoxItem(byte[] imageBytes)
        {
            NListBoxItem item;
            NImageSource mImageSource = new NBytesImageSource(imageBytes);
            NImage image = new NImage(mImageSource);
            item = new NListBoxItem(image);
            NBorder border = new NBorder();
            border.InnerStroke = new NStroke(1.5, NColor.Black);
            item.MouseDown += ItemOnMouseDown;
            item.Border = border;

            return item;
        }

        private NListBoxItem MakeBoxItem(Bitmap bitmap)
        {
            ImageConverter converter = new ImageConverter();
            var imageBytes = (byte[]) converter.ConvertTo(bitmap, typeof(byte[]));

            NImageSource mImageSource = new NBytesImageSource(imageBytes);
            NImage image = new NImage(mImageSource);
            var item = new NListBoxItem(image);
            NBorder border = new NBorder {InnerStroke = new NStroke(1.5, NColor.Black)};
            item.MouseDown += ItemOnMouseDown;
            item.Border = border;

            return item;
        }

        private void AddNewItem(byte[] imageBytes, ulong value)
        {
            NListBoxItem item = MakeBoxItem(imageBytes);
            AddNewItem(item, value);
        }

        private void AddNewItem(NListBoxItem boxItem, ulong value)
        {
            var a = boxItem.GetChildren();
            Item newItem = null;

            foreach (var aItem in a.Items)
            {
                if (aItem is NImageBox g)
                {
                    if (g.Image.ImageSource is NBytesImageSource h)
                    {
                        newItem = new Item(value, boxItem, h.Bytes);
                    }
                }
            }

            if (newItem != null)
            {
                _items.Add(newItem);
                itemListBox.Items.Add(boxItem);
            }
        }

        private void CopyValue()
        {
            if (Current <= 0)
            {
                return;
            }
            Clipboard.SetText(Current.ToString());
            toolStripStatusLabel1.Text = $@"클립보드에 {Current} 값이 복사 됐습니다.";
        }

        private void CopyImage()
        {
            Bitmap img = GetCurrentShape(int.TryParse(imageRatioText.Text, out int r) ? r * 0.01f : 1.0f);
            if (img != null)
            {
                Clipboard.SetImage(img);
                toolStripStatusLabel1.Text = $@"클립보드에 {Current} 이미지가 복사 됐습니다.";
            }
        }

        private static T Clamp<T>(T val, T min, T max) where T : IComparable<T>
        {
            if (val.CompareTo(min) < 0) return min;
            return val.CompareTo(max) > 0 ? max : val;
        }

        private void SetLocationAndSize()
        {
#if DEBUG
            decimalText.ReadOnly = false;
            infoPanel.Location = new Point(0, 391);
            Size = new Size(686, 588);
            //itemPanel.Size = new Size(202, 372);
#else
            infoPanel.Location = new Point(0, 315);
            Size = new Size(686, 498);
#endif
        }

        private void DisableResize()
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateCells()
        {
            for (int i = 0; i < 8; ++i)
            {
                var boxList = new List<Box>();
                _boxes.Add(boxList);
                for (int j = 0; j < 8; ++j)
                {
#if !DEBUG
                    if (j >= 6 || i >= 6)
                    {
                        continue;
                    }
#endif
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
                    boxList.Add(box);

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
                }
            }
        }

        Bitmap GetCurrentShape(float imageSizeRatio = 1.0f)
        {
            if (Current <= 0)
            {
                return null;
            }

            Bitmap bt = new Bitmap(310, 273);
            Graphics g = Graphics.FromImage(bt);

            g.CopyFromScreen(this.Location.X + 15, this.Location.Y + 54
                , 0, 0, new Size(bt.Width, bt.Height));

            Clipboard.SetImage(bt);

            Bitmap newImage = new Bitmap((int)(310 * imageSizeRatio * 0.25f), (int)(273 * imageSizeRatio * 0.25f));
            g = Graphics.FromImage(newImage);
            g.FillRectangle(Brushes.Black, 0, 0, newImage.Width, newImage.Height);
            g.DrawImage(bt, 0, 0, (int)(310 * imageSizeRatio * 0.25f), (int)(273 * imageSizeRatio * 0.25f));

            return newImage;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                LoadFile(openFileDialog1.FileName);
            }
        }
    }
}
