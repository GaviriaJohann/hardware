namespace Hardware
{
    partial class frmHardware
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
            this.btnNumeroSerie = new System.Windows.Forms.Button();
            this.btnNumeroDiscos = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnMacAddress = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnProcesos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNumeroSerie
            // 
            this.btnNumeroSerie.Location = new System.Drawing.Point(106, 91);
            this.btnNumeroSerie.Name = "btnNumeroSerie";
            this.btnNumeroSerie.Size = new System.Drawing.Size(153, 75);
            this.btnNumeroSerie.TabIndex = 0;
            this.btnNumeroSerie.Text = "Numero Serie";
            this.btnNumeroSerie.UseVisualStyleBackColor = true;
            this.btnNumeroSerie.Click += new System.EventHandler(this.btnNumeroSerie_Click);
            // 
            // btnNumeroDiscos
            // 
            this.btnNumeroDiscos.Location = new System.Drawing.Point(298, 91);
            this.btnNumeroDiscos.Name = "btnNumeroDiscos";
            this.btnNumeroDiscos.Size = new System.Drawing.Size(153, 75);
            this.btnNumeroDiscos.TabIndex = 1;
            this.btnNumeroDiscos.Text = "Numero Discos";
            this.btnNumeroDiscos.UseVisualStyleBackColor = true;
            this.btnNumeroDiscos.Click += new System.EventHandler(this.btnNumeroDiscos_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(492, 91);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(153, 75);
            this.btnInventario.TabIndex = 2;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnMacAddress
            // 
            this.btnMacAddress.Location = new System.Drawing.Point(106, 199);
            this.btnMacAddress.Name = "btnMacAddress";
            this.btnMacAddress.Size = new System.Drawing.Size(153, 75);
            this.btnMacAddress.TabIndex = 3;
            this.btnMacAddress.Text = "Mac Address";
            this.btnMacAddress.UseVisualStyleBackColor = true;
            this.btnMacAddress.Click += new System.EventHandler(this.btnMacAddress_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(298, 199);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(153, 75);
            this.btnRegistro.TabIndex = 4;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnProcesos
            // 
            this.btnProcesos.Location = new System.Drawing.Point(492, 199);
            this.btnProcesos.Name = "btnProcesos";
            this.btnProcesos.Size = new System.Drawing.Size(153, 75);
            this.btnProcesos.TabIndex = 5;
            this.btnProcesos.Text = "Procesos";
            this.btnProcesos.UseVisualStyleBackColor = true;
            this.btnProcesos.Click += new System.EventHandler(this.btnProcesos_Click);
            // 
            // frmHardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProcesos);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnMacAddress);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnNumeroDiscos);
            this.Controls.Add(this.btnNumeroSerie);
            this.Name = "frmHardware";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNumeroSerie;
        private System.Windows.Forms.Button btnNumeroDiscos;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnMacAddress;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnProcesos;
    }
}

