namespace Comandas
{
    public partial class FrmCardapioCad : Form
    {   // variavel que indica se esta criando um novo cardapio
        // bool  = true, false
        bool ehNovo = false;
        private readonly BancoDeDados _context;
        public FrmCardapioCad(bool acao, BancoDeDados context)
        {
            ehNovo = acao;
            InitializeComponent();
            _context = context;
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

            var cardapio = _context.Cardapios.
                   FirstOrDefault(c => c.Id ==
                                int.Parse(txtId.TextButton));

            cardapio.Titulo = txtTitulo.TextButton;
            cardapio.Descricao = txtDescricao.TextButton;
            cardapio.Preco = decimal.Parse(txtPreco.TextButton);
            cardapio.PossuiPreparo = chkPreparo.Checked;
            _context.SaveChanges();

        }

        private void AdicionarCardapio()
        {
            // cria uma variavel banco que instancia um conexao com BD

            var novoCardapio = new Cardapio()
            {
                Titulo = txtTitulo.TextButton,
                Descricao = txtDescricao.TextButton,
                Preco = decimal.Parse(txtPreco.TextButton),
                PossuiPreparo = chkPreparo.Checked
            };
            _context.Cardapios.Add(novoCardapio);
            _context.SaveChanges();

        }
    }
}
