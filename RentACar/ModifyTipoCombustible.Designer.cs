namespace RentACar
{
    partial class ModifyTipoCombustible
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyTipoCombustible));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.estadoCbx = new System.Windows.Forms.ComboBox();
            this.tcText = new System.Windows.Forms.TextBox();
            this.enviarTCBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(112, 102);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(161, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Tipo Combustible";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(112, 155);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(69, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Estado";
            // 
            // estadoCbx
            // 
            this.estadoCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoCbx.FormattingEnabled = true;
            this.estadoCbx.Location = new System.Drawing.Point(290, 157);
            this.estadoCbx.Name = "estadoCbx";
            this.estadoCbx.Size = new System.Drawing.Size(135, 24);
            this.estadoCbx.TabIndex = 2;
            // 
            // tcText
            // 
            this.tcText.Location = new System.Drawing.Point(290, 103);
            this.tcText.Name = "tcText";
            this.tcText.Size = new System.Drawing.Size(135, 22);
            this.tcText.TabIndex = 3;
            // 
            // enviarTCBtn
            // 
            this.enviarTCBtn.AutoSize = true;
            this.enviarTCBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enviarTCBtn.Depth = 0;
            this.enviarTCBtn.Location = new System.Drawing.Point(290, 218);
            this.enviarTCBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.enviarTCBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.enviarTCBtn.Name = "enviarTCBtn";
            this.enviarTCBtn.Primary = false;
            this.enviarTCBtn.Size = new System.Drawing.Size(106, 36);
            this.enviarTCBtn.TabIndex = 4;
            this.enviarTCBtn.Text = "enviarBtn";
            this.enviarTCBtn.UseVisualStyleBackColor = true;
            this.enviarTCBtn.Click += new System.EventHandler(this.enviarTCBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atrásToolStripMenuItem
            // 
            this.atrásToolStripMenuItem.Name = "atrásToolStripMenuItem";
            this.atrásToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.atrásToolStripMenuItem.Text = "Atrás";
            this.atrásToolStripMenuItem.Click += new System.EventHandler(this.atrásToolStripMenuItem_Click);
            // 
            // ModifyTipoCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 411);
            this.Controls.Add(this.enviarTCBtn);
            this.Controls.Add(this.tcText);
            this.Controls.Add(this.estadoCbx);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ModifyTipoCombustible";
            this.Text = "Rent A Car - ";
            this.Load += new System.EventHandler(this.ModifyTipoCombustible_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox estadoCbx;
        private System.Windows.Forms.TextBox tcText;
        private MaterialSkin.Controls.MaterialFlatButton enviarTCBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atrásToolStripMenuItem;
    }
}