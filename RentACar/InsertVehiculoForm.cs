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
        private string _keyword;

        public InsertVehiculoForm(int userId = 0, int VehiculoId = 0, string keyword = "")
        {
            _userId = userId;
            _vehiculoId = VehiculoId;
            _comboBoxesRepo = new LoadComboBoxesRepo();
            _vhRepo = new VehiculosRepo();
            _keyword = keyword;
            InitializeComponent();
        }

        private void InsertVehiculoForm_Load(object sender, EventArgs e)
        {
            Text += $" {_keyword} Vehiculos";
            btnEnviarVehiculo.Text = _keyword;
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
            txtDescripcionVehiculo.Text = vh.Descripcion;
            txtNoChasis.Text = vh.NoChasis;
            txtNoMotor.Text = vh.NoMotor;
            txtNoPlaca.Text = vh.NoPlaca;
            marcaSelectVh.SelectedValue = vh.Marca.Id;
            tipoVehiculoSelectVh.SelectedValue = vh.TipoVehiculo.Id;
            tipoCombustibleSelectVh.SelectedValue = vh.TipoCombustible.Id;
            estadoSelectVh.SelectedValue = vh.Estado.Id;
            modeloSelectVh.SelectedValue = vh.Modelo.Id;
        }
        private void ArrangeModelo()
        {
            modeloSelectVh.DataSource = null;
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
                var errorMsg = Utils.Validate.GenerateErrorMessage(this);
                var hexErrorMsg = Utils.Validate.IsANumber(txtNoPlaca, txtNoChasis, txtNoMotor);
                Utils.Validate.LockBtns(this);
                if (string.IsNullOrEmpty(errorMsg) && string.IsNullOrEmpty(hexErrorMsg))
                {

                    var vehiculoExists = _vhRepo.VehiculoExists(txtDescripcionVehiculo.Text);
                    if (vehiculoExists && _vehiculoId == 0)
                    {
                        Utils.Validate.EnableBtns(this);
                        MessageBox.Show("El vehiculo ya existe por favor intente denuevo");
                    }
                    else
                    {
                        _vhRepo.InsertVehiculos(new Context.Vehiculo()
                        {
                            Id = _vehiculoId,
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
                        if (MessageBox.Show("Vehiculo Procesado Correctamente") == DialogResult.OK)
                        {
                            Utils.Returning.ReturnToPreviousForm(this,new VehiculosForm(_userId));
                            
                        }
                    }
                }
                else
                {
                    btnEnviarVehiculo.Enabled = true;
                    MessageBox.Show($"{errorMsg}\n {hexErrorMsg}");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Ocurrio un error al intentar procesar el vehiculo");
            }
        }

        private void atrásMenuVhItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToPreviousForm(this,new VehiculosForm(_userId));
        }

        private void marcaSelectVh_ValueMemberChanged(object sender, EventArgs e)
        {
            ArrangeModelo();
        }
    }
}
