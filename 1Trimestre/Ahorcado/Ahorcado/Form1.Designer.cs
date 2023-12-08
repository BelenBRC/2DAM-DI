namespace Ahorcado
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
            this.panelAdministrador = new System.Windows.Forms.Panel();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.contenedorListaPalabras = new System.Windows.Forms.ListView();
            this.panelPalabras = new System.Windows.Forms.Panel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.panelAgregarPalabra = new System.Windows.Forms.Panel();
            this.txtPalabraNueva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEliminarPalabra = new System.Windows.Forms.Panel();
            this.comboBoxEliminar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelListaPalabras = new System.Windows.Forms.Label();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.botonSalir = new System.Windows.Forms.Button();
            this.buttonAdministrador = new System.Windows.Forms.Button();
            this.tituloJuego = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.panelJuego = new System.Windows.Forms.Panel();
            this.panelFallo = new System.Windows.Forms.Panel();
            this.panelAcierto = new System.Windows.Forms.Panel();
            this.imagenAhorcado = new System.Windows.Forms.PictureBox();
            this.groupBoxPalabraAdivinar = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRepeat = new System.Windows.Forms.Button();
            this.buttonVolverInicio = new System.Windows.Forms.Button();
            this.teclado = new System.Windows.Forms.TableLayoutPanel();
            this.buttonZ = new System.Windows.Forms.Button();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonQ = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonO = new System.Windows.Forms.Button();
            this.buttonÑ = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonK = new System.Windows.Forms.Button();
            this.buttonJ = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonH = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.panelAdministrador.SuspendLayout();
            this.panelPalabras.SuspendLayout();
            this.panelAgregarPalabra.SuspendLayout();
            this.panelEliminarPalabra.SuspendLayout();
            this.panelInicio.SuspendLayout();
            this.panelJuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenAhorcado)).BeginInit();
            this.panel1.SuspendLayout();
            this.teclado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdministrador
            // 
            this.panelAdministrador.BackgroundImage = global::Ahorcado.Properties.Resources.fondo2;
            this.panelAdministrador.Controls.Add(this.buttonVolver);
            this.panelAdministrador.Controls.Add(this.contenedorListaPalabras);
            this.panelAdministrador.Controls.Add(this.panelPalabras);
            this.panelAdministrador.Controls.Add(this.labelListaPalabras);
            this.panelAdministrador.Location = new System.Drawing.Point(928, 0);
            this.panelAdministrador.Name = "panelAdministrador";
            this.panelAdministrador.Size = new System.Drawing.Size(458, 589);
            this.panelAdministrador.TabIndex = 2;
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.SystemColors.Control;
            this.buttonVolver.BackgroundImage = global::Ahorcado.Properties.Resources.back;
            this.buttonVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVolver.ForeColor = System.Drawing.Color.Black;
            this.buttonVolver.Location = new System.Drawing.Point(360, 518);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(65, 57);
            this.buttonVolver.TabIndex = 9;
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // contenedorListaPalabras
            // 
            this.contenedorListaPalabras.Font = new System.Drawing.Font("Calibri Light", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contenedorListaPalabras.HideSelection = false;
            this.contenedorListaPalabras.Location = new System.Drawing.Point(12, 353);
            this.contenedorListaPalabras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contenedorListaPalabras.Name = "contenedorListaPalabras";
            this.contenedorListaPalabras.Size = new System.Drawing.Size(432, 158);
            this.contenedorListaPalabras.TabIndex = 9;
            this.contenedorListaPalabras.UseCompatibleStateImageBehavior = false;
            // 
            // panelPalabras
            // 
            this.panelPalabras.BackColor = System.Drawing.Color.LightCyan;
            this.panelPalabras.Controls.Add(this.buttonCancelar);
            this.panelPalabras.Controls.Add(this.buttonConfirmar);
            this.panelPalabras.Controls.Add(this.buttonBorrar);
            this.panelPalabras.Controls.Add(this.buttonAgregar);
            this.panelPalabras.Controls.Add(this.panelAgregarPalabra);
            this.panelPalabras.Controls.Add(this.panelEliminarPalabra);
            this.panelPalabras.Location = new System.Drawing.Point(0, 91);
            this.panelPalabras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPalabras.Name = "panelPalabras";
            this.panelPalabras.Size = new System.Drawing.Size(458, 240);
            this.panelPalabras.TabIndex = 8;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackgroundImage = global::Ahorcado.Properties.Resources.cancela;
            this.buttonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCancelar.Location = new System.Drawing.Point(247, 90);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 63);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackgroundImage = global::Ahorcado.Properties.Resources.confirma;
            this.buttonConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonConfirmar.Location = new System.Drawing.Point(133, 90);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(75, 63);
            this.buttonConfirmar.TabIndex = 10;
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.BackgroundImage = global::Ahorcado.Properties.Resources.eliminarPalabra;
            this.buttonBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBorrar.Location = new System.Drawing.Point(366, 90);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(75, 63);
            this.buttonBorrar.TabIndex = 9;
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAgregar.BackgroundImage = global::Ahorcado.Properties.Resources.nuevaPalabra;
            this.buttonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAgregar.Location = new System.Drawing.Point(9, 91);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 63);
            this.buttonAgregar.TabIndex = 8;
            this.buttonAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // panelAgregarPalabra
            // 
            this.panelAgregarPalabra.BackColor = System.Drawing.Color.Azure;
            this.panelAgregarPalabra.Controls.Add(this.txtPalabraNueva);
            this.panelAgregarPalabra.Controls.Add(this.label1);
            this.panelAgregarPalabra.Location = new System.Drawing.Point(9, 21);
            this.panelAgregarPalabra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelAgregarPalabra.Name = "panelAgregarPalabra";
            this.panelAgregarPalabra.Size = new System.Drawing.Size(432, 62);
            this.panelAgregarPalabra.TabIndex = 7;
            // 
            // txtPalabraNueva
            // 
            this.txtPalabraNueva.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalabraNueva.Location = new System.Drawing.Point(180, 16);
            this.txtPalabraNueva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPalabraNueva.Name = "txtPalabraNueva";
            this.txtPalabraNueva.Size = new System.Drawing.Size(236, 32);
            this.txtPalabraNueva.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harry P", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agregar palabra:";
            // 
            // panelEliminarPalabra
            // 
            this.panelEliminarPalabra.BackColor = System.Drawing.Color.Azure;
            this.panelEliminarPalabra.Controls.Add(this.comboBoxEliminar);
            this.panelEliminarPalabra.Controls.Add(this.label3);
            this.panelEliminarPalabra.Location = new System.Drawing.Point(9, 160);
            this.panelEliminarPalabra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelEliminarPalabra.Name = "panelEliminarPalabra";
            this.panelEliminarPalabra.Size = new System.Drawing.Size(432, 64);
            this.panelEliminarPalabra.TabIndex = 6;
            // 
            // comboBoxEliminar
            // 
            this.comboBoxEliminar.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEliminar.FormattingEnabled = true;
            this.comboBoxEliminar.Location = new System.Drawing.Point(182, 19);
            this.comboBoxEliminar.Name = "comboBoxEliminar";
            this.comboBoxEliminar.Size = new System.Drawing.Size(236, 32);
            this.comboBoxEliminar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harry P", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Eliminar palabra:";
            // 
            // labelListaPalabras
            // 
            this.labelListaPalabras.BackColor = System.Drawing.SystemColors.Window;
            this.labelListaPalabras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelListaPalabras.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaPalabras.ForeColor = System.Drawing.Color.DimGray;
            this.labelListaPalabras.Location = new System.Drawing.Point(12, 12);
            this.labelListaPalabras.Name = "labelListaPalabras";
            this.labelListaPalabras.Size = new System.Drawing.Size(432, 63);
            this.labelListaPalabras.TabIndex = 7;
            this.labelListaPalabras.Text = "LISTA DE PALABRAS ";
            this.labelListaPalabras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInicio
            // 
            this.panelInicio.BackgroundImage = global::Ahorcado.Properties.Resources.fondo2;
            this.panelInicio.Controls.Add(this.botonSalir);
            this.panelInicio.Controls.Add(this.buttonAdministrador);
            this.panelInicio.Controls.Add(this.tituloJuego);
            this.panelInicio.Controls.Add(this.buttonPlay);
            this.panelInicio.Location = new System.Drawing.Point(0, 0);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(458, 589);
            this.panelInicio.TabIndex = 0;
            // 
            // botonSalir
            // 
            this.botonSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonSalir.Location = new System.Drawing.Point(297, 492);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(149, 82);
            this.botonSalir.TabIndex = 2;
            this.botonSalir.Text = "SALIR";
            this.botonSalir.UseVisualStyleBackColor = false;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click_1);
            // 
            // buttonAdministrador
            // 
            this.buttonAdministrador.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdministrador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdministrador.Location = new System.Drawing.Point(12, 493);
            this.buttonAdministrador.Name = "buttonAdministrador";
            this.buttonAdministrador.Size = new System.Drawing.Size(147, 82);
            this.buttonAdministrador.TabIndex = 3;
            this.buttonAdministrador.Text = "ADMIN";
            this.buttonAdministrador.UseVisualStyleBackColor = false;
            this.buttonAdministrador.Click += new System.EventHandler(this.buttonAdministrador_Click);
            // 
            // tituloJuego
            // 
            this.tituloJuego.AutoSize = true;
            this.tituloJuego.BackColor = System.Drawing.Color.White;
            this.tituloJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloJuego.ForeColor = System.Drawing.Color.Black;
            this.tituloJuego.Location = new System.Drawing.Point(1, 56);
            this.tituloJuego.Name = "tituloJuego";
            this.tituloJuego.Padding = new System.Windows.Forms.Padding(20);
            this.tituloJuego.Size = new System.Drawing.Size(446, 154);
            this.tituloJuego.TabIndex = 14;
            this.tituloJuego.Text = "JUEGO DEL AHORCADO\r\n\r\nHARRY POTTER";
            this.tituloJuego.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPlay.BackgroundImage = global::Ahorcado.Properties.Resources.play;
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlay.Location = new System.Drawing.Point(155, 274);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(148, 127);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // panelJuego
            // 
            this.panelJuego.BackgroundImage = global::Ahorcado.Properties.Resources.fondo2;
            this.panelJuego.Controls.Add(this.panelFallo);
            this.panelJuego.Controls.Add(this.panelAcierto);
            this.panelJuego.Controls.Add(this.imagenAhorcado);
            this.panelJuego.Controls.Add(this.groupBoxPalabraAdivinar);
            this.panelJuego.Controls.Add(this.panel1);
            this.panelJuego.Location = new System.Drawing.Point(464, 0);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.Size = new System.Drawing.Size(458, 589);
            this.panelJuego.TabIndex = 1;
            // 
            // panelFallo
            // 
            this.panelFallo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelFallo.BackgroundImage = global::Ahorcado.Properties.Resources.voldemortAtaca1;
            this.panelFallo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelFallo.Location = new System.Drawing.Point(324, 0);
            this.panelFallo.Name = "panelFallo";
            this.panelFallo.Size = new System.Drawing.Size(134, 250);
            this.panelFallo.TabIndex = 6;
            // 
            // panelAcierto
            // 
            this.panelAcierto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelAcierto.BackgroundImage = global::Ahorcado.Properties.Resources.harryAtaca1;
            this.panelAcierto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelAcierto.Location = new System.Drawing.Point(0, 0);
            this.panelAcierto.Name = "panelAcierto";
            this.panelAcierto.Size = new System.Drawing.Size(134, 250);
            this.panelAcierto.TabIndex = 5;
            // 
            // imagenAhorcado
            // 
            this.imagenAhorcado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imagenAhorcado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagenAhorcado.Image = global::Ahorcado.Properties.Resources.Harry0;
            this.imagenAhorcado.Location = new System.Drawing.Point(134, 0);
            this.imagenAhorcado.Name = "imagenAhorcado";
            this.imagenAhorcado.Size = new System.Drawing.Size(193, 250);
            this.imagenAhorcado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenAhorcado.TabIndex = 3;
            this.imagenAhorcado.TabStop = false;
            // 
            // groupBoxPalabraAdivinar
            // 
            this.groupBoxPalabraAdivinar.BackColor = System.Drawing.Color.White;
            this.groupBoxPalabraAdivinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPalabraAdivinar.Location = new System.Drawing.Point(0, 230);
            this.groupBoxPalabraAdivinar.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPalabraAdivinar.Name = "groupBoxPalabraAdivinar";
            this.groupBoxPalabraAdivinar.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPalabraAdivinar.Size = new System.Drawing.Size(458, 94);
            this.groupBoxPalabraAdivinar.TabIndex = 4;
            this.groupBoxPalabraAdivinar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.BackgroundImage = global::Ahorcado.Properties.Resources.fondo2;
            this.panel1.Controls.Add(this.buttonRepeat);
            this.panel1.Controls.Add(this.buttonVolverInicio);
            this.panel1.Controls.Add(this.teclado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 258);
            this.panel1.TabIndex = 2;
            // 
            // buttonRepeat
            // 
            this.buttonRepeat.BackColor = System.Drawing.Color.LightCyan;
            this.buttonRepeat.BackgroundImage = global::Ahorcado.Properties.Resources.repeat;
            this.buttonRepeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRepeat.ForeColor = System.Drawing.Color.Black;
            this.buttonRepeat.Location = new System.Drawing.Point(28, 185);
            this.buttonRepeat.Name = "buttonRepeat";
            this.buttonRepeat.Size = new System.Drawing.Size(65, 57);
            this.buttonRepeat.TabIndex = 9;
            this.buttonRepeat.UseVisualStyleBackColor = false;
            this.buttonRepeat.Click += new System.EventHandler(this.buttonRepeat_Click);
            // 
            // buttonVolverInicio
            // 
            this.buttonVolverInicio.BackColor = System.Drawing.Color.LightCyan;
            this.buttonVolverInicio.BackgroundImage = global::Ahorcado.Properties.Resources.back;
            this.buttonVolverInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVolverInicio.ForeColor = System.Drawing.Color.Black;
            this.buttonVolverInicio.Location = new System.Drawing.Point(360, 185);
            this.buttonVolverInicio.Name = "buttonVolverInicio";
            this.buttonVolverInicio.Size = new System.Drawing.Size(65, 57);
            this.buttonVolverInicio.TabIndex = 8;
            this.buttonVolverInicio.UseVisualStyleBackColor = false;
            this.buttonVolverInicio.Click += new System.EventHandler(this.buttonVolverInicio_Click);
            // 
            // teclado
            // 
            this.teclado.ColumnCount = 9;
            this.teclado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.teclado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.teclado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.teclado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.teclado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.teclado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.teclado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.teclado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.teclado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.teclado.Controls.Add(this.buttonZ, 8, 2);
            this.teclado.Controls.Add(this.buttonY, 7, 2);
            this.teclado.Controls.Add(this.buttonX, 6, 2);
            this.teclado.Controls.Add(this.buttonW, 5, 2);
            this.teclado.Controls.Add(this.buttonV, 4, 2);
            this.teclado.Controls.Add(this.buttonU, 3, 2);
            this.teclado.Controls.Add(this.buttonT, 2, 2);
            this.teclado.Controls.Add(this.buttonS, 1, 2);
            this.teclado.Controls.Add(this.buttonR, 0, 2);
            this.teclado.Controls.Add(this.buttonQ, 8, 1);
            this.teclado.Controls.Add(this.buttonP, 7, 1);
            this.teclado.Controls.Add(this.buttonO, 6, 1);
            this.teclado.Controls.Add(this.buttonÑ, 5, 1);
            this.teclado.Controls.Add(this.buttonN, 4, 1);
            this.teclado.Controls.Add(this.buttonM, 3, 1);
            this.teclado.Controls.Add(this.buttonL, 2, 1);
            this.teclado.Controls.Add(this.buttonK, 1, 1);
            this.teclado.Controls.Add(this.buttonJ, 0, 1);
            this.teclado.Controls.Add(this.buttonI, 8, 0);
            this.teclado.Controls.Add(this.buttonH, 7, 0);
            this.teclado.Controls.Add(this.buttonG, 6, 0);
            this.teclado.Controls.Add(this.buttonF, 5, 0);
            this.teclado.Controls.Add(this.buttonE, 4, 0);
            this.teclado.Controls.Add(this.buttonD, 3, 0);
            this.teclado.Controls.Add(this.buttonC, 2, 0);
            this.teclado.Controls.Add(this.buttonA, 0, 0);
            this.teclado.Controls.Add(this.buttonB, 1, 0);
            this.teclado.Location = new System.Drawing.Point(28, 22);
            this.teclado.Name = "teclado";
            this.teclado.RowCount = 3;
            this.teclado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.teclado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.teclado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.teclado.Size = new System.Drawing.Size(401, 144);
            this.teclado.TabIndex = 7;
            // 
            // buttonZ
            // 
            this.buttonZ.BackColor = System.Drawing.Color.White;
            this.buttonZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonZ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZ.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ.ForeColor = System.Drawing.Color.DimGray;
            this.buttonZ.Location = new System.Drawing.Point(355, 97);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(43, 44);
            this.buttonZ.TabIndex = 34;
            this.buttonZ.Tag = "Z";
            this.buttonZ.Text = "Z";
            this.buttonZ.UseVisualStyleBackColor = false;
            // 
            // buttonY
            // 
            this.buttonY.BackColor = System.Drawing.Color.White;
            this.buttonY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonY.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonY.ForeColor = System.Drawing.Color.DimGray;
            this.buttonY.Location = new System.Drawing.Point(311, 97);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(38, 44);
            this.buttonY.TabIndex = 33;
            this.buttonY.Tag = "Y";
            this.buttonY.Text = "Y";
            this.buttonY.UseVisualStyleBackColor = false;
            // 
            // buttonX
            // 
            this.buttonX.BackColor = System.Drawing.Color.White;
            this.buttonX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonX.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX.ForeColor = System.Drawing.Color.DimGray;
            this.buttonX.Location = new System.Drawing.Point(267, 97);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(38, 44);
            this.buttonX.TabIndex = 32;
            this.buttonX.Tag = "X";
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = false;
            // 
            // buttonW
            // 
            this.buttonW.BackColor = System.Drawing.Color.White;
            this.buttonW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonW.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonW.ForeColor = System.Drawing.Color.DimGray;
            this.buttonW.Location = new System.Drawing.Point(223, 97);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(38, 44);
            this.buttonW.TabIndex = 31;
            this.buttonW.Tag = "W";
            this.buttonW.Text = "W";
            this.buttonW.UseVisualStyleBackColor = false;
            // 
            // buttonV
            // 
            this.buttonV.BackColor = System.Drawing.Color.White;
            this.buttonV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonV.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonV.ForeColor = System.Drawing.Color.DimGray;
            this.buttonV.Location = new System.Drawing.Point(179, 97);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(38, 44);
            this.buttonV.TabIndex = 30;
            this.buttonV.Tag = "V";
            this.buttonV.Text = "V";
            this.buttonV.UseVisualStyleBackColor = false;
            // 
            // buttonU
            // 
            this.buttonU.BackColor = System.Drawing.Color.White;
            this.buttonU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonU.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonU.ForeColor = System.Drawing.Color.DimGray;
            this.buttonU.Location = new System.Drawing.Point(135, 97);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(38, 44);
            this.buttonU.TabIndex = 29;
            this.buttonU.Tag = "U";
            this.buttonU.Text = "U";
            this.buttonU.UseVisualStyleBackColor = false;
            // 
            // buttonT
            // 
            this.buttonT.BackColor = System.Drawing.Color.White;
            this.buttonT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonT.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonT.ForeColor = System.Drawing.Color.DimGray;
            this.buttonT.Location = new System.Drawing.Point(91, 97);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(38, 44);
            this.buttonT.TabIndex = 28;
            this.buttonT.Tag = "T";
            this.buttonT.Text = "T";
            this.buttonT.UseVisualStyleBackColor = false;
            // 
            // buttonS
            // 
            this.buttonS.BackColor = System.Drawing.Color.White;
            this.buttonS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonS.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonS.ForeColor = System.Drawing.Color.DimGray;
            this.buttonS.Location = new System.Drawing.Point(47, 97);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(38, 44);
            this.buttonS.TabIndex = 27;
            this.buttonS.Tag = "S";
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = false;
            // 
            // buttonR
            // 
            this.buttonR.BackColor = System.Drawing.Color.White;
            this.buttonR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonR.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonR.ForeColor = System.Drawing.Color.DimGray;
            this.buttonR.Location = new System.Drawing.Point(3, 97);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(38, 44);
            this.buttonR.TabIndex = 26;
            this.buttonR.Tag = "R";
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = false;
            // 
            // buttonQ
            // 
            this.buttonQ.BackColor = System.Drawing.Color.White;
            this.buttonQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQ.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQ.ForeColor = System.Drawing.Color.DimGray;
            this.buttonQ.Location = new System.Drawing.Point(355, 50);
            this.buttonQ.Name = "buttonQ";
            this.buttonQ.Size = new System.Drawing.Size(43, 41);
            this.buttonQ.TabIndex = 25;
            this.buttonQ.Tag = "Q";
            this.buttonQ.Text = "Q";
            this.buttonQ.UseVisualStyleBackColor = false;
            // 
            // buttonP
            // 
            this.buttonP.BackColor = System.Drawing.Color.White;
            this.buttonP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonP.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonP.ForeColor = System.Drawing.Color.DimGray;
            this.buttonP.Location = new System.Drawing.Point(311, 50);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(38, 41);
            this.buttonP.TabIndex = 24;
            this.buttonP.Tag = "P";
            this.buttonP.Text = "P";
            this.buttonP.UseVisualStyleBackColor = false;
            // 
            // buttonO
            // 
            this.buttonO.BackColor = System.Drawing.Color.White;
            this.buttonO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonO.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonO.ForeColor = System.Drawing.Color.DimGray;
            this.buttonO.Location = new System.Drawing.Point(267, 50);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(38, 41);
            this.buttonO.TabIndex = 23;
            this.buttonO.Tag = "O";
            this.buttonO.Text = "O";
            this.buttonO.UseVisualStyleBackColor = false;
            // 
            // buttonÑ
            // 
            this.buttonÑ.BackColor = System.Drawing.Color.White;
            this.buttonÑ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonÑ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonÑ.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonÑ.ForeColor = System.Drawing.Color.DimGray;
            this.buttonÑ.Location = new System.Drawing.Point(223, 50);
            this.buttonÑ.Name = "buttonÑ";
            this.buttonÑ.Size = new System.Drawing.Size(38, 41);
            this.buttonÑ.TabIndex = 22;
            this.buttonÑ.Tag = "Ñ";
            this.buttonÑ.Text = "-";
            this.buttonÑ.UseVisualStyleBackColor = false;
            // 
            // buttonN
            // 
            this.buttonN.BackColor = System.Drawing.Color.White;
            this.buttonN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonN.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonN.ForeColor = System.Drawing.Color.DimGray;
            this.buttonN.Location = new System.Drawing.Point(179, 50);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(38, 41);
            this.buttonN.TabIndex = 21;
            this.buttonN.Tag = "N";
            this.buttonN.Text = "N";
            this.buttonN.UseVisualStyleBackColor = false;
            // 
            // buttonM
            // 
            this.buttonM.BackColor = System.Drawing.Color.White;
            this.buttonM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonM.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonM.ForeColor = System.Drawing.Color.DimGray;
            this.buttonM.Location = new System.Drawing.Point(135, 50);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(38, 41);
            this.buttonM.TabIndex = 20;
            this.buttonM.Tag = "M";
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = false;
            // 
            // buttonL
            // 
            this.buttonL.BackColor = System.Drawing.Color.White;
            this.buttonL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonL.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonL.ForeColor = System.Drawing.Color.DimGray;
            this.buttonL.Location = new System.Drawing.Point(91, 50);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(38, 41);
            this.buttonL.TabIndex = 19;
            this.buttonL.Tag = "L";
            this.buttonL.Text = "L";
            this.buttonL.UseVisualStyleBackColor = false;
            // 
            // buttonK
            // 
            this.buttonK.BackColor = System.Drawing.Color.White;
            this.buttonK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonK.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonK.ForeColor = System.Drawing.Color.DimGray;
            this.buttonK.Location = new System.Drawing.Point(47, 50);
            this.buttonK.Name = "buttonK";
            this.buttonK.Size = new System.Drawing.Size(38, 41);
            this.buttonK.TabIndex = 18;
            this.buttonK.Tag = "K";
            this.buttonK.Text = "K";
            this.buttonK.UseVisualStyleBackColor = false;
            // 
            // buttonJ
            // 
            this.buttonJ.BackColor = System.Drawing.Color.White;
            this.buttonJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonJ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonJ.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJ.ForeColor = System.Drawing.Color.DimGray;
            this.buttonJ.Location = new System.Drawing.Point(3, 50);
            this.buttonJ.Name = "buttonJ";
            this.buttonJ.Size = new System.Drawing.Size(38, 41);
            this.buttonJ.TabIndex = 17;
            this.buttonJ.Tag = "J";
            this.buttonJ.Text = "J";
            this.buttonJ.UseVisualStyleBackColor = false;
            // 
            // buttonI
            // 
            this.buttonI.BackColor = System.Drawing.Color.White;
            this.buttonI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonI.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonI.ForeColor = System.Drawing.Color.DimGray;
            this.buttonI.Location = new System.Drawing.Point(355, 3);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(43, 41);
            this.buttonI.TabIndex = 16;
            this.buttonI.Tag = "I";
            this.buttonI.Text = "I";
            this.buttonI.UseVisualStyleBackColor = false;
            // 
            // buttonH
            // 
            this.buttonH.BackColor = System.Drawing.Color.White;
            this.buttonH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonH.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonH.ForeColor = System.Drawing.Color.DimGray;
            this.buttonH.Location = new System.Drawing.Point(311, 3);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(38, 41);
            this.buttonH.TabIndex = 15;
            this.buttonH.Tag = "H";
            this.buttonH.Text = "H";
            this.buttonH.UseVisualStyleBackColor = false;
            // 
            // buttonG
            // 
            this.buttonG.BackColor = System.Drawing.Color.White;
            this.buttonG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonG.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonG.ForeColor = System.Drawing.Color.DimGray;
            this.buttonG.Location = new System.Drawing.Point(267, 3);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(38, 41);
            this.buttonG.TabIndex = 14;
            this.buttonG.Tag = "G";
            this.buttonG.Text = "G";
            this.buttonG.UseVisualStyleBackColor = false;
            // 
            // buttonF
            // 
            this.buttonF.BackColor = System.Drawing.Color.White;
            this.buttonF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonF.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonF.ForeColor = System.Drawing.Color.DimGray;
            this.buttonF.Location = new System.Drawing.Point(223, 3);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(38, 41);
            this.buttonF.TabIndex = 13;
            this.buttonF.Tag = "F";
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = false;
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.White;
            this.buttonE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonE.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonE.ForeColor = System.Drawing.Color.DimGray;
            this.buttonE.Location = new System.Drawing.Point(179, 3);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(38, 41);
            this.buttonE.TabIndex = 12;
            this.buttonE.Tag = "E";
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = false;
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.Color.White;
            this.buttonD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonD.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonD.ForeColor = System.Drawing.Color.DimGray;
            this.buttonD.Location = new System.Drawing.Point(135, 3);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(38, 41);
            this.buttonD.TabIndex = 11;
            this.buttonD.Tag = "D";
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = false;
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.White;
            this.buttonC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonC.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.ForeColor = System.Drawing.Color.DimGray;
            this.buttonC.Location = new System.Drawing.Point(91, 3);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(38, 41);
            this.buttonC.TabIndex = 10;
            this.buttonC.Tag = "C";
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.White;
            this.buttonA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonA.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonA.ForeColor = System.Drawing.Color.DimGray;
            this.buttonA.Location = new System.Drawing.Point(3, 3);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(38, 41);
            this.buttonA.TabIndex = 8;
            this.buttonA.Tag = "A";
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = false;
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.White;
            this.buttonB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonB.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonB.ForeColor = System.Drawing.Color.DimGray;
            this.buttonB.Location = new System.Drawing.Point(47, 3);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(38, 41);
            this.buttonB.TabIndex = 9;
            this.buttonB.Tag = "B";
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 602);
            this.Controls.Add(this.panelAdministrador);
            this.Controls.Add(this.panelInicio);
            this.Controls.Add(this.panelJuego);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Juego del ahorcado - Harry Potter";
            this.panelAdministrador.ResumeLayout(false);
            this.panelPalabras.ResumeLayout(false);
            this.panelAgregarPalabra.ResumeLayout(false);
            this.panelAgregarPalabra.PerformLayout();
            this.panelEliminarPalabra.ResumeLayout(false);
            this.panelEliminarPalabra.PerformLayout();
            this.panelInicio.ResumeLayout(false);
            this.panelInicio.PerformLayout();
            this.panelJuego.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagenAhorcado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.teclado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.Panel panelJuego;
        private System.Windows.Forms.Panel panelAdministrador;
        private System.Windows.Forms.ListView contenedorListaPalabras;
        private System.Windows.Forms.Panel panelPalabras;
        private System.Windows.Forms.Panel panelAgregarPalabra;
        private System.Windows.Forms.TextBox txtPalabraNueva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelEliminarPalabra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelListaPalabras;
        private System.Windows.Forms.PictureBox imagenAhorcado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel teclado;
        private System.Windows.Forms.Button buttonZ;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonV;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonQ;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Button buttonÑ;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonK;
        private System.Windows.Forms.Button buttonJ;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button buttonH;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Label tituloJuego;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button buttonAdministrador;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonVolverInicio;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.GroupBox groupBoxPalabraAdivinar;
        private System.Windows.Forms.Button buttonRepeat;
        private System.Windows.Forms.Panel panelFallo;
        private System.Windows.Forms.Panel panelAcierto;
        private System.Windows.Forms.ComboBox comboBoxEliminar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonAgregar;
    }
}

