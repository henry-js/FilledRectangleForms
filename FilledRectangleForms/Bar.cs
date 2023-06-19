using System.Drawing;

namespace FilledRectangleForms
{
    public class Bar
    {
        private Rectangle _rectangle = new Rectangle();

        public double FillPercentage { get; internal set; }
        public string FillDirection { get; internal set; }
        public int Height
        {
            get => _rectangle.Height; internal set
            {
                _rectangle.Height = value;
            }
        }
        public int Width { get => _rectangle.Width; internal set => _rectangle.Width = value; }
        public Color Color { get; set; } = Color.Red;
        public Rectangle Rectangle => _rectangle;

        public Brush Brush { get; internal set; }
        public Bar Child { get; private set; }

        public Bar(Color? color, int width = 200, int height = 50)
        {
            if (color != null)
                Color = (Color)color;
            Brush = new SolidBrush(Color);
            Width = width;
            Height = height;
        }

        internal void DrawOn(Graphics formGraphics)
        {
            formGraphics.FillRectangle(Brush, Rectangle);
            if (Child != null)
                formGraphics.FillRectangle(Child.Brush, Child.Rectangle);
            formGraphics.Dispose();
        }
        public void AddChild(Color color, double fillPercentage = 0.8, string fillDirection = "Width")
        {
            int x;
            int y;
            Bar child;
            if (fillDirection == "Width")
                child = new Bar(color, (int)(this.Width * fillPercentage), Height);
            else 
                child = new Bar(color, Width, (int)(this.Height * fillPercentage));

            Child = child;
        }

    }
}
