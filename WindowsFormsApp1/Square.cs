using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Square : Figure
    {
        private int sideLength;
        private System.Windows.Forms.Timer timer;

        public Square(Form form, int centerX, int centerY, int sideLength)
        {
            this.form = form;
            this.centerX = centerX;
            this.centerY = centerY;
            this.sideLength = sideLength;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // Встановіть відповідний інтервал таймера
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            MoveRight();
        }

        public override void DrawBlack()
        {
            using (Graphics g = form.CreateGraphics())
            {
                g.FillRectangle(Brushes.Black, centerX - sideLength / 2, centerY - sideLength / 2, sideLength, sideLength);
            }
        }

        public override void HideDrawingBackGround()
        {
            using (Graphics g = form.CreateGraphics())
            {
                g.FillRectangle(SystemBrushes.Control, centerX - sideLength / 2, centerY - sideLength / 2, sideLength, sideLength);
            }
        }
    }


}



