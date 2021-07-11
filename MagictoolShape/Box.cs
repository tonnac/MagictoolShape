using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Box
    {
        public Box(PictureBox pictureBox, ulong value)
        {
            Value = value;
            _pictureBox = pictureBox;
            _pictureBox.BackColor = Color.White;
        }


        public ulong Value { get; }
        private readonly PictureBox _pictureBox;
        private bool _isActive = false;

        public PictureBox PictureBox => _pictureBox;
        public bool IsActive
        {
            get => _isActive;
            set
            {
                _isActive = value;
                _pictureBox.BackColor = _isActive ? Color.Black : Color.White;
            }
        }
    }
}
