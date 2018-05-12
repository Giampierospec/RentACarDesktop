﻿namespace RentACar
{
    partial class VehiculosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.insertVehiculoBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.editarVehiculoBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.vehiculosTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosTable)).BeginInit();
            this.SuspendLayout();
            // 
            // insertVehiculoBtn
            // 
            this.insertVehiculoBtn.AutoSize = true;
            this.insertVehiculoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.insertVehiculoBtn.Depth = 0;
            this.insertVehiculoBtn.Location = new System.Drawing.Point(254, 116);
            this.insertVehiculoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.insertVehiculoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.insertVehiculoBtn.Name = "insertVehiculoBtn";
            this.insertVehiculoBtn.Primary = false;
            this.insertVehiculoBtn.Size = new System.Drawing.Size(179, 36);
            this.insertVehiculoBtn.TabIndex = 0;
            this.insertVehiculoBtn.Text = "Insertar Vehiculo";
            this.insertVehiculoBtn.UseVisualStyleBackColor = true;
            this.insertVehiculoBtn.Click += new System.EventHandler(this.insertVehiculoBtn_Click);
            // 
            // editarVehiculoBtn
            // 
            this.editarVehiculoBtn.AutoSize = true;
            this.editarVehiculoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editarVehiculoBtn.Depth = 0;
            this.editarVehiculoBtn.Location = new System.Drawing.Point(541, 116);
            this.editarVehiculoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editarVehiculoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.editarVehiculoBtn.Name = "editarVehiculoBtn";
            this.editarVehiculoBtn.Primary = false;
            this.editarVehiculoBtn.Size = new System.Drawing.Size(157, 36);
            this.editarVehiculoBtn.TabIndex = 1;
            this.editarVehiculoBtn.Text = "Editar Vehiculo";
            this.editarVehiculoBtn.UseVisualStyleBackColor = true;
            this.editarVehiculoBtn.Click += new System.EventHandler(this.editarVehiculoBtn_Click);
            // 
            // vehiculosTable
            // 
            this.vehiculosTable.AllowUserToAddRows = false;
            this.vehiculosTable.AllowUserToDeleteRows = false;
            this.vehiculosTable.AllowUserToOrderColumns = true;
            this.vehiculosTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.vehiculosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiculosTable.Location = new System.Drawing.Point(37, 229);
            this.vehiculosTable.Name = "vehiculosTable";
            this.vehiculosTable.ReadOnly = true;
            this.vehiculosTable.RowTemplate.Height = 24;
            this.vehiculosTable.Size = new System.Drawing.Size(879, 230);
            this.vehiculosTable.TabIndex = 2;
            this.vehiculosTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehiculosTable_CellClick);
            // 
            // VehiculosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 571);
            this.Controls.Add(this.vehiculosTable);
            this.Controls.Add(this.editarVehiculoBtn);
            this.Controls.Add(this.insertVehiculoBtn);
            this.Name = "VehiculosForm";
            this.Text = "Rent A Car - Vehiculos";
            this.Load += new System.EventHandler(this.VehiculosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton insertVehiculoBtn;
        private MaterialSkin.Controls.MaterialFlatButton editarVehiculoBtn;
        private System.Windows.Forms.DataGridView vehiculosTable;
    }
}