namespace Comandas
{
    public partial class FrmCardapioCad : Form
    {   // variavel que indica se esta criando um novo cardapio
        // bool  = true, false
        bool ehNovo = false;
        public FrmCardapioCad(bool acao)
        {
            ehNovo = acao;
            InitializeComponent();
        }

        private void cyberGroupBox1_Load(object sender, EventArgs e)
        {

        }

        private void crownLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // se o form está em modo de inclusão
            if (ehNovo)
            {
                // Executa o método que realiza o INSERT na tabela
                AdicionarCardapio();
            }
            else
            {   // Executa o método que realiza o UPDATE na tabela
                AtualizarCardapio();
            } // Fecha a tela atual (FrmCardapioCad)
            Close();
        }

        private void AtualizarCardapio()
        {

        }

        private void AdicionarCardapio()
        {
            // cria uma variavel banco que instancia um conexao com BD
            using (var banco = new BancoDeDados())
            {
                var novoCardapio = new Cardapio()
                {
                    Titulo = txtTitulo.TextButton,
                    Descricao = txtDescricao.TextButton,
                    Preco = decimal.Parse(txtPreco.TextButton),
                    PossuiPreparo = chkPreparo.Checked
                };
                banco.Cardapios.Add(novoCardapio);
                banco.SaveChanges();
            }
        }
    }
}
