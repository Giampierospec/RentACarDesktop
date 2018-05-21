using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using RentACar.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class ReporteVehiculos : MaterialForm
    {
        private object _datasource;
        private int _userId;
        private DataSourcesEnum _dataSourcesEnum;

        public ReporteVehiculos(DataSourcesEnum dataSourcesEnum, int userId = 0,object dataSource = null)
        {
            _datasource = dataSource;
            _userId = userId;
            _dataSourcesEnum = dataSourcesEnum;
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToLogin(this);
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToPreviousForm(this, new MainForm(_userId));
        }

        private void ReporteForm_Load(object sender, EventArgs e)
        {
            SetBindingSource(_dataSourcesEnum);
            reportV.RefreshReport();
        }
        private void SetBindingSource(DataSourcesEnum dataSourcesEnum)
        {
            switch (dataSourcesEnum)
            {
                case DataSourcesEnum.Vehiculos:
                    SetReportData("DataSet1", _datasource, "RentACar.vehiculosReport.rdlc");
                    break;
                case DataSourcesEnum.TipoVehiculos:
                    SetReportData("DataSet1", _datasource, "RentACar.TipoVehiculoReport.rdlc");
                    break;
                case DataSourcesEnum.TipoCombustible:
                    SetReportData("TCDataSet", _datasource, "RentACar.tipoCombustibleReport.rdlc");
                    break;
                case DataSourcesEnum.Marcas:
                    SetReportData("MarcaDataSet", _datasource, "RentACar.marcaReport.rdlc");
                    break;
                case DataSourcesEnum.Modelos:
                    SetReportData("ModeloDataSet", _datasource, "RentACar.modeloReport.rdlc");
                    break;
                case DataSourcesEnum.Renta:
                    SetReportData("RentaDataSet", _datasource, "RentACar.RentaReport.rdlc");
                    break;
                case DataSourcesEnum.Inspeccion:
                    SetReportData("InspeccionDataSet", _datasource, "RentACar.inspeccionReport.rdlc");
                    break;
                case DataSourcesEnum.Empleado:
                    SetReportData("EmpleadoDataSet", _datasource, "RentACar.empleadoReport.rdlc");
                    break;
                case DataSourcesEnum.Cliente:
                    SetReportData("ClienteDataSet", _datasource, "RentACar.clienteReport.rdlc");
                    break;
            }
        }
        private void reportV_Load(object sender, EventArgs e)
        {
       
            
            reportV.RefreshReport();
        }
        private void SetReportData(string dataSetName,object data, string fileName)
        {
            var rds = new ReportDataSource(dataSetName, data);
            reportV.LocalReport.DataSources.Clear();
            reportV.ProcessingMode = ProcessingMode.Local;
            reportV.LocalReport.DataSources.Add(rds);
            reportV.LocalReport.ReportEmbeddedResource = fileName;
        }
    }
}
