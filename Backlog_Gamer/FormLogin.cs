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

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_MouseEnter(object sender, EventArgs e)
        {
            btnEntrar.Font = new Font(btnEntrar.Font.FontFamily, 18, FontStyle.Bold);
        }

        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        {
            btnEntrar.Font = new Font(btnEntrar.Font.FontFamily, 15.75f, FontStyle.Bold);
        }
    }
}
