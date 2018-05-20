namespace RentACar
{
    partial class EmpleadosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadosForm));
            this.EmpleadoTable = new System.Windows.Forms.DataGridView();
            this.editarEmpleadoBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.insertEmpleadoBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cedTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmpleadoTable
            // 
            this.EmpleadoTable.AllowUserToAddRows = false;
            this.EmpleadoTable.AllowUserToDeleteRows = false;
            this.EmpleadoTable.AllowUserToOrderColumns = true;
            this.EmpleadoTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmpleadoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpleadoTable.Location = new System.Drawing.Point(183, 293);
            this.EmpleadoTable.Name = "EmpleadoTable";
            this.EmpleadoTable.ReadOnly = true;
            this.EmpleadoTable.RowTemplate.Height = 24;
            this.EmpleadoTable.Size = new System.Drawing.Size(603, 299);
            this.EmpleadoTable.TabIndex = 11;
            this.EmpleadoTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpleadoTable_CellClick);
            // 
            // editarEmpleadoBtn
            // 
            this.editarEmpleadoBtn.AutoSize = true;
            this.editarEmpleadoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editarEmpleadoBtn.Depth = 0;
            this.editarEmpleadoBtn.Location = new System.Drawing.Point(530, 93);
            this.editarEmpleadoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editarEmpleadoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.editarEmpleadoBtn.Name = "editarEmpleadoBtn";
            this.editarEmpleadoBtn.Primary = false;
            this.editarEmpleadoBtn.Size = new System.Drawing.Size(165, 36);
            this.editarEmpleadoBtn.TabIndex = 10;
            this.editarEmpleadoBtn.Text = "Editar Empleado";
            this.editarEmpleadoBtn.UseVisualStyleBackColor = true;
            this.editarEmpleadoBtn.Click += new System.EventHandler(this.editarEmpleadoBtn_Click);
            // 
            // insertEmpleadoBtn
            // 
            this.insertEmpleadoBtn.AutoSize = true;
            this.insertEmpleadoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.insertEmpleadoBtn.Depth = 0;
            this.insertEmpleadoBtn.Location = new System.Drawing.Point(243, 93);
            this.insertEmpleadoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.insertEmpleadoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.insertEmpleadoBtn.Name = "insertEmpleadoBtn";
            this.insertEmpleadoBtn.Primary = false;
            this.insertEmpleadoBtn.Size = new System.Drawing.Size(187, 36);
            this.insertEmpleadoBtn.TabIndex = 9;
            this.insertEmpleadoBtn.Text = "Insertar Empleado";
            this.insertEmpleadoBtn.UseVisualStyleBackColor = true;
            this.insertEmpleadoBtn.Click += new System.EventHandler(this.insertEmpleadoBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.atrásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // atrásToolStripMenuItem
            // 
            this.atrásToolStripMenuItem.Name = "atrásToolStripMenuItem";
            this.atrásToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.atrásToolStripMenuItem.Text = "Atrás";
            this.atrásToolStripMenuItem.Click += new System.EventHandler(this.atrásToolStripMenuItem_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(183, 228);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 24);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Cedula";
            // 
            // cedTxt
            // 
            this.cedTxt.Location = new System.Drawing.Point(268, 228);
            this.cedTxt.Name = "cedTxt";
            this.cedTxt.Size = new System.Drawing.Size(187, 22);
            this.cedTxt.TabIndex = 14;
            this.cedTxt.TextChanged += new System.EventHandler(this.cedTxt_TextChanged);
            // 
            // EmpleadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 667);
            this.Controls.Add(this.cedTxt);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.EmpleadoTable);
            this.Controls.Add(this.editarEmpleadoBtn);
            this.Controls.Add(this.insertEmpleadoBtn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EmpleadosForm";
            this.Text = "Rent a Car - Empleados";
            this.Load += new System.EventHandler(this.EmpleadosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmpleadoTable;
        private MaterialSkin.Controls.MaterialFlatButton editarEmpleadoBtn;
        private MaterialSkin.Controls.MaterialFlatButton insertEmpleadoBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrásToolStripMenuItem;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox cedTxt;
    }
}