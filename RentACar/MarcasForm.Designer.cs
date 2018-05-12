namespace RentACar
{
    partial class MarcasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarcasForm));
            this.marcaTable = new System.Windows.Forms.DataGridView();
            this.editarMarcaBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.insertMarcaBtn = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.marcaTable)).BeginInit();
            this.SuspendLayout();
            // 
            // marcaTable
            // 
            this.marcaTable.AllowUserToAddRows = false;
            this.marcaTable.AllowUserToDeleteRows = false;
            this.marcaTable.AllowUserToOrderColumns = true;
            this.marcaTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.marcaTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marcaTable.Location = new System.Drawing.Point(140, 221);
            this.marcaTable.Name = "marcaTable";
            this.marcaTable.ReadOnly = true;
            this.marcaTable.RowTemplate.Height = 24;
            this.marcaTable.Size = new System.Drawing.Size(379, 205);
            this.marcaTable.TabIndex = 8;
            this.marcaTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.marcaTable_CellClick);
            // 
            // editarMarcaBtn
            // 
            this.editarMarcaBtn.AutoSize = true;
            this.editarMarcaBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editarMarcaBtn.Depth = 0;
            this.editarMarcaBtn.Location = new System.Drawing.Point(402, 100);
            this.editarMarcaBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editarMarcaBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.editarMarcaBtn.Name = "editarMarcaBtn";
            this.editarMarcaBtn.Primary = false;
            this.editarMarcaBtn.Size = new System.Drawing.Size(135, 36);
            this.editarMarcaBtn.TabIndex = 7;
            this.editarMarcaBtn.Text = "Editar Marca";
            this.editarMarcaBtn.UseVisualStyleBackColor = true;
            this.editarMarcaBtn.Click += new System.EventHandler(this.editarMarcaBtn_Click);
            // 
            // insertMarcaBtn
            // 
            this.insertMarcaBtn.AutoSize = true;
            this.insertMarcaBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.insertMarcaBtn.Depth = 0;
            this.insertMarcaBtn.Location = new System.Drawing.Point(115, 100);
            this.insertMarcaBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.insertMarcaBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.insertMarcaBtn.Name = "insertMarcaBtn";
            this.insertMarcaBtn.Primary = false;
            this.insertMarcaBtn.Size = new System.Drawing.Size(157, 36);
            this.insertMarcaBtn.TabIndex = 6;
            this.insertMarcaBtn.Text = "Insertar Marca";
            this.insertMarcaBtn.UseVisualStyleBackColor = true;
            this.insertMarcaBtn.Click += new System.EventHandler(this.insertMarcaBtn_Click);
            // 
            // MarcasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 481);
            this.Controls.Add(this.marcaTable);
            this.Controls.Add(this.editarMarcaBtn);
            this.Controls.Add(this.insertMarcaBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MarcasForm";
            this.Text = "Rent A Car - Marcas";
            this.Load += new System.EventHandler(this.MarcasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marcaTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView marcaTable;
        private MaterialSkin.Controls.MaterialFlatButton editarMarcaBtn;
        private MaterialSkin.Controls.MaterialFlatButton insertMarcaBtn;
    }
}