using Logica_de_Negocios.Tarea;
using Logica_de_Negocios.Usuario;
using Logica_de_Negocios.Proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades.Clase;
using System.Security.Cryptography.X509Certificates;
using MakyDG.Controles;

namespace MakyDG.Forms
{
    public partial class frmTareas : Form
    {
        public int _IdProyecto { get; set; }
        public int _IdTarea { get; set; }
        public string Operacion = "Agregar";
        LN_Tarea objLN_Tarea = new LN_Tarea();

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
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #endregion

        public frmTareas()
        {
            InitializeComponent();
            CargarResponsables();
            LimpiarCampos();

        }
        private void CargarResponsables()
        {
            DataTable dt = new DataTable();
            LN_Usuario objLN = new LN_Usuario();
            dt = objLN.ListarUsuarioxEmpresa();
            if (dt.Rows.Count > 0)
            {
                cbmResponsable.DataSource = dt;
                cbmResponsable.DisplayMember = "Nombre";
                cbmResponsable.ValueMember = "IdUsuario";
                cbmResponsable.SelectedIndex = -1;
            }
        }
        public void CargargarNombreProyecto(int IdProyecto)
        {
            
            LN_Proyecto objLN = new LN_Proyecto();
            DataTable dt = new DataTable();
            _IdProyecto = IdProyecto;
            dt = objLN.ListarProyectoxId(_IdProyecto);
            if (dt.Rows.Count > 0)
            {
                txtProyecto.ReadOnly = true;
                txtProyecto.Texts = dt.Rows[0]["Nombre"].ToString().Trim();
            }
        }
        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                var (result, tarea) = CargarClaseTarea();
                if (result) 
                {
                    if (Operacion == "Agregar")
                    {
                        if (objLN_Tarea.CrearTarea(tarea))
                        {
                            MessageBoxCus.Show("Tarea agregada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                            ActualizarcmbProyectos();
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar la tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else 
                    {
                        tarea.IdTarea = _IdTarea;
                        if (objLN_Tarea.ActualizarTarea(tarea))
                        {
                            MessageBoxCus.Show("Tarea actualizada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                            ActualizarcmbProyectos();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar la tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                  
                }
            }
        }
        private bool Validar()
        {
            bool result = true;
            
            if (string.IsNullOrEmpty(txtProyecto.Texts))
            {
                MessageBoxCus.Show("Debe ingresar el nombre de la tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProyecto.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNombre.Texts))
            {
                MessageBoxCus.Show("Debe ingresar la descripción de la tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }
            if (cbmResponsable.SelectedIndex == -1)
            {
                MessageBoxCus.Show("Debe ingresar el Responsable de la tarea, Si Existen Datos Volver a Seleccionar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbmResponsable.Focus();
                return false;
            }
            if (cbmEstado.SelectedIndex == -1)
            {
                MessageBoxCus.Show("Debe ingresar el Estado de la tarea, Si Existen Datos Volver a Seleccionar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbmEstado.Focus();
                return false;
            }
            if (dtpFechaInicio.Value > dtpFechaFinalizacion.Value)
            {
                MessageBoxCus.Show("La fecha de inicio no puede ser mayor a la fecha de fin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaInicio.Focus();
                return false;
            }

            return result;

           
        }
        private (bool, clsTarea tarea) CargarClaseTarea() 
        {
            bool result = false;
            clsTarea tarea = new clsTarea();
            try
            {
               
                DataRowView dr = (DataRowView)cbmResponsable.SelectedItem;
                tarea.IdProyecto = _IdProyecto;
                tarea.Nombre = txtNombre.Texts.ToString().TrimEnd();
                tarea.Responsable = Convert.ToInt32(dr.Row["IdUsuario"]);
                tarea.Estado = cbmEstado.Texts; 
                tarea.Inicializacion = dtpFechaInicio.Value;
                tarea.Finalizacion = dtpFechaFinalizacion.Value;
                result = true;
            }
            catch (Exception ex)
            {
               
            }
            return (result,tarea);
        }
        private void LimpiarCampos()
        {
            if (Operacion == "Agregar")
            {
                txtNombre.Texts = string.Empty;
                dtpFechaInicio.Value = DateTime.Now;
                dtpFechaFinalizacion.Value = DateTime.Now;
            }
        }
        private void ActualizarcmbProyectos()
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmDashBoard);
            if (frm != null)
            {
                ((frmDashBoard)frm).cbmProyecto_OnSelectedIndexChanged(null, null);
            }
        }
        public void CargarTarea(int IdTarea) 
        {
            Operacion = "Actualizar";
            _IdTarea = IdTarea;
            DataTable dt = new DataTable();
            dt = objLN_Tarea.ListarTareaxId(_IdTarea);
            if (dt.Rows.Count > 0)
            {
                txtProyecto.ReadOnly = true;
                CargargarNombreProyecto(Convert.ToInt32(dt.Rows[0]["IdProyecto"]));
                txtNombre.Texts = dt.Rows[0]["Nombre"].ToString();
                cbmResponsable.SelectedValue = dt.Rows[0]["Responsable"].ToString();
                cbmEstado.SelectedItem = dt.Rows[0]["Estado"].ToString();
                dtpFechaInicio.Value = Convert.ToDateTime(dt.Rows[0]["Inicializacion"]);
                dtpFechaFinalizacion.Value = Convert.ToDateTime(dt.Rows[0]["Finalizacion"]);
            }
        }
    }
}
