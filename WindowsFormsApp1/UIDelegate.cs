using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Nevron.Nov.Dom;
using Nevron.Nov.Graphics;
using Nevron.Nov.UI;

namespace WindowsFormsApp1
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

        private void testMakePanelBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = GetCurrentShape();


            if (bitmap == null)
            {
                return;
            }

            ImageConverter converter = new ImageConverter();
            var abcde = (byte[]) converter.ConvertTo(bitmap, typeof(byte[]));

            NImageSource mImageSource = new NBytesImageSource(abcde);
            NImage image = new NImage(mImageSource);
            var Item = new NListBoxItem(image);
            NBorder border = new NBorder();
            border.InnerStroke = new NStroke(1.5, NColor.Black);
            Item.MouseDown += ItemOnMouseDown;
            Item.Border = border;
            itemListBox.Items.Add(Item);
        }

        private void ItemOnMouseDown(NMouseButtonEventArgs args)
        {
            if (args.Button == ENMouseButtons.Right)
            {
                // Mark the event as handled
                args.Cancel = true;

                // Create the menu to show as context menu
                NMenu menu = new NMenu();
                var copyValue = new NMenuItem("값 복사");
                copyValue.Click += Copy_Click;
                var copyImage = new NMenuItem("이미지 복사");
                copyImage.Click += CopyImageOnClick;

                menu.Items.Add(copyValue);
                menu.Items.Add(copyImage);
                menu.Items.Add(new NMenuSeparator());
                menu.Items.Add(new NCheckableMenuItem(null, "4) Checkable Item", true));

                // Open the menu as context menu
                NPopupWindow.OpenInContext(new NPopupWindow(menu), args.CurrentTargetNode, args.ScreenPosition);
            }
        }

        private void CopyImageOnClick(NEventArgs arg)
        {
            CopyImage();
        }

        private void Copy_Click(Nevron.Nov.Dom.NEventArgs arg)
        {
            CopyValue();
        }

        private void addButton_Click(NEventArgs arg)
        {
            if (_current == 0)
            {
                return;
            }

            Bitmap bitmap = GetCurrentShape();
            if (bitmap == null)
            {
                return;
            }
            NListBoxItem newItem = MakeBoxItem(bitmap);
            AddNewItem(newItem, _current);
        }
        
        private void saveBtn_Click(object sender, EventArgs e)
        {
            ItemShapeFileIO itemShapeFileIo = new ItemShapeFileIO(_fileName);
            itemShapeFileIo.SaveFile(_items);
        }
    }
}