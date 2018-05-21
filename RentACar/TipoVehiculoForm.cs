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
    public partial class TipoVehiculoForm : MaterialForm
    {
        private int _userId;
        private int _tpId = 0;
        private TipoVehiculosRepo _tpVehiculoRepo;
        private UserRepo _userRepo;

        public TipoVehiculoForm(int userId = 0)
        {
            _userId = userId;
            _tpVehiculoRepo = new TipoVehiculosRepo();
            _userRepo = new UserRepo();
            InitializeComponent();
        }

        private void TipoVehiculoForm_Load(object sender, EventArgs e)
        {
            var user = _userRepo.GetUserById(_userId);
            if(user.Id_Rol == 2)
            {
                Utils.Validate.LockBtns(this);
            }
            TVehiculosTable.DataSource = _tpVehiculoRepo.GetAllTipoVehiculos();
        }

        private void insertTVehiculoBtn_Click(object sender, EventArgs e)
        {
            Utils.Validate.LockBtns(this);
            Utils.Returning.ReturnToPreviousForm(this,new ModifyTipoVehiculosForm(_userId,0,"Insertar Tipo Vehiculo"));
        }

        private void editarVehiculoBtn_Click(object sender, EventArgs e)
        {
            if(_tpId == 0)
            {
                MessageBox.Show("Selecciona una fila para poder Editar");
            }
            else
            {
                
                Utils.Validate.LockBtns(this);
               Utils.Returning.ReturnToPreviousForm(this,new ModifyTipoVehiculosForm(_userId, _tpId, "Editar Tipo Vehiculo"));
               
            }
        }

        private void TVehiculosTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _tpId = int.Parse(TVehiculosTable.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void logoutTVMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToLogin(this);
        }

        private void atrásMenuTvItem_Click(object sender, EventArgs e)
        {
           
            Utils.Returning.ReturnToPreviousForm(this,new MainForm(_userId));
        }

        private void tipoVhTxt_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            TVehiculosTable.DataSource = _tpVehiculoRepo.Filter(new Context.TipoVehiculo()
            {
                Descripcion = tipoVhTxt.Text.Trim()
            });
        }

        private void reporteBtn_Click(object sender, EventArgs e)
        {
            Utils.Validate.LockBtns(this);
            Utils.Returning.ReturnToPreviousForm(this, new ReporteVehiculos(Utils.DataSourcesEnum.TipoVehiculos, _userId, TVehiculosTable.DataSource));
        }
    }
}
