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
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void AbrirFormularioCadastro()
        {
            AbrirFormularioUnico(new FormCadastro());
        }

        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioCadastro();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioCadastro();
        }

        private void listagemDeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico(new FormListagem());
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormularioUnico(Form novoFormulario)
        {
            foreach (Form formAbertos in this.MdiChildren)
            {
                formAbertos.Close();
            }
            novoFormulario.MdiParent = this;
            novoFormulario.Show();
        }
    }
}
