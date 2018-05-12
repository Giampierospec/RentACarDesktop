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
    public partial class MarcasForm : MaterialForm
    {
        private int _userId;
        private int _marcaId = 0;
        private MarcasRepo _marcaRepo;
        private UserRepo _userRepo;

        public MarcasForm(int userId = 0)
        {
            _userId = userId;
            _marcaRepo = new MarcasRepo();
            _userRepo = new UserRepo();
            InitializeComponent();
        }

        private void marcaTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _marcaId = int.Parse(marcaTable.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void MarcasForm_Load(object sender, EventArgs e)
        {
            marcaTable.DataSource = _marcaRepo.GetAllMarcas();
            var user = _userRepo.GetUserById(_userId);
            if (user.Id_Rol == 2)
            {
                Utils.Validate.LockBtns(this);
            }
        }

        private void insertMarcaBtn_Click(object sender, EventArgs e)
        {
            Utils.Validate.LockBtns(this);
            Thread.Sleep(2000);
            var modifyMarca = new ModifyMarca(_userId, 0, "Insertar");
            Hide();
            modifyMarca.ShowDialog();
            Close();
        }

        private void editarMarcaBtn_Click(object sender, EventArgs e)
        {
            if(_marcaId == 0)
            {
                MessageBox.Show("Escoja una fila para poder Editar");
            }
            else
            {
                Utils.Validate.LockBtns(this);
                Thread.Sleep(2000);
                var modifyMarca = new ModifyMarca(_userId, _marcaId, "Editar");
                Hide();
                modifyMarca.ShowDialog();
                Close();
            }
        }
    }
}
