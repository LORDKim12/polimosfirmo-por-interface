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
        public int FechaVencimiento;
        
        public TarjetadeCredito(int NumdeTarjeta, string NombreTitular,int FechaVencimiento)
        {
            this.NumdeTarjeta = NumdeTarjeta;
            this.NombreTitular = NombreTitular;
            this.FechaVencimiento = FechaVencimiento;

        }
        public void ProcesarPago(double pago)
        {
            MessageBox.Show("Gracias por su compra");
        }
    }
}
