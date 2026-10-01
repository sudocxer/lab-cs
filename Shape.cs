namespace lab5_c_
{
    public enum ToolKind
    {
        Line,
        Rectangle,
        Ellipse,
        Polygon,
        Text
    }

    public class Shape
    {
        public ToolKind Kind { get; }
        public List<Point> Points { get; } = new();
        public Color Color { get; }
        public float Width { get; }
        public bool Filled { get; }
        public string Text { get; }

        public Shape(ToolKind kind, Color color, float width, bool filled, string text = "")
        {
            Kind = kind;
            Color = color;
            Width = width;
            Filled = filled;
            Text = text;
        }

        public Rectangle Bounds
        {
            get
            {
                Point a = Points[0];
                Point b = Points[^1];
                return new Rectangle(
                    Math.Min(a.X, b.X),
                    Math.Min(a.Y, b.Y),
                    Math.Abs(a.X - b.X),
                    Math.Abs(a.Y - b.Y));
            }
        }

        public void Draw(Graphics g)
        {
            using Pen pen = new Pen(Color, Width);
            using Brush brush = new SolidBrush(Color);

            switch (Kind)
            {
                case ToolKind.Line:
                    g.DrawLine(pen, Points[0], Points[^1]);
                    break;

                case ToolKind.Rectangle:
                    if (Filled)
                        g.FillRectangle(brush, Bounds);
                    else
                        g.DrawRectangle(pen, Bounds);
                    break;

                case ToolKind.Ellipse:
                    if (Filled)
                        g.FillEllipse(brush, Bounds);
                    else
                        g.DrawEllipse(pen, Bounds);
                    break;

                case ToolKind.Polygon:
                    if (Filled)
                        g.FillPolygon(brush, Points.ToArray());
                    else
                        g.DrawPolygon(pen, Points.ToArray());
                    break;

                case ToolKind.Text:
                    using (Font font = new Font("Segoe UI", 16, FontStyle.Bold))
                    {
                        g.DrawString(Text, font, brush, Points[0]);
                    }
                    break;
            }
        }
    }
}
