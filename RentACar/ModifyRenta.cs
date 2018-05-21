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
    public partial class ModifyRenta : MaterialForm
    {
        private int _userId;
        private int _vehiculoId;
        private int _rentaId;
        private string _keyword;
        private RentaRepo _rentaRepo;
        private int _inspeccionId;
        private InspeccionRepository _inspeccionRepo;
        private LoadComboBoxesRepo _loadCombo;

        public ModifyRenta(int userId = 0, int vehiculoId = 0, int rentaId = 0, int inspeccionId = 0,string keyword = "")
        {
            _userId = userId;
            _vehiculoId = vehiculoId;
            _rentaId = rentaId;
            _keyword = keyword;
            _rentaRepo = new RentaRepo();
            _inspeccionId = inspeccionId;
            _inspeccionRepo = new InspeccionRepository();
            _loadCombo = new LoadComboBoxesRepo();
            InitializeComponent();
        }

        private void ModifyRenta_Load(object sender, EventArgs e)
        {
            Text = $"{_keyword} Renta";
            enviarRentaBtn.Text = _keyword;
            if(_rentaId == 0)
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

            empleadoCbx.DataSource = _loadCombo.GetAllEmpleados();
            empleadoCbx.DisplayMember = "Nombre";
            empleadoCbx.ValueMember = "Id";

            clienteCbx.DataSource = _loadCombo.GetAllClientes();
            clienteCbx.DisplayMember = "Nombre";
            clienteCbx.ValueMember = "Id";
        }
        private void SetValues()
        {
            var renta = _rentaRepo.GetRenta(_rentaId);
            estadoCbx.SelectedValue = renta.Id_Estado;
            empleadoCbx.SelectedValue = renta.Id_Empleado;
            clienteCbx.SelectedValue = renta.Id_Cliente;
            fechaRentaDt.Value = renta.FechaRenta.HasValue ? renta.FechaRenta.Value: default(DateTime) ;
            montoxDiaTxt.Text = renta.MontoDiario.HasValue ? renta.MontoDiario.Value.ToString() : default(decimal).ToString();
            cantidadDiasTxt.Text = renta.Dias?.ToString();
            comentartioTxt.Text = renta.Comentario;

        }

        private void enviarRentaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.Validate.LockBtns(this);
                Utils.Validate.LockControls(this);
                var errMsg = Utils.Validate.GenerateErrorMessage(this);
                var isNumber = Utils.Validate.IsANumber(montoxDiaTxt);
                var isStrictlyANumber = Utils.Validate.IsStrictlyANumber(cantidadDiasTxt);
                if(string.IsNullOrEmpty(errMsg) && string.IsNullOrEmpty(isNumber)
                    && string.IsNullOrEmpty(isStrictlyANumber))
                {
                    _rentaRepo.InsertRenta(new Context.Renta() {
                        Dias = int.Parse(cantidadDiasTxt.Text.Trim()),
                        MontoDiario = int.Parse(montoxDiaTxt.Text.Trim()),
                        Comentario = comentartioTxt.Text.Trim(),
                        FechaRenta = fechaRentaDt.Value,
                        Id_Cliente = int.Parse(clienteCbx.SelectedValue.ToString()),
                        Id_Empleado = int.Parse(empleadoCbx.SelectedValue.ToString()),
                        Id_Estado = int.Parse(estadoCbx.SelectedValue.ToString()),
                        Id_User = _userId,
                        Id_Vehiculo = _vehiculoId,
                        Id = _rentaId
                        
                    });
                    _rentaRepo.CambiarEstado(new Context.Vehiculo()
                    {
                        Id = _vehiculoId,
                        Id_Estado = 3
                    });
                   if(enviarRentaBtn.Text == "Crear")
                    {
                        _inspeccionRepo.CambiarEstado(new Context.Inspeccion() {
                            Id= _inspeccionId,
                            Id_Estado = 2
                        });

                    }
                    if(MessageBox.Show("Renta Procesada") == DialogResult.OK)
                    {
                        Utils.Returning.ReturnToPreviousForm(this, new RentaForm(_userId, _vehiculoId));
                    }

                }
                else
                {
                    Utils.Validate.UnLockControls(this);
                    Utils.Validate.EnableBtns(this);
                    MessageBox.Show($"{errMsg} \n {isNumber} \n {isStrictlyANumber}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Utils.Validate.UnLockControls(this);
                Utils.Validate.EnableBtns(this);
                MessageBox.Show("Hubo un error al rentar");
            }
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToPreviousForm(this, new RentaForm(_userId, _vehiculoId));
        }
    }
}
