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
    public partial class ModifyModelos : MaterialForm
    {
        private int _userId;
        private int _modeloId;
        private LoadComboBoxesRepo _loadCombo;
        private ModeloRepo _modeloRepo;
        private string _keyword;

        public ModifyModelos(int userId = 0, int modeloId = 0, string keyword = "")
        {
            _userId = userId;
            _modeloId = modeloId;
            _loadCombo = new LoadComboBoxesRepo();
            _modeloRepo = new ModeloRepo();
            _keyword = keyword;
            InitializeComponent();

        }

        private void ModifyModelos_Load(object sender, EventArgs e)
        {
            Text = $" {_keyword} Modelos";
            btnEnviarModelo.Text = _keyword;
            if(_modeloId == 0)
            {
                InitializeControls();

            }
            else
            {
                InitializeControls();
                SetValues(_modeloId);
            }
        }
        private void InitializeControls()
        {
            estadoTxt.DataSource = _loadCombo.GetEstado();
            estadoTxt.DisplayMember = "Estado1";
            estadoTxt.ValueMember = "Id";
            marcaDrp.DataSource = _loadCombo.GetMarcas();
            marcaDrp.DisplayMember = "Descripcion";
            marcaDrp.ValueMember = "Id";
        }
        private void SetValues(int modeloId)
        {
            var md = _modeloRepo.GetModeloById(modeloId);
            modeloTxt.Text = md.Descripcion;
            estadoTxt.SelectedValue = md.Id_Estado;
            marcaDrp.SelectedValue = md.Id_Marca;
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToPreviousForm(this, new ModelosForm(_userId));
        }

        private void btnEnviarModelo_Click(object sender, EventArgs e)
        {
            try
            {
                var errorMsg = Utils.Validate.GenerateErrorMessage(this);
                if (string.IsNullOrEmpty(errorMsg))
                {
                    Utils.Validate.LockControls(this);
                    Utils.Validate.LockBtns(this);
                    var modeloExists = _modeloRepo.CheckIfModeloExists(modeloTxt.Text.Trim());
                    if (modeloExists && _modeloId == 0)
                    {
                        Utils.Validate.UnLockControls(this);
                        Utils.Validate.EnableBtns(this);
                        MessageBox.Show("El modelo ya existe intente denuevo");
                    }
                    else
                    {
                        _modeloRepo.InsertModelo(new Context.Modelo()
                        {
                            Descripcion = modeloTxt.Text.Trim(),
                            Id_Estado = int.Parse(estadoTxt.SelectedValue.ToString()),
                            Id_Marca = int.Parse(marcaDrp.SelectedValue.ToString()),
                            Id_User = _userId,
                            Id = _modeloId
                        });
                        if(MessageBox.Show("Modelo Procesado Correctamente") == DialogResult.OK)
                        {
                            Utils.Returning.ReturnToPreviousForm(this, new ModelosForm(_userId));
                        }
                    }
                }
                else
                {
                    MessageBox.Show(errorMsg);
                }
            }
            catch
            {
                MessageBox.Show("No se pudo modificar Modelo");
            }
        }
    }
}
