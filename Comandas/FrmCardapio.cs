namespace Comandas
{
    public partial class FrmCardapio : Form
    {
        public FrmCardapio()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            new FrmCardapioCad().ShowDialog();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new FrmCardapioCad().ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
