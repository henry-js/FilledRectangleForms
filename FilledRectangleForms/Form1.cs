using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilledRectangleForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CustomInitializeComponent();
        }

        private void CustomInitializeComponent()
        {
            InitializeComponent();
            int maxValue = 100;
            int currentValue = 75;
            string currentTag = "Loaded";
            string incompleteTag = "Not loaded";

            var barPanel = new BarPanel(maxValue, currentValue, currentTag, incompleteTag);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var filledBar = new Bar(Color.Red);
            filledBar.AddChild(Color.Green, 0.7, "Width");
            Graphics formGraphics = e.Graphics;
            filledBar.DrawOn(formGraphics);
        }
    }
}
