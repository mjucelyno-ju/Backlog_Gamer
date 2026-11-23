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
    public partial class FormCadastro : Form
    {
        private JogoRepositorio repo = new JogoRepositorio();

        public FormCadastro()
        {
            InitializeComponent();
            nudCodigo.Leave += nudCodigo_Leave;

            pnlCampos.BackColor = Color.FromArgb(180, 8, 12, 32); // 180 = opacidade
            this.DoubleBuffered = true; // evita piscar

            EstilizarBotao(btnSalvar, Color.FromArgb(70, 130, 90));   // verde
            EstilizarBotao(btnExcluir, Color.FromArgb(190, 60, 60));   // vermelho
            EstilizarBotao(btnNovo, Color.FromArgb(90, 100, 150));  // azul-acinzentado
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            cboPlataforma.DataSource = Enum.GetValues(typeof(Plataforma));
            cboGenero.DataSource = Enum.GetValues(typeof(Genero));
        }

        private void EstilizarBotao(Button btn, Color cor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = cor;
            btn.ForeColor = Color.White;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        }

        // Ao sair do campo Código, busca o jogo e preenche a tela
        private void nudCodigo_Leave(object sender, EventArgs e)
        {
            int codigo = (int)nudCodigo.Value;
            Jogo jogo = repo.Carregar().Find(j => j.Codigo == codigo);
            if (jogo == null) return;

            txtTitulo.Text = jogo.Titulo;
            cboPlataforma.SelectedItem = jogo.Plataforma;
            cboGenero.SelectedItem = jogo.Genero;
            nudNota.Value = jogo.Nota;
            chkZerado.Checked = jogo.Zerado;
            dtpAquisicao.Value = jogo.DataAquisicao;
            nudHoras.Value = jogo.HorasJogadas;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (nudCodigo.Value <= 0)
            {
                MessageBox.Show("Informe um código maior que 0.");
                nudCodigo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("Informe o título do jogo.");
                txtTitulo.Focus();
                return;
            }

            var lista = repo.Carregar();
            int codigo = (int)nudCodigo.Value;
            Jogo jogo = lista.Find(j => j.Codigo == codigo);

            //  novo: adiciona

            if (jogo == null)           
               
            {
                jogo = new Jogo();
                jogo.Codigo = codigo;
                lista.Add(jogo);
            }

            // atualiza o mesmo objeto ja existente na lista.

            jogo.Titulo = txtTitulo.Text.Trim();
            jogo.Plataforma = (Plataforma)cboPlataforma.SelectedItem;
            jogo.Genero = (Genero)cboGenero.SelectedItem;
            jogo.Nota = nudNota.Value;
            jogo.Zerado = chkZerado.Checked;
            jogo.DataAquisicao = dtpAquisicao.Value;
            jogo.HorasJogadas = (int)nudHoras.Value;

            repo.Salvar(lista);
            MessageBox.Show("Jogo salvo com sucesso!");
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var lista = repo.Carregar();
            int codigo = (int)nudCodigo.Value;
            Jogo jogo = lista.Find(j => j.Codigo == codigo);

            if (jogo == null)
            {
                MessageBox.Show("Código não encontrado.");
                return;
            }

            var resposta = MessageBox.Show(
                "Excluir o jogo \"" + jogo.Titulo + "\"?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                lista.Remove(jogo);
                repo.Salvar(lista);
                Limpar();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            nudCodigo.Value = 0;
            txtTitulo.Clear();
            cboPlataforma.SelectedIndex = 0;
            cboGenero.SelectedIndex = 0;
            nudNota.Value = 0;
            chkZerado.Checked = false;
            dtpAquisicao.Value = DateTime.Today;
            nudHoras.Value = 0;
            nudCodigo.Focus();
        }
    }
}