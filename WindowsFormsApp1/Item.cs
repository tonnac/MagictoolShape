using System.Drawing;
using Nevron.Nov.UI;

namespace WindowsFormsApp1
{
    class Item
    {
        public ulong Value { get; }
        public NListBoxItem ListBoxItem { get; }
        public byte[] BitmapBytes { get; }
        
        public Item(ulong value, NListBoxItem listBoxItem, byte[] bitmapBytes)
        {
            Value = value;
            ListBoxItem = listBoxItem;
            BitmapBytes = bitmapBytes;
        }

        protected bool Equals(Item other)
        {
            return Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Item) obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}