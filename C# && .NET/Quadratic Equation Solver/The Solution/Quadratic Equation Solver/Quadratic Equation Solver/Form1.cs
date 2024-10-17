using System.Text.RegularExpressions;

namespace QuadraticEuation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxA.Text = "";
            textBoxB.Text = "";
            textBoxC.Text = "";

            labelA.Text = "";
            labelB.Text = "+";
            labelC.Text = "+";

            labelRealPart1.Text = "";
            textBoxRealPart1.Text = "";
            labelRealPart2.Text = "";
            textBoxRealPart2.Text = "";
            labelImagPart1.Visible = true;
            labelImagPart2.Visible = true;
            textBoxImagPart1.Visible = true;
            textBoxImagPart2.Visible = true;
            textBoxImagPart1.Text = "";
            textBoxImagPart2.Text = "";

            label7.Visible = true;
            label9.Visible = true;

        }

        /**
         * Solves the quadratic equation.
         * First performes validation of input data.
         * @author Hristifor Sotirovski
         */

        private void button1_Click(object sender, EventArgs e)
        {
            string coefAstr = textBoxA.Text;
            string coefBstr = textBoxB.Text;
            string coefCstr = textBoxC.Text;

            // Regular expression for real number in the interval [-1000000, 1000000]
            // that inputs must match
            Regex validCoef = new Regex("^0(\\.[0-9]+)?$|^-1000000(\\.0+)?$"
                   + "|^1000000(\\.0+)?$|^-?[1-9][0-9]{0,5}(\\.[0-9]+)?$");


            // Validation of inputs
            if (!validCoef.IsMatch(coefAstr))
            {
                MessageBox.Show("You've entered an invalid number for coefficient a." +
                                "You should enter an non-zero integer from in the interval " +
                                "[-1000000, 100000], but you've entered: " + coefAstr);

                textBoxA.Text = "";
                return;
            }

            if (!validCoef.IsMatch(coefBstr))
            {
                MessageBox.Show("You've entered an invalid number for coefficient b." +
                                "You should enter an integer from in the interval " +
                                "[-1000000, 100000], but you've entered: " + coefBstr);

                textBoxB.Text = "";
                return;
            }

            if (!validCoef.IsMatch(coefCstr))
            {
                MessageBox.Show("You've entered an invalid number for coefficient c." +
                                "You should enter an integer from in the interval " +
                                "[-1000000, 100000], but you've entered: " + coefCstr);

                textBoxC.Text = "";
                return;
            }

            decimal.TryParse(coefAstr, out decimal coefA);
            decimal.TryParse(coefBstr, out decimal coefB);
            decimal.TryParse(coefCstr, out decimal coefC);

            if (coefA == 0M)
            {
                MessageBox.Show("You've entered an invalid number for coefficient a." +
                                "You should enter an non-zero integer from in the interval " +
                                "[-1000000, 100000], but you've entered: " + coefAstr);

                textBoxA.Text = "";
                return;
            }




            if (coefA > 0)
            {
                labelA.Text = "";
            }
            else if (coefA == 0)
            {
                labelA.Text = "";
                textBoxA.Text = "0";
            }
            else
            {
                labelA.Text = "-";
                textBoxA.Text = Math.Abs(coefA).ToString();
            }

            if (coefB < 0)
            {
                labelB.Text = "-";
                textBoxB.Text = Math.Abs(coefB).ToString();
            }

            if (coefC < 0)
            {
                labelC.Text = "-";
                textBoxC.Text = Math.Abs(coefC).ToString();
            }


            // Solving the equation

            // Evaluation of discriminant of equation
            decimal D = coefB * coefB - 4M * coefA * coefC;

            if (D < 0)
            {
                // Here we have complex solutions of the form a + bi

                decimal realSolution1 = -coefB / (2 * coefA);
                decimal imaginarySolution1 = (decimal)Math.Sqrt((double)-D) / (2 * coefA);
                decimal realSolution2 = -coefB / (2 * coefA);
                decimal imaginarySolution2 = -(decimal)Math.Sqrt((double)-D) / (2 * coefA);

                // Rounding to 10 decimal digits
                realSolution1 = Math.Round(realSolution1, 10);
                realSolution2 = Math.Round(realSolution2, 10);
                imaginarySolution1 = Math.Round(imaginarySolution1, 10);
                imaginarySolution2 = Math.Round(imaginarySolution2, 10);

                if (realSolution1 < 0)
                {
                    labelRealPart1.Text = "-";
                    textBoxRealPart1.Text = (-realSolution1).ToString();
                }
                else
                {
                    labelRealPart1.Text = "";
                    textBoxRealPart1.Text = realSolution1.ToString();
                }
                if (imaginarySolution1 < 0)
                {
                    labelImagPart1.Text = "-";
                    textBoxImagPart1.Text = (-imaginarySolution1).ToString();
                }
                else
                {
                    textBoxImagPart1.Text = imaginarySolution1.ToString();
                }

                if (realSolution2 < 0)
                {
                    labelRealPart2.Text = "-";
                    textBoxRealPart2.Text = (-realSolution2).ToString();
                }
                else
                {
                    labelRealPart2.Text = "";
                    textBoxRealPart2.Text = realSolution2.ToString();
                }
                if (imaginarySolution2 < 0)
                {
                    labelImagPart2.Text = "-";
                    textBoxImagPart2.Text = (-imaginarySolution2).ToString();
                }
                else
                {
                    textBoxImagPart2.Text = imaginarySolution2.ToString();
                }
            }
            else if (D == 0M)
            {
                // Here we have the only real solution -b / 2a

                decimal theOnlySolution = -coefB / (2 * coefA);

                // Rounding to 10 decimal digits
                theOnlySolution = Math.Round(theOnlySolution, 10);

                textBoxImagPart1.Visible = false;
                textBoxImagPart2.Visible = false;
                labelImagPart1.Visible = false;
                labelImagPart2.Visible = false;
                label7.Visible = false;
                label9.Visible = false;

                if (theOnlySolution < 0)
                {
                    labelRealPart1.Text = "-";
                    labelRealPart2.Text = "-";
                    textBoxRealPart1.Text = (-theOnlySolution).ToString();
                    textBoxRealPart2.Text = (-theOnlySolution).ToString();
                }
                else
                {
                    textBoxRealPart1.Text = theOnlySolution.ToString();
                    textBoxRealPart1.Text = theOnlySolution.ToString();
                }

            }
            else
            {
                // Here we have two real solutions

                decimal realSolution1 = (-coefB + (decimal)Math.Sqrt((double)D)) / (2 * coefA);
                decimal realSolution2 = (-coefB - (decimal)Math.Sqrt((double)D)) / (2 * coefA);

                // Rounding to 10 decimal digits
                realSolution1 = Math.Round(realSolution1, 10);
                realSolution2 = Math.Round(realSolution2, 10);

                textBoxImagPart1.Visible = false;
                textBoxImagPart2.Visible = false;
                labelImagPart1.Visible = false;
                labelImagPart2.Visible = false;
                label7.Visible = false;
                label9.Visible = false;

                if (realSolution1 < 0)
                {
                    labelRealPart1.Text = "-";
                    textBoxRealPart1.Text = (-realSolution1).ToString();
                }
                else
                {
                    textBoxRealPart1.Text = (realSolution1).ToString();
                }

                if (realSolution2 < 0)
                {
                    labelRealPart2.Text = "-";
                    textBoxRealPart2.Text = (-realSolution2).ToString();
                }
                else
                {
                    textBoxRealPart2.Text = (realSolution2).ToString();
                }


            }
        }

        private void textBoxRealPart1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
