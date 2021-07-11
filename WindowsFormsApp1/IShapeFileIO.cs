using System.Collections.Generic;
using System.IO;

namespace WindowsFormsApp1
{
    // ReSharper disable once InconsistentNaming
    internal class ItemShapeFileIO
    {
        public ItemShapeFileIO(string fileName, bool isFullPath = false)
        {
            FileName = fileName;
            IsFullPath = isFullPath;
        }

        private string FileName { get; }
        private bool IsFullPath { get; }

        private string GetFilePath()
        {
            return IsFullPath ? FileName : $@"./{FileName}.bin";
        }

        public void SaveFile(List<Item> items)
        {
            var fs = File.Open(GetFilePath(), FileMode.Create);

            using (var wr = new BinaryWriter(fs))
            {
                wr.Write(items.Count);
                foreach (var item in items)
                {
                    wr.Write(item.Value);
                    wr.Write(item.BitmapBytes.Length);
                    wr.Write(item.BitmapBytes);
                }
            }
        }

        public List<LoadedObject> LoadFile()
        {
            var fi = new FileInfo(GetFilePath());

            if (fi.Exists)
            {
                var items = new List<LoadedObject>();
                using (var rdr = new BinaryReader(File.Open(GetFilePath(), FileMode.Open)))
                {
                    var count = rdr.ReadInt32();

                    for (var i = 0; i < count; i++)
                    {
                        var value = rdr.ReadUInt64();
                        var length = rdr.ReadInt32();
                        var imageBytes = rdr.ReadBytes(length);
                        items.Add(new LoadedObject(value, imageBytes));
                    }
                }

                return items;
            }

            return null;
        }

        internal class LoadedObject
        {
            public LoadedObject(ulong value, byte[] imageBytes)
            {
                Value = value;
                ImageBytes = imageBytes;
            }

            public ulong Value { get; set; }
            public byte[] ImageBytes { get; set; }
        }
    }
}