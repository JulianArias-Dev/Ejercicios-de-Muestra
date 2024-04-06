namespace Prueba_de_Conexion_DB
{
    partial class FormDataBaseTest
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConect = new System.Windows.Forms.Button();
            this.btnDisconect = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConect
            // 
            this.btnConect.Location = new System.Drawing.Point(23, 87);
            this.btnConect.Name = "btnConect";
            this.btnConect.Size = new System.Drawing.Size(212, 73);
            this.btnConect.TabIndex = 0;
            this.btnConect.Text = "Conectar";
            this.btnConect.UseVisualStyleBackColor = true;
            this.btnConect.Click += new System.EventHandler(this.btnConect_Click);
            // 
            // btnDisconect
            // 
            this.btnDisconect.Location = new System.Drawing.Point(23, 177);
            this.btnDisconect.Name = "btnDisconect";
            this.btnDisconect.Size = new System.Drawing.Size(212, 73);
            this.btnDisconect.TabIndex = 1;
            this.btnDisconect.Text = "Desconectar";
            this.btnDisconect.UseVisualStyleBackColor = true;
            this.btnDisconect.Click += new System.EventHandler(this.btnDisconect_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(260, 87);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 62;
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.Size = new System.Drawing.Size(504, 315);
            this.dgvUsuarios.TabIndex = 2;
            // 
            // FormDataBaseTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnDisconect);
            this.Controls.Add(this.btnConect);
            this.Name = "FormDataBaseTest";
            this.Text = "Database Test";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConect;
        private System.Windows.Forms.Button btnDisconect;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}

