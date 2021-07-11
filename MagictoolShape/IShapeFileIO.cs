using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace MagictoolShape
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

        public void SaveFile(List<Item> items, int imageSizeRatio)
        {
            var fs = File.Open(GetFilePath(), FileMode.Create);

            using (var wr = new BinaryWriter(fs))
            {
                wr.Write(imageSizeRatio);
                wr.Write(items.Count);
                foreach (var item in items)
                {
                    wr.Write(item.Value);
                    wr.Write(item.BitmapBytes.Length);
                    wr.Write(item.BitmapBytes);
                }
            }
        }

        public Tuple<List<LoadedObject>, int> LoadFile()
        {
            var fi = new FileInfo(GetFilePath());

            if (fi.Exists)
            {
                var items = new List<LoadedObject>();
                int imageSizeRatio = 100;
                using (var rdr = new BinaryReader(File.Open(GetFilePath(), FileMode.Open)))
                {
                    imageSizeRatio = rdr.ReadInt32();
                    var count = rdr.ReadInt32();

                    for (var i = 0; i < count; i++)
                    {
                        var value = rdr.ReadUInt64();
                        var length = rdr.ReadInt32();
                        var imageBytes = rdr.ReadBytes(length);
                        items.Add(new LoadedObject(value, imageBytes));
                    }
                }

                return new Tuple<List<LoadedObject>, int>(items, imageSizeRatio);
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