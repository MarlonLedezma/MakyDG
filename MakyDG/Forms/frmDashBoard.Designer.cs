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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashBoard));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnTarea = new MakyDG.Controles.CustomButton();
            this.btnCrearProyecto = new MakyDG.Controles.CustomButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblProyeto = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.proyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbVerde = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCliente = new MakyDG.Controles.CustomTextBox();
            this.txtDireccion = new MakyDG.Controles.CustomTextBox();
            this.cbmProyecto = new MakyDG.Controles.CustomComboBox();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BarraTitulo.Controls.Add(this.btnTarea);
            this.BarraTitulo.Controls.Add(this.btnCrearProyecto);
            this.BarraTitulo.Controls.Add(this.lblTitulo);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnMaximizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Controls.Add(this.btnRestaurar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1414, 38);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            this.BarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseMove);
            this.BarraTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseUp);
            // 
            // btnTarea
            // 
            this.btnTarea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTarea.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTarea.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTarea.BorderColor = System.Drawing.Color.Orange;
            this.btnTarea.BorderRadius = 15;
            this.btnTarea.BorderSize = 0;
            this.btnTarea.FlatAppearance.BorderSize = 0;
            this.btnTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarea.ForeColor = System.Drawing.Color.White;
            this.btnTarea.Location = new System.Drawing.Point(1036, 0);
            this.btnTarea.Name = "btnTarea";
            this.btnTarea.Size = new System.Drawing.Size(134, 31);
            this.btnTarea.TabIndex = 8;
            this.btnTarea.Text = "Tareas";
            this.btnTarea.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btnTarea, "Crear un Nuevo Proyecto");
            this.btnTarea.UseVisualStyleBackColor = false;
            this.btnTarea.Click += new System.EventHandler(this.btnTarea_Click);
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
            this.btnCrearProyecto.Location = new System.Drawing.Point(241, 3);
            this.btnCrearProyecto.Name = "btnCrearProyecto";
            this.btnCrearProyecto.Size = new System.Drawing.Size(134, 31);
            this.btnCrearProyecto.TabIndex = 6;
            this.btnCrearProyecto.Text = "Proyectos";
            this.btnCrearProyecto.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btnCrearProyecto, "Crear un Nuevo Proyecto");
            this.btnCrearProyecto.UseVisualStyleBackColor = false;
            this.btnCrearProyecto.Click += new System.EventHandler(this.btnCrearProyecto_Click);
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
            this.btnMinimizar.Location = new System.Drawing.Point(1303, 4);
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
            this.btnMaximizar.Location = new System.Drawing.Point(1339, 4);
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
            this.btnCerrar.Location = new System.Drawing.Point(1379, 4);
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
            this.btnRestaurar.Location = new System.Drawing.Point(1339, 4);
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
            // lblProyeto
            // 
            this.lblProyeto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyeto.Location = new System.Drawing.Point(10, 44);
            this.lblProyeto.Name = "lblProyeto";
            this.lblProyeto.Size = new System.Drawing.Size(200, 23);
            this.lblProyeto.TabIndex = 4;
            this.lblProyeto.Text = "Proyecto";
            this.lblProyeto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCliente.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(1197, 44);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(205, 23);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDireccion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(237, 44);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(933, 23);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Direccion de Proyecto";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowDrop = true;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.AllowUserToOrderColumns = true;
            this.dgvTareas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTareas.BackgroundColor = System.Drawing.Color.White;
            this.dgvTareas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTareas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTareas.EnableHeadersVisualStyles = false;
            this.dgvTareas.GridColor = System.Drawing.Color.White;
            this.dgvTareas.Location = new System.Drawing.Point(0, 176);
            this.dgvTareas.MultiSelect = false;
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(1412, 411);
            this.dgvTareas.TabIndex = 10;
            this.dgvTareas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareas_CellDoubleClick);
            this.dgvTareas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTareas_CellFormatting);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proyectoToolStripMenuItem,
            this.tareaToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(122, 48);
            // 
            // proyectoToolStripMenuItem
            // 
            this.proyectoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearProyectoToolStripMenuItem,
            this.editarProyectoToolStripMenuItem,
            this.eliminarProyectoToolStripMenuItem});
            this.proyectoToolStripMenuItem.Name = "proyectoToolStripMenuItem";
            this.proyectoToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.proyectoToolStripMenuItem.Text = "Proyecto";
            // 
            // crearProyectoToolStripMenuItem
            // 
            this.crearProyectoToolStripMenuItem.Name = "crearProyectoToolStripMenuItem";
            this.crearProyectoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearProyectoToolStripMenuItem.Text = "Crear Proyecto";
            this.crearProyectoToolStripMenuItem.Click += new System.EventHandler(this.crearProyectoToolStripMenuItem_Click);
            // 
            // editarProyectoToolStripMenuItem
            // 
            this.editarProyectoToolStripMenuItem.Name = "editarProyectoToolStripMenuItem";
            this.editarProyectoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarProyectoToolStripMenuItem.Text = "Editar Proyecto";
            this.editarProyectoToolStripMenuItem.Click += new System.EventHandler(this.editarProyectoToolStripMenuItem_Click);
            // 
            // eliminarProyectoToolStripMenuItem
            // 
            this.eliminarProyectoToolStripMenuItem.Name = "eliminarProyectoToolStripMenuItem";
            this.eliminarProyectoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarProyectoToolStripMenuItem.Text = "Eliminar Proyecto";
            this.eliminarProyectoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProyectoToolStripMenuItem_Click);
            // 
            // tareaToolStripMenuItem
            // 
            this.tareaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.editarTareaToolStripMenuItem,
            this.eliminarTareaToolStripMenuItem});
            this.tareaToolStripMenuItem.Name = "tareaToolStripMenuItem";
            this.tareaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.tareaToolStripMenuItem.Text = "Tarea";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.agregarToolStripMenuItem.Text = "Agregar Tarea";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // editarTareaToolStripMenuItem
            // 
            this.editarTareaToolStripMenuItem.Name = "editarTareaToolStripMenuItem";
            this.editarTareaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.editarTareaToolStripMenuItem.Text = "Editar Tarea";
            this.editarTareaToolStripMenuItem.Click += new System.EventHandler(this.editarTareaToolStripMenuItem_Click);
            // 
            // eliminarTareaToolStripMenuItem
            // 
            this.eliminarTareaToolStripMenuItem.Name = "eliminarTareaToolStripMenuItem";
            this.eliminarTareaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.eliminarTareaToolStripMenuItem.Text = "Eliminar Tarea";
            this.eliminarTareaToolStripMenuItem.Click += new System.EventHandler(this.eliminarTareaToolStripMenuItem_Click);
            // 
            // pbVerde
            // 
            this.pbVerde.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbVerde.BackColor = System.Drawing.Color.LightGreen;
            this.pbVerde.Location = new System.Drawing.Point(288, 107);
            this.pbVerde.Name = "pbVerde";
            this.pbVerde.Size = new System.Drawing.Size(47, 18);
            this.pbVerde.TabIndex = 11;
            this.pbVerde.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox2.Location = new System.Drawing.Point(664, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 18);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.BackColor = System.Drawing.Color.Red;
            this.pictureBox3.Location = new System.Drawing.Point(1060, 107);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 18);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Estado Correcto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Estado Con Complicacion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1002, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Proyecto en Pausa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1412, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "Diagrama de Grantt";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.BackColor = System.Drawing.SystemColors.Window;
            this.txtCliente.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCliente.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCliente.BorderRadius = 10;
            this.txtCliente.BorderSize = 2;
            this.txtCliente.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCliente.Location = new System.Drawing.Point(1197, 69);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Multiline = false;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCliente.PasswordChar = false;
            this.txtCliente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCliente.PlaceholderText = "";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(205, 34);
            this.txtCliente.TabIndex = 9;
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCliente.Texts = "";
            this.txtCliente.UnderlinedStyle = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDireccion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDireccion.BorderRadius = 10;
            this.txtDireccion.BorderSize = 2;
            this.txtDireccion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDireccion.Location = new System.Drawing.Point(237, 69);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDireccion.PasswordChar = false;
            this.txtDireccion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDireccion.PlaceholderText = "";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(933, 34);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDireccion.Texts = "";
            this.txtDireccion.UnderlinedStyle = false;
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
            this.cbmProyecto.ListBackColor = System.Drawing.Color.White;
            this.cbmProyecto.ListTextColor = System.Drawing.Color.Black;
            this.cbmProyecto.Location = new System.Drawing.Point(10, 70);
            this.cbmProyecto.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbmProyecto.Name = "cbmProyecto";
            this.cbmProyecto.Padding = new System.Windows.Forms.Padding(2);
            this.cbmProyecto.Size = new System.Drawing.Size(200, 30);
            this.cbmProyecto.TabIndex = 1;
            this.cbmProyecto.Texts = "Seleccione el Proyecto";
            this.cbmProyecto.OnSelectedIndexChanged += new System.EventHandler(this.cbmProyecto_OnSelectedIndexChanged);
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1414, 590);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbVerde);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblProyeto);
            this.Controls.Add(this.cbmProyecto);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Label lblProyeto;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDireccion;
        private Controles.CustomTextBox txtDireccion;
        private Controles.CustomTextBox txtCliente;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.PictureBox pbVerde;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private Controles.CustomButton btnTarea;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem proyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tareaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarTareaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTareaToolStripMenuItem;
    }
}