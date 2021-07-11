using System.Drawing;
using Nevron.Nov.Graphics;
using Nevron.Nov.UI;

namespace MagictoolShape
{
    public class Item
    {
        public Item(ulong value, NListBoxItem listBoxItem, byte[] bitmapBytes)
        {
            Value = value;
            ListBoxItem = listBoxItem;
            BitmapBytes = bitmapBytes;
        }

        public ulong Value { get; set; }
        public NListBoxItem ListBoxItem { get; }
        public byte[] BitmapBytes { get; private set; }

        public bool Modify(ulong value, Bitmap bitmap)
        {
            Value = value;

            var converter = new ImageConverter();
            BitmapBytes = (byte[]) converter.ConvertTo(bitmap, typeof(byte[]));

            var children = ListBoxItem.GetChildren();
            
            NImageSource mImageSource = new NBytesImageSource(BitmapBytes);
            NImage image = new NImage(mImageSource);

            foreach (var aItem in children.Items)
            {
                if (aItem is NImageBox g)
                {
                    g.Image = image;
                    return true;
                }
            }

            return false;
        }

        protected bool Equals(Item other)
        {
            return Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Item) obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}