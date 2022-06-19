using Carros.View.Control;

namespace Carros.View
{
    public partial class CadastroFuncionario : Form
    {
        private ControleContas _ControlL = new ControleContas();
        private ControleFuncionarios _ControlF = new ControleFuncionarios();
        public CadastroFuncionario()
        {
            InitializeComponent();
        }
        public void CarregaCombo()
        {
            dgvFuncionario.DataSource = _ControlF.SelecionarTodos();   
        }
        public void LimpaCampos()
        {
            txtNome.Text = "";
            MskdFuncCPF.Text = "";
            cboCargo.Text = "";
            txtSenha.Text = "";
            txtUsuario.Text = "";
            txtIDConcessionaria.Text = "";
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {
            CarregaCombo();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Model.Funcionarios oFuncionario = new Model.Funcionarios();
            if (btnAdicionar.Text == "Readicionar")
            {
                

                oFuncionario.Cargo = cboCargo.Text;
                oFuncionario.NomeFuncionario = txtNome.Text;
                oFuncionario.Cpf = MskdFuncCPF.Text;
                oFuncionario.IdConcessionaria = int.Parse(txtIDConcessionaria.Text);
                oFuncionario.IdFuncionario = Convert.ToInt32(dgvFuncionario.Rows[0].Cells[0].Value);
                txtUsuario.Visible = true;
                txtSenha.Visible = true;

                btnAdicionar.Text = "Adicionar";
                _ControlF.Alterar(oFuncionario);
                btnCancelar.Visible = false;
            }
            else
            {
                Model.Contas oConta = new Model.Contas();                

                oFuncionario.Cargo = cboCargo.Text;
                oFuncionario.NomeFuncionario = txtNome.Text;
                oFuncionario.Cpf = MskdFuncCPF.Text;
                oFuncionario.IdConcessionaria = int.Parse(txtIDConcessionaria.Text);

                _ControlF.Incluir(oFuncionario);

                oConta.IdUsuario = _ControlF.AcharId(MskdFuncCPF.Text);
                oConta.Usuario = txtUsuario.Text;
                oConta.Senha = txtSenha.Text;

                _ControlL.Incluir(oConta);
            }
            CarregaCombo();
            LimpaCampos();
        }

        private void Pesquisa_TextChanged(object sender, EventArgs e)
        {
            if(txtPesquisa.Text.Length > 0)
            {
                dgvFuncionario.DataSource = _ControlF.PesquisarNome(txtPesquisa.Text);
            }
            else
            {
                CarregaCombo();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int ind = dgvFuncionario.CurrentCell.RowIndex;
            string id = Convert.ToString(dgvFuncionario.Rows[ind].Cells[0].Value);
            int idF = int.Parse(id);
            _ControlF.Remover(idF);
            CarregaCombo();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAdicionar.Text = "Readicionar";
            int ind = dgvFuncionario.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvFuncionario.Rows[ind].Cells[0].Value);
            string idc = Convert.ToString(dgvFuncionario.Rows[ind].Cells[1].Value).TrimEnd();
            string nome = Convert.ToString(dgvFuncionario.Rows[ind].Cells[2].Value).TrimEnd();
            string cpf = Convert.ToString(dgvFuncionario.Rows[ind].Cells[3].Value).TrimEnd();
            string cargo = Convert.ToString(dgvFuncionario.Rows[ind].Cells[4].Value).TrimEnd();

            dgvFuncionario.DataSource = _ControlF.SelecionarUm(id);

            txtNome.Text = nome;
            MskdFuncCPF.Text = cpf;
            cboCargo.Text = cargo;
            txtIDConcessionaria.Text = idc;
            btnCancelar.Visible = true;

            txtUsuario.Visible = false;
            txtSenha.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CarregaCombo();
            LimpaCampos();
            btnAdicionar.Text = "Adicionar";
            btnCancelar.Visible = false;
            txtUsuario.Visible = true;
            txtSenha.Visible = true;
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void MskdFuncCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}