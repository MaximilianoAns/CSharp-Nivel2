
namespace MiPrimerAplicacion
{
    partial class App
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
            this.lblLabel1 = new System.Windows.Forms.Label();
            this.ControlTxtBox = new System.Windows.Forms.TextBox();
            this.ControlTxtBox2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLabel1
            // 
            this.lblLabel1.AutoSize = true;
            this.lblLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLabel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblLabel1.Location = new System.Drawing.Point(281, 34);
            this.lblLabel1.Name = "lblLabel1";
            this.lblLabel1.Size = new System.Drawing.Size(51, 20);
            this.lblLabel1.TabIndex = 1;
            this.lblLabel1.Text = "Label";
            this.lblLabel1.Click += new System.EventHandler(this.lblLabel1_Click);
            this.lblLabel1.MouseLeave += new System.EventHandler(this.lblLabel1_MouseLeave);
            this.lblLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblLabel1_MouseMove);
            // 
            // ControlTxtBox
            // 
            this.ControlTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ControlTxtBox.Location = new System.Drawing.Point(372, 35);
            this.ControlTxtBox.MaxLength = 9999;
            this.ControlTxtBox.Name = "ControlTxtBox";
            this.ControlTxtBox.Size = new System.Drawing.Size(100, 20);
            this.ControlTxtBox.TabIndex = 2;
            this.ControlTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlTxtBox_KeyPress);
            // 
            // ControlTxtBox2
            // 
            this.ControlTxtBox2.Location = new System.Drawing.Point(372, 79);
            this.ControlTxtBox2.Multiline = true;
            this.ControlTxtBox2.Name = "ControlTxtBox2";
            this.ControlTxtBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ControlTxtBox2.Size = new System.Drawing.Size(327, 20);
            this.ControlTxtBox2.TabIndex = 3;
            this.ControlTxtBox2.TextChanged += new System.EventHandler(this.ControlTxtBox2_TextChanged);
            this.ControlTxtBox2.Leave += new System.EventHandler(this.ControlTxtBox2_Leave);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn1.Image = global::MiPrimerAplicacion.Properties.Resources._220px_Drumcode;
            this.btn1.Location = new System.Drawing.Point(35, 34);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(188, 131);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Boton1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ControlTxtBox2);
            this.Controls.Add(this.ControlTxtBox);
            this.Controls.Add(this.lblLabel1);
            this.Controls.Add(this.btn1);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.App_FormClosing);
            this.Load += new System.EventHandler(this.App_Load);
            this.Click += new System.EventHandler(this.App_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblLabel1;
        private System.Windows.Forms.TextBox ControlTxtBox;
        private System.Windows.Forms.TextBox ControlTxtBox2;
    }
}

