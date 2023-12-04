namespace Sumas1aN
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
            this.labelComboBox = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBoxResultadosParciales = new System.Windows.Forms.CheckBox();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelComboBox
            // 
            this.labelComboBox.AutoSize = true;
            this.labelComboBox.Location = new System.Drawing.Point(87, 52);
            this.labelComboBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComboBox.Name = "labelComboBox";
            this.labelComboBox.Size = new System.Drawing.Size(242, 24);
            this.labelComboBox.TabIndex = 0;
            this.labelComboBox.Text = "Calcular suma desde 1 hasta:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(336, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 32);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBoxResultadosParciales
            // 
            this.checkBoxResultadosParciales.AutoSize = true;
            this.checkBoxResultadosParciales.Checked = true;
            this.checkBoxResultadosParciales.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxResultadosParciales.Location = new System.Drawing.Point(91, 109);
            this.checkBoxResultadosParciales.Name = "checkBoxResultadosParciales";
            this.checkBoxResultadosParciales.Size = new System.Drawing.Size(222, 28);
            this.checkBoxResultadosParciales.TabIndex = 2;
            this.checkBoxResultadosParciales.Text = "Ver resultados parciales";
            this.checkBoxResultadosParciales.UseVisualStyleBackColor = true;
            this.checkBoxResultadosParciales.CheckedChanged += new System.EventHandler(this.checkBoxResultadosParciales_CheckedChanged);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 24;
            this.listBoxResultado.Location = new System.Drawing.Point(91, 175);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(326, 220);
            this.listBoxResultado.TabIndex = 3;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(200, 442);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(113, 39);
            this.buttonCalcular.TabIndex = 4;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 525);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.checkBoxResultadosParciales);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelComboBox);
            this.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Suma de 1 a N";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBoxResultadosParciales;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Button buttonCalcular;
    }
}

