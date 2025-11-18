using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimosfirmo_por_interface.Clases
{
    internal class Paypal:MetododePago
    {
        public string correo;
        public Paypal(string correo)
        {
            this.correo = correo;
        }
        public void ProcesarPago(double pago)
        {
            MessageBox.Show("Gracias por su compra");
        }
    }
}
