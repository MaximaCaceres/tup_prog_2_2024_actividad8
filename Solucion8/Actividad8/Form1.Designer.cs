namespace Actividad8
{
    partial class Form1
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
            this.btnVerCuentas = new System.Windows.Forms.Button();
            this.btnImportarCuenta = new System.Windows.Forms.Button();
            this.btnExportarCuenta = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.tbxLista = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnVerCuentas
            // 
            this.btnVerCuentas.Location = new System.Drawing.Point(641, 54);
            this.btnVerCuentas.Name = "btnVerCuentas";
            this.btnVerCuentas.Size = new System.Drawing.Size(118, 23);
            this.btnVerCuentas.TabIndex = 0;
            this.btnVerCuentas.Text = "Ver Cuentas";
            this.btnVerCuentas.UseVisualStyleBackColor = true;
            this.btnVerCuentas.Click += new System.EventHandler(this.btnVerCuentas_Click);
            // 
            // btnImportarCuenta
            // 
            this.btnImportarCuenta.Location = new System.Drawing.Point(641, 126);
            this.btnImportarCuenta.Name = "btnImportarCuenta";
            this.btnImportarCuenta.Size = new System.Drawing.Size(118, 23);
            this.btnImportarCuenta.TabIndex = 1;
            this.btnImportarCuenta.Text = "Importar Cuenta";
            this.btnImportarCuenta.UseVisualStyleBackColor = true;
            this.btnImportarCuenta.Click += new System.EventHandler(this.btnImportarCuenta_Click);
            // 
            // btnExportarCuenta
            // 
            this.btnExportarCuenta.Location = new System.Drawing.Point(641, 191);
            this.btnExportarCuenta.Name = "btnExportarCuenta";
            this.btnExportarCuenta.Size = new System.Drawing.Size(118, 23);
            this.btnExportarCuenta.TabIndex = 2;
            this.btnExportarCuenta.Text = "Exportar Cuenta";
            this.btnExportarCuenta.UseVisualStyleBackColor = true;
            this.btnExportarCuenta.Click += new System.EventHandler(this.btnExportarCuenta_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(641, 256);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(118, 23);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(641, 313);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(118, 23);
            this.btnRestaurar.TabIndex = 4;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // tbxLista
            // 
            this.tbxLista.BackColor = System.Drawing.Color.LightGray;
            this.tbxLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLista.Location = new System.Drawing.Point(28, 54);
            this.tbxLista.Multiline = true;
            this.tbxLista.Name = "tbxLista";
            this.tbxLista.Size = new System.Drawing.Size(607, 282);
            this.tbxLista.TabIndex = 5;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 355);
            this.Controls.Add(this.tbxLista);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnExportarCuenta);
            this.Controls.Add(this.btnImportarCuenta);
            this.Controls.Add(this.btnVerCuentas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerCuentas;
        private System.Windows.Forms.Button btnImportarCuenta;
        private System.Windows.Forms.Button btnExportarCuenta;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.TextBox tbxLista;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

