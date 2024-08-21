using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2POE.Polimorfismo
{
    public class Computadora
    {
        public virtual void Encender() 
        {
            MessageBox.Show("Encendiendo computadora...");
        }

    }

    public class ComputadoraPortatil : Computadora
    {
        public override void Encender()
        {
            MessageBox.Show("Encediendo computadora portatil");
        }
    }

    public class ComputadoraEscritorio : Computadora 
    {
        public override void Encender()
        {
            MessageBox.Show("Encediendo computadora de escritorio");
        }
    }
}
