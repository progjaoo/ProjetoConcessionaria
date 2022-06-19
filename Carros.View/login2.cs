using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carros.View.Control;

namespace Carros.View
{
    public partial class login2 : Form
    {
        private ControleContas _Control = new ControleContas();
        private ControleFuncionarios _ControlF = new ControleFuncionarios();
        public login2()
        {
            InitializeComponent();
        }

        
        public bool tipodeacesso;
        public string nomedeusuario;
        private void limparcampos()
        {
            txtSenha.Text = "";
            txtUsuario.Text = "";
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            var id = _Control.ConfirmarConta(usuario, senha);
            limparcampos();
            if (id == 0)
            {
                MessageBox.Show("Usuario ou Senha Incorretos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (_ControlF.AcharNivel(id) == true)
            {
                ((FrmAdmin)this.MdiParent).loginadmin(usuario);
                return;
            }
            ((FrmAdmin)this.MdiParent).loginfunc(usuario);
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
    }
}
