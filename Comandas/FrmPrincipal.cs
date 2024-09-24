using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing.Drawing2D;

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
            // criar uma variavel do tipo BananaContext
            // usar a var e acessar o contexto
            // executar a migração == F5
            //using (var banco = new BancoDeDados())
            // {
            // executa a migração(CREATE TABLE Usuarios)
            _context.Database.Migrate();
            //}
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Define o tamanho do raio dos cantos arredondados
            int radius = 35;
            GraphicsPath path = new GraphicsPath();

            // Cria um retângulo arredondado
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90);
            path.CloseAllFigures();

            // Aplica a região arredondada ao formulário
            this.Region = new Region(path);
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
