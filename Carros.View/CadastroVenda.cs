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
    public partial class CadastroVenda : Form
    {
        private ControleVendas _Control = new ControleVendas();
        public CadastroVenda()
        {
            InitializeComponent();
        }

        public void CarregaCombo()
        {
            dgvVendas.DataSource = _Control.SelecionarTodos();
        }
        public void LimpaCampos()
        {
            txtIDCarro.Text = "";
            txtIDCliente.Text = "";
            txtIDConcessionaria.Text = "";
            txtIDVendedor.Text = "";
        }

        private void CadastroVenda_Load(object sender, EventArgs e)
        {
            CarregaCombo();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Model.Vendas oVenda = new Model.Vendas();
            if (btnAdicionar.Text == "Readicionar")
            {


                oVenda.IdFuncionario = int.Parse(txtIDVendedor.Text);
                oVenda.IdCliente = int.Parse(txtIDCliente.Text);
                oVenda.IdCarro = int.Parse(txtIDCarro.Text);
                oVenda.IdConcessionaria = int.Parse(txtIDConcessionaria.Text);
                oVenda.IdVenda = Convert.ToInt32(dgvVendas.Rows[0].Cells[0].Value);
                
                btnAdicionar.Text = "Adicionar";
                _Control.Alterar(oVenda);
                btnCancelar.Visible = false;
            }
            else
            {
                oVenda.IdFuncionario = int.Parse(txtIDVendedor.Text);
                oVenda.IdCliente = int.Parse(txtIDCliente.Text);
                oVenda.IdCarro = int.Parse(txtIDCarro.Text);
                oVenda.IdConcessionaria = int.Parse(txtIDConcessionaria.Text);

                _Control.Incluir(oVenda);
            }
            CarregaCombo();
            LimpaCampos();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text.Length > 0)
            {
                dgvVendas.DataSource = _Control.PesquisarNome(txtPesquisa.Text);
            }
            else
            {
                CarregaCombo();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int ind = dgvVendas.CurrentCell.RowIndex;
            string id = Convert.ToString(dgvVendas.Rows[ind].Cells[0].Value);
            int idF = int.Parse(id);
            _Control.Remover(idF);
            CarregaCombo();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAdicionar.Text = "Readicionar";
            int ind = dgvVendas.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvVendas.Rows[ind].Cells[0].Value);
            string idf = Convert.ToString(dgvVendas.Rows[ind].Cells[1].Value).TrimEnd();
            string idcl = Convert.ToString(dgvVendas.Rows[ind].Cells[2].Value).TrimEnd();
            string idca = Convert.ToString(dgvVendas.Rows[ind].Cells[3].Value).TrimEnd();
            string idco = Convert.ToString(dgvVendas.Rows[ind].Cells[4].Value).TrimEnd();

            dgvVendas.DataSource = _Control.SelecionarUm(id);

            txtIDCarro.Text = idca;
            txtIDCliente.Text = idcl;
            txtIDVendedor.Text = idf;
            txtIDConcessionaria.Text = idco;
            btnCancelar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CarregaCombo();
            LimpaCampos();
            btnAdicionar.Text = "Adicionar";
            btnCancelar.Visible = false;
        }
    }
}