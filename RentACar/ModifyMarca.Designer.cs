namespace RentACar
{
    partial class ModifyMarca
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.marcaTxt = new System.Windows.Forms.TextBox();
            this.estadoTxt = new System.Windows.Forms.ComboBox();
            this.btnEnviarMarca = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(170, 154);
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
            this.materialLabel2.Location = new System.Drawing.Point(170, 216);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(69, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Estado";
            // 
            // marcaTxt
            // 
            this.marcaTxt.Location = new System.Drawing.Point(262, 156);
            this.marcaTxt.Name = "marcaTxt";
            this.marcaTxt.Size = new System.Drawing.Size(169, 22);
            this.marcaTxt.TabIndex = 3;
            // 
            // estadoTxt
            // 
            this.estadoTxt.FormattingEnabled = true;
            this.estadoTxt.Location = new System.Drawing.Point(262, 218);
            this.estadoTxt.Name = "estadoTxt";
            this.estadoTxt.Size = new System.Drawing.Size(169, 24);
            this.estadoTxt.TabIndex = 4;
            // 
            // btnEnviarMarca
            // 
            this.btnEnviarMarca.AutoSize = true;
            this.btnEnviarMarca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEnviarMarca.Depth = 0;
            this.btnEnviarMarca.Location = new System.Drawing.Point(262, 264);
            this.btnEnviarMarca.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEnviarMarca.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnviarMarca.Name = "btnEnviarMarca";
            this.btnEnviarMarca.Primary = false;
            this.btnEnviarMarca.Size = new System.Drawing.Size(106, 36);
            this.btnEnviarMarca.TabIndex = 5;
            this.btnEnviarMarca.Text = "EnviarBtn";
            this.btnEnviarMarca.UseVisualStyleBackColor = true;
            this.btnEnviarMarca.Click += new System.EventHandler(this.btnEnviarMarca_Click);
            // 
            // ModifyMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 455);
            this.Controls.Add(this.btnEnviarMarca);
            this.Controls.Add(this.estadoTxt);
            this.Controls.Add(this.marcaTxt);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ModifyMarca";
            this.Text = "Rent A Car - ";
            this.Load += new System.EventHandler(this.ModifyMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox marcaTxt;
        private System.Windows.Forms.ComboBox estadoTxt;
        private MaterialSkin.Controls.MaterialFlatButton btnEnviarMarca;
    }
}