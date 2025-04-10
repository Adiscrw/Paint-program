using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.IO;
using System.Drawing.Text;

namespace hodina_21._3
{
    public partial class Form1 : Form
    {
        private bool mouseDown = false;
        private const int disabledButton = 0;
        private const int pencilButton = 1;
        private const int rubberButton = 2;
        private const int colorButton = 3;
        private const int circleButton = 4;
        private const int squareButton = 5;
        private const int highliterButton = 6;
        private const int bucketButton = 7;
        private const int spray = 8;
        private const int ellipseButton = 9;

        private Bitmap canvasBitmap;
        private bool isDrawing = false;
        private bool pencilSwitch = false;
        private bool shapeDraw = false;
        private Point lastPoint = Point.Empty;
        private Point shapePoint = Point.Empty;
        private int lineWidth;
        private Color lineColor;
        private Graphics panelGraphics;
        private int buttonVariable = disabledButton;
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = 3;
            panelGraphics = panel1.CreateGraphics();
            lineColor = Color.Black;
            canvasBitmap = new Bitmap(panel1.Width, panel1.Height);
            panel1.BackgroundImage = canvasBitmap;
            panel1.BackColor = Color.White;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.MouseDown += Panel1_MouseDown;
            panel1.MouseMove += Panel1_MouseMove;
            panel1.MouseUp += Panel1_MouseUp;

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            shapePoint = e.Location;
            mouseDown = !mouseDown;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                if (buttonVariable == pencilButton)
                {
                    Pen pen = new Pen(lineColor, lineWidth); // Tlouöùka 2px, Ëern· barva
                    panelGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    panelGraphics.DrawLine(pen, lastPoint, e.Location);
                    lastPoint = e.Location;
                }
                if (buttonVariable == rubberButton)
                {
                    Pen pen = new Pen(Color.White, lineWidth); // Tlouöùka 2px, Ëern· barva
                    panelGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    panelGraphics.DrawLine(pen, lastPoint, e.Location);
                    lastPoint = e.Location;
                }
                if (buttonVariable == highliterButton)
                {
                    Pen pen = Highlight(panelGraphics, lineColor, lineWidth);
                    panelGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    panelGraphics.DrawLine(pen, lastPoint, e.Location);
                    lastPoint = e.Location;
                }
                if (buttonVariable == spray)
                {
                    Pen pen = new Pen(lineColor, lineWidth); // Tlouöùka 2px, Ëern· barva
                    panelGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    Spray(lastPoint, lineWidth, 50);
                    lastPoint = e.Location;
                }

            }

        }
        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = !mouseDown;
            if (buttonVariable == circleButton)
            {
                lastPoint = e.Location;
                int distance = (int)Distance(shapePoint, lastPoint);
                using (Graphics g = Graphics.FromImage(canvasBitmap))
                {
                    Pen pen = new Pen(lineColor, lineWidth);
                    DrawCircle(distance, shapePoint, pen);
                }
            }
            if (buttonVariable == squareButton)
            {
                lastPoint = e.Location;
                int distance = (int)Distance(shapePoint, lastPoint);
                using (Graphics g = Graphics.FromImage(canvasBitmap))
                {
                    Pen pen = new Pen(lineColor, lineWidth);
                    DrawSquare(distance, shapePoint, pen);
                }
            }
            if (buttonVariable == ellipseButton)
            {
                lastPoint = e.Location;
                using (Graphics g = Graphics.FromImage(canvasBitmap))
                {
                    Pen pen = new Pen(lineColor, lineWidth);
                    DrawFreeEllipse(pen);
                }


            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private double Distance(Point shapePoint, Point lastPoint)
        {
            int dx = lastPoint.X - shapePoint.X;
            int dy = lastPoint.Y - shapePoint.Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        private Pen Highlight(Graphics panelGraphics, Color lineColor, int lineWidth)
        {
            Pen highlighter = new Pen(Color.FromArgb(128, lineColor.R, lineColor.G, lineColor.B), lineWidth);
            return highlighter;
        }

        private void Spray(Point lastPoint, int lineWidth, int sprayedPoints)
        {
            Random rng = new Random();
            Brush brush = new SolidBrush(lineColor);
            int positionX;
            int positionY;
            int random;
            for (int i = 0; i < sprayedPoints * lineWidth / 3; i++)
            {
                random = rng.Next(0, lineWidth * 10);//udela tlustsi stopu
                positionX = (lastPoint.X + random);
                random = rng.Next(0, lineWidth * 10);
                positionY = (lastPoint.Y + random);
                panelGraphics.FillEllipse(brush, positionX, positionY, 4, 4);

            }
        }
        private void DrawFreeEllipse(Pen pen)
        {
            int xDistance = shapePoint.X - lastPoint.X;
            int yDistance = shapePoint.Y - lastPoint.Y;
            panelGraphics.DrawEllipse(pen, shapePoint.X, shapePoint.Y, xDistance, yDistance);
        }
        private void DrawCircle(int distance, Point center, Pen pen)
        {
            panelGraphics.DrawEllipse(pen, center.X, center.Y, distance, distance);
        }
        private void DrawSquare(int distance, Point corner, Pen pen)
        {
            panelGraphics.DrawRectangle(pen, corner.X, corner.Y, distance, distance);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lineWidth = (int)numericUpDown1.Value;
        }
        private void circle_Click(object sender, EventArgs e)
        {
            if (buttonVariable != circleButton)
            {
                buttonVariable = circleButton;
            }
            else
            {
                buttonVariable = disabledButton;
            }
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            if (buttonVariable != squareButton)
            {
                buttonVariable = squareButton;
            }
            else
            {
                buttonVariable = disabledButton;
            }
        }

        private void highliter_Click(object sender, EventArgs e)
        {
            if (buttonVariable != highliterButton)
            {
                buttonVariable = highliterButton;
            }
            else
            {
                buttonVariable = disabledButton;
            }
        }

        private void bucket_Click(object sender, EventArgs e)
        {
            if (buttonVariable != bucketButton)
            {
                buttonVariable = bucketButton;
            }
            else
            {
                buttonVariable = disabledButton;
            }
        }

        private void sprayButton_Click(object sender, EventArgs e)
        {
            if (buttonVariable != spray)
            {
                buttonVariable = spray;
            }
            else
            {
                buttonVariable = disabledButton;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.AllowFullOpen = true;
                colorDialog.FullOpen = true;
                colorDialog.Color = lineColor;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    lineColor = colorDialog.Color;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (buttonVariable != rubberButton)
            {
                buttonVariable = rubberButton;
            }
            else
            {
                buttonVariable = disabledButton;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonVariable != pencilButton)
            {
                buttonVariable = pencilButton;
            }
            else
            {
                buttonVariable = disabledButton;
            }
        }

        private void ellipse_Click(object sender, EventArgs e)
        {
            if (buttonVariable != ellipseButton)
            {
                buttonVariable = ellipseButton;
            }
            else
            {
                buttonVariable = disabledButton;
            }
        }
    }
}