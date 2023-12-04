namespace EjercicioLibre
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
            this.labelRegreso = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerIda = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRegreso = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownPasajeros = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxVuelosIdaVuelta = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDestino = new System.Windows.Forms.Label();
            this.checkBoxTodosLosDestinos = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxDestinos = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de salida";
            // 
            // labelRegreso
            // 
            this.labelRegreso.AutoSize = true;
            this.labelRegreso.Location = new System.Drawing.Point(451, 114);
            this.labelRegreso.Name = "labelRegreso";
            this.labelRegreso.Size = new System.Drawing.Size(176, 29);
            this.labelRegreso.TabIndex = 3;
            this.labelRegreso.Text = "Fecha de regreso";
            this.labelRegreso.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pasajeros";
            // 
            // dateTimePickerIda
            // 
            this.dateTimePickerIda.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIda.Location = new System.Drawing.Point(107, 156);
            this.dateTimePickerIda.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerIda.MinDate = new System.DateTime(2023, 10, 26, 0, 0, 0, 0);
            this.dateTimePickerIda.Name = "dateTimePickerIda";
            this.dateTimePickerIda.Size = new System.Drawing.Size(306, 36);
            this.dateTimePickerIda.TabIndex = 1;
            this.dateTimePickerIda.ValueChanged += new System.EventHandler(this.dateTimePickerIda_ValueChanged);
            // 
            // dateTimePickerRegreso
            // 
            this.dateTimePickerRegreso.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRegreso.Location = new System.Drawing.Point(471, 156);
            this.dateTimePickerRegreso.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerRegreso.MinDate = new System.DateTime(2023, 10, 26, 0, 0, 0, 0);
            this.dateTimePickerRegreso.Name = "dateTimePickerRegreso";
            this.dateTimePickerRegreso.Size = new System.Drawing.Size(306, 36);
            this.dateTimePickerRegreso.TabIndex = 3;
            this.dateTimePickerRegreso.Visible = false;
            // 
            // numericUpDownPasajeros
            // 
            this.numericUpDownPasajeros.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPasajeros.Location = new System.Drawing.Point(236, 424);
            this.numericUpDownPasajeros.Name = "numericUpDownPasajeros";
            this.numericUpDownPasajeros.Size = new System.Drawing.Size(61, 36);
            this.numericUpDownPasajeros.TabIndex = 7;
            this.numericUpDownPasajeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPasajeros.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(261, 507);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(312, 32);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Ver también vuelos con escala";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxVuelosIdaVuelta
            // 
            this.checkBoxVuelosIdaVuelta.AutoSize = true;
            this.checkBoxVuelosIdaVuelta.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVuelosIdaVuelta.Location = new System.Drawing.Point(107, 198);
            this.checkBoxVuelosIdaVuelta.Name = "checkBoxVuelosIdaVuelta";
            this.checkBoxVuelosIdaVuelta.Size = new System.Drawing.Size(205, 32);
            this.checkBoxVuelosIdaVuelta.TabIndex = 2;
            this.checkBoxVuelosIdaVuelta.Text = "Vuelos ida y vuelta";
            this.checkBoxVuelosIdaVuelta.UseVisualStyleBackColor = true;
            this.checkBoxVuelosIdaVuelta.CheckedChanged += new System.EventHandler(this.checkBoxVuelosIdaVuelta_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Origen";
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Location = new System.Drawing.Point(451, 258);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(87, 29);
            this.labelDestino.TabIndex = 12;
            this.labelDestino.Text = "Destino";
            this.labelDestino.Visible = false;
            // 
            // checkBoxTodosLosDestinos
            // 
            this.checkBoxTodosLosDestinos.AutoSize = true;
            this.checkBoxTodosLosDestinos.Checked = true;
            this.checkBoxTodosLosDestinos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTodosLosDestinos.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTodosLosDestinos.Location = new System.Drawing.Point(107, 349);
            this.checkBoxTodosLosDestinos.Name = "checkBoxTodosLosDestinos";
            this.checkBoxTodosLosDestinos.Size = new System.Drawing.Size(201, 32);
            this.checkBoxTodosLosDestinos.TabIndex = 5;
            this.checkBoxTodosLosDestinos.Text = "Todos los destinos";
            this.checkBoxTodosLosDestinos.UseVisualStyleBackColor = true;
            this.checkBoxTodosLosDestinos.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 307);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 36);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBoxDestinos
            // 
            this.comboBoxDestinos.FormattingEnabled = true;
            this.comboBoxDestinos.Location = new System.Drawing.Point(471, 307);
            this.comboBoxDestinos.Name = "comboBoxDestinos";
            this.comboBoxDestinos.Size = new System.Drawing.Size(312, 36);
            this.comboBoxDestinos.TabIndex = 6;
            this.comboBoxDestinos.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EjercicioLibre.Properties.Resources.delivery_transportation_vehicle_transport_travel_icon_225386;
            this.pictureBox3.Location = new System.Drawing.Point(31, 101);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EjercicioLibre.Properties.Resources.pin_navigation_map_destination_icon_225369;
            this.pictureBox2.Location = new System.Drawing.Point(31, 244);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EjercicioLibre.Properties.Resources.account_passport_person_avatar_man_male_icon_225365;
            this.pictureBox1.Location = new System.Drawing.Point(31, 410);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::EjercicioLibre.Properties.Resources.transport_travel_flight_airplane_ticket_plane_icon_225382;
            this.pictureBox4.Location = new System.Drawing.Point(385, 52);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(477, 568);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(773, 82);
            this.label2.TabIndex = 17;
            this.label2.Text = "Buscador de vuelos baratos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 667);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxDestinos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBoxTodosLosDestinos);
            this.Controls.Add(this.labelDestino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxVuelosIdaVuelta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numericUpDownPasajeros);
            this.Controls.Add(this.dateTimePickerRegreso);
            this.Controls.Add(this.dateTimePickerIda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRegreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "Buscador de vuelos";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRegreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerIda;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegreso;
        private System.Windows.Forms.NumericUpDown numericUpDownPasajeros;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxVuelosIdaVuelta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.CheckBox checkBoxTodosLosDestinos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxDestinos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
    }
}

