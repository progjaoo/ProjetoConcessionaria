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
    public partial class CadastroCarro : Form
    {
        private ControleCarros _Control = new ControleCarros();
        public CadastroCarro()
        {
            InitializeComponent();
        }
        public void CarregaCombo()
        {
            dgvCarros.DataSource = _Control.SelecionarTodos();
            
        }

        public void LimpaCampos()
        {
            txtModelo.Text = "";
            txtPreco.Text = "";
        }
       

        private void CadastroCarro_Load(object sender, EventArgs e)
        {
            

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Model.Carros oCarro = new Model.Carros();
            if (btnAdicionar.Text == "Readicionar")
            {
                oCarro.ModeloCarro = txtModelo.Text;
                oCarro.Preco = int.Parse(txtPreco.Text);
                oCarro.IdCarro = Convert.ToInt32(dgvCarros.Rows[0].Cells[0].Value);

                btnAdicionar.Text = "Adicionar";
                _Control.Alterar(oCarro);
                btnCancelar.Visible = false;
            }
            else
            {
                oCarro.ModeloCarro = txtModelo.Text;
                oCarro.Preco = int.Parse(txtPreco.Text);
                _Control.Incluir(oCarro);
            }
            CarregaCombo();
            LimpaCampos();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int ind = dgvCarros.CurrentCell.RowIndex;
            string id = Convert.ToString(dgvCarros.Rows[ind].Cells[0].Value);
            int idF = int.Parse(id);
            _Control.Remover(idF);
            CarregaCombo();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAdicionar.Text = "Readicionar";
            int ind = dgvCarros.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvCarros.Rows[ind].Cells[0].Value);
            string modelo = Convert.ToString(dgvCarros.Rows[ind].Cells[1].Value).TrimEnd();
            string preco = Convert.ToString(dgvCarros.Rows[ind].Cells[2].Value);

            dgvCarros.DataSource = _Control.SelecionarUm(id);

            txtModelo.Text = modelo;
            txtPreco.Text = preco;
            btnCancelar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnAdicionar.Text = "Adicionar";
            CarregaCombo();
            LimpaCampos();
            btnCancelar.Visible = false;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != "") 
            {
                dgvCarros.DataSource = _Control.PesquisarNome(txtPesquisa.Text);
            }
            else if(txtPesquisa.Text != "")
            {
                dgvCarros.DataSource = _Control = ;
            }
        }
    }
}
