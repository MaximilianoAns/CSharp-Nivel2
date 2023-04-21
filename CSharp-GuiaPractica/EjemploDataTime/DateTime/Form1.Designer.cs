
namespace DateTime
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
            this.dtpCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnPrueba2 = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnPrueba1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpCalendar
            // 
            this.dtpCalendar.Location = new System.Drawing.Point(161, 150);
            this.dtpCalendar.Name = "dtpCalendar";
            this.dtpCalendar.TabIndex = 2;
            // 
            // btnPrueba2
            // 
            this.btnPrueba2.Location = new System.Drawing.Point(435, 207);
            this.btnPrueba2.Name = "btnPrueba2";
            this.btnPrueba2.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba2.TabIndex = 3;
            this.btnPrueba2.Text = "Prueba2";
            this.btnPrueba2.UseVisualStyleBackColor = true;
            this.btnPrueba2.Click += new System.EventHandler(this.btnPrueba2_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(161, 100);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // btnPrueba1
            // 
            this.btnPrueba1.Location = new System.Drawing.Point(435, 100);
            this.btnPrueba1.Name = "btnPrueba1";
            this.btnPrueba1.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba1.TabIndex = 5;
            this.btnPrueba1.Text = "Prueba1";
            this.btnPrueba1.UseVisualStyleBackColor = true;
            this.btnPrueba1.Click += new System.EventHandler(this.btnPrueba1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrueba1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnPrueba2);
            this.Controls.Add(this.dtpCalendar);
            this.Name = "Form1";
            this.Text = "Ejemplo DateTime";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MonthCalendar dtpCalendar;
        private System.Windows.Forms.Button btnPrueba2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnPrueba1;
    }
}

