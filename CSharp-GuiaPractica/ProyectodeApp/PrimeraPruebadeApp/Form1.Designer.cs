﻿
namespace PrimeraPruebadeApp
{
    partial class FrmCelulares
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
            this.dgvpicCelular = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpicCelular)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvpicCelular
            // 
            this.dgvpicCelular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpicCelular.Location = new System.Drawing.Point(12, 23);
            this.dgvpicCelular.Name = "dgvpicCelular";
            this.dgvpicCelular.Size = new System.Drawing.Size(388, 194);
            this.dgvpicCelular.TabIndex = 0;
            // 
            // FrmCelulares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvpicCelular);
            this.Name = "FrmCelulares";
            this.Text = "AppCelular";
            this.Load += new System.EventHandler(this.FrmCelulares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpicCelular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpicCelular;
    }
}

