using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcular
{
    public partial class Calcu : Form
    {
        public Calcu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            int firstNumberLabel = Convert.ToInt32(firstNumberTextbox.Text);
            int twoNumberLabel = Convert.ToInt32(twoNumberTextbox.Text);

            int result = firstNumberLabel + twoNumberLabel;

            resultLabel.Text = $"La sumatoria de {firstNumberLabel} + {twoNumberLabel}= {result} ";
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            int firstNumberLabel = Convert.ToInt32(firstNumberTextbox.Text);
            int twoNumberLabel = Convert.ToInt32(twoNumberTextbox.Text);

            int result = firstNumberLabel - twoNumberLabel;

            resultLabel.Text = $"La resta de {firstNumberLabel} - {twoNumberLabel}= {result} ";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            firstNumberTextbox.Text = $"";
            twoNumberTextbox.Text = $"";
            resultLabel.Text = $"";
        }

        private void btnm_Click(object sender, EventArgs e)
        {
            int firstNumberLabel = Convert.ToInt32(firstNumberTextbox.Text);
            int twoNumberLabel = Convert.ToInt32(twoNumberTextbox.Text);

            int result = firstNumberLabel * twoNumberLabel;

            resultLabel.Text = $"La multiplicacion de {firstNumberLabel} x {twoNumberLabel}= {result} ";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            int firstNumberLabel = Convert.ToInt32(firstNumberTextbox.Text);
            int twoNumberLabel = Convert.ToInt32(twoNumberTextbox.Text);

            int result = firstNumberLabel / twoNumberLabel;

            resultLabel.Text = $"La division de {firstNumberLabel} / {twoNumberLabel}= {result} ";
        }
    }
}
