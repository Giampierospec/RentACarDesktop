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
    public partial class ModifyClientesForm : MaterialForm
    {
        private LoadComboBoxesRepo _loadCombo;
        private ClienteRepo _clientesRepo;
        private int _userId;
        private int _clienteId;
        private string _keyword;

        public ModifyClientesForm(int userId = 0, int clienteId = 0, string keyword = "")
        {
            InitializeComponent();
            _loadCombo = new LoadComboBoxesRepo();
            _clientesRepo = new ClienteRepo();
            _userId = userId;
            _clienteId = clienteId;
            _keyword = keyword;
        }

        private void ModifyClientesForm_Load(object sender, EventArgs e)
        {
            Text = $" {_keyword} Clientes";
            enviarClBtn.Text = _keyword;
            if(_clienteId == 0)
            {
                InitializeControls();
            }
            else
            {
                InitializeControls();
                SetValues();
            }
        }
        private void InitializeControls()
        {
            estadoCbx.DataSource = _loadCombo.GetEstado();
            estadoCbx.DisplayMember = "Estado1";
            estadoCbx.ValueMember = "Id";

        }
        private void SetValues()
        {
            var cliente = _clientesRepo.GetClienteById(_userId);
            cedTxt.Text = cliente.Cedula;
            nombreTxt.Text = cliente.Nombre;
            lmCrdTxt.Text = cliente.LimiteCredito?.ToString();
            nmTarTxt.Text = cliente.NoTarjetaCr;
            passTxt.Text = cliente.Usuario.Pass;
            emailTxt.Text = cliente.Usuario.Email;
            tipoPCbx.Text = cliente.TipoPersona;
        }

        private void enviarClBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.Validate.LockBtns(this);
                Utils.Validate.LockControls(this);
                var errorMsg = Utils.Validate.GenerateErrorMessage(this);
                var emailErrMsg = _clientesRepo.GenerateMessageIfUserExists(emailTxt.Text.Trim(),_clienteId);
                var clienteExists = _clientesRepo.UserExistsByCedula(cedTxt.Text.Trim());
                var cedulaIsValid = Utils.Validate.ValidaCedula(cedTxt.Text.Trim());
                var isNumber = Utils.Validate.IsANumber(lmCrdTxt);
                var isStrictlyANumber = Utils.Validate.IsStrictlyANumber(nmTarTxt);
                if(string.IsNullOrEmpty(errorMsg) && string.IsNullOrEmpty(emailErrMsg) && string.IsNullOrEmpty(isNumber)
                    &&string.IsNullOrEmpty(isStrictlyANumber))
                {
                    if (clienteExists && _clienteId == 0)
                    {
                        Utils.Validate.UnLockControls(this);
                        Utils.Validate.EnableBtns(this);
                        MessageBox.Show("El cliente ya existe intente denuevo");
                    }
                    if (!cedulaIsValid)
                    {
                        Utils.Validate.UnLockControls(this);
                        Utils.Validate.EnableBtns(this);
                        MessageBox.Show("Cedula no valida");
                    }
                    else
                    {
                        _clientesRepo.InsertCliente(new Context.Cliente()
                        {
                            Cedula = cedTxt.Text.Trim(),
                            Id_Estado = int.Parse(estadoCbx.SelectedValue.ToString()),
                            Nombre = nombreTxt.Text.Trim().ToUpper(),
                            LimiteCredito = decimal.Parse(lmCrdTxt.Text.Trim()),
                            NoTarjetaCr = nmTarTxt.Text.Trim(),
                            TipoPersona = tipoPCbx.Text.Trim(),
                            Id = _clienteId,
                            Usuario = new Context.Usuario()
                            {
                                Id_Rol = 2,
                                Email = emailTxt.Text.Trim(),
                                Pass = passTxt.Text.Trim()
                            }
                        });
                        if(MessageBox.Show("Cliente Procesado correctamente") == DialogResult.OK)
                        {
                            Utils.Returning.ReturnToPreviousForm(this, new ClientesForm(_userId));
                        }
                    }
                }
                else
                {
                    Utils.Validate.UnLockControls(this);
                    Utils.Validate.EnableBtns(this);
                    MessageBox.Show($"{errorMsg} \n {emailErrMsg} \n {isNumber} \n {isStrictlyANumber}");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo procesar al Cliente");
                Console.WriteLine(ex);

            }
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToPreviousForm(this, new ClientesForm(_userId));
        }
    }
}
