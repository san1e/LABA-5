using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Circle : Figure
    {
        private int radius;
        private System.Windows.Forms.Timer timer;

        public Circle(Form form, int centerX, int centerY, int radius)
        {
            this.form = form;
            this.centerX = centerX;
            this.centerY = centerY;
            this.radius = radius;
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

                g.FillEllipse(Brushes.Black, centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            }
        }

        public override void HideDrawingBackGround()
        {
            using (Graphics g = form.CreateGraphics())
            {
                    g.FillEllipse(SystemBrushes.Control, centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            }
        }
    }
}
