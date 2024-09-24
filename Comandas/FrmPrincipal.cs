using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Comandas
{
    public partial class FrmPrincipal : Form
    {
        private readonly BancoDeDados _context;
        private readonly IServiceProvider _serviceProvider;

        public FrmPrincipal(BancoDeDados context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _context = context;
            CriarBancoDeDados();
            _serviceProvider = serviceProvider;
        }


        // método (visibilidade=private, retorno=void nome)
        private void CriarBancoDeDados()
        {
            _context.Database.Migrate();
        }


        // evento de clique
        private void btnCardapio_Click(object sender, EventArgs e)
        {
            // criar o formulario e exibe
            var frmCardapio = _serviceProvider.GetRequiredService<FrmCardapio>();
            frmCardapio.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            var frmUsuarios = _serviceProvider.GetRequiredService<FrmUsuarios>();
            frmUsuarios.ShowDialog();
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            new FrmComanda().ShowDialog();
        }

        private void btnPedidoCozinha_Click(object sender, EventArgs e)
        {
            new FrmPedidoCozinha().ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // encerra o aplicativo
            Application.Exit();
        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {
            // criar o formulario e exibe
            var frmCardapio = _serviceProvider.GetRequiredService<FrmCardapio>();
            frmCardapio.ShowDialog();
        }

        private void cyberButton2_Click(object sender, EventArgs e)
        {
            new FrmComanda().ShowDialog();
        }

        private void cyberButton3_Click(object sender, EventArgs e)
        {
            new FrmPedidoCozinha().ShowDialog();
        }

        private void cyberButton4_Click(object sender, EventArgs e)
        {
            var frmUsuarios = _serviceProvider.GetRequiredService<FrmUsuarios>();
            frmUsuarios.ShowDialog();
        }
    }
}
