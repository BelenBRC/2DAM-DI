using System.Drawing;
using System.Windows.Forms;

namespace PizzaOrder
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
            Microsoft.Win32.SystemEvents.UserPreferenceChanged -= new Microsoft.Win32.UserPreferenceChangedEventHandler(this.UserPreferenceChanged);
            base.Dispose(disposing);
        }
        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Logotipo = new System.Windows.Forms.PictureBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.sizeOptions = new System.Windows.Forms.GroupBox();
            this.largePizza = new System.Windows.Forms.RadioButton();
            this.smallPizza = new System.Windows.Forms.RadioButton();
            this.toppingsLabel = new System.Windows.Forms.Label();
            this.toppings = new System.Windows.Forms.CheckedListBox();
            this.orden = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.theMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Logotipo)).BeginInit();
            this.sizeOptions.SuspendLayout();
            this.theMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logotipo
            // 
            this.Logotipo.AccessibleDescription = "Porción de pizza";
            this.Logotipo.AccessibleName = "Logotipo de la compañía";
            this.Logotipo.Image = global::PizzaOrder.Properties.Resources.Pizza_icon_icons_com_68706;
            this.Logotipo.Location = new System.Drawing.Point(60, 67);
            this.Logotipo.Name = "Logotipo";
            this.Logotipo.Size = new System.Drawing.Size(100, 104);
            this.Logotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logotipo.TabIndex = 0;
            this.Logotipo.TabStop = false;
            // 
            // companyLabel
            // 
            this.companyLabel.AccessibleDescription = "Nombre de la compañía";
            this.companyLabel.AccessibleName = "Nombre de la compañía";
            this.companyLabel.BackColor = System.Drawing.Color.Blue;
            this.companyLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.ForeColor = System.Drawing.Color.Yellow;
            this.companyLabel.Location = new System.Drawing.Point(222, 67);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(319, 104);
            this.companyLabel.TabIndex = 1;
            this.companyLabel.Text = "Good Pizza";
            this.companyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerLabel
            // 
            this.customerLabel.AccessibleDescription = "Etiqueta de nombre de cliente";
            this.customerLabel.AccessibleName = "Etiqueta de nombre de cliente";
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(255, 202);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(67, 21);
            this.customerLabel.TabIndex = 2;
            this.customerLabel.Text = "&Nombre";
            // 
            // customerName
            // 
            this.customerName.AccessibleDescription = "Nombre de cliente";
            this.customerName.AccessibleName = "Nombre de cliente";
            this.customerName.Location = new System.Drawing.Point(328, 199);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(211, 28);
            this.customerName.TabIndex = 3;
            // 
            // sizeOptions
            // 
            this.sizeOptions.AccessibleDescription = "Opciones de tamaño de pizza";
            this.sizeOptions.AccessibleName = "Opciones de tamaño de pizza";
            this.sizeOptions.Controls.Add(this.largePizza);
            this.sizeOptions.Controls.Add(this.smallPizza);
            this.sizeOptions.Location = new System.Drawing.Point(60, 259);
            this.sizeOptions.Name = "sizeOptions";
            this.sizeOptions.Size = new System.Drawing.Size(200, 91);
            this.sizeOptions.TabIndex = 4;
            this.sizeOptions.TabStop = false;
            this.sizeOptions.Text = "Tamaño de la pizza";
            // 
            // largePizza
            // 
            this.largePizza.AccessibleDescription = "Pizza grande";
            this.largePizza.AccessibleName = "Pizza grande";
            this.largePizza.AutoSize = true;
            this.largePizza.Location = new System.Drawing.Point(7, 59);
            this.largePizza.Name = "largePizza";
            this.largePizza.Size = new System.Drawing.Size(135, 25);
            this.largePizza.TabIndex = 1;
            this.largePizza.TabStop = true;
            this.largePizza.Text = "&Grande 10.00€";
            this.largePizza.UseVisualStyleBackColor = true;
            // 
            // smallPizza
            // 
            this.smallPizza.AccessibleDescription = "Pizza pequeña";
            this.smallPizza.AccessibleName = "Pizza pequeña";
            this.smallPizza.AutoSize = true;
            this.smallPizza.Checked = true;
            this.smallPizza.Location = new System.Drawing.Point(7, 28);
            this.smallPizza.Name = "smallPizza";
            this.smallPizza.Size = new System.Drawing.Size(135, 25);
            this.smallPizza.TabIndex = 0;
            this.smallPizza.TabStop = true;
            this.smallPizza.Text = "&Pequeña 6.00€";
            this.smallPizza.UseVisualStyleBackColor = true;
            // 
            // toppingsLabel
            // 
            this.toppingsLabel.AccessibleDescription = "Etiqueta de ingredientes";
            this.toppingsLabel.AccessibleName = "Etiqueta de ingredientes";
            this.toppingsLabel.AutoSize = true;
            this.toppingsLabel.Location = new System.Drawing.Point(324, 259);
            this.toppingsLabel.Name = "toppingsLabel";
            this.toppingsLabel.Size = new System.Drawing.Size(217, 21);
            this.toppingsLabel.TabIndex = 5;
            this.toppingsLabel.Text = "&Ingredientes (0.75€ cada uno)";
            // 
            // toppings
            // 
            this.toppings.AccessibleDescription = "Ingredientes disponibles";
            this.toppings.AccessibleName = "Ingredientes disponibles";
            this.toppings.FormattingEnabled = true;
            this.toppings.Items.AddRange(new object[] {
            "Adrián",
            "Belén"});
            this.toppings.Location = new System.Drawing.Point(328, 300);
            this.toppings.Name = "toppings";
            this.toppings.Size = new System.Drawing.Size(213, 50);
            this.toppings.TabIndex = 6;
            // 
            // orden
            // 
            this.orden.AccessibleDescription = "Total del pedido";
            this.orden.AccessibleName = "Total del pedido";
            this.orden.Location = new System.Drawing.Point(328, 396);
            this.orden.Name = "orden";
            this.orden.Size = new System.Drawing.Size(85, 38);
            this.orden.TabIndex = 7;
            this.orden.Text = "&Pedido";
            this.orden.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.AccessibleDescription = "Cancelar el pedido";
            this.cancel.AccessibleName = "Cancelar el pedido";
            this.cancel.Location = new System.Drawing.Point(175, 396);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(85, 38);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "&Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // theMainMenu
            // 
            this.theMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.theMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileCommands});
            this.theMainMenu.Location = new System.Drawing.Point(0, 0);
            this.theMainMenu.Name = "theMainMenu";
            this.theMainMenu.Size = new System.Drawing.Size(606, 30);
            this.theMainMenu.TabIndex = 9;
            this.theMainMenu.Text = "menuStrip1";
            // 
            // fileCommands
            // 
            this.fileCommands.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitApp});
            this.fileCommands.Name = "fileCommands";
            this.fileCommands.Size = new System.Drawing.Size(73, 26);
            this.fileCommands.Text = "&Archivo";
            // 
            // exitApp
            // 
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(116, 26);
            this.exitApp.Text = "&Exit";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Formulario de pedidos de pizza";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AccessibleDescription = "Formulario de pedido";
            this.AccessibleName = "Formulario de pedido";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 472);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.orden);
            this.Controls.Add(this.toppings);
            this.Controls.Add(this.toppingsLabel);
            this.Controls.Add(this.sizeOptions);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.Logotipo);
            this.Controls.Add(this.theMainMenu);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.theMainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Formulario de pedidos de pizza - Belén Robustillo";
            ((System.ComponentModel.ISupportInitialize)(this.Logotipo)).EndInit();
            this.sizeOptions.ResumeLayout(false);
            this.sizeOptions.PerformLayout();
            this.theMainMenu.ResumeLayout(false);
            this.theMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logotipo;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.GroupBox sizeOptions;
        private System.Windows.Forms.RadioButton smallPizza;
        private System.Windows.Forms.Label toppingsLabel;
        private System.Windows.Forms.CheckedListBox toppings;
        private System.Windows.Forms.Button orden;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.MenuStrip theMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileCommands;
        private System.Windows.Forms.RadioButton largePizza;
        private System.Windows.Forms.ToolStripMenuItem exitApp;
        private NotifyIcon notifyIcon1;
    }
}

