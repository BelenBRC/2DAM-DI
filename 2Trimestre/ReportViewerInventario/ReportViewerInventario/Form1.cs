using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportViewerInventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Establecer origen de datos
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", pedidosDataSet1.Tables[0]));

            this.reportViewer1.RefreshReport();

            //Abrir el formulario maximizado
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Actualizamos el informe
            this.reportViewer1.RefreshReport();
            //Rellenamos la tabla
            this.articulosTableAdapter1.Fill(this.pedidosDataSet1.ARTICULOS);
           
            //Mostramos el informe
            this.reportViewer1.Visible = true;
        }
    }
}
