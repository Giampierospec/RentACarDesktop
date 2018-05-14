using MaterialSkin.Controls;
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
    public partial class ModifyTipoVehiculosForm : MaterialForm
    {
        private int _userId;
        private int _tpId;
        private TipoVehiculosRepo _tpRepo;
        private LoadComboBoxesRepo _loadComboBoxes;
        private string _keyword;

        public ModifyTipoVehiculosForm(int userId = 0, int tpId = 0, string keyword = "")
        {
            InitializeComponent();
            _userId = userId;
            _tpId = tpId;
            _tpRepo = new TipoVehiculosRepo();
            _loadComboBoxes = new LoadComboBoxesRepo();
            _keyword = keyword;
        }

        private void ModifyTipoVehiculosForm_Load(object sender, EventArgs e)
        {
            Text += $" {_keyword}";
           
            if(_tpId == 0)
            {
                enviarTpBtn.Text = "Insertar";
               InitializeForm();
            }
            else
            {
                enviarTpBtn.Text = "Editar";
                InitializeForm();
                SetValues(_tpId);
            }
        }
        private void InitializeForm()
        {
            estadoTipoVehiculoTxt.DataSource = _loadComboBoxes.GetEstado();
            estadoTipoVehiculoTxt.DisplayMember = "Estado1";
            estadoTipoVehiculoTxt.ValueMember = "Id";
        }
        private void SetValues(int vehiculoId)
        {
            var vh = _tpRepo.GetTipoVehiculoById(vehiculoId);
            tipoVehiculoDesc.Text = vh.Descripcion;
            estadoTipoVehiculoTxt.SelectedValue = vh.Id_Estado;
        }

        private void enviarTpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                enviarTpBtn.Enabled = false;
                var errorMsg = Utils.Validate.GenerateErrorMessage(this);
                Utils.Validate.LockControls(this);
                Utils.Validate.LockBtns(this);
                if (string.IsNullOrEmpty(errorMsg))
                {
                    var tpExists = _tpRepo.TipoVehiculoExists(tipoVehiculoDesc.Text);
                    if(tpExists && _tpId == 0)
                    {
                        MessageBox.Show("El tipo Vehiculo ya existe intente denuevo");
                        Utils.Validate.UnLockControls(this);
                        Utils.Validate.EnableBtns(this);
                        enviarTpBtn.Enabled = true;
                    }
                    else
                    {
                      
                        _tpRepo.InsertTipoVehiculo(new Context.TipoVehiculo()
                        {
                            Id = _tpId,
                            Descripcion = tipoVehiculoDesc.Text,
                            Id_Estado = int.Parse(estadoTipoVehiculoTxt.SelectedValue.ToString()),
                            Id_User = _userId
                        });
                        if(MessageBox.Show("Tipo Vehiculo Procesado Correctamente") == DialogResult.OK)
                        {
                            Utils.Returning.ReturnToPreviousForm(this,new TipoVehiculoForm(_userId));
                        }
                    }
                }
                else
                {
                    MessageBox.Show(errorMsg);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo Editar el tipo de vehiculo");
            }
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Utils.Returning.ReturnToPreviousForm(this,new TipoVehiculoForm(_userId));
            
        }
    }
}
