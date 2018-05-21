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
    public partial class ClientesForm : MaterialForm
    {
        private int _userId;
        private ClienteRepo _clienteRepo;
        private int _clienteId = 0;

        public ClientesForm(int userId = 0)
        {
            _userId = userId;
            _clienteRepo = new ClienteRepo();
            InitializeComponent();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            var user = _clienteRepo.GetUserById(_userId);
            if(user.Id_Rol != 1)
            {
                Utils.Validate.LockBtns(this);
            }
            clienteTable.DataSource = _clienteRepo.GetAllClientes();
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToPreviousForm(this, new MainForm(_userId));
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToLogin(this);
        }

        private void clienteTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _clienteId = int.Parse(clienteTable.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void insertClienteBtn_Click(object sender, EventArgs e)
        {
            Utils.Validate.LockBtns(this);
            Utils.Returning.ReturnToPreviousForm(this, new ModifyClientesForm(_userId, 0, "Insertar"));
        }

        private void editarClienteBtn_Click(object sender, EventArgs e)
        {
            if(_clienteId == 0)
            {
                MessageBox.Show("Elija Una Fila Para Editar");
            }
            else
            {
                Utils.Validate.LockBtns(this);
                Utils.Returning.ReturnToPreviousForm(this, new ModifyClientesForm(_userId, _clienteId, "Editar"));
            }
        }

        private void cedTxt_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }
        private void Filter()
        {
            clienteTable.DataSource = _clienteRepo.Filter(new Context.Cliente() {
                Cedula = cedTxt.Text.Trim()
            });

        }

        private void reporteBtn_Click(object sender, EventArgs e)
        {
            Utils.Validate.LockBtns(this);
            Utils.Returning.ReturnToPreviousForm(this, new ReporteVehiculos(Utils.DataSourcesEnum.Cliente, _userId, clienteTable.DataSource));
        }
    }
}
