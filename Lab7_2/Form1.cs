using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_2
{
    public partial class Form1 : Form
    {

        public const int DEFAULT_COLOR = 125;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            redTrackBar.Value = DEFAULT_COLOR;
            greenTrackBar.Value = DEFAULT_COLOR;
            blueTrackBar.Value = DEFAULT_COLOR;
            updateCanvas();
        }

        private void updateCanvas() {
            int red = redTrackBar.Value;
            int green = greenTrackBar.Value;
            int blue = blueTrackBar.Value;
            canvas.BackColor = Color.FromArgb(red, green, blue);
            Clipboard.SetText(getRGBString());
        }

        
        private void redTrackBar_Scroll(object sender, EventArgs e)
        {
            updateCanvas();
        }

        private void greenTrackBar_Scroll(object sender, EventArgs e)
        {
            updateCanvas();
        }

        private void blueTrackBar_Scroll(object sender, EventArgs e)
        {
            updateCanvas();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void canvas_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(canvas, getRGBString());
        }

        private string getRGBString() {
            int red = redTrackBar.Value;
            int green = greenTrackBar.Value;
            int blue = blueTrackBar.Value;
            Color myColor = Color.FromArgb(red, green, blue);
            string RGBString = "#" + myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            return RGBString;
        }
    }
}
