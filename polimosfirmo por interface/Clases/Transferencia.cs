using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimosfirmo_por_interface.Clases
{
    internal class Transferencia:MetododePago
    {
        public string banco;
        public int NumdeCta;
        public Transferencia(string banco, int NumdeCta) 
        { 
            this.banco = banco; 
            this.NumdeCta = NumdeCta;
        }
        public void ProcesarPago(double pago)
        {
            MessageBox.Show("pago:" + pago);

        }
    }
}
