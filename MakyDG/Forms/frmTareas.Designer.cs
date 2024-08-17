namespace MakyDG.Forms
{
    partial class frmTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTareas));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cbmResponsable = new MakyDG.Controles.CustomComboBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtProyecto = new MakyDG.Controles.CustomTextBox();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.cbmEstado = new MakyDG.Controles.CustomComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNombre = new MakyDG.Controles.CustomTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaFinalizacion = new System.Windows.Forms.Label();
            this.dtpFechaFinalizacion = new MakyDG.Controles.CustomDataTimePiker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new MakyDG.Controles.CustomDataTimePiker();
            this.btnAccion = new MakyDG.Controles.CustomButton();
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
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 38);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tarea";
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
            // cbmResponsable
            // 
            this.cbmResponsable.BackColor = System.Drawing.Color.White;
            this.cbmResponsable.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.cbmResponsable.BorderSize = 2;
            this.cbmResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmResponsable.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmResponsable.ForeColor = System.Drawing.Color.Black;
            this.cbmResponsable.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbmResponsable.ListBackColor = System.Drawing.Color.White;
            this.cbmResponsable.ListTextColor = System.Drawing.Color.Black;
            this.cbmResponsable.Location = new System.Drawing.Point(367, 80);
            this.cbmResponsable.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbmResponsable.Name = "cbmResponsable";
            this.cbmResponsable.Padding = new System.Windows.Forms.Padding(2);
            this.cbmResponsable.Size = new System.Drawing.Size(200, 34);
            this.cbmResponsable.TabIndex = 21;
            this.cbmResponsable.Texts = "";
            // 
            // lblResponsable
            // 
            this.lblResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResponsable.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsable.Location = new System.Drawing.Point(367, 49);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(200, 23);
            this.lblResponsable.TabIndex = 20;
            this.lblResponsable.Text = "Responsable";
            this.lblResponsable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProyecto
            // 
            this.txtProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProyecto.BackColor = System.Drawing.SystemColors.Window;
            this.txtProyecto.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.txtProyecto.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtProyecto.BorderRadius = 10;
            this.txtProyecto.BorderSize = 2;
            this.txtProyecto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProyecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProyecto.Location = new System.Drawing.Point(7, 80);
            this.txtProyecto.Margin = new System.Windows.Forms.Padding(4);
            this.txtProyecto.Multiline = false;
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProyecto.PasswordChar = false;
            this.txtProyecto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtProyecto.PlaceholderText = "";
            this.txtProyecto.ReadOnly = false;
            this.txtProyecto.Size = new System.Drawing.Size(161, 34);
            this.txtProyecto.TabIndex = 19;
            this.txtProyecto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProyecto.Texts = "";
            this.txtProyecto.UnderlinedStyle = false;
            // 
            // lblProyecto
            // 
            this.lblProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProyecto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyecto.Location = new System.Drawing.Point(7, 49);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(161, 23);
            this.lblProyecto.TabIndex = 18;
            this.lblProyecto.Text = "Proyecto";
            this.lblProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cbmEstado.Location = new System.Drawing.Point(590, 80);
            this.cbmEstado.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbmEstado.Name = "cbmEstado";
            this.cbmEstado.Padding = new System.Windows.Forms.Padding(2);
            this.cbmEstado.Size = new System.Drawing.Size(200, 34);
            this.cbmEstado.TabIndex = 27;
            this.cbmEstado.Texts = "";
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstado.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(590, 49);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(200, 23);
            this.lblEstado.TabIndex = 26;
            this.lblEstado.Text = "Estado";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txtNombre.Location = new System.Drawing.Point(186, 80);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.ReadOnly = false;
            this.txtNombre.Size = new System.Drawing.Size(161, 34);
            this.txtNombre.TabIndex = 29;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = false;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(186, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(161, 23);
            this.lblNombre.TabIndex = 28;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaFinalizacion
            // 
            this.lblFechaFinalizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaFinalizacion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinalizacion.Location = new System.Drawing.Point(465, 135);
            this.lblFechaFinalizacion.Name = "lblFechaFinalizacion";
            this.lblFechaFinalizacion.Size = new System.Drawing.Size(239, 23);
            this.lblFechaFinalizacion.TabIndex = 33;
            this.lblFechaFinalizacion.Text = "Fecha Finalizacion";
            this.lblFechaFinalizacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFechaFinalizacion
            // 
            this.dtpFechaFinalizacion.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.dtpFechaFinalizacion.BorderSize = 1;
            this.dtpFechaFinalizacion.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinalizacion.Location = new System.Drawing.Point(465, 161);
            this.dtpFechaFinalizacion.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFechaFinalizacion.Name = "dtpFechaFinalizacion";
            this.dtpFechaFinalizacion.Size = new System.Drawing.Size(239, 35);
            this.dtpFechaFinalizacion.SkinColor = System.Drawing.Color.White;
            this.dtpFechaFinalizacion.TabIndex = 32;
            this.dtpFechaFinalizacion.TextColor = System.Drawing.Color.Black;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaInicio.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(56, 135);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(239, 23);
            this.lblFechaInicio.TabIndex = 31;
            this.lblFechaInicio.Text = "Fecha Inicio";
            this.lblFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.dtpFechaInicio.BorderSize = 1;
            this.dtpFechaInicio.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(56, 161);
            this.dtpFechaInicio.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(239, 35);
            this.dtpFechaInicio.SkinColor = System.Drawing.Color.White;
            this.dtpFechaInicio.TabIndex = 30;
            this.dtpFechaInicio.TextColor = System.Drawing.Color.Black;
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
            this.btnAccion.Location = new System.Drawing.Point(313, 231);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(139, 47);
            this.btnAccion.TabIndex = 34;
            this.btnAccion.Text = "Aceptar";
            this.btnAccion.TextColor = System.Drawing.Color.White;
            this.btnAccion.UseVisualStyleBackColor = false;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // frmTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 308);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.lblFechaFinalizacion);
            this.Controls.Add(this.dtpFechaFinalizacion);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cbmEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbmResponsable);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.txtProyecto);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTareas";
            this.BarraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private Controles.CustomComboBox cbmResponsable;
        private System.Windows.Forms.Label lblResponsable;
        private Controles.CustomTextBox txtProyecto;
        private System.Windows.Forms.Label lblProyecto;
        private Controles.CustomComboBox cbmEstado;
        private System.Windows.Forms.Label lblEstado;
        private Controles.CustomTextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaFinalizacion;
        private Controles.CustomDataTimePiker dtpFechaFinalizacion;
        private System.Windows.Forms.Label lblFechaInicio;
        private Controles.CustomDataTimePiker dtpFechaInicio;
        private Controles.CustomButton btnAccion;
    }
}