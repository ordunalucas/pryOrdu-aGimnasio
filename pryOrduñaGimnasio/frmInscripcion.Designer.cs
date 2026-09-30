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
            btnLimpiar = new Button();
            btnCalcular = new Button();
            lblCuotas = new Label();
            cboCuotas = new ComboBox();
            lblMedPago = new Label();
            rbtTarjeta = new RadioButton();
            rbtEfectivo = new RadioButton();
            grpDatos.SuspendLayout();
            grpPlan.SuspendLayout();
            grpPago.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(133, 30);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 1;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(133, 94);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(150, 31);
            txtEdad.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(53, 36);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(75, 94);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(52, 25);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad";
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(21, 213);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(120, 29);
            chkEstudiante.TabIndex = 0;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculación", "Funcional ", "Natación" });
            cboPlan.Location = new Point(107, 29);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(182, 33);
            cboPlan.TabIndex = 1;
            cboPlan.SelectedIndexChanged += cboPlan_SelectedIndexChanged;
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboTurno.Location = new Point(107, 96);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(182, 33);
            cboTurno.TabIndex = 2;
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(107, 155);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(80, 31);
            txtMeses.TabIndex = 3;
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(173, 213);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(218, 29);
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
            grpDatos.Location = new Point(132, 58);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(398, 144);
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
            grpPlan.Location = new Point(132, 208);
            grpPlan.Name = "grpPlan";
            grpPlan.Size = new Size(398, 276);
            grpPlan.TabIndex = 10;
            grpPlan.TabStop = false;
            grpPlan.Text = "PLAN";
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(39, 155);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(62, 25);
            lblMeses.TabIndex = 11;
            lblMeses.Text = "Meses";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(43, 99);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(58, 25);
            lblTurno.TabIndex = 10;
            lblTurno.Text = "Turno";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(56, 37);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(45, 25);
            lblPlan.TabIndex = 9;
            lblPlan.Text = "Plan";
            // 
            // grpPago
            // 
            grpPago.Controls.Add(btnLimpiar);
            grpPago.Controls.Add(btnCalcular);
            grpPago.Controls.Add(lblCuotas);
            grpPago.Controls.Add(cboCuotas);
            grpPago.Controls.Add(lblMedPago);
            grpPago.Controls.Add(rbtTarjeta);
            grpPago.Controls.Add(rbtEfectivo);
            grpPago.Location = new Point(132, 508);
            grpPago.Name = "grpPago";
            grpPago.Size = new Size(398, 209);
            grpPago.TabIndex = 11;
            grpPago.TabStop = false;
            grpPago.Text = "PAGO";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(75, 149);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(214, 149);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(64, 97);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(67, 25);
            lblCuotas.TabIndex = 1;
            lblCuotas.Text = "Cuotas";
            // 
            // cboCuotas
            // 
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cboCuotas.Location = new Point(147, 89);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(90, 33);
            cboCuotas.TabIndex = 3;
            // 
            // lblMedPago
            // 
            lblMedPago.AutoSize = true;
            lblMedPago.Location = new Point(6, 41);
            lblMedPago.Name = "lblMedPago";
            lblMedPago.Size = new Size(135, 25);
            lblMedPago.TabIndex = 0;
            lblMedPago.Text = "Medio de pago";
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(278, 41);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(87, 29);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(147, 41);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(99, 29);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // frmInscripcion
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 750);
            Controls.Add(grpPago);
            Controls.Add(grpPlan);
            Controls.Add(grpDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
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
