using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7CSharp
{
    using Lab7CSharp.DrawingApplication;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    namespace DrawingApplication
    {
        // Базовий клас для всіх фігур
        abstract class Figure
        {
            protected int x, y; // Координати верхнього лівого кута фігури
            protected Color color; // Колір фігури

            public Figure(int x, int y, Color color)
            {
                this.x = x;
                this.y = y;
                this.color = color;
            }

            public abstract void Draw(Graphics g); // Віртуальний метод малювання

            public virtual void Move(int dx, int dy) // Віртуальний метод переміщення
            {
                x += dx;
                y += dy;
            }
        }

        // Похідний клас для круга
        class Circle : Figure
        {
            private int radius;

            public Circle(int x, int y, int radius, Color color) : base(x, y, color)
            {
                this.radius = radius;
            }

            public override void Draw(Graphics g)
            {
                using (Brush brush = new SolidBrush(color))
                {
                    g.FillEllipse(brush, x, y, radius * 2, radius * 2);
                }
            }
        }

        // Похідний клас для сектора
        class Sector : Figure
        {
            private int startAngle;
            private int sweepAngle;

            public Sector(int x, int y, int startAngle, int sweepAngle, Color color) : base(x, y, color)
            {
                this.startAngle = startAngle;
                this.sweepAngle = sweepAngle;
            }

            public override void Draw(Graphics g)
            {
                using (Brush brush = new SolidBrush(color))
                {
                    g.FillPie(brush, x, y, 100, 100, startAngle, sweepAngle);
                }
            }
        }

        // Похідний клас для зафарбованого прямокутника
        class FilledRectangle : Figure
        {
            private int width, height;

            public FilledRectangle(int x, int y, int width, int height, Color color) : base(x, y, color)
            {
                this.width = width;
                this.height = height;
            }

            public override void Draw(Graphics g)
            {
                using (Brush brush = new SolidBrush(color))
                {
                    g.FillRectangle(brush, x, y, width, height);
                }
            }
        }

        // Похідний клас для зірки
        class Star : Figure
        {
            private Point[] points;

            public Star(int x, int y, Point[] points, Color color) : base(x, y, color)
            {
                this.points = points;
            }

            public override void Draw(Graphics g)
            {
                using (Brush brush = new SolidBrush(color))
                {
                    g.FillPolygon(brush, points);
                }
            }
        }

       
    }

    public partial class Form4 : Form
    {
       
            private Random random = new Random();
            private Figure[] figures = new Figure[10]; // Масив для зберігання фігур
          

        public Form4() { 
                InitializeComponent();
                InitializePictureBox();
                GenerateFigures();
                pictureBox1.Paint += PictureBox_Paint;
            }

            private void InitializePictureBox()
            {
              
                pictureBox1.Dock = DockStyle.Fill;
                Controls.Add(pictureBox1);
            }

            private void GenerateFigures()
            {
                // Генеруємо випадкові фігури і додаємо до масиву
                for (int i = 0; i < figures.Length; i++)
                {
                    int x = random.Next(pictureBox1.Width);
                    int y = random.Next(pictureBox1.Height);
                    Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                    switch (random.Next(4))
                    {
                        case 0:
                            figures[i] = new Circle(x, y, 50, color);
                            break;
                        case 1:
                            figures[i] = new Sector(x, y, 0, 90, color);
                            break;
                        case 2:
                            figures[i] = new FilledRectangle(x, y, 100, 50, color);
                            break;
                        case 3:
                            Point[] points = {
                            new Point(x, y),
                            new Point(x + 20, y + 80),
                            new Point(x + 80, y + 30),
                            new Point(x - 50, y + 30),
                            new Point(x + 10, y + 80)
                        };
                            figures[i] = new Star(x, y, points, color);
                            break;
                    }
                }
            }

            private void PictureBox_Paint(object sender, PaintEventArgs e)
            {
                // Малюємо всі фігури на PictureBox
                foreach (Figure figure in figures)
                {
                    figure.Draw(e.Graphics);
                }
            }
        
    

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
