using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakyDG.Forms
{
    public partial class frmDashBoard : Form
    {
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
    }
}
