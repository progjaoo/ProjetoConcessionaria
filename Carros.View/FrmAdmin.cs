using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carros.View
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        CadastroConcessionaria conc = new CadastroConcessionaria();
        CadastroVenda vend = new CadastroVenda();
        CadastroFuncionario func = new CadastroFuncionario();
        CadastroCarro carr = new CadastroCarro();
        CadastroCliente cli = new CadastroCliente();
        login2 log = new login2();
        VisualizarTabelas vis = new VisualizarTabelas();


        public void loginadmin(string usuario)
        {
            btnFunc.Visible = true;
            btnConcess.Visible = true;
            btnCarros.Visible = true;
            btnLogin.Visible = false;
            btnTabelas.Visible = false;
            lblUsuario.Text = usuario;
            lblUsuario.BackColor = Color.Green;
            fecharform();
        }
        public void loginfunc(string usuario)
        {
            btnCliente.Visible = true;
            btnVendas.Visible = true;
            btnLogin.Visible = false;
            btnTabelas.Visible = true;
            lblUsuario.Text = usuario;
            lblUsuario.BackColor = Color.Green;
            fecharform();
        }

        private void desconect()
        {
            botoesinvisiveis();
            btnLogin.Visible = true;
            fecharform();
            lblUsuario.Text = "Desconectado";
            lblUsuario.BackColor = Color.Red;
        }

        private void fecharform()
        {
            conc.Hide();
            vend.Hide();
            func.Hide();
            carr.Hide();
            cli.Hide();
            log.Hide();
            vis.Hide();
        }
        private void botoesinvisiveis()
        {
            btnCliente.Visible = false;
            btnVendas.Visible = false;
            btnFunc.Visible = false;
            btnConcess.Visible = false;
            btnCarros.Visible = false;
            btnTabelas.Visible = false;
        }
        private void desabilitacampos()
        {
            btnCliente.Visible = false;
            btnVendas.Visible = false;
            btnLogin.Visible = false;
            btnTabelas.Visible = false;
        }

        private void btnConcess_Click(object sender, EventArgs e)
        {
            conc.MdiParent = this;
            fecharform();
            conc.Show();
        }
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            desabilitacampos();
            desconect();
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            func.MdiParent = this;
            fecharform();
            func.Show();
        }
        private void btnCarros_Click(object sender, EventArgs e)
        {   
            carr.MdiParent = this;
            fecharform();
            carr.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            cli.MdiParent = this;
            fecharform();
            cli.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            vend.MdiParent = this;
            fecharform();
            vend.Show();
        }

        private void btnDesconect_Click(object sender, EventArgs e)
        {
            desconect();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            log.MdiParent = this;
            fecharform();
            log.Show();
        }

        private void btnTabelas_Click(object sender, EventArgs e)
        {
            vis.MdiParent = this;
            fecharform();
            vis.Show();
        }
    }
}
