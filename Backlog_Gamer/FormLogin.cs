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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
       string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Informe usuário e senha.");
                txtUsuario.Focus();
                return;
            }

            if (txtUsuario.Text == "admin" && txtSenha.Text == "1234")
            {
                DialogResult = DialogResult.OK;   // fecha o form e sinaliza sucesso
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
                txtSenha.Clear();
                txtSenha.Focus();
            }
        }
    }
}
