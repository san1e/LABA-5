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
    class Rhomb : Figure
    {
        private int horDiagLen;
        private int vertDiagLen;
        private System.Windows.Forms.Timer timer;

        public Rhomb(Form form, int centerX, int centerY, int horDiagLen, int vertDiagLen)
        {
            this.form = form;
            this.centerX = centerX;
            this.centerY = centerY;
            this.horDiagLen = horDiagLen;
            this.vertDiagLen = vertDiagLen;

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
            Point[] points = new Point[]
            {
            new Point(centerX, centerY - vertDiagLen / 2),
            new Point(centerX + horDiagLen / 2, centerY),
            new Point(centerX, centerY + vertDiagLen / 2),
            new Point(centerX - horDiagLen / 2, centerY)
            };

            using (Graphics g = form.CreateGraphics())
            {
                g.FillPolygon(Brushes.Black, points);
            }
        }

        public override void HideDrawingBackGround()
        {
            Point[] points = new Point[]
            {
            new Point(centerX, centerY - vertDiagLen / 2),
            new Point(centerX + horDiagLen / 2, centerY),
            new Point(centerX, centerY + vertDiagLen / 2),
            new Point(centerX - horDiagLen / 2, centerY)
            };

            using (Graphics g = form.CreateGraphics())
            {
                g.FillPolygon(SystemBrushes.Control, points);
            }
        }
    }

}
