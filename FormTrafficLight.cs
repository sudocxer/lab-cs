using System.Drawing.Drawing2D;

namespace lab5_c_
{
    public partial class FormTrafficLight : Form
    {
        private enum LightState
        {
            Red,
            Green,
            Yellow
        }

        private static readonly Color RedLamp = Color.FromArgb(230, 30, 30);
        private static readonly Color YellowLamp = Color.FromArgb(255, 200, 0);
        private static readonly Color GreenLamp = Color.FromArgb(30, 200, 70);

        private LightState state = LightState.Red;
        private int secondsLeft;

        public FormTrafficLight()
        {
            InitializeComponent();
            secondsLeft = Duration(state);
        }

        private static int Duration(LightState state) => state == LightState.Yellow ? 2 : 5;

        private void FormTrafficLight_Load(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void NextState()
        {
            state = state switch
            {
                LightState.Red => LightState.Green,
                LightState.Green => LightState.Yellow,
                _ => LightState.Red,
            };

            secondsLeft = Duration(state);
            UpdateStatus();
            canvas.Invalidate();
        }

        private void UpdateStatus()
        {
            switch (state)
            {
                case LightState.Red:
                    labelState.Text = "Красный — стоп";
                    labelState.ForeColor = Color.Firebrick;
                    break;
                case LightState.Green:
                    labelState.Text = "Зелёный — движение разрешено";
                    labelState.ForeColor = Color.ForestGreen;
                    break;
                default:
                    labelState.Text = "Жёлтый — внимание";
                    labelState.ForeColor = Color.DarkGoldenrod;
                    break;
            }

            labelTimer.Text = timerLight.Enabled
                ? $"До переключения: {secondsLeft} с"
                : "Автоматический режим выключен";
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            timerLight.Enabled = !timerLight.Enabled;
            buttonStartStop.Text = timerLight.Enabled ? "Стоп" : "Старт";
            secondsLeft = Duration(state);
            UpdateStatus();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            NextState();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timerLight_Tick(object sender, EventArgs e)
        {
            secondsLeft--;
            if (secondsLeft <= 0)
            {
                NextState();
            }
            else
            {
                UpdateStatus();
            }
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int width = canvas.ClientSize.Width;
            int height = canvas.ClientSize.Height;
            int groundY = height - 60;
            int centerX = width / 2;

            DrawBackground(g, width, height, groundY);

            Rectangle housing = new Rectangle(centerX - 62, 16, 124, 316);

            using (Brush poleBrush = new SolidBrush(Color.FromArgb(85, 85, 90)))
            {
                g.FillRectangle(poleBrush, centerX - 9, housing.Bottom - 4, 18, groundY - housing.Bottom + 4);
                g.FillRectangle(poleBrush, centerX - 32, groundY - 10, 64, 10);
            }

            using (GraphicsPath body = RoundedRectangle(housing, 20))
            using (Brush bodyBrush = new SolidBrush(Color.FromArgb(38, 38, 42)))
            using (Pen outline = new Pen(Color.FromArgb(12, 12, 14), 4))
            {
                g.FillPath(bodyBrush, body);
                g.DrawPath(outline, body);
            }

            DrawLamp(g, new Point(centerX, 88), RedLamp, state == LightState.Red);
            DrawLamp(g, new Point(centerX, 184), YellowLamp, state == LightState.Yellow);
            DrawLamp(g, new Point(centerX, 280), GreenLamp, state == LightState.Green);

            using (Font font = new Font("Segoe UI", 12, FontStyle.Bold))
            {
                g.DrawString("Светофор", font, Brushes.White, 12, groundY + 30);
            }
        }

        private static void DrawBackground(Graphics g, int width, int height, int groundY)
        {
            using (LinearGradientBrush sky = new LinearGradientBrush(
                new Rectangle(0, 0, width, groundY),
                Color.FromArgb(140, 195, 245),
                Color.White,
                LinearGradientMode.Vertical))
            {
                g.FillRectangle(sky, 0, 0, width, groundY);
            }

            using (Brush asphalt = new SolidBrush(Color.FromArgb(70, 70, 75)))
            {
                g.FillRectangle(asphalt, 0, groundY, width, height - groundY);
            }

            using (Pen marking = new Pen(Color.White, 3) { DashStyle = DashStyle.Dash })
            {
                g.DrawLine(marking, 0, groundY + 24, width, groundY + 24);
            }
        }

        private static void DrawLamp(Graphics g, Point center, Color color, bool lit)
        {
            Rectangle lamp = new Rectangle(center.X - 38, center.Y - 38, 76, 76);

            Point[] hood =
            {
                new Point(center.X - 46, lamp.Top - 2),
                new Point(center.X + 46, lamp.Top - 2),
                new Point(center.X + 34, lamp.Top - 14),
                new Point(center.X - 34, lamp.Top - 14),
            };

            using (Brush hoodBrush = new SolidBrush(Color.FromArgb(22, 22, 25)))
            {
                g.FillPolygon(hoodBrush, hood);
            }

            if (lit)
            {
                using (Brush glow = new SolidBrush(Color.FromArgb(70, color)))
                {
                    g.FillEllipse(glow, Rectangle.Inflate(lamp, 14, 14));
                }

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(lamp);
                    using (PathGradientBrush brush = new PathGradientBrush(path))
                    {
                        brush.CenterPoint = new PointF(center.X - 12, center.Y - 12);
                        brush.CenterColor = Lighten(color, 130);
                        brush.SurroundColors = new[] { color };
                        g.FillEllipse(brush, lamp);
                    }
                }
            }
            else
            {
                Color dark = Color.FromArgb(color.R / 4, color.G / 4, color.B / 4);
                using (Brush off = new SolidBrush(dark))
                {
                    g.FillEllipse(off, lamp);
                }
            }

            using (Pen rim = new Pen(Color.FromArgb(10, 10, 12), 3))
            {
                g.DrawEllipse(rim, lamp);
            }
        }

        private static Color Lighten(Color color, int amount)
        {
            return Color.FromArgb(
                Math.Min(255, color.R + amount),
                Math.Min(255, color.G + amount),
                Math.Min(255, color.B + amount));
        }

        private static GraphicsPath RoundedRectangle(Rectangle bounds, int radius)
        {
            int d = radius * 2;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.Left, bounds.Top, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Top, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
