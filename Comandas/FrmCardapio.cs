using Microsoft.Extensions.DependencyInjection;

namespace Comandas
{
    public partial class FrmCardapio : Form
    {
        private readonly BancoDeDados _context;
        private readonly IServiceProvider _serviceProvider;
        public FrmCardapio(BancoDeDados context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _context = context;
            ListarCardapios();
            _serviceProvider = serviceProvider;
        }

        private void ListarCardapios()
        {

            var cardapios = _context.Cardapios.ToList();
            dgvCardapio.DataSource = cardapios;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var context = _serviceProvider.GetRequiredService<BancoDeDados>();
            var frmCardapioCad = new FrmCardapioCad(false, context);

            // Exibe o formulário
            frmCardapioCad.ShowDialog();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var context = _serviceProvider.GetRequiredService<BancoDeDados>();

            var frmCardapioCad = new FrmCardapioCad(true, context);

            // Exibe o formulário
            frmCardapioCad.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
