namespace RentACar
{
    partial class RentaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentaForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentaTable = new System.Windows.Forms.DataGridView();
            this.editarRenta = new MaterialSkin.Controls.MaterialFlatButton();
            this.devolverBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.clienteTxt = new System.Windows.Forms.TextBox();
            this.empleadoTxt = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentaTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.atrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.logoutToolStripMenuItem.Text = "logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.atrasToolStripMenuItem.Text = "atras";
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.atrasToolStripMenuItem_Click);
            // 
            // rentaTable
            // 
            this.rentaTable.AllowUserToAddRows = false;
            this.rentaTable.AllowUserToDeleteRows = false;
            this.rentaTable.AllowUserToOrderColumns = true;
            this.rentaTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.rentaTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentaTable.Location = new System.Drawing.Point(127, 280);
            this.rentaTable.Name = "rentaTable";
            this.rentaTable.ReadOnly = true;
            this.rentaTable.RowTemplate.Height = 24;
            this.rentaTable.Size = new System.Drawing.Size(603, 299);
            this.rentaTable.TabIndex = 14;
            this.rentaTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rentaTable_CellClick);
            // 
            // editarRenta
            // 
            this.editarRenta.AutoSize = true;
            this.editarRenta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editarRenta.Depth = 0;
            this.editarRenta.Location = new System.Drawing.Point(507, 93);
            this.editarRenta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editarRenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.editarRenta.Name = "editarRenta";
            this.editarRenta.Primary = false;
            this.editarRenta.Size = new System.Drawing.Size(130, 36);
            this.editarRenta.TabIndex = 13;
            this.editarRenta.Text = "Editar Renta";
            this.editarRenta.UseVisualStyleBackColor = true;
            this.editarRenta.Click += new System.EventHandler(this.editarRenta_Click);
            // 
            // devolverBtn
            // 
            this.devolverBtn.AutoSize = true;
            this.devolverBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.devolverBtn.Depth = 0;
            this.devolverBtn.Location = new System.Drawing.Point(220, 93);
            this.devolverBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.devolverBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.devolverBtn.Name = "devolverBtn";
            this.devolverBtn.Primary = false;
            this.devolverBtn.Size = new System.Drawing.Size(98, 36);
            this.devolverBtn.TabIndex = 12;
            this.devolverBtn.Text = "Devolver";
            this.devolverBtn.UseVisualStyleBackColor = true;
            this.devolverBtn.Click += new System.EventHandler(this.devolverBtn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(109, 224);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(142, 24);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Nombre Cliente";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(418, 224);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(170, 24);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Nombre Empleado";
            // 
            // clienteTxt
            // 
            this.clienteTxt.Location = new System.Drawing.Point(258, 225);
            this.clienteTxt.Name = "clienteTxt";
            this.clienteTxt.Size = new System.Drawing.Size(139, 22);
            this.clienteTxt.TabIndex = 17;
            this.clienteTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // empleadoTxt
            // 
            this.empleadoTxt.Location = new System.Drawing.Point(608, 226);
            this.empleadoTxt.Name = "empleadoTxt";
            this.empleadoTxt.Size = new System.Drawing.Size(139, 22);
            this.empleadoTxt.TabIndex = 18;
            this.empleadoTxt.TextChanged += new System.EventHandler(this.empleadoTxt_TextChanged);
            // 
            // RentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 616);
            this.Controls.Add(this.empleadoTxt);
            this.Controls.Add(this.clienteTxt);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.rentaTable);
            this.Controls.Add(this.editarRenta);
            this.Controls.Add(this.devolverBtn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RentaForm";
            this.Text = "Rent A Car - Renta";
            this.Load += new System.EventHandler(this.RentaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentaTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
        private System.Windows.Forms.DataGridView rentaTable;
        private MaterialSkin.Controls.MaterialFlatButton editarRenta;
        private MaterialSkin.Controls.MaterialFlatButton devolverBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox clienteTxt;
        private System.Windows.Forms.TextBox empleadoTxt;
    }
}