using System.Drawing;

namespace FilledRectangleForms
{
    internal class BarPanel
    {
        private int maxValue;
        private int currentValue;
        private string currentTag;
        private string incompleteTag;
        private int defaultWidth = 250;
        private int defaultHeight = 50;
        public Bar InitialBar { get; private set; }

        public BarPanel(int maxValue, int currentValue, string currentTag, string incompleteTag)
        {
            this.maxValue = maxValue;
            this.currentValue = currentValue;
            this.currentTag = currentTag;
            this.incompleteTag = incompleteTag;
            InitialBar = new Bar(Color.Red, defaultWidth, defaultHeight);
            InitialBar.AddChild(Color.Blue, (double)maxValue / currentValue * 100);
        }
        public void DrawBarOn(Graphics graphics)
        {
            InitialBar.DrawOn(graphics);
        }
    }
}