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
using Logica_de_Negocios;
using Logica_de_Negocios.Usuario;
using Utilidades.Clase;
using Logica_de_Negocios.Proyecto;

namespace MakyDG.Forms
{
    public partial class frmProyecto : Form
    {
        #region Variables
        string Operacion = "Insertar";
        int IdProyecto = 0;
        #endregion

        #region Constructor
        public frmProyecto()
        {
            InitializeComponent();
            CargarResponsables();
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
           this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #endregion

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
        private void btnAccion_Click(object sender, EventArgs e)
        {
            //Validar los campos que no estén vacíos
            if (ValidarCampos())
            {
                try
                {
                    //Cargar Datos en clsProyecto
                    clsProyecto objProyecto = new clsProyecto();
                    DataRowView dr = (DataRowView)cbmResponsable.SelectedItem;
                    objProyecto.IdProyecto = IdProyecto;
                    objProyecto.Nombre = txtNombre.Texts;
                    objProyecto.Responsable = (int)dr["IdUsuario"];
                    objProyecto.Cliente = txtCliente.Texts;
                    objProyecto.Direccion = txtDireccion.Texts;
                    objProyecto.Inicio = Convert.ToDateTime(dtpFechaInicio.Value.ToString("dd/MM/yyyy"));
                    objProyecto.Finalizacion = Convert.ToDateTime(dtpFechaFinalizacion.Value.ToString("dd/MM/yyyy"));
                    objProyecto.Estado = cbmEstado.Texts;
                    //Insertar o Actualizar
                    if (Operacion == "Insertar")
                    {
                        //Insertar
                        LN_Proyecto objLN = new LN_Proyecto();
                        if (objLN.CrearProyecto(objProyecto))
                        {
                            MessageBoxCus.Show("Proyecto Creado correctamente", "Proyecto Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                            ActualizarcmbProyectos();
                        }
                        else
                        {
                            MessageBoxCus.Show("Error al insertar el proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (Operacion == "Actualizar")
                    {
                        //Actualizar
                        LN_Proyecto objLN = new LN_Proyecto();
                        if (objLN.ActualizarProyecto(objProyecto))
                        {
                            MessageBoxCus.Show("Proyecto Actualizado correctamente", "Proyecto Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                            ActualizarcmbProyectos();
                        }
                        else
                        {
                            MessageBoxCus.Show("Error al actualizar el proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBoxCus.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
            }

        }
        private bool ValidarCampos() 
        {
            bool validar = true;
            if (txtNombre.Texts == string.Empty)
            {
                MessageBoxCus.Show("El campo Nombre es obligatorio", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                validar = false;
            }
            else if (txtCliente.Texts == string.Empty)
            {
                MessageBoxCus.Show("El campo Cliente es obligatorio", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                validar = false;
            }
            else if (txtDireccion.Texts == string.Empty)
            {
                MessageBoxCus.Show("El campo Dirección es obligatorio", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccion.Focus();
                validar = false;
            }
            else if (cbmResponsable.SelectedIndex == -1)
            {
                MessageBoxCus.Show("El campo Responsable es obligatorio", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbmResponsable.Focus();
                validar = false;
            }
            else if (dtpFechaInicio.Value > dtpFechaFinalizacion.Value)
            {
                MessageBoxCus.Show("La fecha de Inicio no puede ser mayor a la fecha de Finalización", "Fecha Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaInicio.Focus();
                validar = false;
            }
            else if (cbmEstado.Texts == string.Empty)
            {
                MessageBoxCus.Show("El campo Estado es obligatorio", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validar = false;
            }
            return validar;
        }
        private void LimpiarCampos()
        {
            if (Operacion == "Insertar") 
            {
                txtNombre.Texts = string.Empty;
                txtCliente.Texts = string.Empty;
                txtDireccion.Texts = string.Empty;
                cbmResponsable.SelectedIndex = -1;
                dtpFechaInicio.Value = DateTime.Now;
                dtpFechaFinalizacion.Value = DateTime.Now;
                cbmEstado.SelectedIndex = -1;
            }
        }
        private void ActualizarcmbProyectos() 
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmDashBoard);
            if (frm != null)
            {
                ((frmDashBoard)frm).frmDashBoard_Load(null,null);
            }
        }
        public void CargarProyecto(int Id) 
        {
            Operacion = "Actualizar";
            LN_Proyecto objLN = new LN_Proyecto();
            DataTable dt = objLN.ListarProyectoxId(Id);
            if (dt.Rows.Count > 0)
            {
                IdProyecto = Id;
                txtNombre.Texts = dt.Rows[0]["Nombre"].ToString();
                txtCliente.Texts = dt.Rows[0]["Cliente"].ToString();
                txtDireccion.Texts = dt.Rows[0]["Direccion"].ToString();
                dtpFechaInicio.Value = Convert.ToDateTime(dt.Rows[0]["Inicio"]);
                dtpFechaFinalizacion.Value = Convert.ToDateTime(dt.Rows[0]["Finalizacion"]);
                cbmResponsable.SelectedValue = dt.Rows[0]["Responsable"].ToString();
                cbmEstado.SelectedItem = dt.Rows[0]["Estado"].ToString();
            }
        }
    }
}
