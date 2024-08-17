using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica_de_Negocios.Observacion;
using Logica_de_Negocios.Proyecto;
using Logica_de_Negocios.Tarea;
using MakyDG.Controles;

namespace MakyDG.Forms
{
    public partial class frmDashBoard : Form
    {
        #region Variables
        DataTable dtObservaciones = new DataTable();
        LN_Proyecto lnProyecto = new LN_Proyecto();
        #endregion

        #region Constructor
        public frmDashBoard()
        {
            InitializeComponent();
        }
        #endregion

        #region Barra de Título

        #region Mover Formulario
        #region Variables
        // Variables Mover Formulario
        private bool dragging = false;
        private Point offset;
        #endregion

        #region Eventos Move
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                offset = new Point(e.X, e.Y);
            }
        }

        private void BarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = this.PointToScreen(e.Location);
                this.Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void BarraTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
            }
        }
        #endregion
        #endregion

        #region Botones Cerrar, Maximizar y Minimizar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #endregion

        public void frmDashBoard_Load(object sender, EventArgs e)
        {
            //Cargar Proyectos
            LN_Proyecto lnProyecto = new LN_Proyecto();
            //Limpiar Combobox
            cbmProyecto.DataSource = null;
            cbmProyecto.Items.Clear();

            //Limpiar Datagridview
            dgvTareas.Rows.Clear();
            dgvTareas.Columns.Clear();

            //Cargar Proyectos
            cbmProyecto.DataSource = lnProyecto.ListProyectos();
            cbmProyecto.DisplayMember = "Nombre";
            cbmProyecto.ValueMember = "IdProyecto";

        }
        public void cbmProyecto_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            //Cargar Direccion y Cliente
            if (cbmProyecto.SelectedIndex != -1)
            {
                DataRowView dr = (DataRowView)cbmProyecto.SelectedItem;
                txtDireccion.Texts = dr["Direccion"].ToString();
                txtCliente.Texts = dr["Cliente"].ToString();
                ConfigDGV();
            }
        }
        private void ConfigDGV() 
        {
            dgvTareas.SuspendLayout();
            //Limpiar DGV
            dgvTareas.Rows.Clear();
            dgvTareas.Columns.Clear();

            //Ajustar Tamaño de las Celdas del DGV al Tamaño del Contenido
            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //Obtener Fehas
            DataRowView dr = (DataRowView)cbmProyecto.SelectedItem;
            DateTime FechaInicio = Convert.ToDateTime(dr["Inicio"]);
            DateTime FechaFin = Convert.ToDateTime(dr["Finalizacion"]);

            //Calcular Días
            int Dias = (FechaFin - FechaInicio).Days;

            //Crear Columnas
            dgvTareas.Columns.Add("Id", "id");
            dgvTareas.Columns.Add("Tarea", "Tarea");
            dgvTareas.Columns.Add("FechaInicio", "FechaInicio");
            dgvTareas.Columns.Add("FechaFin", "FechaFin");
            dgvTareas.Columns.Add("Responsable", "Responsable");
            dgvTareas.Columns.Add("Estado", "Estado");

            //Ocultar Columnas
            dgvTareas.Columns["Id"].Visible = false;

            //Agregar los Dias Como Columnas
            for (int i = 0; i <= Dias; i++)
            {
                dgvTareas.Columns.Add(FechaInicio.AddDays(i).ToString("dd/MM/yyyy"), FechaInicio.AddDays(i).ToString("dd/MM/yyyy"));
            }

            //Agregar Proyecto al DGV
            AgregarProyectodgv();

            //Agregar Tareas al DGV
            AgregarTareas();

            dgvTareas.ResumeLayout();


        }
        private void AgregarProyectodgv()
        {
            //Agregar Proyecto al DGV
            DataRowView dr = (DataRowView)cbmProyecto.SelectedItem;
            dgvTareas.Rows.Add(dr["IdProyecto"],"Proyecto: "+dr["Nombre"].ToString(), Convert.ToDateTime(dr["Inicio"]).ToString("dd/MM/yyyy"), Convert.ToDateTime(dr["Finalizacion"]).ToString("dd/MM/yyyy"), dr["Responsable"].ToString(), dr["Estado"].ToString());

            //Marcar las Celdas de las Fechas en Verde
            for (int i = 0; i < dgvTareas.Columns.Count; i++)
            {
                if (dgvTareas.Columns[i].Name != "Tarea" && dgvTareas.Columns[i].Name != "FechaInicio" && dgvTareas.Columns[i].Name != "FechaFin" && dgvTareas.Columns[i].Name != "Responsable" && dgvTareas.Columns[i].Name != "Estado")
                {
                    dgvTareas.Rows[dgvTareas.Rows.Count - 2].Cells[i].Style.BackColor = Color.Aqua;
                }
            }

        }
        private void AgregarTareas()
        {
            DataTable dtTareas = new DataTable();
            DataRowView dr = (DataRowView)cbmProyecto.SelectedItem;
            int IdProyecto = Convert.ToInt32(dr["IdProyecto"]);

            // Cargar Tareas
            LN_Tarea lnTarea = new LN_Tarea();
            dtTareas = lnTarea.ListarTareas(IdProyecto);

            // Recorrer Tareas
            foreach (DataRow row in dtTareas.Rows)
            {
                DateTime fechaInicio, fechaFin;

                if (DateTime.TryParse(row["Inicializacion"].ToString(), out fechaInicio) &&
                    DateTime.TryParse(row["Finalizacion"].ToString(), out fechaFin))
                {
                    dgvTareas.Rows.Add(
                        row["IdTarea"].ToString(),
                        row["Nombre"].ToString(),
                        fechaInicio.ToString("dd/MM/yyyy"),
                        fechaFin.ToString("dd/MM/yyyy"),
                        row["Responsable"].ToString(),
                        row["Estado"].ToString()
                    );
                }
            }

            // Pintar las Celdas de las Fechas en Verde
            for (int i = 0; i < dgvTareas.Columns.Count; i++)
            {
                if (dgvTareas.Columns[i].Name != "Tarea" && dgvTareas.Columns[i].Name != "FechaInicio" && dgvTareas.Columns[i].Name != "FechaFin" && dgvTareas.Columns[i].Name != "Responsable" && dgvTareas.Columns[i].Name != "Estado")
                {
                    for (int j = 1; j < dgvTareas.Rows.Count; j++) // Empezar desde la segunda fila
                    {
                        DateTime fechaInicio, fechaFin, fechaColumna;

                        if (DateTime.TryParse(dgvTareas.Rows[j].Cells["FechaInicio"].Value?.ToString(), out fechaInicio) &&
                            DateTime.TryParse(dgvTareas.Rows[j].Cells["FechaFin"].Value?.ToString(), out fechaFin) &&
                            DateTime.TryParse(dgvTareas.Columns[i].Name, out fechaColumna))
                        {
                            if (fechaColumna >= fechaInicio && fechaColumna <= fechaFin)
                            {
                                dgvTareas.Rows[j].Cells[i].Style.BackColor = Color.LightGreen;
                            }
                        }
                    }
                }
            }

            // Cargar Observaciones
            LN_Observacion lnObservacion = new LN_Observacion();
            dtObservaciones = lnObservacion.ListarObservaciones(IdProyecto);

            //Recorrer el Datagridview en Filas
            for (int i = 1; i < dgvTareas.Rows.Count-1; i++)
            {
                //Recorrer el Datagridview en Columnas
                for (int j = 1; j < dgvTareas.Columns.Count; j++)
                {
                    //Verificar si la Columna es una Fecha
                    if (dgvTareas.Columns[j].Name != "Tarea" && dgvTareas.Columns[j].Name != "FechaInicio" && dgvTareas.Columns[j].Name != "FechaFin" && dgvTareas.Columns[j].Name != "Responsable" && dgvTareas.Columns[j].Name != "Estado")
                    {
                        //Verificar si la Fecha de la Columna esta entre la Fecha de Inicio y la Fecha de Fin de la Tarea
                        DateTime fechaInicio, fechaFin, fechaColumna;
                        if (DateTime.TryParse(dgvTareas.Rows[i].Cells["FechaInicio"].Value?.ToString(), out fechaInicio) &&
                            DateTime.TryParse(dgvTareas.Rows[i].Cells["FechaFin"].Value?.ToString(), out fechaFin) &&
                            DateTime.TryParse(dgvTareas.Columns[j].Name, out fechaColumna))
                        {
                            if (fechaColumna >= fechaInicio && fechaColumna <= fechaFin)
                            {
                                //Verificar si hay Observaciones para esta Tarea en la Fecha de la Columna
                                int IdTarea = Convert.ToInt32(dgvTareas.Rows[i].Cells["Id"].Value);
                                DataRow[] observaciones = dtObservaciones.Select($"IdTarea = {IdTarea} AND Fecha = '{fechaColumna:yyyy-MM-dd}'");

                                if (observaciones.Length > 0)
                                {
                                    string estado = observaciones[0]["Estado"].ToString();

                                    if (estado == "Verde")
                                        dgvTareas.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;
                                    else if (estado == "Amarillo")
                                        dgvTareas.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                                    else if (estado == "Rojo")
                                        dgvTareas.Rows[i].Cells[j].Style.BackColor = Color.Red;
                                }
                            }
                        }
                    }
                }
            }
            //Deseleccionar la Celda Seleccionada
            dgvTareas.ClearSelection();
        }
        private void dgvTareas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Primero Verificar si la Columna es una Fecha
            try
            {
                if (dgvTareas.Columns[e.ColumnIndex].Name != "Tarea" && dgvTareas.Columns[e.ColumnIndex].Name != "FechaInicio" && dgvTareas.Columns[e.ColumnIndex].Name != "FechaFin" && dgvTareas.Columns[e.ColumnIndex].Name != "Responsable" && dgvTareas.Columns[e.ColumnIndex].Name != "Estado")
                {
                    if (e.RowIndex > 0)
                    {
                        //Validar que la Celda Tenga un Color
                        if (dgvTareas.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.LightGreen || dgvTareas.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Yellow || dgvTareas.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Red)
                        {
                            if (dgvTareas.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.LightGreen)
                            {
                                //Buscar en dtObservaciones la Observacion Cuya Fecha Concida con la Columna y la Tarea
                                DateTime fechaColumna = Convert.ToDateTime(dgvTareas.Columns[e.ColumnIndex].Name);
                                int IdTarea = Convert.ToInt32(dgvTareas.Rows[e.RowIndex].Cells["Id"].Value);
                                DataRow[] observaciones = dtObservaciones.Select($"IdTarea = {IdTarea} AND Fecha = '{fechaColumna:yyyy-MM-dd}'");
                                if (dgvTareas.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Yellow)
                                {
                                    string result = MessageBoxCus.Show("Observación: " + observaciones[0]["Nombre"].ToString() + "\n" + observaciones[0]["Detalle"].ToString()+", Desea Editar la Obeservacion", "Complicacion " + "\n" + "Creada Por: " + observaciones[0]["Creador"], MessageBoxIcon.Warning, "Editar","Cancelar","");
                                    if (result == "Editar")
                                    {
                                        Operacion = "Editar";
                                        btnObservacion_Click(sender, e);
                                    }
                                }
                                if (dgvTareas.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Red)
                                {
                                    string result =  MessageBoxCus.Show("Observación: " + observaciones[0]["Nombre"].ToString() + "\n" + observaciones[0]["Detalle"].ToString() + ", Desea Editar la Obeservacion", "Complicacion Fatal " + "\n" + "Creada Por: " + observaciones[0]["Creador"], MessageBoxIcon.Error, "Editar", "Cancelar", "");
                                    if (result == "Editar")
                                    {
                                        Operacion = "Editar";
                                        btnObservacion_Click(sender, e);
                                    }
                                }

                            }
                            else
                            {
                                string result = MessageBoxCus.Show("La Tarea esta Completada Con Exito, Desea agregar una Nueva Observacion", "Acción",MessageBoxIcon.Information ,"Nuevo", "Cancelar", "");
                                if (result == "Nuevo")
                                {
                                    Operacion = "Insertar";
                                    btnObservacion_Click(sender, e);
                                }
                                
                            }

                        }
                        else
                        {
                            MessageBoxCus.Show("No se puede Acceder a las observaciónes en una fecha que no corresponda a la tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBoxCus.Show("No se puede agregar una observación al Proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBoxCus.Show("Error Celda Invalida, Verifique que sea Detro de una Fecha de la Tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
            }
            
        }
        private void dgvTareas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Restaurar el color de fondo cuando una celda es seleccionada
            if (e.CellStyle.BackColor != Color.Empty)
            {
                e.CellStyle.SelectionBackColor = e.CellStyle.BackColor;
            }
        }
        private void btnCrearProyecto_Click(object sender, EventArgs e)
        {
            frmProyecto frmProyecto = new frmProyecto();
            frmProyecto.ShowDialog();

        }
        private void crearProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProyecto frmProyecto = new frmProyecto();
            frmProyecto.ShowDialog();
        }
        private void editarProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProyecto frmProyecto = new frmProyecto();
            DataRowView dr = (DataRowView)cbmProyecto.SelectedItem;
            int IdProyecto = Convert.ToInt32(dr["IdProyecto"]);
            frmProyecto.CargarProyecto(IdProyecto) ;
            frmProyecto.ShowDialog();
        }
        private void btnTarea_Click(object sender, EventArgs e)
        {
            if (MessageBoxCus.Show("La Tarea se Asigna al Proyecto Actualmente Seleccionado", "Accion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                frmTareas frmTarea = new frmTareas();
                DataRowView dr = (DataRowView)cbmProyecto.SelectedItem;
                int IdProyecto = Convert.ToInt32(dr["IdProyecto"]);
                frmTarea.CargargarNombreProyecto(IdProyecto);
                frmTarea.ShowDialog();
            }
        }
        private void eliminarProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBoxCus.Show("¿Está seguro de que desea eliminar el proyecto?", "Eliminar Proyecto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DataRowView dr = (DataRowView)cbmProyecto.SelectedItem;
                    int IdProyecto = Convert.ToInt32(dr["IdProyecto"]);
                    lnProyecto.EliminarProyecto(IdProyecto);
                    txtCliente.Texts = "";
                    txtDireccion.Texts = "";
                    frmDashBoard_Load(sender, e);
                    
                }
                catch(Exception ex) 
                {
                    MessageBoxCus.Show("Error al eliminar el proyecto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTarea_Click(sender, e);
        }
        private void editarTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvTareas.SelectedRows.Count > 0)
            {
                //Verificar que no sea la Primera Fila (Proyecto)
                if (dgvTareas.SelectedRows[0].Index > 0)
                {
                    //Obtener el Id de la Tarea
                    int IdTarea = Convert.ToInt32(dgvTareas.SelectedRows[0].Cells["Id"].Value);
                    frmTareas frmTarea = new frmTareas();
                    frmTarea.CargarTarea(IdTarea);
                    frmTarea.ShowDialog();
                }
                else
                {
                    MessageBoxCus.Show("No se puede editar el Proyecto como Tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBoxCus.Show("Seleccione una tarea para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void eliminarTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvTareas.SelectedRows.Count > 0)
            {
                //Verificar que no sea la Primera Fila (Proyecto)
                if (dgvTareas.SelectedRows[0].Index > 0)
                {
                    //Obtener el Id de la Tarea
                    int IdTarea = Convert.ToInt32(dgvTareas.SelectedRows[0].Cells["Id"].Value);
                    if (MessageBoxCus.Show("¿Está seguro de que desea eliminar la tarea?", "Eliminar Tarea", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            LN_Tarea lnTarea = new LN_Tarea();
                            lnTarea.EliminarTarea(IdTarea);
                            cbmProyecto_OnSelectedIndexChanged(sender, e);

                        }
                        catch (Exception ex)
                        {
                            MessageBoxCus.Show("Error al eliminar la tarea: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBoxCus.Show("No se puede eliminar el Proyecto como Tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBoxCus.Show("Seleccione una tarea para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string Operacion { get; set; }
        private void btnObservacion_Click(object sender, EventArgs e)
        {
            frmObservaciones frmObservaciones = new frmObservaciones();
            DataRowView dr = (DataRowView)cbmProyecto.SelectedItem;
            int IdProyecto = Convert.ToInt32(dr["IdProyecto"]);
            //Obtener id de la tarea
            int IdTarea = Convert.ToInt32(dgvTareas.SelectedRows[0].Cells["Id"].Value);
            //Obtener la fecha de la columna seleccionada
            DateTime fechaColumna = Convert.ToDateTime(dgvTareas.Columns[dgvTareas.CurrentCell.ColumnIndex].Name);
            if(Operacion == "Insertar") 
            {
                frmObservaciones.CargarDatos(IdProyecto, IdTarea, fechaColumna);
            }
            else if (Operacion == "Editar") 
            {
                //Buscar en dtObservaciones la Observacion Cuya Fecha Concida con la Columna y la Tarea
                DataRow[] observaciones = dtObservaciones.Select($"IdTarea = {IdTarea} AND Fecha = '{fechaColumna:yyyy-MM-dd}'");
                frmObservaciones.CargarObservacion(Convert.ToInt32(observaciones[0]["IdObservacion"]));
            }
            //Quitar la seleccion de la celda
            dgvTareas.ClearSelection();
            frmObservaciones.ShowDialog();
        }

        private void crearObservacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operacion = "Insertar";
            btnObservacion_Click(sender, e);
        }
    }
}
