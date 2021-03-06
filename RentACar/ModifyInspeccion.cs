﻿using MaterialSkin.Controls;
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
    public partial class ModifyInspeccion : MaterialForm
    {
        private int _userId;
        private int _vehiculoId;
        private LoadComboBoxesRepo _loadCombo;
        private InspeccionRepository _inspeccionRepo;
        private string _keyword;
        private int _inspeccionId;

        public ModifyInspeccion(int userId = 0,int vehiculoId = 0, int inspeccionId = 0,string keyword = "")
        {
            _userId = userId;
            _vehiculoId = vehiculoId;
            _loadCombo = new LoadComboBoxesRepo();
            _inspeccionRepo = new InspeccionRepository();
            _keyword = keyword;
            _inspeccionId = inspeccionId;
            InitializeComponent();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.Returning.ReturnToPreviousForm(this, new InspeccionForm(_userId,_vehiculoId));
        }

        private void btnInsEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.Validate.LockBtns(this);
                Utils.Validate.LockControls(this);
                var errMsg = Utils.Validate.GenerateErrorMessage(this);
                var isNumber = Utils.Validate.IsANumber(cantCombTxt);
                if (string.IsNullOrEmpty(errMsg) && string.IsNullOrEmpty(isNumber))
                {
                    _inspeccionRepo.InsertInspeccion(new Context.Inspeccion() {
                        CantidadCombustible = decimal.Parse(cantCombTxt.Text.Trim()),
                        EstadoGomas = estadoGomasTxt.Text.Trim(),
                        GomaRepuesta = gomaResCbx.Checked,
                        Fecha = fechaInsDt.Value,
                        Ralladuras = ralladurasCbx.Checked,
                        TieneGato = gatoCbx.Checked,
                        TieneRoturasCristal = roturasCristalCbx.Checked,
                        Id_Cliente = int.Parse(clienteCbx.SelectedValue.ToString()),
                        Id_Empleado = int.Parse(empleadoCbx.SelectedValue.ToString()),
                        Id_User = _userId,
                        Id_Estado = int.Parse(estadoCbx.SelectedValue.ToString()),
                        Id_Vehiculo = _vehiculoId,
                        Id = _inspeccionId,
                        
                       

                    });
                    _inspeccionRepo.CambiarEstado(new Context.Vehiculo()
                    {
                        Id = _vehiculoId,
                        Id_Estado = 4
                    });
                    if (MessageBox.Show("Inspeccion procesada correctamente") == DialogResult.OK)
                    {
                        Utils.Returning.ReturnToPreviousForm(this, new InspeccionForm(_userId, _vehiculoId));
                    }

                }
                else
                {

                    Utils.Validate.EnableBtns(this);
                    Utils.Validate.UnLockControls(this);
                    MessageBox.Show($"{errMsg} \n {isNumber}");
                }
            }
            catch(Exception ex)
            {
                Utils.LogExceptions.LogToJsonFile(ex);
                Utils.Validate.EnableBtns(this);
                Utils.Validate.UnLockControls(this);
                MessageBox.Show("Ocurrio un error al inspeccionar");
            }
        }

        private void ModifyInspeccion_Load(object sender, EventArgs e)
        {
            Text = $"{_keyword} Inspeccion";
            btnInsEnviar.Text = _keyword;
           if(_inspeccionId == 0)
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
            clienteCbx.DataSource = _loadCombo.GetAllClientes();
            clienteCbx.DisplayMember = "Nombre";
            clienteCbx.ValueMember = "Id";
            empleadoCbx.DataSource = _loadCombo.GetAllEmpleados();
            empleadoCbx.DisplayMember = "Nombre";
            empleadoCbx.ValueMember = "Id";
        }
        private void SetValues()
        {
            var inspeccion = _inspeccionRepo.GetInspeccionById(_inspeccionId);
            estadoCbx.SelectedValue = inspeccion.Id_Estado;
            clienteCbx.SelectedValue = inspeccion.Id_Cliente;
            empleadoCbx.SelectedValue = inspeccion.Id_Empleado;
            ralladurasCbx.Checked = inspeccion.Ralladuras.HasValue? inspeccion.Ralladuras.Value: false;
            gomaResCbx.Checked = inspeccion.GomaRepuesta.HasValue ? inspeccion.GomaRepuesta.Value : false;
            gatoCbx.Checked = inspeccion.TieneGato.HasValue ? inspeccion.TieneGato.Value : false;
            roturasCristalCbx.Checked = inspeccion.TieneRoturasCristal.HasValue ? inspeccion.TieneRoturasCristal.Value : false;
            cantCombTxt.Text = inspeccion.CantidadCombustible.ToString();
            estadoGomasTxt.Text = inspeccion.EstadoGomas;

        }
    }
}
