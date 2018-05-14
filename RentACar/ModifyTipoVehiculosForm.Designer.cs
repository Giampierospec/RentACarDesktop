namespace RentACar
{
    partial class ModifyTipoVehiculosForm
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
            this.enviarTpBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tipoVehiculoDesc = new System.Windows.Forms.TextBox();
            this.estadoTipoVehiculoTxt = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // enviarTpBtn
            // 
            this.enviarTpBtn.AutoSize = true;
            this.enviarTpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enviarTpBtn.Depth = 0;
            this.enviarTpBtn.Location = new System.Drawing.Point(223, 264);
            this.enviarTpBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.enviarTpBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.enviarTpBtn.Name = "enviarTpBtn";
            this.enviarTpBtn.Primary = false;
            this.enviarTpBtn.Size = new System.Drawing.Size(106, 36);
            this.enviarTpBtn.TabIndex = 2;
            this.enviarTpBtn.Text = "EnviarBtn";
            this.enviarTpBtn.UseVisualStyleBackColor = true;
            this.enviarTpBtn.Click += new System.EventHandler(this.enviarTpBtn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(178, 150);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(126, 24);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Tipo Vehiculo";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(178, 201);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(69, 24);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Estado";
            // 
            // tipoVehiculoDesc
            // 
            this.tipoVehiculoDesc.Location = new System.Drawing.Point(310, 150);
            this.tipoVehiculoDesc.Name = "tipoVehiculoDesc";
            this.tipoVehiculoDesc.Size = new System.Drawing.Size(164, 22);
            this.tipoVehiculoDesc.TabIndex = 5;
            // 
            // estadoTipoVehiculoTxt
            // 
            this.estadoTipoVehiculoTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoTipoVehiculoTxt.FormattingEnabled = true;
            this.estadoTipoVehiculoTxt.Location = new System.Drawing.Point(310, 203);
            this.estadoTipoVehiculoTxt.Name = "estadoTipoVehiculoTxt";
            this.estadoTipoVehiculoTxt.Size = new System.Drawing.Size(164, 24);
            this.estadoTipoVehiculoTxt.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.atrasToolStripMenuItem.Text = "Atras";
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.atrasToolStripMenuItem_Click);
            // 
            // ModifyTipoVehiculosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 451);
            this.Controls.Add(this.estadoTipoVehiculoTxt);
            this.Controls.Add(this.tipoVehiculoDesc);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.enviarTpBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ModifyTipoVehiculosForm";
            this.Text = "Rent A Car - Tipo Vehiculos";
            this.Load += new System.EventHandler(this.ModifyTipoVehiculosForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton enviarTpBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox tipoVehiculoDesc;
        private System.Windows.Forms.ComboBox estadoTipoVehiculoTxt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
    }
}