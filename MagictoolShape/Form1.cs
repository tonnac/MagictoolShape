using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
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
        private bool _isSave = false;
        private int _imageSizeRatio = 100;
        private readonly string _fileName = "save";
        private readonly List<Item> _items = new List<Item>();
        private readonly List<List<Box>> _boxes = new List<List<Box>>();
        private Item _selectedItem;

        private Item SelectedItem
        {
            get => _selectedItem;
            set
            {
                itemListBox.Selection.Deselect(itemListBox.Selection.SelectedItems);
                _selectedItem = value;
                deleteBtn.Enabled = _selectedItem != null;
                addBtn.Enabled = false;
                modifyBtn.Enabled = false;

                if (_selectedItem == null)
                {
                }
                else
                {
                }
            }
        }
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

                    decimalText.Text = _current.ToString();
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
            modifyBtn.Enabled = false;
            deleteBtn.Enabled = false;
            FormClosing += (sender, args) =>
            {
                if (_isSave)
                {
                    var result = MessageBox.Show(@"변경 내용을 저장하겠습니까?", @"MagicTool Shape", MessageBoxButtons.YesNoCancel);

                    switch (result)
                    {
                        case DialogResult.Cancel:
                            args.Cancel = true;
                            break;
                        case DialogResult.Yes:
                            ItemShapeFileIO itemShapeFileIo = new ItemShapeFileIO(_fileName);
                            itemShapeFileIo.SaveFile(_items, _imageSizeRatio);
                            _isSave = false;
                            break;
                    }
                }
            };
        }

        // ReSharper disable once IdentifierTypo
        private void LoadFile_Imple(ItemShapeFileIO itemShapeFileIo)
        {
            itemListBox.Items.Clear();
            _items.Clear();
            Current = 0;
            var loadedObjects = itemShapeFileIo.LoadFile();
            if (loadedObjects == null) return;
            _imageSizeRatio = loadedObjects.Item2;
            imageRatioText.Text = _imageSizeRatio.ToString();
            foreach (var loadedObject in loadedObjects.Item1)
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
            NImageSource mImageSource = new NBytesImageSource(imageBytes);
            var image = new NImage(mImageSource);
            var item = new NListBoxItem(image);
            var border = new NBorder {InnerStroke = new NStroke(1.5, NColor.Black)};
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
                        boxItem.MouseDown += delegate(NMouseButtonEventArgs args)
                        {
                            // ReSharper disable once AccessToModifiedClosure
                            var _item = newItem;
                            if (args.Button == ENMouseButtons.Right)
                            {
                                itemListBox.Selection.SingleSelect(boxItem);
                                // Mark the event as handled
                                args.Cancel = true;

                                // Create the menu to show as context menu
                                NMenu menu = new NMenu();
                                var copyValue = new NMenuItem("값 복사");
                                copyValue.Click += eventArgs =>
                                {
                                    CopyValue(_item.Value);   
                                };
                                var copyImage = new NMenuItem("이미지 복사");
                                copyImage.Click += eventArgs =>
                                {
                                    CopyImage(_item.Value);
                                };
                                var deleteMenu = new NMenuItem("삭제");
                                deleteMenu.Click += eventArgs =>
                                {
                                    DeleteItem(_item.Value);
                                };

                                menu.Items.Add(copyValue);
                                menu.Items.Add(copyImage);
                                menu.Items.Add(new NMenuSeparator());
                                menu.Items.Add(deleteMenu);

                                // Open the menu as context menu
                                NPopupWindow.OpenInContext(new NPopupWindow(menu), args.CurrentTargetNode, args.ScreenPosition);
                            }
                            else if (args.ButtonEvent == ENMouseButtonEvent.LeftButtonDoubleClick)
                            {
                                SelectedItem = _item;
                                Current = _item.Value;
                            }
                
                        };
                    }
                }
            }

            if (newItem != null)
            {
                _items.Add(newItem);
                itemListBox.Items.Add(boxItem);
            }
        }

        private void CopyValue(ulong value = 0)
        {
            if (Current <= 0 && value == 0)
            {
                return;
            }

            ulong copyValue = value > 0 ? value : Current;
            Clipboard.SetText(copyValue.ToString());
            toolStripStatusLabel1.Text = $@"클립보드에 {copyValue} 값이 복사 됐습니다.";
        }

        private void CopyImage(ulong value = 0)
        {
            Bitmap img = null;
            if (value == 0)
            {
                img = GetCurrentShape(int.TryParse(imageRatioText.Text, out int r) ? r * 0.01f : 1.0f);
            }
            else
            {
                foreach (var item in _items)
                {
                    if (item.Value == value)
                    {
                        using (var ms = new MemoryStream(item.BitmapBytes))
                        {
                            img = new Bitmap(ms);
                            break;
                        }
                    }
                }
            }

            ulong copyValue = value > 0 ? value : Current;
            if (img != null)
            {
                Clipboard.SetImage(img);
                toolStripStatusLabel1.Text = $@"클립보드에 {copyValue} 이미지가 복사 됐습니다.";
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
            itemListBox.Size = new Size(115, 355);
            itemListBox.Location = new Point(542, 30);
            btnPanel.Location = new Point(437, 30);
#else
            btnPanel.Location = new Point(387, 30);
            itemListBox.Location = new Point(502, 30);
            itemListBox.Size = new Size(155, 280);
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

                        bool isExistSameValue = _items.FindAll(item => item.Value == Current).Count > 0;
                        if (SelectedItem != null)
                        {
                            modifyBtn.Enabled = !isExistSameValue;
                        }
                        addBtn.Enabled = !isExistSameValue;
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

        private bool DeleteItem(ulong value)
        {
            foreach (var item in _items)
            {
                if (item.Value == value)
                {
                    _items.Remove(item);
                    itemListBox.Items.Remove(item.ListBoxItem);
                    DeSelectItem();
                    _isSave = true;
                    return true;
                }
            }

            return false;
        }

        private void DeSelectItem()
        {
            if (itemListBox.Selection.SelectedItems.Count > 0)
            {
                itemListBox.Selection.Deselect(itemListBox.Selection.FirstSelected);
            }
            SelectedItem = null;
            Current = 0;
        }
    }
}
