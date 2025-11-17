using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimosfirmo_por_interface.Clases
{
    internal class TarjetadeCredito:MetododePago
    {
        public int NumdeTarjeta;
        public string NombreTitular;
        public TarjetadeCredito(int NumdeTarjeta, string NombreTitular)
        {
            this.NumdeTarjeta = NumdeTarjeta;
            this.NombreTitular = NombreTitular;
        }
        public void ProcesarPago(double pago)
        {
            MessageBox.Show("pago:" + pago);
        }
    }
}
