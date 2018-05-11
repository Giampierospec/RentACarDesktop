using MaterialSkin.Controls;
using RentACar.Context;
using RentACar.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class InsertVehiculoForm : MaterialForm
    {
        private int _userId;
        private int _vehiculoId;
        private LoadComboBoxesRepo _comboBoxesRepo;
        private VehiculosRepo _vhRepo;

        public InsertVehiculoForm(int userId = 0, int VehiculoId = 0)
        {
            _userId = userId;
            _vehiculoId = VehiculoId;
            _comboBoxesRepo = new LoadComboBoxesRepo();
            _vhRepo = new VehiculosRepo();
            InitializeComponent();
        }

        private void InsertVehiculoForm_Load(object sender, EventArgs e)
        {
            if (_vehiculoId == 0)
            {
                InitializeTextBoxes();
            }
            else
            {
                InitializeTextBoxes();
                var vh = _vhRepo.GetVehiculoById(_vehiculoId);
                SetValues(vh);

            }


        }

        private void marcaSelectVh_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrangeModelo();
        }
        private void InitializeTextBoxes()
        {
            marcaSelectVh.DataSource = _comboBoxesRepo.GetMarcas();
            marcaSelectVh.DisplayMember = "Descripcion";
            marcaSelectVh.ValueMember = "Id";

            tipoVehiculoSelectVh.DataSource = _comboBoxesRepo.GetAllTipoVehiculos();
            tipoVehiculoSelectVh.DisplayMember = "Descripcion";
            tipoVehiculoSelectVh.ValueMember = "Id";

            tipoCombustibleSelectVh.DataSource = _comboBoxesRepo.GetTipoCombustible();
            tipoCombustibleSelectVh.DisplayMember = "Descripcion";
            tipoCombustibleSelectVh.ValueMember = "Id";

            estadoSelectVh.DataSource = _comboBoxesRepo.GetEstado();
            estadoSelectVh.DisplayMember = "Estado1";
            estadoSelectVh.ValueMember = "Id";
            ArrangeModelo();
        }
        private void SetValues(Vehiculo vh)
        {
            marcaSelectVh.SelectedValue = vh.Marca;
            tipoVehiculoSelectVh.SelectedValue = vh.TipoVehiculo;
            tipoCombustibleSelectVh.SelectedValue = vh.TipoCombustible;
            estadoSelectVh.SelectedValue = vh.Estado;
            modeloSelectVh.SelectedValue = vh.Modelo;
        }
        private void ArrangeModelo()
        {
            int marcaId;
            int.TryParse(marcaSelectVh.SelectedValue.ToString(), out marcaId);

            modeloSelectVh.DataSource = _comboBoxesRepo.GetModelosByMarca(marcaId);
            modeloSelectVh.DisplayMember = "Descripcion";
            modeloSelectVh.ValueMember = "Id";
        }

        private void btnEnviarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                btnEnviarVehiculo.Enabled = false;
                Cursor = Cursors.WaitCursor;
                _vhRepo.InsertVehiculos(new Context.Vehiculo()
                {
                    Descripcion = txtDescripcionVehiculo.Text.Trim(),
                    NoChasis = txtNoChasis.Text.Trim(),
                    NoMotor = txtNoMotor.Text.Trim(),
                    NoPlaca = txtNoPlaca.Text.Trim(),
                    Id_Estado = int.Parse(estadoSelectVh.SelectedValue.ToString()),
                    Id_Marca = int.Parse(marcaSelectVh.SelectedValue.ToString()),
                    Id_Modelo = int.Parse(modeloSelectVh.SelectedValue.ToString()),
                    Id_TipoVehiculo = int.Parse(tipoVehiculoSelectVh.SelectedValue.ToString()),
                    Id_Tipo_Combustible = int.Parse(tipoCombustibleSelectVh.SelectedValue.ToString()),
                    Id_User = _userId
                });
                if(MessageBox.Show("Usuario Insertado Correctamente") == DialogResult.OK)
                {
                    var vehiculosForm = new VehiculosForm();
                    Hide();
                    vehiculosForm.ShowDialog();
                    Close();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
