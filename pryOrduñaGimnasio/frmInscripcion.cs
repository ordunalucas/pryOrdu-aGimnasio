using static pryOrduñaGimnasio.frmInscripcion;

namespace pryOrduñaGimnasio
{
    public partial class frmInscripcion : Form
    {
        const decimal PRECIO_NATACION = 22000;
        const decimal PRECIO_MUSCULACION = 15000;
        const decimal PRECIO_FUNCIONAL = 18000;

        const decimal PRECIO_CASILLERO = 3000;
        const int EDAD_MINIMA = 14;
        const decimal DESCUENTO_MENOR = 0.10m;
        const decimal DESCUENTO_MAYOR = 0.30m;
        const decimal RECARGO_3CUOTAS = 0.10m;
        const decimal RECARGO_6CUOTAS = 0.20m;

        public struct SOCIO
        {
            public string Nombre;
            public int Edad;
            public string Categoria;
            public string Plan;
            public string Horario;
            public int Meses;
            public string FormaPago;
            public decimal Total;      
            public decimal ValorCuota;
        }

        public frmInscripcion()
        {
            InitializeComponent();

        }

        private void EstadoInicial()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Text = "1";
            chkCasillero.Checked = false;
            chkEstudiante.Checked = false;
            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;
            rbtEfectivo.Checked = true;
            cboCuotas.SelectedIndex = 0;
            cboCuotas.Enabled = false;
            btnCalcular.Enabled = false;
        }
        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            EstadoInicial();
            txtNombre.TextChanged += ValidarEntradas_TextChanged;
            txtEdad.TextChanged += ValidarEntradas_TextChanged;
            txtMeses.TextChanged += ValidarEntradas_TextChanged;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboPlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(txtEdad.Text);
            int meses = int.Parse(txtMeses.Text);

            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show("La edad mínima para inscribirse es de 14 años.", "EDAD NO PERMITIDA", MessageBoxButtons.OK);
                return;
            }


            if (meses < 1 || meses > 12)
            {
                MessageBox.Show("La cantidad de meses debe estar comprendida entre 1 y 12.", "RANGO DE MESES INVALIDO", MessageBoxButtons.OK);
                return;
            }




            Decimal precioMensual = 0m;
            string horario = "";

            string planSeleccionado = cboPlan.Text;

            switch (planSeleccionado)
            {
                case "Musculacion": precioMensual = PRECIO_MUSCULACION; break;

                case "Funcional": precioMensual = PRECIO_FUNCIONAL; break;

                case "Natacion": precioMensual = PRECIO_NATACION; break;
            }


            int indiceTurno = cboTurno.SelectedIndex;

            switch (indiceTurno)
            {
                case 0: horario = "7 a 12hs"; break;

                case 1: horario = "14 a 18hs"; break;

                case 2: horario = "18 a 23hs"; break;

                default: horario = "No especificado"; break;
            }




            if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;

            decimal subtotal = precioMensual * meses;



            decimal porcentajeDescuento = 0m;

            if (edad < 18)
            {
                porcentajeDescuento = 0.25m;
            }
            else
            {
                if (edad >= 65)
                {
                    porcentajeDescuento = 0.30m;
                }
                else if (chkEstudiante.Checked)
                {
                    porcentajeDescuento = 0.15m;
                }
                else
                {
                    porcentajeDescuento = 0m;
                }
            }


            decimal importeDescuento = subtotal * porcentajeDescuento;
            decimal subtotalConDescuento = subtotal - importeDescuento;


            decimal porcentajePago = 0m;

            if (rbtEfectivo.Checked)
            {
                porcentajePago = -0.10m; 
            }
            else
            {
               
                int cuotas = int.Parse(cboCuotas.Text);

                if (cuotas == 1)
                {
                    porcentajePago = 0m;
                }
                else if (cuotas == 3)
                {
                    porcentajePago = 0.10m;
                }
                else if (cuotas == 6)
                {
                    porcentajePago = 0.20m;
                }

            }

            decimal importeAjuste = subtotalConDescuento * porcentajePago;
            decimal totalFinal = subtotalConDescuento + importeAjuste;


            string categoria = (edad < 18) ? "Menor" : "Mayor";
            string formaPagoTexto = rbtEfectivo.Checked
                ? "Efectivo"
                : $"Tarjeta en {cboCuotas.Text} cuotas";

            decimal valorCuota = rbtEfectivo.Checked
                ? totalFinal
                : totalFinal / int.Parse(cboCuotas.Text);


            SOCIO miSocio = new SOCIO();
            miSocio.Nombre = txtNombre.Text;
            miSocio.Edad = edad;
            miSocio.Categoria = categoria;
            miSocio.Plan = planSeleccionado;
            miSocio.Horario = horario;
            miSocio.Meses = meses;
            miSocio.FormaPago = formaPagoTexto;
            miSocio.Total = totalFinal;
            miSocio.ValorCuota = valorCuota;

            string mensaje = "RESUMEN DE INSCRIPCION" +
                             $"SOCIO: {miSocio.Nombre} ({miSocio.Edad} años - Categoría: {miSocio.Categoria})\n" +
                              $"PLAN: {miSocio.Plan} ({miSocio.Horario})\n" +
                              $"DURACION: {miSocio.Meses}\n" +
                              $"FORMA DE PAGO: {miSocio.FormaPago}\n" +
                              $"IMPORTE TOTAL: {miSocio.Total}\n" +
                              $"VALOR POR CUOTA: {miSocio.ValorCuota}";

            MessageBox.Show(mensaje, "GIMNASIO SIGLO - DETALLE DE INSCRIPCION",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            EstadoInicial();

        }

        private void btnCalcular_TextChanged(object sender, EventArgs e)
        {
            btnCalcular.Enabled = false;
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;

                e.KeyChar = char.ToUpper(e.KeyChar);

            }
        }

        private void ValidarEntradas_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtEdad.Text != "" && txtMeses.Text != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTarjeta.Checked)
            {
                cboCuotas.Enabled = true;
                cboCuotas.SelectedIndex = 0;
            }
            else
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = -1; 
            }
        }
    }
}
