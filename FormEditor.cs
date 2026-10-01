using System.Drawing.Drawing2D;

namespace lab5_c_
{
    public partial class FormEditor : Form
    {
        private readonly List<Shape> shapes = new();
        private readonly List<Point> polygonPoints = new();
        private Shape? current;
        private Point cursor;
        private Color currentColor = Color.Black;

        public FormEditor()
        {
            InitializeComponent();
        }

        private ToolKind CurrentTool =>
            radioButtonLine.Checked ? ToolKind.Line :
            radioButtonRectangle.Checked ? ToolKind.Rectangle :
            radioButtonEllipse.Checked ? ToolKind.Ellipse :
            radioButtonPolygon.Checked ? ToolKind.Polygon :
            ToolKind.Text;

        private void FormEditor_Load(object sender, EventArgs e)
        {
            UpdateHint();
        }

        private void UpdateHint()
        {
            labelHint.Text = CurrentTool switch
            {
                ToolKind.Line => "Линия: зажмите левую кнопку мыши и протяните курсор.",
                ToolKind.Rectangle => "Прямоугольник: зажмите левую кнопку мыши и протяните по диагонали.",
                ToolKind.Ellipse => "Эллипс: зажмите левую кнопку мыши и протяните — фигура впишется в рамку.",
                ToolKind.Polygon => "Многоугольник: ЛКМ — добавить вершину, ПКМ или двойной щелчок — завершить.",
                _ => "Текст: введите надпись в поле «Текст» и щёлкните в нужном месте холста.",
            };
        }

        private void SetColor(Color color)
        {
            currentColor = color;
            panelCurrentColor.BackColor = color;
        }

        private Shape CreateShape(ToolKind kind, string text = "")
        {
            return new Shape(kind, currentColor, (float)numericUpDownWidth.Value, checkBoxFill.Checked, text);
        }

        private void FinishPolygon()
        {
            if (polygonPoints.Count >= 3)
            {
                Shape polygon = CreateShape(ToolKind.Polygon);
                polygon.Points.AddRange(polygonPoints);
                shapes.Add(polygon);
            }

            polygonPoints.Clear();
            canvas.Invalidate();
        }

        private void tool_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton { Checked: true })
            {
                current = null;
                polygonPoints.Clear();
                UpdateHint();
                canvas.Invalidate();
            }
        }

        private void swatch_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                SetColor(button.BackColor);
            }
        }

        private void buttonMoreColors_Click(object sender, EventArgs e)
        {
            using ColorDialog dialog = new ColorDialog { Color = currentColor, FullOpen = true };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                SetColor(dialog.Color);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            polygonPoints.Clear();
            current = null;
            canvas.Invalidate();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            foreach (Shape shape in shapes)
            {
                shape.Draw(e.Graphics);
            }

            current?.Draw(e.Graphics);

            if (polygonPoints.Count > 0)
            {
                using Pen preview = new Pen(currentColor, (float)numericUpDownWidth.Value)
                {
                    DashStyle = DashStyle.Dash
                };
                e.Graphics.DrawLines(preview, polygonPoints.Append(cursor).ToArray());
            }
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            switch (CurrentTool)
            {
                case ToolKind.Line:
                case ToolKind.Rectangle:
                case ToolKind.Ellipse:
                    if (e.Button == MouseButtons.Left)
                    {
                        current = CreateShape(CurrentTool);
                        current.Points.Add(e.Location);
                        current.Points.Add(e.Location);
                    }
                    break;

                case ToolKind.Polygon:
                    if (e.Button == MouseButtons.Right || (e.Button == MouseButtons.Left && e.Clicks == 2))
                    {
                        FinishPolygon();
                    }
                    else if (e.Button == MouseButtons.Left)
                    {
                        polygonPoints.Add(e.Location);
                        canvas.Invalidate();
                    }
                    break;

                case ToolKind.Text:
                    if (e.Button == MouseButtons.Left && !string.IsNullOrWhiteSpace(textBoxText.Text))
                    {
                        Shape label = CreateShape(ToolKind.Text, textBoxText.Text);
                        label.Points.Add(e.Location);
                        shapes.Add(label);
                        canvas.Invalidate();
                    }
                    break;
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            cursor = e.Location;
            labelCoordinates.Text = $"X: {e.X}, Y: {e.Y}";

            if (current != null)
            {
                current.Points[1] = e.Location;
                canvas.Invalidate();
            }
            else if (polygonPoints.Count > 0)
            {
                canvas.Invalidate();
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (current != null && e.Button == MouseButtons.Left)
            {
                current.Points[1] = e.Location;
                shapes.Add(current);
                current = null;
                canvas.Invalidate();
            }
        }
    }
}
