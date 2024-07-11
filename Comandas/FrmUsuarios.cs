namespace Comandas
{
    public partial class FrmUsuarios : Form
    {
        private bool ehNovo;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ehNovo)
                CriarUsuario();
            else
                AtualizarUsuario();
        }

        private void AtualizarUsuario()
        {
            using (var banco = new BananaContext())
            {
                var usuario = banco
                    .Usuarios
                    .Where(e => e.Id == 1)
                    .FirstOrDefault();
                usuario.Nome = "Natasha";
                usuario.Email = "nat@gmail.com";
                banco.SaveChanges();
            }
        }

        private void CriarUsuario()
        {
            using (var banco = new BananaContext())
            {
                var novoUsuario = new Usuario();
                novoUsuario.Nome = "Rafael";
                novoUsuario.Email = "rafaelv_s@hotmail.com";
                novoUsuario.Senha = "123";
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ehNovo = true;
        }
    }
}
