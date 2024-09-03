﻿namespace Comandas
{
    public partial class FrmCardapio : Form
    {
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
            new FrmCardapioCad(ehNovo).ShowDialog();
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
    }
}
