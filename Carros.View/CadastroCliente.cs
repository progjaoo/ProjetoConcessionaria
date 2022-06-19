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
    public partial class CadastroCliente : Form
    {
        private ControleClientes _Control = new ControleClientes();
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void CarregaCombo()
        {
            dgvCliente.DataSource = _Control.SelecionarTodos();
        }

        private void LimpaCampos()
        {
            txtNome.Text = "";
            MskdClienteCPF.Text = "";
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            CarregaCombo();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Model.Clientes oCliente = new Model.Clientes();
            if (btnAdicionar.Text == "Readicionar")
            {
                oCliente.NomeCliente = txtNome.Text;
                oCliente.Cpf = MskdClienteCPF.Text;
                oCliente.IdCliente = Convert.ToInt32(dgvCliente.Rows[0].Cells[0].Value);
                
                btnAdicionar.Text = "Adicionar";
                _Control.Alterar(oCliente);
                btnCancelar.Visible = false;
            }
            else
            {
                oCliente.NomeCliente = txtNome.Text;
                oCliente.Cpf = MskdClienteCPF.Text;

                _Control.Incluir(oCliente);
            }
            CarregaCombo();
            LimpaCampos();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text.Length > 0)
            {
                dgvCliente.DataSource = _Control.PesquisarNome(txtPesquisa.Text);
            }
            else
            {
                CarregaCombo();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int ind = dgvCliente.CurrentCell.RowIndex;
            string id = Convert.ToString(dgvCliente.Rows[ind].Cells[0].Value);
            int idF = int.Parse(id);
            _Control.Remover(idF);
            CarregaCombo();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAdicionar.Text = "Readicionar";
            int ind = dgvCliente.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvCliente.Rows[ind].Cells[0].Value);
            string nome = Convert.ToString(dgvCliente.Rows[ind].Cells[1].Value).TrimEnd();
            string cpf = Convert.ToString(dgvCliente.Rows[ind].Cells[2].Value).TrimEnd();

            dgvCliente.DataSource = _Control.SelecionarUm(id);

            txtNome.Text = nome;
            MskdClienteCPF.Text = cpf;
            btnCancelar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CarregaCombo();
            LimpaCampos();
            btnAdicionar.Text = "Adicionar";
            btnCancelar.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}