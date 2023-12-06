using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public abstract class Figure
    {
        protected int centerX;
        protected int centerY;
        protected Form form;
        protected int speed = 5;
        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();
        public void MoveRight()
        {
                HideDrawingBackGround();
                centerX += speed;
                DrawBlack();
        }
    }
}
