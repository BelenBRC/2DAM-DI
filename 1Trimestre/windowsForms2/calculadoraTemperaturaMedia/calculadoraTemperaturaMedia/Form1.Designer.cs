namespace calculadoraTemperaturaMedia
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
            this.labelDiaSemana = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTemperatura = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelTempMedia = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca las temperaturas de cada día de la semana:";
            // 
            // labelDiaSemana
            // 
            this.labelDiaSemana.Location = new System.Drawing.Point(23, 160);
            this.labelDiaSemana.Name = "labelDiaSemana";
            this.labelDiaSemana.Size = new System.Drawing.Size(119, 28);
            this.labelDiaSemana.TabIndex = 1;
            this.labelDiaSemana.Text = "Lunes";
            this.labelDiaSemana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temperatura (ºC)";
            // 
            // textBoxTemperatura
            // 
            this.textBoxTemperatura.Location = new System.Drawing.Point(145, 157);
            this.textBoxTemperatura.Name = "textBoxTemperatura";
            this.textBoxTemperatura.Size = new System.Drawing.Size(167, 36);
            this.textBoxTemperatura.TabIndex = 1;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCalcular.Location = new System.Drawing.Point(145, 211);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(167, 39);
            this.buttonCalcular.TabIndex = 6;
            this.buttonCalcular.Text = "CALCULAR";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Visible = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelTempMedia
            // 
            this.labelTempMedia.AutoSize = true;
            this.labelTempMedia.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempMedia.Location = new System.Drawing.Point(395, 137);
            this.labelTempMedia.Name = "labelTempMedia";
            this.labelTempMedia.Size = new System.Drawing.Size(250, 33);
            this.labelTempMedia.TabIndex = 7;
            this.labelTempMedia.Text = "Temperatura media:";
            this.labelTempMedia.Visible = false;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Calibri Light", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(418, 174);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(199, 82);
            this.labelResultado.TabIndex = 8;
            this.labelResultado.Text = "label8";
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelResultado.Visible = false;
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSiguiente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSiguiente.Location = new System.Drawing.Point(145, 211);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(167, 39);
            this.buttonSiguiente.TabIndex = 9;
            this.buttonSiguiente.Text = "SIGUIENTE";
            this.buttonSiguiente.UseVisualStyleBackColor = false;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonReiniciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReiniciar.Location = new System.Drawing.Point(145, 256);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(167, 39);
            this.buttonReiniciar.TabIndex = 10;
            this.buttonReiniciar.Text = "REINICIAR";
            this.buttonReiniciar.UseVisualStyleBackColor = false;
            this.buttonReiniciar.Click += new System.EventHandler(this.buttonReiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 321);
            this.Controls.Add(this.buttonReiniciar);
            this.Controls.Add(this.buttonSiguiente);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelTempMedia);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxTemperatura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelDiaSemana);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Calculadora de Temperatura Media Semanal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDiaSemana;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTemperatura;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelTempMedia;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.Button buttonReiniciar;
    }
}

