namespace ReportViewerInventario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.articulosTableAdapter1 = new ReportViewerInventario.pedidosDataSetTableAdapters.ARTICULOSTableAdapter();
            this.pedidosDataSet1 = new ReportViewerInventario.pedidosDataSet();
            this.pedidosDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new ReportViewerInventario.pedidosDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportViewerInventario.Inventario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(994, 926);
            this.reportViewer1.TabIndex = 0;
            // 
            // articulosTableAdapter1
            // 
            this.articulosTableAdapter1.ClearBeforeFill = true;
            // 
            // pedidosDataSet1
            // 
            this.pedidosDataSet1.DataSetName = "pedidosDataSet";
            this.pedidosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidosDataSet1BindingSource
            // 
            this.pedidosDataSet1BindingSource.DataSource = this.pedidosDataSet1;
            this.pedidosDataSet1BindingSource.Position = 0;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.ARTICULOSTableAdapter = this.articulosTableAdapter1;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CLIENTESTableAdapter = null;
            this.tableAdapterManager1.NUEVA_TABLA_PEDIDOSTableAdapter = null;
            this.tableAdapterManager1.PEDIDOSTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ReportViewerInventario.pedidosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ZONASTableAdapter = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 926);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Inventario de Artículos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedidosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private pedidosDataSetTableAdapters.ARTICULOSTableAdapter articulosTableAdapter1;
        private pedidosDataSet pedidosDataSet1;
        private System.Windows.Forms.BindingSource pedidosDataSet1BindingSource;
        private pedidosDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}

