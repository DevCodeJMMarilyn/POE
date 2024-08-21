using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2POE.Encapsulamiento.Modulo
{
    public partial class EncapsulamientoF : Form
    {
        Cuenta cuenta =new Cuenta();

        public EncapsulamientoF()
        {
            InitializeComponent();
        }

        private void RealizarDeposito_Click(object sender, EventArgs e)
        {
            cuenta.RealizarDeposito(double.Parse(MontoTextBox.Text));
        }


        private void RealizarRetiro_Click(object sender, EventArgs e)
        {
            cuenta.RealizarRetiro(double.Parse(MontoTextBox.Text));
        }

        private void VerSaldo_Click(object sender, EventArgs e)
        {
            cuenta.SaldoActual();
        }
    }
}
