namespace Comandas
{
    public partial class FrmCardapio : Form
    {
        public int ID { get; private set; }
        public string? TITULO { get; private set; }
        public bool POSSUI_PREPARO { get; private set; }
        public string? DESCRICAO { get; private set; }
        public decimal PRECO { get; private set; }

        public FrmCardapio()
        {
            InitializeComponent();
            ListarCardapios();
        }

        private void ListarCardapios()
        {
            using (var banco = new BancoDeDados())
            {
                var cardapios = banco.Cardapios.ToList();
                dgvCardapio.DataSource = cardapios;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var ehNovo = false;
            new FrmCardapioCad(ehNovo, ID, TITULO, DESCRICAO, PRECO, POSSUI_PREPARO).ShowDialog();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // criei uma variavel booleana para indicar o tipo da cad
            var ehNovo = true;
            new FrmCardapioCad(ehNovo).ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void dgvCardapio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // obtem o numero da linha clicada
            var numeroLinha = e.RowIndex;
            // verifica se alguma linha foi selecionda
            if (numeroLinha >= 0)
            {
                var id = dgvCardapio.Rows[numeroLinha].Cells["Id"].Value.ToString();
                var titulo = dgvCardapio.Rows[numeroLinha].Cells["Titulo"].Value.ToString();
                var descricao = dgvCardapio.Rows[numeroLinha].Cells["Descricao"].Value.ToString();
                var preco = dgvCardapio.Rows[numeroLinha].Cells["Preco"].Value.ToString();
                var possuiPreparo = dgvCardapio.Rows[numeroLinha].Cells["PossuiPreparo"].Value.ToString();

                // CONVERTER PARA os tipos corretos
                ID = int.Parse(id);
                TITULO = titulo;
                DESCRICAO = descricao;
                PRECO = decimal.Parse(preco);
                POSSUI_PREPARO = bool.Parse(possuiPreparo);

                // habilitar o botão Editar e botão Excluir
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }
    }
}
