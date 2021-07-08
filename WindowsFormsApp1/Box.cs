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
        public Box(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            IsActive = false;
        }


        private PictureBox pictureBox;
        private bool isActive = false;

        public PictureBox PictureBox => pictureBox;
        public bool IsActive
        {
            get => isActive;
            set
            {
                isActive = value;
                pictureBox.BackColor = isActive ? Color.Black : Color.White;
            }
        }
    }
}
