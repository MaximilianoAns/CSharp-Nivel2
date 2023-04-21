
namespace Ejemplo1
{
    partial class frmPerfil
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.listListaColores = new System.Windows.Forms.ListView();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.chkProgramacion = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbJunior = new System.Windows.Forms.RadioButton();
            this.rbTraining = new System.Windows.Forms.RadioButton();
            this.rbSenior = new System.Windows.Forms.RadioButton();
            this.grupoboxTipo = new System.Windows.Forms.GroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cboColores = new System.Windows.Forms.ComboBox();
            this.numNumeric = new System.Windows.Forms.NumericUpDown();
            this.lblNumeroFav = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.grupoboxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(87, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(140, 434);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(143, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(82, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // listListaColores
            // 
            this.listListaColores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listListaColores.HideSelection = false;
            this.listListaColores.Location = new System.Drawing.Point(144, 319);
            this.listListaColores.Name = "listListaColores";
            this.listListaColores.Size = new System.Drawing.Size(234, 109);
            this.listListaColores.TabIndex = 7;
            this.listListaColores.UseCompatibleStateImageBehavior = false;
            this.listListaColores.View = System.Windows.Forms.View.List;
            this.listListaColores.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(50, 106);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(84, 13);
            this.lblFechaNac.TabIndex = 4;
            this.lblFechaNac.Text = "Fecha de Nac. :";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNac.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dtpFechaNac.CalendarTrailingForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaNac.Location = new System.Drawing.Point(140, 103);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(164, 20);
            this.dtpFechaNac.TabIndex = 1;
            // 
            // chkProgramacion
            // 
            this.chkProgramacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkProgramacion.AutoSize = true;
            this.chkProgramacion.Location = new System.Drawing.Point(140, 126);
            this.chkProgramacion.Name = "chkProgramacion";
            this.chkProgramacion.Size = new System.Drawing.Size(124, 17);
            this.chkProgramacion.TabIndex = 2;
            this.chkProgramacion.Text = "Te gusta programar?";
            this.chkProgramacion.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(47, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(228, 31);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "PERFIL PERSONA";
            // 
            // rbJunior
            // 
            this.rbJunior.AutoSize = true;
            this.rbJunior.Checked = true;
            this.rbJunior.Location = new System.Drawing.Point(0, 28);
            this.rbJunior.Name = "rbJunior";
            this.rbJunior.Size = new System.Drawing.Size(53, 17);
            this.rbJunior.TabIndex = 9;
            this.rbJunior.TabStop = true;
            this.rbJunior.Text = "Junior";
            this.rbJunior.UseVisualStyleBackColor = true;
            // 
            // rbTraining
            // 
            this.rbTraining.AutoSize = true;
            this.rbTraining.Location = new System.Drawing.Point(110, 28);
            this.rbTraining.Name = "rbTraining";
            this.rbTraining.Size = new System.Drawing.Size(63, 17);
            this.rbTraining.TabIndex = 10;
            this.rbTraining.Text = "Training";
            this.rbTraining.UseVisualStyleBackColor = true;
            // 
            // rbSenior
            // 
            this.rbSenior.AutoSize = true;
            this.rbSenior.Location = new System.Drawing.Point(238, 28);
            this.rbSenior.Name = "rbSenior";
            this.rbSenior.Size = new System.Drawing.Size(55, 17);
            this.rbSenior.TabIndex = 11;
            this.rbSenior.Text = "Senior";
            this.rbSenior.UseVisualStyleBackColor = true;
            // 
            // grupoboxTipo
            // 
            this.grupoboxTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoboxTipo.Controls.Add(this.rbTraining);
            this.grupoboxTipo.Controls.Add(this.rbJunior);
            this.grupoboxTipo.Controls.Add(this.rbSenior);
            this.grupoboxTipo.Location = new System.Drawing.Point(140, 162);
            this.grupoboxTipo.Name = "grupoboxTipo";
            this.grupoboxTipo.Size = new System.Drawing.Size(293, 58);
            this.grupoboxTipo.TabIndex = 3;
            this.grupoboxTipo.TabStop = false;
            this.grupoboxTipo.Text = "Que nivel de programadar queres ser?";
            // 
            // lblColor
            // 
            this.lblColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(59, 230);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(75, 13);
            this.lblColor.TabIndex = 13;
            this.lblColor.Text = "Color Favorito:";
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // cboColores
            // 
            this.cboColores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboColores.FormattingEnabled = true;
            this.cboColores.Location = new System.Drawing.Point(140, 222);
            this.cboColores.Name = "cboColores";
            this.cboColores.Size = new System.Drawing.Size(193, 21);
            this.cboColores.TabIndex = 4;
            // 
            // numNumeric
            // 
            this.numNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numNumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numNumeric.Location = new System.Drawing.Point(144, 252);
            this.numNumeric.Name = "numNumeric";
            this.numNumeric.Size = new System.Drawing.Size(189, 20);
            this.numNumeric.TabIndex = 5;
            // 
            // lblNumeroFav
            // 
            this.lblNumeroFav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumeroFav.AutoSize = true;
            this.lblNumeroFav.Location = new System.Drawing.Point(46, 252);
            this.lblNumeroFav.Name = "lblNumeroFav";
            this.lblNumeroFav.Size = new System.Drawing.Size(88, 13);
            this.lblNumeroFav.TabIndex = 16;
            this.lblNumeroFav.Text = "Numero Favorito:";
            this.lblNumeroFav.Click += new System.EventHandler(this.numNumeroFav_Click);
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVerPerfil.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnVerPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVerPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnVerPerfil.FlatAppearance.BorderSize = 2;
            this.btnVerPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnVerPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnVerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPerfil.Location = new System.Drawing.Point(40, 299);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(103, 23);
            this.btnVerPerfil.TabIndex = 6;
            this.btnVerPerfil.Text = "Ver &Perfil Cargado:";
            this.btnVerPerfil.UseVisualStyleBackColor = false;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // frmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(532, 469);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.lblNumeroFav);
            this.Controls.Add(this.numNumeric);
            this.Controls.Add(this.cboColores);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.grupoboxTipo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.chkProgramacion);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.listListaColores);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(660, 512);
            this.MinimumSize = new System.Drawing.Size(460, 512);
            this.Name = "frmPerfil";
            this.Text = "frmVentanaDos";
            this.Load += new System.EventHandler(this.frmVentanaDos_Load);
            this.grupoboxTipo.ResumeLayout(false);
            this.grupoboxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListView listListaColores;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.CheckBox chkProgramacion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbJunior;
        private System.Windows.Forms.RadioButton rbTraining;
        private System.Windows.Forms.RadioButton rbSenior;
        private System.Windows.Forms.GroupBox grupoboxTipo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cboColores;
        private System.Windows.Forms.NumericUpDown numNumeric;
        private System.Windows.Forms.Label lblNumeroFav;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}