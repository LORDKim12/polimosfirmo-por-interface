using polimosfirmo_por_interface.Clases;

namespace polimosfirmo_por_interface
{
    public partial class Form1 : Form
    {
        List<MetododePago> intefaces = new List<MetododePago>();
        public Form1()
        {
            InitializeComponent();
            lblTarjeta.Visible = false;
            txtTarjeta.Visible = false;
            lblFecha.Visible = false;
            txtFecha.Visible = false;
            lblCorreo.Visible = false;
            txtCorreo.Visible = false;

            panel5.Visible = false;
            label15.Visible = false;
            textBox2.Visible = false;
            label18.Visible = false;
            textBox5.Visible = false;
            label17.Visible = false;
            textBox3.Visible = false;





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*List<MetododePago> intefaces = new List<MetododePago>
            {
                new Transferencia("bbva", 12345),
                new TarjetadeCredito(123456, "jose"),
                new Paypal("kkk")
            };
            foreach (var item in intefaces)
            {
                item.ProcesarPago(500);
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelCompras.Visible = false;
            panel5.Visible = true;
            panel5.Location = new Point(12, 12);
        }

        private void btnComprar1_Click(object sender, EventArgs e)
        {
            PanelCompras.Visible = false;
            panel5.Visible = true;
            panel5.Location = new Point(12, 12);

        }

        private void btnComprar2_Click(object sender, EventArgs e)
        {
            PanelCompras.Visible = false;
            panel5.Visible = true;
            panel5.Location = new Point(12, 12);
        }

        private void btnComprar4_Click(object sender, EventArgs e)
        {
            PanelCompras.Visible = false;
            panel5.Visible = true;
            panel5.Location = new Point(12, 12);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                lblTarjeta.Visible = false;
                txtTarjeta.Visible = false;
                lblFecha.Visible = false;
                txtFecha.Visible = false;
                label15.Visible = false;
                textBox2.Visible = false;

                lblCorreo.Visible = true;
                txtCorreo.Visible = true;
                label18.Visible = false;
                textBox5.Visible = false;
                label17.Visible = false;
                textBox3.Visible = false;


                lblCorreo.Location = new Point(447, 46);
                txtCorreo.Location = new Point(447, 72);




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetododePago metodo = null;

            if (radioButton1.Checked)
            {
                int NumdeTarjeta;
                if (!int.TryParse(txtTarjeta.Text, out NumdeTarjeta))
                {
                    MessageBox.Show("favor de rellenar todos los espacios"); return;
                }

                int fechaVencimiento;
                if (!int.TryParse(txtFecha.Text, out fechaVencimiento))
                {
                    MessageBox.Show("favor de llenar todos los espacios"); return;
                }
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Falta el nombre del titular");
                    return;
                }

                metodo = new TarjetadeCredito(NumdeTarjeta, textBox2.Text, fechaVencimiento);
               

            }
            else if (radioButton2.Checked)
            {
                if (string.IsNullOrEmpty(txtCorreo.Text))
                {
                    MessageBox.Show("Favor de ingresar el correo");
                    return;
                }
                metodo = new Paypal(txtCorreo.Text);
                
            }
            else if (radioButton3.Checked)
            {
                if (string.IsNullOrEmpty( textBox5.Text))
                {
                    MessageBox.Show("favor de llenar todos los espacios"); return;
                }
                int NumCta;
                if(!int.TryParse( textBox3.Text, out NumCta))
                {
                    MessageBox.Show("favor de llenar todos los espacios"); return;
                }

                metodo = new Transferencia(textBox5.Text, NumCta);
            }
            if (metodo != null)
            {
                intefaces.Add(metodo);
                metodo.ProcesarPago(0);
            }



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                lblTarjeta.Visible = true;
                txtTarjeta.Visible = true;
                lblFecha.Visible = true;
                txtFecha.Visible = true;
                lblCorreo.Visible = false;
                txtCorreo.Visible = false;

                label15.Visible = true;
                textBox2.Visible = true;
                label18.Visible = false;
                textBox5.Visible = false;
                label17.Visible = false;
                textBox3.Visible = false;

                label15.Location = new Point(447, 189);
                textBox2.Location = new Point(447, 215);



            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                lblTarjeta.Visible = false;
                txtTarjeta.Visible = false;
                lblFecha.Visible = false;
                txtFecha.Visible = false;
                lblCorreo.Visible = false;
                txtCorreo.Visible = false;
                label15.Visible = false;
                textBox2.Visible = false;

                label18.Visible = true;
                textBox5.Visible = true;
                label17.Visible = true;
                textBox3.Visible = true;

                label18.Location = new Point(447, 46);
                textBox5.Location = new Point(447, 72);
                label17.Location = new Point(447, 120);
                textBox3.Location = new Point(447, 146);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PanelCompras.Visible = false;
            panel5.Visible = true;
            panel5.Location = new Point(12, 12);
        }
    }
}
