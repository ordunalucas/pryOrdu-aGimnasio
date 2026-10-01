namespace pryOrduñaGimnasio
{
    partial class frmInscripcion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            lblNombre = new Label();
            lblEdad = new Label();
            chkEstudiante = new CheckBox();
            cboPlan = new ComboBox();
            cboTurno = new ComboBox();
            txtMeses = new TextBox();
            chkCasillero = new CheckBox();
            grpDatos = new GroupBox();
            grpPlan = new GroupBox();
            lblMeses = new Label();
            lblTurno = new Label();
            lblPlan = new Label();
            grpPago = new GroupBox();
            lblCuotas = new Label();
            cboCuotas = new ComboBox();
            lblMedPago = new Label();
            rbtTarjeta = new RadioButton();
            rbtEfectivo = new RadioButton();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            grpDatos.SuspendLayout();
            grpPlan.SuspendLayout();
            grpPago.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(93, 18);
            txtNombre.Margin = new Padding(2);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(106, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(93, 56);
            txtEdad.Margin = new Padding(2);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(106, 23);
            txtEdad.TabIndex = 2;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(37, 22);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(52, 56);
            lblEdad.Margin = new Padding(2, 0, 2, 0);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad";
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(15, 128);
            chkEstudiante.Margin = new Padding(2);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(81, 19);
            chkEstudiante.TabIndex = 0;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculación", "Funcional ", "Natación" });
            cboPlan.Location = new Point(75, 17);
            cboPlan.Margin = new Padding(2);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(129, 23);
            cboPlan.TabIndex = 1;
            cboPlan.SelectedIndexChanged += cboPlan_SelectedIndexChanged;
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboTurno.Location = new Point(75, 58);
            cboTurno.Margin = new Padding(2);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(129, 23);
            cboTurno.TabIndex = 2;
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(75, 93);
            txtMeses.Margin = new Padding(2);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(57, 23);
            txtMeses.TabIndex = 3;
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(121, 128);
            chkCasillero.Margin = new Padding(2);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(145, 19);
            chkCasillero.TabIndex = 4;
            chkCasillero.Text = "Casillero ($ 3.000/mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(lblEdad);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(txtEdad);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Location = new Point(92, 35);
            grpDatos.Margin = new Padding(2);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(2);
            grpDatos.Size = new Size(279, 86);
            grpDatos.TabIndex = 9;
            grpDatos.TabStop = false;
            grpDatos.Text = "DATOS PERSONALES";
            grpDatos.Enter += groupBox1_Enter;
            // 
            // grpPlan
            // 
            grpPlan.Controls.Add(lblMeses);
            grpPlan.Controls.Add(lblTurno);
            grpPlan.Controls.Add(lblPlan);
            grpPlan.Controls.Add(cboTurno);
            grpPlan.Controls.Add(cboPlan);
            grpPlan.Controls.Add(chkCasillero);
            grpPlan.Controls.Add(chkEstudiante);
            grpPlan.Controls.Add(txtMeses);
            grpPlan.Location = new Point(92, 125);
            grpPlan.Margin = new Padding(2);
            grpPlan.Name = "grpPlan";
            grpPlan.Padding = new Padding(2);
            grpPlan.Size = new Size(279, 166);
            grpPlan.TabIndex = 10;
            grpPlan.TabStop = false;
            grpPlan.Text = "PLAN";
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(27, 93);
            lblMeses.Margin = new Padding(2, 0, 2, 0);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(40, 15);
            lblMeses.TabIndex = 11;
            lblMeses.Text = "Meses";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(30, 59);
            lblTurno.Margin = new Padding(2, 0, 2, 0);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(39, 15);
            lblTurno.TabIndex = 10;
            lblTurno.Text = "Turno";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(39, 22);
            lblPlan.Margin = new Padding(2, 0, 2, 0);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(30, 15);
            lblPlan.TabIndex = 9;
            lblPlan.Text = "Plan";
            // 
            // grpPago
            // 
            grpPago.Controls.Add(lblCuotas);
            grpPago.Controls.Add(cboCuotas);
            grpPago.Controls.Add(lblMedPago);
            grpPago.Controls.Add(rbtTarjeta);
            grpPago.Controls.Add(rbtEfectivo);
            grpPago.Location = new Point(92, 305);
            grpPago.Margin = new Padding(2);
            grpPago.Name = "grpPago";
            grpPago.Padding = new Padding(2);
            grpPago.Size = new Size(279, 89);
            grpPago.TabIndex = 11;
            grpPago.TabStop = false;
            grpPago.Text = "PAGO";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(45, 58);
            lblCuotas.Margin = new Padding(2, 0, 2, 0);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(44, 15);
            lblCuotas.TabIndex = 1;
            lblCuotas.Text = "Cuotas";
            // 
            // cboCuotas
            // 
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cboCuotas.Location = new Point(103, 53);
            cboCuotas.Margin = new Padding(2);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(64, 23);
            cboCuotas.TabIndex = 3;
            // 
            // lblMedPago
            // 
            lblMedPago.AutoSize = true;
            lblMedPago.Location = new Point(4, 25);
            lblMedPago.Margin = new Padding(2, 0, 2, 0);
            lblMedPago.Name = "lblMedPago";
            lblMedPago.Size = new Size(87, 15);
            lblMedPago.TabIndex = 0;
            lblMedPago.Text = "Medio de pago";
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(195, 25);
            rbtTarjeta.Margin = new Padding(2);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(60, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(103, 25);
            rbtEfectivo.Margin = new Padding(2);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(228, 398);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(78, 20);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(146, 398);
            btnCalcular.Margin = new Padding(2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(78, 20);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.TextChanged += btnCalcular_TextChanged;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // frmInscripcion
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(grpPago);
            Controls.Add(btnCalcular);
            Controls.Add(grpPlan);
            Controls.Add(grpDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo — Inscripción";
            Load += frmInscripcion_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            grpPlan.ResumeLayout(false);
            grpPlan.PerformLayout();
            grpPago.ResumeLayout(false);
            grpPago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtEdad;
        private Label lblNombre;
        private Label lblEdad;
        private CheckBox chkEstudiante;
        private ComboBox cboPlan;
        private ComboBox cboTurno;
        private TextBox txtMeses;
        private CheckBox chkCasillero;
        private GroupBox grpDatos;
        private GroupBox grpPlan;
        private Label lblMeses;
        private Label lblTurno;
        private Label lblPlan;
        private GroupBox grpPago;
        private Label lblMedPago;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private Label lblCuotas;
        private ComboBox cboCuotas;
        private Button btnLimpiar;
        private Button btnCalcular;
    }
}
