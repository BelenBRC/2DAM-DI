namespace MaquinaRefrescos
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
            this.selectorCocaCola = new System.Windows.Forms.PictureBox();
            this.selectorPepsiMax = new System.Windows.Forms.PictureBox();
            this.selectorFantaNaranja = new System.Windows.Forms.PictureBox();
            this.selectorFantaNaranjaZero = new System.Windows.Forms.PictureBox();
            this.selectorFantaLimonZero = new System.Windows.Forms.PictureBox();
            this.selectorFantaLimon = new System.Windows.Forms.PictureBox();
            this.selectorNestea = new System.Windows.Forms.PictureBox();
            this.selector7up = new System.Windows.Forms.PictureBox();
            this.pantallaVending = new System.Windows.Forms.Label();
            this.labelPrecioCocaCola = new System.Windows.Forms.Label();
            this.panelRefrescos = new System.Windows.Forms.Panel();
            this.labelPrecioFantaLimonZero = new System.Windows.Forms.Label();
            this.labelPrecioFantaLimon = new System.Windows.Forms.Label();
            this.labelPrecioNestea = new System.Windows.Forms.Label();
            this.labelPrecio7up = new System.Windows.Forms.Label();
            this.labelPrecioFantaNaranjaZero = new System.Windows.Forms.Label();
            this.labelPrecioFantaNaranja = new System.Windows.Forms.Label();
            this.labelPrecioPepsi = new System.Windows.Forms.Label();
            this.panelMonedas = new System.Windows.Forms.Panel();
            this.pictureBoxMoneda10 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMoneda20 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMoneda50 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMoneda1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMoneda2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxRefresco = new System.Windows.Forms.PictureBox();
            this.pictureBoxCambio = new System.Windows.Forms.PictureBox();
            this.buttonInsertCoin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selectorCocaCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectorPepsiMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectorFantaNaranja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectorFantaNaranjaZero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectorFantaLimonZero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectorFantaLimon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectorNestea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector7up)).BeginInit();
            this.panelRefrescos.SuspendLayout();
            this.panelMonedas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoneda10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoneda20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoneda50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoneda1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoneda2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCambio)).BeginInit();
            this.SuspendLayout();
            // 
            // selectorCocaCola
            // 
            this.selectorCocaCola.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectorCocaCola.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selectorCocaCola.Image = global::MaquinaRefrescos.Properties.Resources.cocacola;
            this.selectorCocaCola.Location = new System.Drawing.Point(51, 98);
            this.selectorCocaCola.Name = "selectorCocaCola";
            this.selectorCocaCola.Size = new System.Drawing.Size(151, 161);
            this.selectorCocaCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectorCocaCola.TabIndex = 0;
            this.selectorCocaCola.TabStop = false;
            this.selectorCocaCola.Click += new System.EventHandler(this.selectorCocaCola_Click);
            // 
            // selectorPepsiMax
            // 
            this.selectorPepsiMax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectorPepsiMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selectorPepsiMax.Image = global::MaquinaRefrescos.Properties.Resources.pepsi_max;
            this.selectorPepsiMax.Location = new System.Drawing.Point(208, 98);
            this.selectorPepsiMax.Name = "selectorPepsiMax";
            this.selectorPepsiMax.Size = new System.Drawing.Size(151, 161);
            this.selectorPepsiMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectorPepsiMax.TabIndex = 1;
            this.selectorPepsiMax.TabStop = false;
            this.selectorPepsiMax.Click += new System.EventHandler(this.selectorPepsiMax_Click);
            // 
            // selectorFantaNaranja
            // 
            this.selectorFantaNaranja.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectorFantaNaranja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selectorFantaNaranja.Image = global::MaquinaRefrescos.Properties.Resources.fanta_naranja;
            this.selectorFantaNaranja.Location = new System.Drawing.Point(365, 98);
            this.selectorFantaNaranja.Name = "selectorFantaNaranja";
            this.selectorFantaNaranja.Size = new System.Drawing.Size(151, 161);
            this.selectorFantaNaranja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectorFantaNaranja.TabIndex = 2;
            this.selectorFantaNaranja.TabStop = false;
            this.selectorFantaNaranja.Click += new System.EventHandler(this.selectorFantaNaranja_Click);
            // 
            // selectorFantaNaranjaZero
            // 
            this.selectorFantaNaranjaZero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectorFantaNaranjaZero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selectorFantaNaranjaZero.Image = global::MaquinaRefrescos.Properties.Resources.fanta_naranja_zero;
            this.selectorFantaNaranjaZero.Location = new System.Drawing.Point(522, 98);
            this.selectorFantaNaranjaZero.Name = "selectorFantaNaranjaZero";
            this.selectorFantaNaranjaZero.Size = new System.Drawing.Size(151, 161);
            this.selectorFantaNaranjaZero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectorFantaNaranjaZero.TabIndex = 3;
            this.selectorFantaNaranjaZero.TabStop = false;
            this.selectorFantaNaranjaZero.Click += new System.EventHandler(this.selectorFantaNaranjaZero_Click);
            // 
            // selectorFantaLimonZero
            // 
            this.selectorFantaLimonZero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectorFantaLimonZero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selectorFantaLimonZero.Image = global::MaquinaRefrescos.Properties.Resources.fanta_limon_zero;
            this.selectorFantaLimonZero.Location = new System.Drawing.Point(522, 302);
            this.selectorFantaLimonZero.Name = "selectorFantaLimonZero";
            this.selectorFantaLimonZero.Size = new System.Drawing.Size(151, 161);
            this.selectorFantaLimonZero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectorFantaLimonZero.TabIndex = 7;
            this.selectorFantaLimonZero.TabStop = false;
            this.selectorFantaLimonZero.Click += new System.EventHandler(this.selectorFantaLimonZero_Click);
            // 
            // selectorFantaLimon
            // 
            this.selectorFantaLimon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectorFantaLimon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selectorFantaLimon.Image = global::MaquinaRefrescos.Properties.Resources.fanta_limon;
            this.selectorFantaLimon.Location = new System.Drawing.Point(365, 302);
            this.selectorFantaLimon.Name = "selectorFantaLimon";
            this.selectorFantaLimon.Size = new System.Drawing.Size(151, 161);
            this.selectorFantaLimon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectorFantaLimon.TabIndex = 6;
            this.selectorFantaLimon.TabStop = false;
            this.selectorFantaLimon.Click += new System.EventHandler(this.selectorFantaLimon_Click);
            // 
            // selectorNestea
            // 
            this.selectorNestea.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectorNestea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selectorNestea.Image = global::MaquinaRefrescos.Properties.Resources.nestea;
            this.selectorNestea.Location = new System.Drawing.Point(208, 302);
            this.selectorNestea.Name = "selectorNestea";
            this.selectorNestea.Size = new System.Drawing.Size(151, 161);
            this.selectorNestea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectorNestea.TabIndex = 5;
            this.selectorNestea.TabStop = false;
            this.selectorNestea.Click += new System.EventHandler(this.selectorNestea_Click);
            // 
            // selector7up
            // 
            this.selector7up.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selector7up.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selector7up.Image = global::MaquinaRefrescos.Properties.Resources._7up;
            this.selector7up.Location = new System.Drawing.Point(51, 302);
            this.selector7up.Name = "selector7up";
            this.selector7up.Size = new System.Drawing.Size(151, 161);
            this.selector7up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selector7up.TabIndex = 4;
            this.selector7up.TabStop = false;
            this.selector7up.Click += new System.EventHandler(this.selector7up_Click);
            // 
            // pantallaVending
            // 
            this.pantallaVending.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pantallaVending.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantallaVending.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pantallaVending.Location = new System.Drawing.Point(25, 14);
            this.pantallaVending.Name = "pantallaVending";
            this.pantallaVending.Size = new System.Drawing.Size(679, 73);
            this.pantallaVending.TabIndex = 8;
            this.pantallaVending.Text = "SELECCIONE SU BEBIDA";
            this.pantallaVending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrecioCocaCola
            // 
            this.labelPrecioCocaCola.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPrecioCocaCola.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioCocaCola.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPrecioCocaCola.Location = new System.Drawing.Point(51, 262);
            this.labelPrecioCocaCola.Name = "labelPrecioCocaCola";
            this.labelPrecioCocaCola.Size = new System.Drawing.Size(151, 20);
            this.labelPrecioCocaCola.TabIndex = 9;
            this.labelPrecioCocaCola.Text = "1,50 €";
            this.labelPrecioCocaCola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRefrescos
            // 
            this.panelRefrescos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelRefrescos.Controls.Add(this.labelPrecioFantaLimonZero);
            this.panelRefrescos.Controls.Add(this.labelPrecioFantaLimon);
            this.panelRefrescos.Controls.Add(this.labelPrecioNestea);
            this.panelRefrescos.Controls.Add(this.labelPrecio7up);
            this.panelRefrescos.Controls.Add(this.labelPrecioFantaNaranjaZero);
            this.panelRefrescos.Controls.Add(this.labelPrecioFantaNaranja);
            this.panelRefrescos.Controls.Add(this.labelPrecioPepsi);
            this.panelRefrescos.Controls.Add(this.pantallaVending);
            this.panelRefrescos.Controls.Add(this.selectorCocaCola);
            this.panelRefrescos.Controls.Add(this.selectorPepsiMax);
            this.panelRefrescos.Controls.Add(this.selectorFantaNaranja);
            this.panelRefrescos.Controls.Add(this.selectorFantaNaranjaZero);
            this.panelRefrescos.Controls.Add(this.selector7up);
            this.panelRefrescos.Controls.Add(this.selectorNestea);
            this.panelRefrescos.Controls.Add(this.selectorFantaLimon);
            this.panelRefrescos.Controls.Add(this.labelPrecioCocaCola);
            this.panelRefrescos.Controls.Add(this.selectorFantaLimonZero);
            this.panelRefrescos.Location = new System.Drawing.Point(655, 42);
            this.panelRefrescos.Name = "panelRefrescos";
            this.panelRefrescos.Size = new System.Drawing.Size(722, 522);
            this.panelRefrescos.TabIndex = 17;
            // 
            // labelPrecioFantaLimonZero
            // 
            this.labelPrecioFantaLimonZero.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPrecioFantaLimonZero.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioFantaLimonZero.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPrecioFantaLimonZero.Location = new System.Drawing.Point(522, 466);
            this.labelPrecioFantaLimonZero.Name = "labelPrecioFantaLimonZero";
            this.labelPrecioFantaLimonZero.Size = new System.Drawing.Size(151, 20);
            this.labelPrecioFantaLimonZero.TabIndex = 16;
            this.labelPrecioFantaLimonZero.Text = "1,50 €";
            this.labelPrecioFantaLimonZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrecioFantaLimon
            // 
            this.labelPrecioFantaLimon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPrecioFantaLimon.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioFantaLimon.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPrecioFantaLimon.Location = new System.Drawing.Point(365, 466);
            this.labelPrecioFantaLimon.Name = "labelPrecioFantaLimon";
            this.labelPrecioFantaLimon.Size = new System.Drawing.Size(151, 20);
            this.labelPrecioFantaLimon.TabIndex = 15;
            this.labelPrecioFantaLimon.Text = "1,50 €";
            this.labelPrecioFantaLimon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrecioNestea
            // 
            this.labelPrecioNestea.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPrecioNestea.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioNestea.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPrecioNestea.Location = new System.Drawing.Point(208, 466);
            this.labelPrecioNestea.Name = "labelPrecioNestea";
            this.labelPrecioNestea.Size = new System.Drawing.Size(151, 20);
            this.labelPrecioNestea.TabIndex = 14;
            this.labelPrecioNestea.Text = "1,50 €";
            this.labelPrecioNestea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrecio7up
            // 
            this.labelPrecio7up.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPrecio7up.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio7up.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPrecio7up.Location = new System.Drawing.Point(51, 466);
            this.labelPrecio7up.Name = "labelPrecio7up";
            this.labelPrecio7up.Size = new System.Drawing.Size(151, 20);
            this.labelPrecio7up.TabIndex = 13;
            this.labelPrecio7up.Text = "1,50 €";
            this.labelPrecio7up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrecioFantaNaranjaZero
            // 
            this.labelPrecioFantaNaranjaZero.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPrecioFantaNaranjaZero.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioFantaNaranjaZero.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPrecioFantaNaranjaZero.Location = new System.Drawing.Point(522, 262);
            this.labelPrecioFantaNaranjaZero.Name = "labelPrecioFantaNaranjaZero";
            this.labelPrecioFantaNaranjaZero.Size = new System.Drawing.Size(151, 20);
            this.labelPrecioFantaNaranjaZero.TabIndex = 12;
            this.labelPrecioFantaNaranjaZero.Text = "1,50 €";
            this.labelPrecioFantaNaranjaZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrecioFantaNaranja
            // 
            this.labelPrecioFantaNaranja.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPrecioFantaNaranja.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioFantaNaranja.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPrecioFantaNaranja.Location = new System.Drawing.Point(365, 262);
            this.labelPrecioFantaNaranja.Name = "labelPrecioFantaNaranja";
            this.labelPrecioFantaNaranja.Size = new System.Drawing.Size(151, 20);
            this.labelPrecioFantaNaranja.TabIndex = 11;
            this.labelPrecioFantaNaranja.Text = "1,50 €";
            this.labelPrecioFantaNaranja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrecioPepsi
            // 
            this.labelPrecioPepsi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPrecioPepsi.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioPepsi.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPrecioPepsi.Location = new System.Drawing.Point(208, 262);
            this.labelPrecioPepsi.Name = "labelPrecioPepsi";
            this.labelPrecioPepsi.Size = new System.Drawing.Size(151, 20);
            this.labelPrecioPepsi.TabIndex = 10;
            this.labelPrecioPepsi.Text = "1,50 €";
            this.labelPrecioPepsi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMonedas
            // 
            this.panelMonedas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelMonedas.Controls.Add(this.pictureBoxMoneda10);
            this.panelMonedas.Controls.Add(this.pictureBoxMoneda20);
            this.panelMonedas.Controls.Add(this.pictureBoxMoneda50);
            this.panelMonedas.Controls.Add(this.pictureBoxMoneda1);
            this.panelMonedas.Controls.Add(this.pictureBoxMoneda2);
            this.panelMonedas.Location = new System.Drawing.Point(960, 581);
            this.panelMonedas.Name = "panelMonedas";
            this.panelMonedas.Size = new System.Drawing.Size(417, 88);
            this.panelMonedas.TabIndex = 21;
            this.panelMonedas.Visible = false;
            // 
            // pictureBoxMoneda10
            // 
            this.pictureBoxMoneda10.Image = global::MaquinaRefrescos.Properties.Resources.moneda10;
            this.pictureBoxMoneda10.Location = new System.Drawing.Point(336, 3);
            this.pictureBoxMoneda10.Name = "pictureBoxMoneda10";
            this.pictureBoxMoneda10.Size = new System.Drawing.Size(77, 80);
            this.pictureBoxMoneda10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMoneda10.TabIndex = 4;
            this.pictureBoxMoneda10.TabStop = false;
            this.pictureBoxMoneda10.Click += new System.EventHandler(this.pictureBoxMoneda10_Click);
            // 
            // pictureBoxMoneda20
            // 
            this.pictureBoxMoneda20.Image = global::MaquinaRefrescos.Properties.Resources.moneda20;
            this.pictureBoxMoneda20.Location = new System.Drawing.Point(253, 3);
            this.pictureBoxMoneda20.Name = "pictureBoxMoneda20";
            this.pictureBoxMoneda20.Size = new System.Drawing.Size(77, 80);
            this.pictureBoxMoneda20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMoneda20.TabIndex = 3;
            this.pictureBoxMoneda20.TabStop = false;
            this.pictureBoxMoneda20.Click += new System.EventHandler(this.pictureBoxMoneda20_Click);
            // 
            // pictureBoxMoneda50
            // 
            this.pictureBoxMoneda50.Image = global::MaquinaRefrescos.Properties.Resources.moneda50;
            this.pictureBoxMoneda50.Location = new System.Drawing.Point(170, 3);
            this.pictureBoxMoneda50.Name = "pictureBoxMoneda50";
            this.pictureBoxMoneda50.Size = new System.Drawing.Size(77, 80);
            this.pictureBoxMoneda50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMoneda50.TabIndex = 2;
            this.pictureBoxMoneda50.TabStop = false;
            this.pictureBoxMoneda50.Click += new System.EventHandler(this.pictureBoxMoneda50_Click);
            // 
            // pictureBoxMoneda1
            // 
            this.pictureBoxMoneda1.Image = global::MaquinaRefrescos.Properties.Resources.moneda1;
            this.pictureBoxMoneda1.Location = new System.Drawing.Point(87, 3);
            this.pictureBoxMoneda1.Name = "pictureBoxMoneda1";
            this.pictureBoxMoneda1.Size = new System.Drawing.Size(77, 80);
            this.pictureBoxMoneda1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMoneda1.TabIndex = 1;
            this.pictureBoxMoneda1.TabStop = false;
            this.pictureBoxMoneda1.Click += new System.EventHandler(this.pictureBoxMoneda1_Click);
            // 
            // pictureBoxMoneda2
            // 
            this.pictureBoxMoneda2.Image = global::MaquinaRefrescos.Properties.Resources.moneda2;
            this.pictureBoxMoneda2.Location = new System.Drawing.Point(4, 3);
            this.pictureBoxMoneda2.Name = "pictureBoxMoneda2";
            this.pictureBoxMoneda2.Size = new System.Drawing.Size(77, 80);
            this.pictureBoxMoneda2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMoneda2.TabIndex = 0;
            this.pictureBoxMoneda2.TabStop = false;
            this.pictureBoxMoneda2.Click += new System.EventHandler(this.pictureBoxMoneda2_Click);
            // 
            // pictureBoxRefresco
            // 
            this.pictureBoxRefresco.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxRefresco.Location = new System.Drawing.Point(698, 626);
            this.pictureBoxRefresco.Name = "pictureBoxRefresco";
            this.pictureBoxRefresco.Size = new System.Drawing.Size(268, 130);
            this.pictureBoxRefresco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRefresco.TabIndex = 18;
            this.pictureBoxRefresco.TabStop = false;
            this.pictureBoxRefresco.Visible = false;
            this.pictureBoxRefresco.Click += new System.EventHandler(this.pictureBoxRefresco_Click);
            // 
            // pictureBoxCambio
            // 
            this.pictureBoxCambio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxCambio.Image = global::MaquinaRefrescos.Properties.Resources.cambio;
            this.pictureBoxCambio.Location = new System.Drawing.Point(1177, 801);
            this.pictureBoxCambio.Name = "pictureBoxCambio";
            this.pictureBoxCambio.Size = new System.Drawing.Size(202, 102);
            this.pictureBoxCambio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCambio.TabIndex = 19;
            this.pictureBoxCambio.TabStop = false;
            this.pictureBoxCambio.Visible = false;
            this.pictureBoxCambio.Click += new System.EventHandler(this.pictureBoxCambio_Click);
            // 
            // buttonInsertCoin
            // 
            this.buttonInsertCoin.Enabled = false;
            this.buttonInsertCoin.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertCoin.Location = new System.Drawing.Point(1196, 690);
            this.buttonInsertCoin.Name = "buttonInsertCoin";
            this.buttonInsertCoin.Size = new System.Drawing.Size(87, 65);
            this.buttonInsertCoin.TabIndex = 20;
            this.buttonInsertCoin.Text = "Insertar Monedas";
            this.buttonInsertCoin.UseVisualStyleBackColor = true;
            this.buttonInsertCoin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::MaquinaRefrescos.Properties.Resources.vending_machine_clipart_md;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.panelMonedas);
            this.Controls.Add(this.buttonInsertCoin);
            this.Controls.Add(this.pictureBoxCambio);
            this.Controls.Add(this.pictureBoxRefresco);
            this.Controls.Add(this.panelRefrescos);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vending de refrescos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectorCocaCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectorPepsiMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectorFantaNaranja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectorFantaNaranjaZero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectorFantaLimonZero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectorFantaLimon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectorNestea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector7up)).EndInit();
            this.panelRefrescos.ResumeLayout(false);
            this.panelMonedas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoneda10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoneda20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoneda50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoneda1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoneda2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCambio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox selectorCocaCola;
        private System.Windows.Forms.PictureBox selectorPepsiMax;
        private System.Windows.Forms.PictureBox selectorFantaNaranja;
        private System.Windows.Forms.PictureBox selectorFantaNaranjaZero;
        private System.Windows.Forms.PictureBox selectorFantaLimonZero;
        private System.Windows.Forms.PictureBox selectorFantaLimon;
        private System.Windows.Forms.PictureBox selectorNestea;
        private System.Windows.Forms.PictureBox selector7up;
        private System.Windows.Forms.Label pantallaVending;
        private System.Windows.Forms.Label labelPrecioCocaCola;
        private System.Windows.Forms.Panel panelRefrescos;
        private System.Windows.Forms.Label labelPrecioFantaLimonZero;
        private System.Windows.Forms.Label labelPrecioFantaLimon;
        private System.Windows.Forms.Label labelPrecioNestea;
        private System.Windows.Forms.Label labelPrecio7up;
        private System.Windows.Forms.Label labelPrecioFantaNaranjaZero;
        private System.Windows.Forms.Label labelPrecioFantaNaranja;
        private System.Windows.Forms.Label labelPrecioPepsi;
        private System.Windows.Forms.PictureBox pictureBoxRefresco;
        private System.Windows.Forms.PictureBox pictureBoxCambio;
        private System.Windows.Forms.Button buttonInsertCoin;
        private System.Windows.Forms.Panel panelMonedas;
        private System.Windows.Forms.PictureBox pictureBoxMoneda2;
        private System.Windows.Forms.PictureBox pictureBoxMoneda10;
        private System.Windows.Forms.PictureBox pictureBoxMoneda20;
        private System.Windows.Forms.PictureBox pictureBoxMoneda50;
        private System.Windows.Forms.PictureBox pictureBoxMoneda1;
    }
}

