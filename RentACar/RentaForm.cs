using MaterialSkin.Controls;
using RentACar.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class RentaForm : MaterialForm
    {
        private int _userId;
        private int _vehiculoId;
        private RentaRepo _rentaRepo;
        private UserRepo _userRepo;
        private int _rentaId = 0;

        public RentaForm(int userId = 0, int vehiculoId = 0)
        {
            _userId = userId;
            _vehiculoId = vehiculoId;
            _rentaRepo = new RentaRepo();
            _userRepo = new UserRepo();
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

        private void RentaForm_Load(object sender, EventArgs e)
        {
            try
            {
                rentaTable.DataSource = _rentaRepo.GetAllRentas();
                var user = _userRepo.GetUserById(_userId);
                if (user.Id_Rol == 2)
                {
                    Utils.Validate.LockBtns(this);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos de renta", "Error");
                Utils.LogExceptions.LogToJsonFile(ex);
            }
        }

        private void devolverBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_rentaId == 0)
                {
                    MessageBox.Show("Escoja una fila para Devolver");
                }
                else
                {
                    Utils.Validate.LockBtns(this);
                    _rentaRepo.Devolver(new Context.Renta()
                    {
                        Id = _rentaId
                    });
                    if (MessageBox.Show("Vehiculo Devuelto") == DialogResult.OK)
                    {
                        Utils.Returning.ReturnToPreviousForm(this, new VehiculosForm(_userId));
                    }

                }
            }
            catch (Exception ex)
            {
                Utils.LogExceptions.LogToJsonFile(ex);
                MessageBox.Show("Ocurrio un error al devolver");
            }
        }

        private void rentaTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _rentaId = int.Parse(rentaTable.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void editarRenta_Click(object sender, EventArgs e)
        {
            if(_rentaId == 0)
            {
                MessageBox.Show("Escoja una fila para editar");
            }
            else
            {
                Utils.Validate.LockBtns(this);
                var renta = _rentaRepo.GetRenta(_rentaId);
                var vehiculoId = _rentaRepo.GetVehiculoId(_rentaId).Value;
                Utils.Returning.ReturnToPreviousForm(this, new ModifyRenta(_userId, vehiculoId, _rentaId, 0, renta.Id_Cliente.Value,renta.Id_Empleado.Value,"Editar"));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

       

        private void empleadoTxt_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }
        private void Filter()
        {
            rentaTable.DataSource = _rentaRepo.Filter(new Context.Renta()
            {
                Empleado = new Context.Empleado()
                {
                    Nombre = empleadoTxt.Text.Trim()
                },
                Cliente = new Context.Cliente()
                {
                    Nombre = clienteTxt.Text.Trim()
                }
            });
        }

        private void reporteBtn_Click(object sender, EventArgs e)
        {
            Utils.Validate.LockBtns(this);
            Utils.Returning.ReturnToPreviousForm(this, new ReporteVehiculos(Utils.DataSourcesEnum.Renta, _userId, rentaTable.DataSource));
        }
    }
}
