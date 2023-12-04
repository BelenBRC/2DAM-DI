namespace CuentaBancaria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonCuentaCorriente = new System.Windows.Forms.RadioButton();
            this.radioButtonCuentaAhorro = new System.Windows.Forms.RadioButton();
            this.labelSeleccioneCuenta = new System.Windows.Forms.Label();
            this.comboBoxCuenta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCuotaMantenimiento = new System.Windows.Forms.Label();
            this.textBoxNumeroCuenta = new System.Windows.Forms.TextBox();
            this.textBoxTitularCuenta = new System.Windows.Forms.TextBox();
            this.textBoxSaldoCuenta = new System.Windows.Forms.TextBox();
            this.textBoxTipoInteres = new System.Windows.Forms.TextBox();
            this.textBoxCuotaMantenimiento = new System.Windows.Forms.TextBox();
            this.labelCampoNumeroCuenta = new System.Windows.Forms.Label();
            this.labelCampoTitularCuenta = new System.Windows.Forms.Label();
            this.labelCampoSaldoCuenta = new System.Windows.Forms.Label();
            this.labelCampoTipoInteres = new System.Windows.Forms.Label();
            this.labelCampoCuotaMantenimiento = new System.Windows.Forms.Label();
            this.buttonAniadirCuenta = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.pictureBoxCuentaCorriente = new System.Windows.Forms.PictureBox();
            this.pictureBoxCuentaAhorro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentaCorriente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentaAhorro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de cuenta";
            // 
            // radioButtonCuentaCorriente
            // 
            this.radioButtonCuentaCorriente.AutoSize = true;
            this.radioButtonCuentaCorriente.Checked = true;
            this.radioButtonCuentaCorriente.Location = new System.Drawing.Point(345, 57);
            this.radioButtonCuentaCorriente.Name = "radioButtonCuentaCorriente";
            this.radioButtonCuentaCorriente.Size = new System.Drawing.Size(192, 33);
            this.radioButtonCuentaCorriente.TabIndex = 1;
            this.radioButtonCuentaCorriente.TabStop = true;
            this.radioButtonCuentaCorriente.Text = "Cuenta corriente";
            this.radioButtonCuentaCorriente.UseVisualStyleBackColor = true;
            this.radioButtonCuentaCorriente.CheckedChanged += new System.EventHandler(this.radioButtonCuentaCorriente_CheckedChanged);
            // 
            // radioButtonCuentaAhorro
            // 
            this.radioButtonCuentaAhorro.AutoSize = true;
            this.radioButtonCuentaAhorro.Location = new System.Drawing.Point(557, 57);
            this.radioButtonCuentaAhorro.Name = "radioButtonCuentaAhorro";
            this.radioButtonCuentaAhorro.Size = new System.Drawing.Size(171, 33);
            this.radioButtonCuentaAhorro.TabIndex = 2;
            this.radioButtonCuentaAhorro.Text = "Cuenta ahorro";
            this.radioButtonCuentaAhorro.UseVisualStyleBackColor = true;
            this.radioButtonCuentaAhorro.CheckedChanged += new System.EventHandler(this.radioButtonCuentaAhorro_CheckedChanged);
            // 
            // labelSeleccioneCuenta
            // 
            this.labelSeleccioneCuenta.AutoSize = true;
            this.labelSeleccioneCuenta.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeleccioneCuenta.Location = new System.Drawing.Point(56, 122);
            this.labelSeleccioneCuenta.Name = "labelSeleccioneCuenta";
            this.labelSeleccioneCuenta.Size = new System.Drawing.Size(283, 37);
            this.labelSeleccioneCuenta.TabIndex = 3;
            this.labelSeleccioneCuenta.Text = "Seleccione una cuenta";
            // 
            // comboBoxCuenta
            // 
            this.comboBoxCuenta.FormattingEnabled = true;
            this.comboBoxCuenta.Location = new System.Drawing.Point(345, 126);
            this.comboBoxCuenta.Name = "comboBoxCuenta";
            this.comboBoxCuenta.Size = new System.Drawing.Size(404, 36);
            this.comboBoxCuenta.TabIndex = 3;
            this.comboBoxCuenta.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCuenta_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número de cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Titular de la cuenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Saldo de la cuenta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tipo de interés";
            // 
            // labelCuotaMantenimiento
            // 
            this.labelCuotaMantenimiento.AutoSize = true;
            this.labelCuotaMantenimiento.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuotaMantenimiento.Location = new System.Drawing.Point(58, 405);
            this.labelCuotaMantenimiento.Name = "labelCuotaMantenimiento";
            this.labelCuotaMantenimiento.Size = new System.Drawing.Size(249, 29);
            this.labelCuotaMantenimiento.TabIndex = 9;
            this.labelCuotaMantenimiento.Text = "Cuota de mantenimiento";
            this.labelCuotaMantenimiento.Visible = false;
            // 
            // textBoxNumeroCuenta
            // 
            this.textBoxNumeroCuenta.Location = new System.Drawing.Point(345, 226);
            this.textBoxNumeroCuenta.Name = "textBoxNumeroCuenta";
            this.textBoxNumeroCuenta.Size = new System.Drawing.Size(404, 36);
            this.textBoxNumeroCuenta.TabIndex = 5;
            this.textBoxNumeroCuenta.Visible = false;
            // 
            // textBoxTitularCuenta
            // 
            this.textBoxTitularCuenta.Location = new System.Drawing.Point(345, 269);
            this.textBoxTitularCuenta.Name = "textBoxTitularCuenta";
            this.textBoxTitularCuenta.Size = new System.Drawing.Size(404, 36);
            this.textBoxTitularCuenta.TabIndex = 6;
            this.textBoxTitularCuenta.Visible = false;
            // 
            // textBoxSaldoCuenta
            // 
            this.textBoxSaldoCuenta.Location = new System.Drawing.Point(345, 314);
            this.textBoxSaldoCuenta.Name = "textBoxSaldoCuenta";
            this.textBoxSaldoCuenta.Size = new System.Drawing.Size(404, 36);
            this.textBoxSaldoCuenta.TabIndex = 7;
            this.textBoxSaldoCuenta.Visible = false;
            // 
            // textBoxTipoInteres
            // 
            this.textBoxTipoInteres.Location = new System.Drawing.Point(345, 361);
            this.textBoxTipoInteres.Name = "textBoxTipoInteres";
            this.textBoxTipoInteres.Size = new System.Drawing.Size(404, 36);
            this.textBoxTipoInteres.TabIndex = 8;
            this.textBoxTipoInteres.Visible = false;
            // 
            // textBoxCuotaMantenimiento
            // 
            this.textBoxCuotaMantenimiento.Location = new System.Drawing.Point(345, 402);
            this.textBoxCuotaMantenimiento.Name = "textBoxCuotaMantenimiento";
            this.textBoxCuotaMantenimiento.Size = new System.Drawing.Size(404, 36);
            this.textBoxCuotaMantenimiento.TabIndex = 9;
            this.textBoxCuotaMantenimiento.Visible = false;
            // 
            // labelCampoNumeroCuenta
            // 
            this.labelCampoNumeroCuenta.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCampoNumeroCuenta.Location = new System.Drawing.Point(345, 229);
            this.labelCampoNumeroCuenta.Name = "labelCampoNumeroCuenta";
            this.labelCampoNumeroCuenta.Size = new System.Drawing.Size(404, 36);
            this.labelCampoNumeroCuenta.TabIndex = 18;
            this.labelCampoNumeroCuenta.Text = " ";
            // 
            // labelCampoTitularCuenta
            // 
            this.labelCampoTitularCuenta.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCampoTitularCuenta.Location = new System.Drawing.Point(345, 272);
            this.labelCampoTitularCuenta.Name = "labelCampoTitularCuenta";
            this.labelCampoTitularCuenta.Size = new System.Drawing.Size(404, 36);
            this.labelCampoTitularCuenta.TabIndex = 19;
            this.labelCampoTitularCuenta.Text = " ";
            // 
            // labelCampoSaldoCuenta
            // 
            this.labelCampoSaldoCuenta.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCampoSaldoCuenta.Location = new System.Drawing.Point(345, 317);
            this.labelCampoSaldoCuenta.Name = "labelCampoSaldoCuenta";
            this.labelCampoSaldoCuenta.Size = new System.Drawing.Size(404, 36);
            this.labelCampoSaldoCuenta.TabIndex = 20;
            this.labelCampoSaldoCuenta.Text = " ";
            // 
            // labelCampoTipoInteres
            // 
            this.labelCampoTipoInteres.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCampoTipoInteres.Location = new System.Drawing.Point(345, 359);
            this.labelCampoTipoInteres.Name = "labelCampoTipoInteres";
            this.labelCampoTipoInteres.Size = new System.Drawing.Size(404, 36);
            this.labelCampoTipoInteres.TabIndex = 21;
            this.labelCampoTipoInteres.Text = " ";
            // 
            // labelCampoCuotaMantenimiento
            // 
            this.labelCampoCuotaMantenimiento.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCampoCuotaMantenimiento.Location = new System.Drawing.Point(345, 405);
            this.labelCampoCuotaMantenimiento.Name = "labelCampoCuotaMantenimiento";
            this.labelCampoCuotaMantenimiento.Size = new System.Drawing.Size(404, 36);
            this.labelCampoCuotaMantenimiento.TabIndex = 22;
            this.labelCampoCuotaMantenimiento.Text = " ";
            this.labelCampoCuotaMantenimiento.Visible = false;
            // 
            // buttonAniadirCuenta
            // 
            this.buttonAniadirCuenta.BackColor = System.Drawing.Color.Transparent;
            this.buttonAniadirCuenta.BackgroundImage = global::CuentaBancaria.Properties.Resources.nuevo;
            this.buttonAniadirCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAniadirCuenta.Location = new System.Drawing.Point(391, 476);
            this.buttonAniadirCuenta.Name = "buttonAniadirCuenta";
            this.buttonAniadirCuenta.Size = new System.Drawing.Size(60, 60);
            this.buttonAniadirCuenta.TabIndex = 4;
            this.buttonAniadirCuenta.UseVisualStyleBackColor = false;
            this.buttonAniadirCuenta.Click += new System.EventHandler(this.buttonAniadirCuenta_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelar.BackgroundImage = global::CuentaBancaria.Properties.Resources.cancelar;
            this.buttonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCancelar.Location = new System.Drawing.Point(689, 476);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(60, 60);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Visible = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.Transparent;
            this.buttonGuardar.BackgroundImage = global::CuentaBancaria.Properties.Resources.guardar;
            this.buttonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGuardar.Location = new System.Drawing.Point(608, 476);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(60, 60);
            this.buttonGuardar.TabIndex = 10;
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Visible = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // pictureBoxCuentaCorriente
            // 
            this.pictureBoxCuentaCorriente.Image = global::CuentaBancaria.Properties.Resources.credit_card;
            this.pictureBoxCuentaCorriente.Location = new System.Drawing.Point(382, 96);
            this.pictureBoxCuentaCorriente.Name = "pictureBoxCuentaCorriente";
            this.pictureBoxCuentaCorriente.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxCuentaCorriente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCuentaCorriente.TabIndex = 23;
            this.pictureBoxCuentaCorriente.TabStop = false;
            this.pictureBoxCuentaCorriente.Visible = false;
            // 
            // pictureBoxCuentaAhorro
            // 
            this.pictureBoxCuentaAhorro.Image = global::CuentaBancaria.Properties.Resources.ahorro;
            this.pictureBoxCuentaAhorro.Location = new System.Drawing.Point(592, 96);
            this.pictureBoxCuentaAhorro.Name = "pictureBoxCuentaAhorro";
            this.pictureBoxCuentaAhorro.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxCuentaAhorro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCuentaAhorro.TabIndex = 24;
            this.pictureBoxCuentaAhorro.TabStop = false;
            this.pictureBoxCuentaAhorro.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 573);
            this.Controls.Add(this.pictureBoxCuentaAhorro);
            this.Controls.Add(this.pictureBoxCuentaCorriente);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAniadirCuenta);
            this.Controls.Add(this.labelCuotaMantenimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCuenta);
            this.Controls.Add(this.labelSeleccioneCuenta);
            this.Controls.Add(this.radioButtonCuentaAhorro);
            this.Controls.Add(this.radioButtonCuentaCorriente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCuotaMantenimiento);
            this.Controls.Add(this.textBoxTipoInteres);
            this.Controls.Add(this.textBoxSaldoCuenta);
            this.Controls.Add(this.textBoxTitularCuenta);
            this.Controls.Add(this.textBoxNumeroCuenta);
            this.Controls.Add(this.labelCampoCuotaMantenimiento);
            this.Controls.Add(this.labelCampoTipoInteres);
            this.Controls.Add(this.labelCampoSaldoCuenta);
            this.Controls.Add(this.labelCampoTitularCuenta);
            this.Controls.Add(this.labelCampoNumeroCuenta);
            this.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Banco";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentaCorriente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuentaAhorro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonCuentaCorriente;
        private System.Windows.Forms.RadioButton radioButtonCuentaAhorro;
        private System.Windows.Forms.Label labelSeleccioneCuenta;
        private System.Windows.Forms.ComboBox comboBoxCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCuotaMantenimiento;
        private System.Windows.Forms.TextBox textBoxNumeroCuenta;
        private System.Windows.Forms.TextBox textBoxTitularCuenta;
        private System.Windows.Forms.TextBox textBoxSaldoCuenta;
        private System.Windows.Forms.TextBox textBoxTipoInteres;
        private System.Windows.Forms.TextBox textBoxCuotaMantenimiento;
        private System.Windows.Forms.Label labelCampoNumeroCuenta;
        private System.Windows.Forms.Label labelCampoTitularCuenta;
        private System.Windows.Forms.Label labelCampoSaldoCuenta;
        private System.Windows.Forms.Label labelCampoTipoInteres;
        private System.Windows.Forms.Label labelCampoCuotaMantenimiento;
        private System.Windows.Forms.Button buttonAniadirCuenta;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.PictureBox pictureBoxCuentaCorriente;
        private System.Windows.Forms.PictureBox pictureBoxCuentaAhorro;
    }
}

