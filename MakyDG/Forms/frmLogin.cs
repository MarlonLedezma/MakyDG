using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica_de_Negocios.Login;
using MakyDG.Controles;

namespace MakyDG.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LN_Login lnLogin = new LN_Login();
            if (txtUserName.Texts == "" || txtPassWord.Texts =="")
            {
                MessageBoxCus.Show
            }
            if (lnLogin.ValidarUsuario(txtUserName.Texts, txtPassWord.Texts))
            {
                this.Hide();
                frmDashBoard frmDashBoard = new frmDashBoard();
                frmDashBoard.Show();
            }
            else
            {
                MessageBoxCus.Show("Usuario o contraseña incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
