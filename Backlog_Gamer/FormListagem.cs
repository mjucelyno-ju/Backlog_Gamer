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
        public FormListagem()
        {
            InitializeComponent();
        }


        private JogoRepositorio repo = new JogoRepositorio();

        private void dgvJogos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormListagem_Load(object sender, EventArgs e)
        {
            
        }

        private void FormListagem_Activated(object sender, EventArgs e)
        {
            dgvJogos.DataSource = null;
            dgvJogos.DataSource = repo.Carregar();
        }
    }
}
