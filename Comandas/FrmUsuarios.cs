namespace Comandas
{
    public partial class FrmUsuarios : Form
    {
        private bool ehNovo;

        public FrmUsuarios()
        {
            InitializeComponent();
            // metodo que lista os usuarios
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {
            // 1. conectar no banco
            using (var banco = new BananaContext())
            {
                // 2. SELECT * FROM usuarios
                var usuarios = banco.Usuarios.ToList();
                // 3. Popular a tabela na tela DataGridView
                dgvUsuarios.DataSource = usuarios;
            }
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

            DesabilitarCampos();
            ListarUsuarios();
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtId.TextButton = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }

        private void AtualizarUsuario()
        {
            using (var banco = new BananaContext())
            { // consulta um usuario na tabela usando o Id da tela
                var usuario = banco
                    .Usuarios
                    .Where(e => e.Id == int.Parse(txtId.TextButton))
                    .FirstOrDefault();

                usuario.Nome = txtNome.TextButton;
                usuario.Email = txtEmail.TextButton;
                usuario.Senha = txtSenha.TextButton;
                banco.SaveChanges();
            }
        }

        private void CriarUsuario()
        {
            using (var banco = new BananaContext())
            {
                var novoUsuario = new Usuario();
                novoUsuario.Nome = txtNome.TextButton;
                novoUsuario.Email = txtEmail.TextButton;
                novoUsuario.Senha = txtSenha.TextButton;
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ehNovo = true;
            HabilitarCampos();
        }
        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // indica que está editando um usuario
            ehNovo = false;
        }
    }
}
