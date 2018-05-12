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
    public partial class ModifyMarca : MaterialForm
    {
        private int _userId;
        private int _marcaId;
        private string _keyword;
        private LoadComboBoxesRepo _comboBoxRepo;
        private MarcasRepo _marcasRepo;

        public ModifyMarca(int userId = 0, int marcaId = 0, string keyword = "")
        {
            _userId = userId;
            _marcaId = marcaId;
            _keyword = keyword;
            _comboBoxRepo = new LoadComboBoxesRepo();
            _marcasRepo = new MarcasRepo();
            InitializeComponent();
        }

        private void ModifyMarca_Load(object sender, EventArgs e)
        {
            Text = $"{ _keyword} Marcas";
            btnEnviarMarca.Text = _keyword;
            if(_marcaId == 0)
            {
                InitializeCtrl();
            }
            else
            {
                InitializeCtrl();
                SetValues(_marcaId);
            }
            
        }
        private void InitializeCtrl()
        {
            estadoTxt.DataSource = _comboBoxRepo.GetEstado();
            estadoTxt.DisplayMember = "Estado1";
            estadoTxt.ValueMember = "Id";
        }
        private void SetValues(int id)
        {
            var marca = _marcasRepo.GetMarcaById(id);
            marcaTxt.Text = marca.Descripcion;
            estadoTxt.SelectedValue = marca.Id_Estado;
        }

        private void btnEnviarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Utils.Validate.LockBtns(this);
                Utils.Validate.LockControls(this);
                var marcaExists = _marcasRepo.CheckMarcaExists(marcaTxt.Text.Trim());
                if (marcaExists && _marcaId == 0)
                {
                    MessageBox.Show("La marca ya existe intente denuevo");
                    Utils.Validate.UnLockControls(this);
                    Utils.Validate.EnableBtns(this);
                }
                else
                {
                    _marcasRepo.InsertMarca(new Context.Marca()
                    {
                        Descripcion = marcaTxt.Text,
                        Id_Estado = int.Parse(estadoTxt.SelectedValue.ToString()),
                        Id_User = _userId,
                        Id = _marcaId
                    });
                    if(MessageBox.Show("Marca Procesada Correctamente") == DialogResult.OK)
                    {
                        Thread.Sleep(2000);
                        Hide();
                        var marcasForm = new MarcasForm(_userId);
                        marcasForm.ShowDialog();
                        Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("No se pudo procesar la Marca");
            }
        }
    }
}
