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
    public partial class ModifyTipoCombustible : MaterialForm
    {
        private int _userId;
        private int _tcId;
        private UserRepo _userRepo;
        private TCRepo _tcRepo;
        private LoadComboBoxesRepo _loadCombo;
        private string _keyword;

        public ModifyTipoCombustible(int userId = 0, int tcId = 0,string keyword = "")
        { 
            _userId = userId;
            _tcId = tcId;
            _userRepo = new UserRepo();
            _tcRepo = new TCRepo();
            _loadCombo = new LoadComboBoxesRepo();
            _keyword = keyword;
            InitializeComponent();
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToPreviousForm(this, new TipoCombustibleForm(_userId));
        }

        private void ModifyTipoCombustible_Load(object sender, EventArgs e)
        {
            Text = $" {_keyword} Tipo Combustible";
            enviarTCBtn.Text = _keyword;
            if(_tcId == 0)
            {
                InitializeCtrls();
            }
            else
            {
                InitializeCtrls();
                SetValues(_tcId);
            }
        }
        private void InitializeCtrls()
        {
            estadoCbx.DataSource = _loadCombo.GetEstado();
            estadoCbx.DisplayMember = "Estado1";
            estadoCbx.ValueMember = "Id";
        }
        private void SetValues(int tcId)
        {
            var tc = _tcRepo.GetTipoCombustibleById(tcId);
            tcText.Text = tc.Descripcion;
            estadoCbx.SelectedValue = tc.Id_Estado;
        }

        private void enviarTCBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var errMsg = Utils.Validate.GenerateErrorMessage(this);
                Utils.Validate.LockBtns(this);
                Utils.Validate.LockControls(this);
                if (string.IsNullOrEmpty(errMsg))
                {
                    var tcExists = _tcRepo.CheckIfTipoCombustibleExists(tcText.Text);
                    if(tcExists && _tcId == 0)
                    {
                        Utils.Validate.EnableBtns(this);
                        Utils.Validate.UnLockControls(this);
                        MessageBox.Show("El Tipo de Combustible ya existe intente denuevo");
                    }
                    else
                    {
                        _tcRepo.InsertTipoCombustible(new Context.TipoCombustible()
                        {
                            Descripcion = tcText.Text.Trim(),
                            Id_Estado = int.Parse(estadoCbx.SelectedValue.ToString()),
                            Id_User = _userId,
                            Id = _tcId
                            
                        });
                        if(MessageBox.Show("Tipo Combustible procesado correctamente") == DialogResult.OK)
                        {
                            Utils.Returning.ReturnToPreviousForm(this, new TipoCombustibleForm(_userId));
                        }
                    }
                }
                else
                {
                    MessageBox.Show(errMsg);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ocurrió un error al tratar de procesar el tipo de combustible");
            }
        }
    }
}
