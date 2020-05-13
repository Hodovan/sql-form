using System;
using System.Windows.Forms;

namespace SqlForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOutput.Text = "Click Me!";
            cobModifier.SelectedIndex = 0;
        }

        private void Output_Click(object sender, EventArgs e)
        {
            ushort price = 42;

            lblOutput.Text = price.ToString("C2");
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            lblMirror.Text = txtInput.Text.ToUpper();
        }

        private void Amount_DoubleClick(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        
        private void Modifier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text.Length != 0)
            {
                UpdatePrice();
            }
        }

        private void UpdatePrice()
        {
            var amount = decimal.Parse(txtAmount.Text);

            lblPrice.Text = (cobModifier.SelectedIndex == 1) ? (amount *= 1.1m).ToString("C") : (amount *= 0.9m).ToString("C");
        }

        private void trbScale_ValueChanged(object sender, EventArgs e)
        {
            prbScale.Value = trbScale.Value;
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            if (trbScale.Value <= trbScale.Maximum - 10)
            {
                trbScale.Value += 10;
            }
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (trbScale.Value >= trbScale.Minimum + 10)
            {
                trbScale.Value -= 10;
            }
        }

        private void trbScale_Scroll(object sender, EventArgs e)
        {
            tltScale.SetToolTip(trbScale, $"[1] [{trbScale.Value}] [100]");
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (radSum.Checked)
            {
                lblResult.Text = MathOperations.Add(numNumber1.Value, NumNumber2.Value).ToString();
            }

            if (radDivide.Checked)
            {
                if (NumNumber2.Value != 0.0m)
                {
                    lblResult.Text = MathOperations.Divide(numNumber1.Value, NumNumber2.Value).ToString();
                }
                else
                {
                    lblResult.Text = "!! 0 !!";
                }
            }
        }
    }
}
