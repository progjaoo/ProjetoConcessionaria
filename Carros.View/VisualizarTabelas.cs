using Carros.View.Control;

namespace Carros.View
{
    public partial class VisualizarTabelas : Form
    {
        private ControleCarros _ControlCar = new ControleCarros();
        private ControleConcessionaria _ControlCon = new ControleConcessionaria();

        bool tabela = true;
        public VisualizarTabelas()
        {
            InitializeComponent();
        }
        
        public void CarregaCombo()
        {
            if (tabela)
            {
                dgvFuncionario.DataSource = _ControlCon.SelecionarTodos();
            }
            else
            {
                dgvFuncionario.DataSource = _ControlCar.SelecionarTodos();
            }
        }
        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {
            CarregaCombo();
        }
        private void Pesquisa_TextChanged(object sender, EventArgs e)
        {
            if (tabela){
                if (txtPesquisa.Text.Length > 0)
                {
                    dgvFuncionario.DataSource = _ControlCon.PesquisarNome(txtPesquisa.Text);
                }
                else
                {
                    CarregaCombo();
                }
            }
            else
            {
                if (txtPesquisa.Text.Length > 0)
                {
                    dgvFuncionario.DataSource = _ControlCar.PesquisarNome(txtPesquisa.Text);
                }
                else
                {
                    CarregaCombo();
                }
            }
        }

        private void btnConc_Click(object sender, EventArgs e)
        {
            tabela = true;
            CarregaCombo();
        }

        private void btnCarros_Click(object sender, EventArgs e)
        {
            tabela = false;
            CarregaCombo();
        }
    }
}