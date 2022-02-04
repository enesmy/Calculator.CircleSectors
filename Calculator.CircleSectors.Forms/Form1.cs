using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator.CircleSectors.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Draw(CircleSector sector)
        {
            var Edge = new Pen(Color.Black, 2F);

            Brush fill_brush = Brushes.LightGreen;
            
            Graphics graphics = pnlGraphic.CreateGraphics();
            graphics.Clear(Color.White);

            Rectangle rectangle = new Rectangle(5, 5, pnlGraphic.Width-10, pnlGraphic.Height-10);
            
            graphics.DrawEllipse(Edge, rectangle);

            graphics.FillPie(fill_brush, rectangle, -90, (float)sector.Angle);
            graphics.DrawPie(Edge, rectangle,-90, (float)sector.Angle);
        }

        private void nud_Leave(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            if ((IsAngle(sender) || IsRadius(sender)) && Math.Round(nudAngle.Value, 2) > 0 && Math.Round(nudRadius.Value, 2) > 0)
            {
                CircleSectorCalculator calculator = new CircleSectorCalculator();
                var result = calculator.GetFromAngleAndRadius((double)Math.Round(nudAngle.Value, 2), (double)Math.Round(nudRadius.Value, 2));

                if (!SmallerThanControl(result)) return;

                nudArcLength.Value = (decimal)result.ArcLength;
                nudChord.Value = (decimal)result.Chord;
                nudSurfaceArea.Value = (decimal)result.SurfaceArea;
                Draw(result);
                return;
            }

            if ((IsArcLength(sender) || IsSurfaceArea(sender)) && Math.Round(nudArcLength.Value, 2) > 0 && Math.Round(nudSurfaceArea.Value, 2) > 0)
            {
                CircleSectorCalculator calculator = new CircleSectorCalculator();
                var result = calculator.GetFromArcLengthAndSurfaceArea((double)Math.Round(nudArcLength.Value, 2), (double)Math.Round(nudSurfaceArea.Value, 2));
                if (!SmallerThanControl(result)) return;

                nudAngle.Value = (decimal)result.Angle;
                nudChord.Value = (decimal)result.Chord;
                nudRadius.Value = (decimal)result.Radius;
                Draw(result);
                return;
            }
        }

        private bool SmallerThanControl(CircleSector result)
        {
            if (result.Angle <= 0)
            {
                lblMessage.Text = "Angle is equel or smaller than 0!";
                return false;
            }
            if (result.Chord <= 0)
            {
                lblMessage.Text = "Chord is equel or smaller than 0!";
                return false;
            }
            if (result.Radius <= 0)
            {
                lblMessage.Text = "Radius is equel or smaller than 0!";
                return false;
            }
            if (result.ArcLength <= 0)
            {
                lblMessage.Text = "Arc Length is equel or smaller than 0!";
                return false;
            }
            if (result.SurfaceArea <= 0)
            {
                lblMessage.Text = "Surface Area is equel or smaller than 0!";
                return false;
            }
            return true;
        }
        private bool BiggerThanControl(CircleSector result)
        {
            if ((decimal)result.Angle > nudAngle.Maximum)
            {
                lblMessage.Text = "Angle is bigger than limit!";
                return false;
            }
            if ((decimal)result.Chord > nudChord.Maximum)
            {
                lblMessage.Text = "Chord is bigger than limit!";
                return false;
            }
            if ((decimal)result.Radius > nudRadius.Maximum)
            {
                lblMessage.Text = "Radius is bigger than limit!";
                return false;
            }
            if ((decimal)result.ArcLength > nudArcLength.Maximum)
            {
                lblMessage.Text = "Arc Length is bigger than limit!";
                return false;
            }
            if ((decimal)result.SurfaceArea > nudSurfaceArea.Value)
            {
                lblMessage.Text = "Surface Area is bigger than limit!";
                return false;
            }
            return true;
        }
        bool IsAngle(object sender) => ((NumericUpDown)sender).Name == "nudAngle";
        bool IsRadius(object sender) => ((NumericUpDown)sender).Name == "nudRadius";
        bool IsArcLength(object sender) => ((NumericUpDown)sender).Name == "nudArcLength";
        bool IsSurfaceArea(object sender) => ((NumericUpDown)sender).Name == "nudSurfaceArea";
    }
}
