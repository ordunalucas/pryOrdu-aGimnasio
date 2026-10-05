namespace pryOrduñaGimnasio
{
    public partial class frmInscripcion : Form
    {
        const decimal PRECIO_NATACION = 22000;
        const decimal PRECIO_MUSCULACION = 15000;
        const decimal PRECIO_FUNCIONAL = 18000;
        const int EDAD_MINIMA = 14;
        const decimal DESCUENTO_MENOR = 0.10m;
        const decimal DESCUENTO_MAYOR = 0.30m;
        const decimal RECARGO_3CUOTAS = 0.10m;
        const decimal RECARGO_6CUOTAS = 0.20m;
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
    }
}
