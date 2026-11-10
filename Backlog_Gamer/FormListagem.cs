using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backlog_Gamer
{
    public partial class FormListagem : Form
    {
        private JogoRepositorio repositorio = new JogoRepositorio();

        public FormListagem()
        {
            InitializeComponent();
        }

        private void FormListagem_Load(object sender, EventArgs e)
        {
            CarregarJogos();
        }

        private void CarregarJogos()
        {
            var jogos = repositorio.Carregar();
            dgvJogos.DataSource = jogos;
        }

        private void dgvJogos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
