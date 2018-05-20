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
            this.menuStrip1.Size = new System.Drawing.Size(817, 28);
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
            this.rentaTable.Location = new System.Drawing.Point(86, 225);
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
            this.editarRenta.Location = new System.Drawing.Point(443, 93);
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
            this.devolverBtn.Location = new System.Drawing.Point(156, 93);
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
            // RentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 589);
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
    }
}