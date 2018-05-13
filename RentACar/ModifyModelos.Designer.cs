namespace RentACar
{
    partial class ModifyModelos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyModelos));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.modeloTxt = new System.Windows.Forms.TextBox();
            this.marcaDrp = new System.Windows.Forms.ComboBox();
            this.estadoTxt = new System.Windows.Forms.ComboBox();
            this.btnEnviarModelo = new MaterialSkin.Controls.MaterialFlatButton();
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
            this.materialLabel1.Location = new System.Drawing.Point(174, 122);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(63, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Marca";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(174, 167);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Modelo";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(174, 217);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(69, 24);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Estado";
            // 
            // modeloTxt
            // 
            this.modeloTxt.Location = new System.Drawing.Point(255, 169);
            this.modeloTxt.Name = "modeloTxt";
            this.modeloTxt.Size = new System.Drawing.Size(186, 22);
            this.modeloTxt.TabIndex = 3;
            // 
            // marcaDrp
            // 
            this.marcaDrp.FormattingEnabled = true;
            this.marcaDrp.Location = new System.Drawing.Point(255, 122);
            this.marcaDrp.Name = "marcaDrp";
            this.marcaDrp.Size = new System.Drawing.Size(186, 24);
            this.marcaDrp.TabIndex = 4;
            // 
            // estadoTxt
            // 
            this.estadoTxt.FormattingEnabled = true;
            this.estadoTxt.Location = new System.Drawing.Point(255, 219);
            this.estadoTxt.Name = "estadoTxt";
            this.estadoTxt.Size = new System.Drawing.Size(186, 24);
            this.estadoTxt.TabIndex = 5;
            // 
            // btnEnviarModelo
            // 
            this.btnEnviarModelo.AutoSize = true;
            this.btnEnviarModelo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEnviarModelo.Depth = 0;
            this.btnEnviarModelo.Location = new System.Drawing.Point(255, 277);
            this.btnEnviarModelo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEnviarModelo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnviarModelo.Name = "btnEnviarModelo";
            this.btnEnviarModelo.Primary = false;
            this.btnEnviarModelo.Size = new System.Drawing.Size(106, 36);
            this.btnEnviarModelo.TabIndex = 6;
            this.btnEnviarModelo.Text = "btnEnviar";
            this.btnEnviarModelo.UseVisualStyleBackColor = true;
            this.btnEnviarModelo.Click += new System.EventHandler(this.btnEnviarModelo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atrásToolStripMenuItem
            // 
            this.atrásToolStripMenuItem.Name = "atrásToolStripMenuItem";
            this.atrásToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.atrásToolStripMenuItem.Text = " Atrás";
            this.atrásToolStripMenuItem.Click += new System.EventHandler(this.atrásToolStripMenuItem_Click);
            // 
            // ModifyModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 434);
            this.Controls.Add(this.btnEnviarModelo);
            this.Controls.Add(this.estadoTxt);
            this.Controls.Add(this.marcaDrp);
            this.Controls.Add(this.modeloTxt);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ModifyModelos";
            this.Text = "Rent A Car - ";
            this.Load += new System.EventHandler(this.ModifyModelos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox modeloTxt;
        private System.Windows.Forms.ComboBox marcaDrp;
        private System.Windows.Forms.ComboBox estadoTxt;
        private MaterialSkin.Controls.MaterialFlatButton btnEnviarModelo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atrásToolStripMenuItem;
    }
}