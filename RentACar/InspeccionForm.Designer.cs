namespace RentACar
{
    partial class InspeccionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InspeccionForm));
            this.inspeccionTable = new System.Windows.Forms.DataGridView();
            this.rentarBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.editarInsBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.inspeccionTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inspeccionTable
            // 
            this.inspeccionTable.AllowUserToAddRows = false;
            this.inspeccionTable.AllowUserToDeleteRows = false;
            this.inspeccionTable.AllowUserToOrderColumns = true;
            this.inspeccionTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.inspeccionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inspeccionTable.Location = new System.Drawing.Point(115, 226);
            this.inspeccionTable.Name = "inspeccionTable";
            this.inspeccionTable.ReadOnly = true;
            this.inspeccionTable.RowTemplate.Height = 24;
            this.inspeccionTable.Size = new System.Drawing.Size(654, 224);
            this.inspeccionTable.TabIndex = 11;
            this.inspeccionTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inspeccionTable_CellClick);
            // 
            // rentarBtn
            // 
            this.rentarBtn.AutoSize = true;
            this.rentarBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rentarBtn.Depth = 0;
            this.rentarBtn.Location = new System.Drawing.Point(531, 105);
            this.rentarBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rentarBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.rentarBtn.Name = "rentarBtn";
            this.rentarBtn.Primary = false;
            this.rentarBtn.Size = new System.Drawing.Size(78, 36);
            this.rentarBtn.TabIndex = 10;
            this.rentarBtn.Text = "Rentar";
            this.rentarBtn.UseVisualStyleBackColor = true;
            this.rentarBtn.Click += new System.EventHandler(this.rentarBtn_Click);
            // 
            // editarInsBtn
            // 
            this.editarInsBtn.AutoSize = true;
            this.editarInsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editarInsBtn.Depth = 0;
            this.editarInsBtn.Location = new System.Drawing.Point(230, 105);
            this.editarInsBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editarInsBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.editarInsBtn.Name = "editarInsBtn";
            this.editarInsBtn.Primary = false;
            this.editarInsBtn.Size = new System.Drawing.Size(175, 36);
            this.editarInsBtn.TabIndex = 9;
            this.editarInsBtn.Text = "Editar Inspeccion";
            this.editarInsBtn.UseVisualStyleBackColor = true;
            this.editarInsBtn.Click += new System.EventHandler(this.editarInsBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.atrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 28);
            this.menuStrip1.TabIndex = 12;
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
            // InspeccionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 605);
            this.Controls.Add(this.inspeccionTable);
            this.Controls.Add(this.rentarBtn);
            this.Controls.Add(this.editarInsBtn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InspeccionForm";
            this.Text = "Rent A Car - Inspeccion";
            this.Load += new System.EventHandler(this.InspeccionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inspeccionTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inspeccionTable;
        private MaterialSkin.Controls.MaterialFlatButton rentarBtn;
        private MaterialSkin.Controls.MaterialFlatButton editarInsBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
    }
}