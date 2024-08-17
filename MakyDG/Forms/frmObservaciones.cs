using Logica_de_Negocios.Observacion;
using MakyDG.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades.Cache;
using Utilidades.Clase;

namespace MakyDG.Forms
{
    public partial class frmObservaciones : Form
    {
        int IdObservacion = 0;
        int IdProyecto;
        int IdTarea;
        string Operacion = "Insertar";

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

        public frmObservaciones()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void CargarDatos(int IdProyecto, int IdTarea, DateTime Fecha) 
        {
            this.IdProyecto = IdProyecto;
            this.IdTarea = IdTarea;
            txtCreador.Texts = UsuarioCache.Nombre;
            dtpFechaInicio.Value = Fecha;
        }
        public void CargarObservacion(int IdObservacion) 
        {
            this.IdObservacion = IdObservacion;
            Operacion = "Actualizar";
            LN_Observacion objLN = new LN_Observacion();
            DataTable dt = objLN.ListaObservacacionxId(IdObservacion);
            if (dt.Rows.Count > 0) 
            {
                txtNombre.Texts = dt.Rows[0]["Nombre"].ToString();
                txtDetalle.Texts = dt.Rows[0]["Detalle"].ToString();
                cbmEstado.ValueMember = dt.Rows[0]["Estado"].ToString();
                txtCreador.Texts = dt.Rows[0]["Creador"].ToString();
                dtpFechaInicio.Value = Convert.ToDateTime(dt.Rows[0]["Fecha"].ToString());
            }
        }
        private bool ValidarDatos()
        {
            if (txtDetalle.Texts == "")
            {
                MessageBoxCus.Show("Debe ingresar una observación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNombre.Texts == "")
            {
                MessageBoxCus.Show("Debe ingresar un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private (bool, clsObservacion) CargarClaseObservacion()
        {
            clsObservacion Observacion = new clsObservacion();
            Observacion.IdObservacion = IdObservacion;
            Observacion.IdTarea = IdTarea;
            Observacion.IdProyecto = IdProyecto;
            Observacion.Nombre = txtNombre.Texts;
            Observacion.Detalle = txtDetalle.Texts;
            Observacion.Responsable = UsuarioCache.IdUsuario;
            Observacion.Fecha = Convert.ToDateTime(dtpFechaInicio.Value.ToString("dd/MM/yyyy"));
            Observacion.Estado = cbmEstado.Texts;
            return (true, Observacion);
        }
        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var (Valido, Observacion) = CargarClaseObservacion();
                if (Valido) 
                {
                    if (Operacion == "Insertar")
                    {
                        LN_Observacion objLN = new LN_Observacion();
                        if (objLN.InsertarObservacion(Observacion))
                        {
                            MessageBoxCus.Show("Observación Creada correctamente", "Observación Creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ActualizarObservacionesDashBoard();
                            LimpiarCampos();
                            this.Close();
                        }
                        else
                        {
                            MessageBoxCus.Show("Error al insertar la observación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (Operacion == "Actualizar")
                    {
                        LN_Observacion objLN = new LN_Observacion();
                        if (objLN.ActualizarObservacion(Observacion))
                        {
                            MessageBoxCus.Show("Observación Actualizada correctamente", "Observación Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ActualizarObservacionesDashBoard();
                            LimpiarCampos();
                            this.Close();
                        }
                        else
                        {
                            MessageBoxCus.Show("Error al actualizar la observación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                } 
            }
        }
        private void ActualizarObservacionesDashBoard()
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmDashBoard);
            if (frm != null)
            {
                ((frmDashBoard)frm).cbmProyecto_OnSelectedIndexChanged(null, null);
            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Texts = "";
            txtDetalle.Texts = "";
            cbmEstado.Texts = "";
        }

    }
}
