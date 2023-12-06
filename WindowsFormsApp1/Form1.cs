using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Circle circle;
        private Square square;
        private Rhomb rhomb;
        private bool isAnimationRunning = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }



        private void button1_Click(object sender, EventArgs e)
        {
          circle = new Circle(this, 50, 100, 20);
          circle.MoveRight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            square = new Square(this, 150, 100, 30);
            square.MoveRight();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                rhomb = new Rhomb(this, 250, 100, 40, 60);
                rhomb.MoveRight();
        }

        private void StopCurrentAnimation()
        {
            
        }
    }
}
