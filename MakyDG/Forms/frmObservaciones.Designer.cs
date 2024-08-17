namespace MakyDG.Forms
{
    partial class frmObservaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObservaciones));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtNombre = new MakyDG.Controles.CustomTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new MakyDG.Controles.CustomDataTimePiker();
            this.cbmEstado = new MakyDG.Controles.CustomComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCreador = new MakyDG.Controles.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAccion = new MakyDG.Controles.CustomButton();
            this.txtDetalle = new MakyDG.Controles.CustomTextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BarraTitulo.Controls.Add(this.label1);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(800, 38);
            this.BarraTitulo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Observaciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseUp);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::MakyDG.Properties.Resources.Minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(721, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(29, 30);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::MakyDG.Properties.Resources.Close;
            this.btnCerrar.Location = new System.Drawing.Point(765, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 30);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombre.BorderRadius = 10;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.Location = new System.Drawing.Point(3, 76);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.ReadOnly = false;
            this.txtNombre.Size = new System.Drawing.Size(161, 34);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = false;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(3, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(161, 20);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaInicio.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(364, 56);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(205, 18);
            this.lblFechaInicio.TabIndex = 21;
            this.lblFechaInicio.Text = "Fecha Inicio";
            this.lblFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.dtpFechaInicio.BorderSize = 1;
            this.dtpFechaInicio.Enabled = false;
            this.dtpFechaInicio.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(347, 77);
            this.dtpFechaInicio.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(239, 35);
            this.dtpFechaInicio.SkinColor = System.Drawing.Color.White;
            this.dtpFechaInicio.TabIndex = 20;
            this.dtpFechaInicio.TextColor = System.Drawing.Color.Black;
            // 
            // cbmEstado
            // 
            this.cbmEstado.BackColor = System.Drawing.Color.White;
            this.cbmEstado.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.cbmEstado.BorderSize = 2;
            this.cbmEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmEstado.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmEstado.ForeColor = System.Drawing.Color.Black;
            this.cbmEstado.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbmEstado.Items.AddRange(new object[] {
            "Verde",
            "Amarillo",
            "Rojo"});
            this.cbmEstado.ListBackColor = System.Drawing.Color.White;
            this.cbmEstado.ListTextColor = System.Drawing.Color.Black;
            this.cbmEstado.Location = new System.Drawing.Point(597, 77);
            this.cbmEstado.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbmEstado.Name = "cbmEstado";
            this.cbmEstado.Padding = new System.Windows.Forms.Padding(2);
            this.cbmEstado.Size = new System.Drawing.Size(200, 35);
            this.cbmEstado.TabIndex = 27;
            this.cbmEstado.Texts = "";
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstado.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(600, 51);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(200, 23);
            this.lblEstado.TabIndex = 26;
            this.lblEstado.Text = "Estado";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCreador
            // 
            this.txtCreador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreador.BackColor = System.Drawing.SystemColors.Window;
            this.txtCreador.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.txtCreador.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCreador.BorderRadius = 10;
            this.txtCreador.BorderSize = 2;
            this.txtCreador.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCreador.Location = new System.Drawing.Point(175, 77);
            this.txtCreador.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreador.Multiline = false;
            this.txtCreador.Name = "txtCreador";
            this.txtCreador.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCreador.PasswordChar = false;
            this.txtCreador.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCreador.PlaceholderText = "";
            this.txtCreador.ReadOnly = true;
            this.txtCreador.Size = new System.Drawing.Size(161, 34);
            this.txtCreador.TabIndex = 29;
            this.txtCreador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCreador.Texts = "";
            this.txtCreador.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Responsable";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAccion
            // 
            this.btnAccion.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAccion.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAccion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAccion.BorderRadius = 15;
            this.btnAccion.BorderSize = 0;
            this.btnAccion.FlatAppearance.BorderSize = 0;
            this.btnAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccion.ForeColor = System.Drawing.Color.White;
            this.btnAccion.Location = new System.Drawing.Point(331, 279);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(139, 47);
            this.btnAccion.TabIndex = 32;
            this.btnAccion.Text = "Aceptar";
            this.btnAccion.TextColor = System.Drawing.Color.White;
            this.btnAccion.UseVisualStyleBackColor = false;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // txtDetalle
            // 
            this.txtDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetalle.BackColor = System.Drawing.SystemColors.Window;
            this.txtDetalle.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.txtDetalle.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDetalle.BorderRadius = 10;
            this.txtDetalle.BorderSize = 2;
            this.txtDetalle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDetalle.Location = new System.Drawing.Point(36, 159);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDetalle.PasswordChar = false;
            this.txtDetalle.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDetalle.PlaceholderText = "";
            this.txtDetalle.ReadOnly = false;
            this.txtDetalle.Size = new System.Drawing.Size(729, 104);
            this.txtDetalle.TabIndex = 31;
            this.txtDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDetalle.Texts = "";
            this.txtDetalle.UnderlinedStyle = false;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDireccion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(36, 132);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(729, 23);
            this.lblDireccion.TabIndex = 30;
            this.lblDireccion.Text = "Observacion";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmObservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtCreador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbmEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmObservaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmObservaciones";
            this.BarraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private Controles.CustomTextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaInicio;
        private Controles.CustomDataTimePiker dtpFechaInicio;
        private Controles.CustomComboBox cbmEstado;
        private System.Windows.Forms.Label lblEstado;
        private Controles.CustomTextBox txtCreador;
        private System.Windows.Forms.Label label2;
        private Controles.CustomButton btnAccion;
        private Controles.CustomTextBox txtDetalle;
        private System.Windows.Forms.Label lblDireccion;
    }
}