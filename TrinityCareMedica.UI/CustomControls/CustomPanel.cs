using System.Drawing.Drawing2D;

namespace TrinityCareMedica.UI.CustomControls
{
    internal class CustomPanel : Panel
    {
        public Color ColorTop { get; set; } = Color.LightBlue;
        public Color ColorBottom { get; set; } = Color.Blue;
        public int BorderRadius { get; set; } = 20;
        public Color BorderColor { get; set; } = Color.Black;
        public int BorderThickness { get; set; } = 2;

        public CustomPanel()
        {
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = this.ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            // Decide if we use rounded corners or normal rectangle
            GraphicsPath path;
            if (BorderRadius > 0)
                path = GetRoundedPath(rect, BorderRadius);
            else
            {
                path = new GraphicsPath();
                path.AddRectangle(rect);
            }

            using (path)
            {
                // Gradient fill
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    rect, ColorTop, ColorBottom, LinearGradientMode.Vertical))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Optional border
                if (BorderThickness > 0)
                {
                    using (Pen pen = new Pen(BorderColor, BorderThickness))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            return path;
        }

    }
}
