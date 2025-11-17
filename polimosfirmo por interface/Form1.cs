using polimosfirmo_por_interface.Clases;

namespace polimosfirmo_por_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<MetododePago> intefaces = new List<MetododePago>
            {
                new Transferencia("bbva", 12345),
                new TarjetadeCredito(123456, "jose"),
                new Paypal("kkk")
            };
            foreach(var item in intefaces)
            {
                item.ProcesarPago(500);
            }
        }
    }
}
