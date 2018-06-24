using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Fractal_Summative
{
    public partial class Form1 : Form
    {

        #region Global Variables
        // bitmap that stores the pixel data
        private Bitmap newtonFractalBitmap = new Bitmap(400, 400); // newton fractal
        private Bitmap juliaFractalBitmap = new Bitmap(300, 300);

        // values used to animate the fractal
        private int currentIteration = 1;
        private int increment = 1;

        // stores the value of c for generating the julia fractal
        private Complex c = new Complex(0, 0);
        #endregion

        #region Event Handlers

        private void displayButton_Click(object sender, EventArgs e)
        {
            int maxIterations = (int)maxIterationsNumericUpDown.Value; // determined by user
            DrawFractal(maxIterations, newtonFractalBitmap, "Newton"); // draw the fractal design onto the bitmap
            newtonFractalPictureBox.Refresh(); // calls the paint event of newtonFractalPictureBox

            // resets values relating to animation to ensure it will animate properly next call
            animateNewtonTimer.Enabled = false;
            animateNewtonTimer.Stop();
            currentIteration = 1;
            animateNewtonButton.Text = "Animate";
        }

        // draws the newton fractal onto the picture box
        private void fractalPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(newtonFractalBitmap, 0, 0);
        }

        // start/stop animating the newton fractal
        private void animateButton_Click(object sender, EventArgs e)
        {
            if (!animateNewtonTimer.Enabled)
            {
                animateNewtonTimer.Enabled = true;
                currentIteration = 1;
                animateNewtonTimer.Start();
                animateNewtonButton.Text = "Stop";
            }
            else
            {
                animateNewtonTimer.Enabled = false;
                animateNewtonTimer.Stop();
                animateNewtonButton.Text = "Animate";
            }
        }

        // draws a new image on each tick
        private void animateTimer_Tick(object sender, EventArgs e)
        {
            DrawFractal(currentIteration, newtonFractalBitmap, "Newton");
            newtonFractalPictureBox.Refresh();

            // keep increasing or decreasing the number of iterations on each tick to generate a new fractal
            if (currentIteration >= maxIterationsNumericUpDown.Value)
            {
                increment = -1;
            }
            else if (currentIteration <= maxIterationsNumericUpDown.Minimum)
            {
                increment = 1;
            }
            currentIteration += increment;
        }

        // display the complex coordinates of the mouse
        private void fractalPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            complexCoordLabel.Text = "(" + Math.Round(3.0d / newtonFractalBitmap.Width * e.X - 1.5d, 2) + ", "
                                         + Math.Round(-3.0d / newtonFractalBitmap.Height * e.Y + 1.5d, 2) + ")";
        }

        private void newtonFractalPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            // assign complex coordinates of mouse click to c
            c = new Complex(Math.Round(3.0d / newtonFractalBitmap.Width * e.X - 1.5d, 2), Math.Round(-3.0d / newtonFractalBitmap.Height * e.Y + 1.5d, 2));
            DrawFractal((int)maxIterationsNumericUpDown.Value, juliaFractalBitmap, "Julia"); // draw the fractal design onto the bitmap
            juliaFractalPictureBox.Refresh(); // calls the paint event of juliaFractalPictureBox
        }

        // draws the julia fractal onto the picture box
        private void juliaFractalPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(juliaFractalBitmap, 0, 0);
        }

        #endregion

        #region Methods

        public Form1()
        {
            InitializeComponent();
        }

        private void DrawFractal(int maxIterations, Bitmap fractalBitmap, string fractalType)
        {
            // stores the complex coordinate of a pixel
            Complex z = new Complex(0, 0);

            int width = fractalBitmap.Width;
            int height = fractalBitmap.Height;

            // minimum distance of z from the polynomial's root
            double minDistanceFromRoot = 0.000001;

            // iterates through each pixel row by row
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // converts pixel coordinates to complex coordinates and assigns the value to z
                    z = new Complex(3.0d / width * x - 1.5d, -3.0d / height * y + 1.5d);

                    // set the colour of a pixel on the bitmap
                    if(fractalType == "Newton")
                    {
                        fractalBitmap.SetPixel(x, y, ChooseColourNewton(z, maxIterations, minDistanceFromRoot));
                    }
                    else if (fractalType == "Julia")
                    {
                        fractalBitmap.SetPixel(x, y, ChooseColorJulia(z, c, maxIterations));
                    }
                }
            }
        }

        // determines what colour to assign to a pixel based on which root the sequence approaches
        private Color ChooseColourNewton(Complex z, int maxIterations, double minDistanceFromRoot)
        {
            // array of the polynomial's roots
            Complex[] roots = 
            {
                new Complex(1, 0),
                new Complex(-.5, Math.Sqrt(3) / 2),
                new Complex(-.5, -Math.Sqrt(3) / 2)
            };

            // array of colours corresponding to each root
            Color[] colours =
            {
                Color.Magenta,
                Color.Cyan,
                Color.FloralWhite
            };

            // copy of z to store the next terms in the sequence
            Complex zNext = z;

            for (int i = 0; i < maxIterations; i++)
            {
                // next z = current z - ( polynomial / derivative of polynomial )
                zNext = Complex.Subtract(zNext, Complex.Divide(Polynomial(zNext), Derivative(zNext)));

                // calculates the distance of the term from each root
                // if the distance is small enough, return the corresponding colour
                for (int r = 0; r < roots.Length; r++)
                {

                    Complex difference = Complex.Subtract(zNext, roots[r]);

                    if(Complex.Abs(difference) < minDistanceFromRoot)
                    {
                        return colours[r];
                    }
                }
            }

            // return if the max number of iterations is reached without being close enough to any root
            return Color.Black;
        }

        // applies the polynomial function to z
        // p(z) = z^3 - 1
        private Complex Polynomial(Complex z)
        {
            return Complex.Subtract(Complex.Pow(z, 3), Complex.One);
        }

        // applies the derivative function of the polynomial to z
        // p'(z) = 3*z^2
        private Complex Derivative(Complex z)
        {
            return Complex.Multiply(new Complex(3, 0), Complex.Pow(z, 2));
        }

        private Color ChooseColorJulia(Complex z, Complex c, int maxIterations)
        {
            int iterations = 0;
            Complex zNext = z;
            
            while (Complex.Abs(z) < 2 && iterations < maxIterations)
            {
                zNext = Complex.Add(Complex.Pow(zNext, 2), c); // z = z^2 + c
                iterations++;
            }

            // Generates pixel colour based on "iterations", "z", and "c"
            int red = 255 - (int)(255 * Math.Abs(Math.Sin((Complex.Add(Complex.Pow(z, 2), c)).Real * iterations)));
            int blue = 255 - (int)(255 * Math.Abs(Math.Cos((Complex.Add(Complex.Pow(z, 2), c)).Imaginary * iterations)));
            int green = (red < blue) ? red : blue; //Set green to smaller of red and blue
            return Color.FromArgb(red, green, blue);
        }

        #endregion

    }   
}
//Further: user chooses polynomial