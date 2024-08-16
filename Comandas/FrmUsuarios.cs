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
            using (var banco = new BancoDeDados())
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
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void LimparCampos()
        {
            txtId.TextButton = string.Empty;
            txtNome.TextButton = string.Empty;
            txtEmail.TextButton = string.Empty;
            txtSenha.TextButton = string.Empty;
        }

        private void AtualizarUsuario()
        {
            using (var banco = new BancoDeDados())
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
            using (var banco = new BancoDeDados())
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
            HabilitarCampos();
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void CarregarUsuarios()
        {
            // Conectar no banco
            using (var banco = new BancoDeDados())
            {
                // Realizar consulta na tabela usuarios
                var usuarios = banco.Usuarios.ToList();
                // Popular os dados do grid(dataGridView)
                dgvUsuarios.DataSource = usuarios;
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // verifica se o indice da linha é maior igual a 0
            // saber se existe uma linha selecionada
            if (e.RowIndex >= 0)
            {
                // obter dados da linha
                var id = dgvUsuarios.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                var nome = dgvUsuarios.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                var email = dgvUsuarios.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                var senha = dgvUsuarios.Rows[e.RowIndex].Cells["Senha"].Value.ToString();

                txtId.TextButton = id;
                txtNome.TextButton = nome;
                txtEmail.TextButton = email;
                txtSenha.TextButton = senha;

                btnEditar.Enabled = true;
                btnNovo.Enabled = false;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnExcluir.Enabled = true;
            } // end if(e.rowINdex >=0 )
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // obtem o id do usuário da tela
            var idUsuario = Convert.ToInt32(txtId.TextButton);
            // Chama o método  que exclui da tabela usuario
            ExcluirUsuario(idUsuario);
            ListarUsuarios();
            LimparCampos();
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            MessageBox.Show("Usuário excluído com sucesso");
        }

        private void ExcluirUsuario(int idUsuario)
        {
            // conectar no banco de dados
            using (var banco = new BancoDeDados())
            {
                // consultar o usuario
                // SELECT * FROM usuarios WHERE id = ?
                var usuario = banco
                                .Usuarios
                                    .First(u => u.Id
                                        .Equals(idUsuario)
                                     );
                // avisar o banco que estou excluindo
                // DELETE FROM usuarios WHERE id = ?
                banco.Usuarios.Remove(usuario);

                // confirmar a exclusão
                // COMMIT
                banco.SaveChanges();
            }
        }
    }
}
