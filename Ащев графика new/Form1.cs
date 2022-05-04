using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ащев_графика_new
{
    public partial class Form1 : Form
    {
        int x = 200;
        int x1 = 150;
        int y = 200;
        int y1 = 150;
        int dx = 6;
        int dx1 = 3;
        int dy = 6;
        int dy1 = 3;

        int score = 0;

        Image cursorImage = Image.FromFile("..\\..\\images\\handler.jpg");
        int cursorSize = 50;
        Image targetImage = Image.FromFile("..\\..\\images\\target.jpg");
        int targetSize = 100;
        Image Apple = Image.FromFile("..\\..\\images\\1.jpg");
        int AppleSize = 100;

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);
            UpdateStyles();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Apples();
            Target();
            Game();

            var cursorPosition = PointToClient(Cursor.Position);
            
            var g = e.Graphics;

            var targetRect = new Rectangle(x, y, targetSize, targetSize);
            g.DrawImage(targetImage, targetRect);

            var AppleRect = new Rectangle(x1, y1, AppleSize, AppleSize);
            g.DrawImage(Apple, AppleRect);

            var cursorRect = new Rectangle(cursorPosition.X - cursorSize / 2,
                cursorPosition.Y - cursorSize / 2, cursorSize, cursorSize);
            g.DrawImage(cursorImage, cursorRect);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
        public void Apples()
        {
            if (x1 >= Form1.ActiveForm.Width - 1.15 * AppleSize || x1 <= 0)
                dx1 = -dx1;

            x1 += dx1;

            if (y1 >= Form1.ActiveForm.Height - 1.35 * AppleSize || y1 <= 0)
                dy1 = -dy1;

            y1 += dy1;
        }
        public void Target()
        {

            if (x >= Form1.ActiveForm.Width - 1.15 * targetSize || x <= 0)
                dx = -dx;

            x += dx;

            if (y >= Form1.ActiveForm.Height - 1.35 * targetSize || y <= 0)
                dy = -dy;

            y += dy;
        }
        public void Game()
        {
            var cPos = PointToClient(Cursor.Position);

            var xcur = cPos.X - cursorSize / 2;
            var ycur = cPos.Y - cursorSize / 2;

            if (score <= -100)
            {
                score = -100;
                label1.Text = "Game Over";
                dx = 0;
                dx1 = 0;
                dy = 0;
                dy1 = 0;
                
            }
            else
            {
                if (score >= 100)
                {
                    score = 100;
                    label1.Text = "You Win";
                    dx = 0;
                    dx1 = 0;
                    dy = 0;
                    dy1 = 0;
                }
                else
                {
                    if (xcur >= x - targetSize / 2 & xcur <= x + targetSize &
                        ycur >= y - targetSize / 2 & ycur <= y + targetSize)
                        score += 1;
                    label1.Text = $"Ваш счёт {score}";

                    if (xcur >= x1 - targetSize / 2 & xcur <= x1 + targetSize &
                        ycur >= y1 - targetSize / 2 & ycur <= y1 + targetSize)
                        score -= 1;
                    label1.Text = $"Ваш счёт {score}";
                }
            }
        }
    }
}
