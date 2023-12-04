namespace Suma
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.Label();
            this.buttonSuma = new System.Windows.Forms.Button();
            this.ButtonLimpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(93, 65);
            this.num1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(67, 28);
            this.num1.TabIndex = 0;
            this.num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(93, 101);
            this.num2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(67, 28);
            this.num2.TabIndex = 1;
            this.num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resultado
            // 
            this.resultado.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(48, 166);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(112, 34);
            this.resultado.TabIndex = 4;
            this.resultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonSuma
            // 
            this.buttonSuma.Font = new System.Drawing.Font("Calibri Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuma.Location = new System.Drawing.Point(166, 65);
            this.buttonSuma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSuma.Name = "buttonSuma";
            this.buttonSuma.Size = new System.Drawing.Size(67, 64);
            this.buttonSuma.TabIndex = 2;
            this.buttonSuma.Text = "+";
            this.buttonSuma.UseVisualStyleBackColor = true;
            this.buttonSuma.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonLimpiar
            // 
            this.ButtonLimpiar.BackgroundImage = global::Suma.Properties.Resources.escoba;
            this.ButtonLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonLimpiar.Location = new System.Drawing.Point(166, 166);
            this.ButtonLimpiar.Name = "ButtonLimpiar";
            this.ButtonLimpiar.Size = new System.Drawing.Size(67, 62);
            this.ButtonLimpiar.TabIndex = 5;
            this.ButtonLimpiar.UseVisualStyleBackColor = true;
            this.ButtonLimpiar.Click += new System.EventHandler(this.ButtonLimpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Suma.Properties.Resources.linea_horizontal;
            this.pictureBox1.Location = new System.Drawing.Point(48, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 259);
            this.Controls.Add(this.ButtonLimpiar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSuma);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Suma";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button buttonSuma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonLimpiar;
    }
}

