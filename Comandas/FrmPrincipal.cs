using Microsoft.EntityFrameworkCore;

namespace Comandas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CriarBancoDeDados();
        }
        // método (visibilidade=private, retorno=void nome)
        private void CriarBancoDeDados()
        {
            // criar uma variavel do tipo BananaContext
            // usar a var e acessar o contexto
            // executar a migração == F5
            using (var banco = new BananaContext())
            {
                // executa a migração(CREATE TABLE Usuarios)
                banco.Database.Migrate();
            }
        }

        // evento de clique
        private void btnCardapio_Click(object sender, EventArgs e)
        {
            // criar o formulario e exibe
            new FrmCardapio().ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            new FrmUsuarios().ShowDialog();
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
    }
}
