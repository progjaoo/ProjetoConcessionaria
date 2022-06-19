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
    public partial class CadastroConcessionaria : Form
    {
        private ControleConcessionaria _Control = new ControleConcessionaria();

        public CadastroConcessionaria()
        {
            InitializeComponent();
        }

        public void CarregaCombo()
        {
            dgvConcessionaria.DataSource = _Control.SelecionarTodos();
        }

        public void LimpaCampos()
        {
            txtCidade.Text = "";
            txtGerente.Text = "";
            txtNome.Text = "";
        }

        private void CadastroConcessionaria_Load(object sender, EventArgs e)
        {
            CarregaCombo();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Model.Concessionarias oConcessionaria = new Model.Concessionarias();
            if (btnAdicionar.Text == "Readicionar")
            {
                oConcessionaria.NomeConcessionaria = txtNome.Text;
                oConcessionaria.Cidade = txtCidade.Text;
                oConcessionaria.Gerente = txtGerente.Text;
                oConcessionaria.IdConcessionaria = Convert.ToInt32(dgvConcessionaria.Rows[0].Cells[0].Value);

                btnAdicionar.Text = "Adicionar";
                _Control.Alterar(oConcessionaria);
                btnCancelar.Visible = false;
            }
            else
            {
                oConcessionaria.NomeConcessionaria = txtNome.Text;
                oConcessionaria.Cidade = txtCidade.Text;
                oConcessionaria.Gerente = txtGerente.Text;
                _Control.Incluir(oConcessionaria);
            }
            CarregaCombo();
            LimpaCampos();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int ind = dgvConcessionaria.CurrentCell.RowIndex;
            string id = Convert.ToString(dgvConcessionaria.Rows[ind].Cells[0].Value);
            int idF = int.Parse(id);
            _Control.Remover(idF);
            CarregaCombo();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAdicionar.Text = "Readicionar";
            int ind = dgvConcessionaria.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvConcessionaria.Rows[ind].Cells[0].Value);
            string nome = Convert.ToString(dgvConcessionaria.Rows[ind].Cells[1].Value).TrimEnd();
            string cidade = Convert.ToString(dgvConcessionaria.Rows[ind].Cells[2].Value).TrimEnd();
            string gerente = Convert.ToString(dgvConcessionaria.Rows[ind].Cells[3].Value).TrimEnd();

            dgvConcessionaria.DataSource = _Control.SelecionarUm(id);

            txtNome.Text = nome;
            txtCidade.Text = cidade;
            txtGerente.Text = gerente;
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
            if (txtPesquisa.Text.Length > 0)
            {
                dgvConcessionaria.DataSource = _Control.PesquisarNome(txtPesquisa.Text);
            }
            else
            {
                CarregaCombo();
            }
            
        }
    }
}
