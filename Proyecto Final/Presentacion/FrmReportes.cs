using Microsoft.Reporting.WinForms;
using Proyecto1.RN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Utilitarios;

namespace Presentacion
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            this.MostrarReporte(Utilitarios.Utilitarios.NroReporte);
            this.reportViewer1.RefreshReport();
        }
        private void MostrarReporte(Int64 NroReporte)
        {
            ReportDataSource RpDataSource = new ReportDataSource();
            switch (NroReporte)
            {
                case 1:
                    RNVendedor ObjRNVendedor = new RNVendedor();
                    RpDataSource.Name = "DataSet1";
                    RpDataSource.Value = ObjRNVendedor.TraerVendedor(Convert.ToInt32(Utilitarios.Utilitarios.id)); //converti a int32
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(RpDataSource);
                    this.reportViewer1.LocalReport.ReportPath = @"G:\Líder\Líder\Proyecto Final\Presentacion\RptVendedores.rdlc";
                    this.reportViewer1.LocalReport.Refresh();
                    break;
                case 2:
                    RNTipoProducto ObjRNTipoProducto = new RNTipoProducto();
                    RpDataSource.Name = "DataSet1";
                    RpDataSource.Value = ObjRNTipoProducto.TraerTipoProducto(Convert.ToInt32(Utilitarios.Utilitarios.id)); //converti a int32
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(RpDataSource);
                    this.reportViewer1.LocalReport.ReportPath = @"G:\Líder\Líder\Proyecto Final\Presentacion\RptTipoProducto.rdlc";
                    this.reportViewer1.LocalReport.Refresh();
                    break;
                case 3:
                    RNProducto ObjRNProducto = new RNProducto();
                    RpDataSource.Name = "DataSet1";
                    RpDataSource.Value = ObjRNProducto.TraerProductos(Convert.ToInt32(Utilitarios.Utilitarios.id)); //converti a int32
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(RpDataSource);
                    this.reportViewer1.LocalReport.ReportPath = @"G:\Líder\Líder\Proyecto Final\Presentacion\RptProducto.rdlc";
                    this.reportViewer1.LocalReport.Refresh();
                    break;
                case 4:
                    RNCliente ObjRNCliente = new RNCliente();
                    RpDataSource.Name = "DataSet1";
                    RpDataSource.Value = ObjRNCliente.TraerClientes(Convert.ToInt32(Utilitarios.Utilitarios.id)); //converti a int32
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(RpDataSource);
                    this.reportViewer1.LocalReport.ReportPath = @"G:\Líder\Líder\Proyecto Final\Presentacion\RptCliente.rdlc";
                    this.reportViewer1.LocalReport.Refresh();
                    break;
                case 5:
                    RNFactura ObjRNFactura = new RNFactura();
                    RpDataSource.Name = "DataSet1";
                    RpDataSource.Value = ObjRNFactura.TraerFactura(Convert.ToInt32(Utilitarios.Utilitarios.id)); //converti a int32
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(RpDataSource);
                    this.reportViewer1.LocalReport.ReportPath = @"G:\Líder\Líder\Proyecto Final\Presentacion\RptVenta.rdlc";
                    this.reportViewer1.LocalReport.Refresh();
                    break;
            }
        }
    }
}
