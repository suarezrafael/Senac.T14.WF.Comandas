namespace Comandas
{
    public partial class FrmCardapioCad : Form
    {   // variavel que indica se esta criando um novo cardapio
        // bool  = true, false
        bool ehNovo = false;
        private FrmCardapio _frmCardapio;

        public int ID { get; }
        public string? TITULO { get; set; }
        public string? DESCRICAO { get; }
        public decimal PRECO { get; }
        public bool POSSUI_PREPARO { get; }

        public FrmCardapioCad(bool acao, FrmCardapio frmCardapio)
        {
            ehNovo = acao;
            _frmCardapio = frmCardapio;
            InitializeComponent();
        }

        public FrmCardapioCad(bool acao, int iD, string? tITULO, string? dESCRICAO, decimal pRECO, bool pOSSUI_PREPARO, FrmCardapio frmCardapio) : this(acao, frmCardapio)
        {
            ehNovo = acao;
            InitializeComponent();
            ID = iD;
            TITULO = tITULO;
            DESCRICAO = dESCRICAO;
            PRECO = pRECO;
            POSSUI_PREPARO = pOSSUI_PREPARO;
            PopularCampos();

        }

        private void PopularCampos()
        {
            txtId.TextButton = ID.ToString();
            txtTitulo.TextButton = TITULO;
            txtDescricao.TextButton = DESCRICAO;
            txtPreco.TextButton = PRECO.ToString();
            chkPreparo.Checked = POSSUI_PREPARO;
            textBox1.Text = TITULO;
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
            }
            _frmCardapio.ListarCardapios();
            // Fecha a tela atual (FrmCardapioCad)
            Close();
        }

        private void AtualizarCardapio()
        {
            using (var banco = new BancoDeDados())
            {
                var cardapio = banco.Cardapios.
                       FirstOrDefault(c => c.Id ==
                                    int.Parse(txtId.TextButton));

                cardapio.Titulo = txtTitulo.TextButton;
                cardapio.Descricao = txtDescricao.TextButton;
                cardapio.Preco = decimal.Parse(txtPreco.TextButton);
                cardapio.PossuiPreparo = chkPreparo.Checked;
                banco.SaveChanges();
            }
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
