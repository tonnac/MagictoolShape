using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Nevron.Nov.Dom;
using Nevron.Nov.Graphics;
using Nevron.Nov.UI;

namespace MagictoolShape
{
    public partial class Form1
    {
        private void imageCopyBtn_Click(object sender, EventArgs e)
        {
            CopyImage();
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
                value = string.IsNullOrEmpty(decimalText.Text) ? 0 : MaxValue;
            }
            else
            {
                value = Clamp(value, ulong.MinValue, MaxValue);
            }

            decimalText.Text = value.ToString();
            Current = value;
        }

        private void numberCopyBtn_Click(object sender, EventArgs e)
        {
            CopyValue();
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemShapeFileIO itemShapeFileIo = new ItemShapeFileIO(_fileName);
            itemShapeFileIo.SaveFile(_items, _imageSizeRatio);
            _isSave = false;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            DeSelectItem();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (_current == 0)
            {
                MessageBox.Show(@"저장 할 수 없는 값", @"오류");
                return;
            }
            
            foreach (var item in _items)
            {
                if (item.Value == _current)
                {
                    MessageBox.Show(@"현재 저장이 되어있는 값입니다.", @"오류");
                    return;
                }
            }

            Bitmap bitmap = GetCurrentShape();
            if (bitmap == null)
            {
                return;
            }
            NListBoxItem newItem = MakeBoxItem(bitmap);
            AddNewItem(newItem, _current);
            DeSelectItem();
            _isSave = true;
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            _selectedItem?.Modify(_current, GetCurrentShape());
            DeSelectItem();
            _isSave = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteItem(SelectedItem.Value);
        }

        private void imageRatioText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                _isSave = true;
            }
        }

        private void imageRatioText_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(imageRatioText.Text, out int ratio))
            {
                _imageSizeRatio = ratio;
            }
            else
            {
                imageRatioText.Text = _imageSizeRatio.ToString();
            }
        }
    }
}