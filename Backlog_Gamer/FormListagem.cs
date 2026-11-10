using System;
using System.Windows.Forms;

namespace Backlog_Gamer
{
    public partial class FormListagem : Form
    {
        private JogoRepositorio repo = new JogoRepositorio();

        public FormListagem()
        {
            InitializeComponent();
        }

        private void FormListagem_Activated(object sender, EventArgs e)
        {
            dgvJogos.DataSource = null;
            dgvJogos.DataSource = repo.Carregar();
        }
    }
}