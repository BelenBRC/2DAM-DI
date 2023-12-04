namespace Envíos
{
    partial class EnviosLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnviosLayout));
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxTipoEnvio = new System.Windows.Forms.GroupBox();
            this.radioButtonPU = new System.Windows.Forms.RadioButton();
            this.radioButtonPN = new System.Windows.Forms.RadioButton();
            this.radioButtonCN = new System.Windows.Forms.RadioButton();
            this.groupBoxNotificaciones = new System.Windows.Forms.GroupBox();
            this.checkBoxEmail = new System.Windows.Forms.CheckBox();
            this.checkBoxTelefono = new System.Windows.Forms.CheckBox();
            this.checkBoxFax = new System.Windows.Forms.CheckBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxFax = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.labelPrecioCN = new System.Windows.Forms.Label();
            this.labelPrecioPN = new System.Windows.Forms.Label();
            this.labelPrecioPU = new System.Windows.Forms.Label();
            this.groupBoxTipoEnvio.SuspendLayout();
            this.groupBoxNotificaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Calibri Light", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(36, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(413, 61);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Opciones de envío";
            // 
            // groupBoxTipoEnvio
            // 
            this.groupBoxTipoEnvio.Controls.Add(this.labelPrecioPU);
            this.groupBoxTipoEnvio.Controls.Add(this.labelPrecioPN);
            this.groupBoxTipoEnvio.Controls.Add(this.labelPrecioCN);
            this.groupBoxTipoEnvio.Controls.Add(this.radioButtonPU);
            this.groupBoxTipoEnvio.Controls.Add(this.radioButtonPN);
            this.groupBoxTipoEnvio.Controls.Add(this.radioButtonCN);
            this.groupBoxTipoEnvio.Location = new System.Drawing.Point(23, 74);
            this.groupBoxTipoEnvio.Name = "groupBoxTipoEnvio";
            this.groupBoxTipoEnvio.Size = new System.Drawing.Size(426, 164);
            this.groupBoxTipoEnvio.TabIndex = 1;
            this.groupBoxTipoEnvio.TabStop = false;
            this.groupBoxTipoEnvio.Text = "Tipo de envío";
            // 
            // radioButtonPU
            // 
            this.radioButtonPU.AutoSize = true;
            this.radioButtonPU.Location = new System.Drawing.Point(34, 114);
            this.radioButtonPU.Name = "radioButtonPU";
            this.radioButtonPU.Size = new System.Drawing.Size(214, 32);
            this.radioButtonPU.TabIndex = 2;
            this.radioButtonPU.Text = "Paquetería Urgente";
            this.radioButtonPU.UseVisualStyleBackColor = true;
            // 
            // radioButtonPN
            // 
            this.radioButtonPN.AutoSize = true;
            this.radioButtonPN.Location = new System.Drawing.Point(34, 75);
            this.radioButtonPN.Name = "radioButtonPN";
            this.radioButtonPN.Size = new System.Drawing.Size(207, 32);
            this.radioButtonPN.TabIndex = 1;
            this.radioButtonPN.Text = "Paquetería Normal";
            this.radioButtonPN.UseVisualStyleBackColor = true;
            // 
            // radioButtonCN
            // 
            this.radioButtonCN.AutoSize = true;
            this.radioButtonCN.Checked = true;
            this.radioButtonCN.Location = new System.Drawing.Point(34, 36);
            this.radioButtonCN.Name = "radioButtonCN";
            this.radioButtonCN.Size = new System.Drawing.Size(170, 32);
            this.radioButtonCN.TabIndex = 0;
            this.radioButtonCN.TabStop = true;
            this.radioButtonCN.Text = "Correo Normal";
            this.radioButtonCN.UseVisualStyleBackColor = true;
            // 
            // groupBoxNotificaciones
            // 
            this.groupBoxNotificaciones.Controls.Add(this.textBoxFax);
            this.groupBoxNotificaciones.Controls.Add(this.textBoxTelefono);
            this.groupBoxNotificaciones.Controls.Add(this.textBoxEmail);
            this.groupBoxNotificaciones.Controls.Add(this.checkBoxFax);
            this.groupBoxNotificaciones.Controls.Add(this.checkBoxTelefono);
            this.groupBoxNotificaciones.Controls.Add(this.checkBoxEmail);
            this.groupBoxNotificaciones.Location = new System.Drawing.Point(23, 265);
            this.groupBoxNotificaciones.Name = "groupBoxNotificaciones";
            this.groupBoxNotificaciones.Size = new System.Drawing.Size(426, 164);
            this.groupBoxNotificaciones.TabIndex = 2;
            this.groupBoxNotificaciones.TabStop = false;
            this.groupBoxNotificaciones.Text = "Notificación";
            // 
            // checkBoxEmail
            // 
            this.checkBoxEmail.AutoSize = true;
            this.checkBoxEmail.Checked = true;
            this.checkBoxEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEmail.Location = new System.Drawing.Point(34, 36);
            this.checkBoxEmail.Name = "checkBoxEmail";
            this.checkBoxEmail.Size = new System.Drawing.Size(84, 32);
            this.checkBoxEmail.TabIndex = 0;
            this.checkBoxEmail.Text = "Email";
            this.checkBoxEmail.UseVisualStyleBackColor = true;
            this.checkBoxEmail.CheckedChanged += new System.EventHandler(this.checkBoxEmail_CheckedChanged);
            // 
            // checkBoxTelefono
            // 
            this.checkBoxTelefono.AutoSize = true;
            this.checkBoxTelefono.Location = new System.Drawing.Point(34, 75);
            this.checkBoxTelefono.Name = "checkBoxTelefono";
            this.checkBoxTelefono.Size = new System.Drawing.Size(112, 32);
            this.checkBoxTelefono.TabIndex = 1;
            this.checkBoxTelefono.Text = "Teléfono";
            this.checkBoxTelefono.UseVisualStyleBackColor = true;
            this.checkBoxTelefono.CheckedChanged += new System.EventHandler(this.checkBoxTelefono_CheckedChanged);
            // 
            // checkBoxFax
            // 
            this.checkBoxFax.AutoSize = true;
            this.checkBoxFax.Location = new System.Drawing.Point(34, 114);
            this.checkBoxFax.Name = "checkBoxFax";
            this.checkBoxFax.Size = new System.Drawing.Size(65, 32);
            this.checkBoxFax.TabIndex = 2;
            this.checkBoxFax.Text = "Fax";
            this.checkBoxFax.UseVisualStyleBackColor = true;
            this.checkBoxFax.CheckedChanged += new System.EventHandler(this.checkBoxFax_CheckedChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(159, 32);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(251, 36);
            this.textBoxEmail.TabIndex = 3;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(159, 73);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(251, 36);
            this.textBoxTelefono.TabIndex = 4;
            this.textBoxTelefono.Visible = false;
            // 
            // textBoxFax
            // 
            this.textBoxFax.Location = new System.Drawing.Point(159, 112);
            this.textBoxFax.Name = "textBoxFax";
            this.textBoxFax.Size = new System.Drawing.Size(251, 36);
            this.textBoxFax.TabIndex = 5;
            this.textBoxFax.Visible = false;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.Location = new System.Drawing.Point(182, 466);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(126, 53);
            this.buttonConfirmar.TabIndex = 3;
            this.buttonConfirmar.Text = "CONFIRMAR";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // labelPrecioCN
            // 
            this.labelPrecioCN.AutoSize = true;
            this.labelPrecioCN.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioCN.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPrecioCN.Location = new System.Drawing.Point(276, 41);
            this.labelPrecioCN.Name = "labelPrecioCN";
            this.labelPrecioCN.Size = new System.Drawing.Size(58, 24);
            this.labelPrecioCN.TabIndex = 3;
            this.labelPrecioCN.Text = "Gratis";
            // 
            // labelPrecioPN
            // 
            this.labelPrecioPN.AutoSize = true;
            this.labelPrecioPN.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioPN.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPrecioPN.Location = new System.Drawing.Point(276, 80);
            this.labelPrecioPN.Name = "labelPrecioPN";
            this.labelPrecioPN.Size = new System.Drawing.Size(58, 24);
            this.labelPrecioPN.TabIndex = 4;
            this.labelPrecioPN.Text = "Gratis";
            // 
            // labelPrecioPU
            // 
            this.labelPrecioPU.AutoSize = true;
            this.labelPrecioPU.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioPU.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPrecioPU.Location = new System.Drawing.Point(276, 122);
            this.labelPrecioPU.Name = "labelPrecioPU";
            this.labelPrecioPU.Size = new System.Drawing.Size(58, 24);
            this.labelPrecioPU.TabIndex = 5;
            this.labelPrecioPU.Text = "Gratis";
            // 
            // EnviosLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 558);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.groupBoxNotificaciones);
            this.Controls.Add(this.groupBoxTipoEnvio);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EnviosLayout";
            this.Text = "Envíos";
            this.groupBoxTipoEnvio.ResumeLayout(false);
            this.groupBoxTipoEnvio.PerformLayout();
            this.groupBoxNotificaciones.ResumeLayout(false);
            this.groupBoxNotificaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxTipoEnvio;
        private System.Windows.Forms.RadioButton radioButtonPU;
        private System.Windows.Forms.RadioButton radioButtonPN;
        private System.Windows.Forms.RadioButton radioButtonCN;
        private System.Windows.Forms.GroupBox groupBoxNotificaciones;
        private System.Windows.Forms.CheckBox checkBoxFax;
        private System.Windows.Forms.CheckBox checkBoxTelefono;
        private System.Windows.Forms.CheckBox checkBoxEmail;
        private System.Windows.Forms.TextBox textBoxFax;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label labelPrecioPU;
        private System.Windows.Forms.Label labelPrecioPN;
        private System.Windows.Forms.Label labelPrecioCN;
    }
}

