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
    public partial class ModifyEmpleados : MaterialForm
    {
        private int _userId;
        private int _empleadoId;
        private string _keyword;
        private LoadComboBoxesRepo _loadCombo;
        private EmpleadosRepo _empleadoRepo;

        public ModifyEmpleados(int userId = 0, int empleadoId = 0, string keyword="")
        {
            InitializeComponent();
            _userId = userId;
            _empleadoId = empleadoId;
            _keyword = keyword;
            _loadCombo = new LoadComboBoxesRepo();
            _empleadoRepo = new EmpleadosRepo();
        }

        private void ModifyEmpleados_Load(object sender, EventArgs e)
        {
            Text = $"{_keyword} Empleados";
            enviarEmpBtn.Text = _keyword;
            if(_empleadoId == 0)
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
            var empleado = _empleadoRepo.GetEmpleadoById(_empleadoId);
            cedTxt.Text = empleado.Cedula;
            nombreTxt.Text = empleado.Nombre;
            emailTxt.Text = empleado.Usuario.Email;
            passTxt.Text = empleado.Usuario.Pass;
            cmsTxt.Text = empleado.Comision.ToString();
            fechaIngrestoDt.Value = empleado.FechaIngreso.HasValue? empleado.FechaIngreso.Value: default(DateTime);
            estadoCbx.SelectedValue = empleado.Id_Estado;
            tandaCbx.Text = empleado.Tanda;
        }

        private void enviarEmpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.Validate.LockBtns(this);
                Utils.Validate.LockControls(this);
                var errorMsg = Utils.Validate.GenerateErrorMessage(this);
                var emailErrMsg = _empleadoRepo.GenerateMessageIfUserExists(emailTxt.Text.Trim(),_empleadoId);
                var comisionError = Utils.Validate.IsANumber(cmsTxt);
                var empleadoExists = _empleadoRepo.GetEmpleadoByCedula(cedTxt.Text.Trim());
                var cedulaIsValid = Utils.Validate.ValidaCedula(cedTxt.Text.Trim());
                
                if (string.IsNullOrEmpty(errorMsg) && string.IsNullOrEmpty(emailErrMsg) && string.IsNullOrEmpty(comisionError))
                {
                    if (empleadoExists && _empleadoId == 0)
                    {
                        Utils.Validate.UnLockControls(this);
                        Utils.Validate.EnableBtns(this);
                        MessageBox.Show("El empleado ya existe intente denuevo");
                    }
                    if (!cedulaIsValid)
                    {
                        Utils.Validate.UnLockControls(this);
                        Utils.Validate.EnableBtns(this);
                        MessageBox.Show("Cedula invalida intente denuevo");
                    }
                    else
                    {
                        _empleadoRepo.InsertEmpleado(new Context.Empleado()
                        {
                            Cedula = cedTxt.Text.Trim(),
                            Comision = decimal.Parse(cmsTxt.Text.Trim()),
                            FechaIngreso = fechaIngrestoDt.Value,
                            Tanda = tandaCbx.Text.Trim(),
                            Id_Estado = int.Parse(estadoCbx.SelectedValue.ToString()),
                            Nombre = nombreTxt.Text.Trim().ToUpper(),
                            Usuario = new Context.Usuario()
                            {
                                Email = emailTxt.Text.Trim(),
                                Pass = passTxt.Text.Trim(),
                                Id_Rol = 3
                            }
                            ,
                            Id = _empleadoId
                        });
                        if(MessageBox.Show("Empleado procesado correctamente") == DialogResult.OK)
                        {
                            Utils.Returning.ReturnToPreviousForm(this, new EmpleadosForm(_userId));
                        }
                    }
                }
                else
                {
                    Utils.Validate.UnLockControls(this);
                    Utils.Validate.EnableBtns(this);
                    MessageBox.Show($"{errorMsg} \n {emailErrMsg} \n {comisionError}");
                }

            }
            catch (Exception ex)
            {
                Utils.LogExceptions.LogToJsonFile(ex);
                MessageBox.Show("Ocurrio un error al procesar el Empleado");
            }
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToPreviousForm(this, new EmpleadosForm(_userId));
        }
    }
}
