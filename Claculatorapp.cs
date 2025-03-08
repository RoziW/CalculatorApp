using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double enterFirstValue, enterSecondValue;
        String op;
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!txtResult.Text .Contains("."))
                        txtResult.Text = txtResult.Text + num.Text;
                }
                else
                {
                    txtResult.Text = txtResult.Text + num.Text;
                }
            }
        }

        private void numberOper(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            enterFirstValue = Convert.ToDouble(txtResult.Text);
            op = num.Text;
            txtResult.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(txtResult.Text);

            switch (op)
            {
                    case "+":
                    txtResult.Text = (enterFirstValue + enterSecondValue).ToString();
                    break;

                    case "-":
                    txtResult.Text = (enterFirstValue - enterSecondValue).ToString();
                    break;

                    case "*":
                    txtResult.Text = (enterFirstValue * enterSecondValue).ToString();
                    break;

                    case "/":
                    txtResult.Text = (enterFirstValue / enterSecondValue).ToString();
                    break;
                case "Mod":
                    txtResult.Text = (enterFirstValue % enterSecondValue).ToString();
                    break;

                case "Exp":
                    double i = Convert.ToDouble(txtResult.Text);
                    double j ;
                    j = enterSecondValue;
                    txtResult.Text = Math.Exp(i * Math.Log(j * 4)).ToString();
                    break;

                default:
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";

            String f, s;

            f = Convert.ToString(enterFirstValue);
            s = Convert.ToString(enterSecondValue);

            f = "";
            s = "";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * q); 
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);

            }

            if (txtResult.Text == "")
            {
                txtResult.Text = "0";

            }
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 388;
            txtResult.Width = 354;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 780;
            txtResult.Width = 735;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;

            exitCal = MessageBox.Show("Confirm if you want to exit", "Scientific Calculator",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.141592653589976323";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txtResult.Text);
            logg = Math.Log10(logg);
            txtResult.Text = Convert.ToString(logg);    
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Convert.ToDouble(txtResult.Text);
            sqrt = Math.Sqrt(sqrt);
            txtResult.Text = Convert.ToString(sqrt);
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(x);
        }

        private void btnx3_Click(object sender, EventArgs e)
        {
            double x,q,p,m;

            q = Convert.ToDouble(txtResult.Text);
            p = Convert.ToDouble(txtResult.Text);
            m = Convert.ToDouble(txtResult.Text);

            x = (q * p * m);
            txtResult.Text = Convert.ToString(x);
        }

        private void btnSinx_Click(object sender, EventArgs e)
        {
            double sinx = Convert.ToDouble(txtResult.Text);
            sinx = Math.Sinh(sinx);
            txtResult.Text = Convert.ToString(sinx);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(txtResult.Text);
            sin = Math.Sin(sin);
            txtResult.Text = Convert.ToString(sin);
        }

        private void btnCosx_Click(object sender, EventArgs e)
        {
            double cosx = Convert.ToDouble(txtResult.Text);
            cosx = Math.Cosh(cosx);
            txtResult.Text = Convert.ToString(cosx);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(txtResult.Text);
            cos = Math.Cos(cos);
            txtResult.Text = Convert.ToString(cos);
        }

        private void btnTanx_Click(object sender, EventArgs e)
        {
            double tanx = Convert.ToDouble(txtResult.Text);
            tanx = Math.Tanh(tanx);
            txtResult.Text = Convert.ToString(tanx);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(txtResult.Text);
            tan = Math.Tan(tan);
            txtResult.Text = Convert.ToString(tan);
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            double a;

            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtResult.Text));
            txtResult.Text = Convert.ToString(a);

        }

        private void btnlnx_Click(object sender, EventArgs e)
        {
            double lnx = Convert.ToDouble(txtResult.Text);
            lnx = Math.Log(lnx);
            txtResult.Text = Convert.ToString(lnx);
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            double a;

            a = Convert.ToDouble(txtResult.Text) / Convert.ToDouble(100);
            txtResult.Text = Convert.ToString(a);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txtResult.Text);

            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            txtResult.Text = Convert.ToString(i2);
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a,2);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 16);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 8);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 853 original size
            this.Width = 390; 
            txtResult.Width = 354;
        }
    }
}
