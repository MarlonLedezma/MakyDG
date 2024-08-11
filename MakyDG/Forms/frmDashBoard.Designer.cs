namespace MakyDG.Forms
{
    partial class frmDashBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashBoard));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnCrearProyecto = new MakyDG.Controles.CustomButton();
            this.cbmProyecto = new MakyDG.Controles.CustomComboBox();
            this.BarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BarraTitulo.Controls.Add(this.btnCrearProyecto);
            this.BarraTitulo.Controls.Add(this.lblTitulo);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnMaximizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Controls.Add(this.btnRestaurar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(957, 38);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            this.BarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseMove);
            this.BarraTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseUp);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(6, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 24);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "MakyDG";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::MakyDG.Properties.Resources.Minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(846, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(29, 30);
            this.btnMinimizar.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnMinimizar, "Minimizar la Ventana");
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = global::MakyDG.Properties.Resources.Maximizar;
            this.btnMaximizar.Location = new System.Drawing.Point(882, 4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(34, 30);
            this.btnMaximizar.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnMaximizar, "Maximizar la Ventana");
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::MakyDG.Properties.Resources.Close;
            this.btnCerrar.Location = new System.Drawing.Point(922, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 30);
            this.btnCerrar.TabIndex = 0;
            this.toolTip.SetToolTip(this.btnCerrar, "Cerrar Aplicacion");
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = global::MakyDG.Properties.Resources.Restaurar;
            this.btnRestaurar.Location = new System.Drawing.Point(882, 4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(34, 30);
            this.btnRestaurar.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnRestaurar, "Restaurar la Ventana");
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.BackColor = System.Drawing.Color.White;
            this.toolTip.ForeColor = System.Drawing.Color.Black;
            this.toolTip.InitialDelay = 200;
            this.toolTip.ReshowDelay = 100;
            // 
            // btnCrearProyecto
            // 
            this.btnCrearProyecto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCrearProyecto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCrearProyecto.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCrearProyecto.BorderColor = System.Drawing.Color.Orange;
            this.btnCrearProyecto.BorderRadius = 15;
            this.btnCrearProyecto.BorderSize = 0;
            this.btnCrearProyecto.FlatAppearance.BorderSize = 0;
            this.btnCrearProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearProyecto.ForeColor = System.Drawing.Color.White;
            this.btnCrearProyecto.Location = new System.Drawing.Point(421, 3);
            this.btnCrearProyecto.Name = "btnCrearProyecto";
            this.btnCrearProyecto.Size = new System.Drawing.Size(134, 31);
            this.btnCrearProyecto.TabIndex = 6;
            this.btnCrearProyecto.Text = "Crear Proyecto";
            this.btnCrearProyecto.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btnCrearProyecto, "Crear un Nuevo Proyecto");
            this.btnCrearProyecto.UseVisualStyleBackColor = false;
            // 
            // cbmProyecto
            // 
            this.cbmProyecto.BackColor = System.Drawing.Color.White;
            this.cbmProyecto.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.cbmProyecto.BorderSize = 2;
            this.cbmProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmProyecto.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmProyecto.ForeColor = System.Drawing.Color.Black;
            this.cbmProyecto.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbmProyecto.Items.AddRange(new object[] {
            "Sarchi",
            "Grecia",
            "Naranjo",
            "San Jose",
            "Cartago",
            "Belen",
            "Heredia"});
            this.cbmProyecto.ListBackColor = System.Drawing.Color.White;
            this.cbmProyecto.ListTextColor = System.Drawing.Color.Black;
            this.cbmProyecto.Location = new System.Drawing.Point(6, 47);
            this.cbmProyecto.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbmProyecto.Name = "cbmProyecto";
            this.cbmProyecto.Padding = new System.Windows.Forms.Padding(2);
            this.cbmProyecto.Size = new System.Drawing.Size(200, 30);
            this.cbmProyecto.TabIndex = 1;
            this.cbmProyecto.Texts = "Seleccione el Proyecto";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 481);
            this.Controls.Add(this.cbmProyecto);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.BarraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Label lblTitulo;
        private Controles.CustomButton btnCrearProyecto;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnRestaurar;
        private Controles.CustomComboBox cbmProyecto;
    }
}