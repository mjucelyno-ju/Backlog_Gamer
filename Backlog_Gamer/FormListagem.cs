using System;
using System.Drawing;
using System.Windows.Forms;

namespace Backlog_Gamer
{
    public partial class FormListagem : Form
    {
        private JogoRepositorio repo = new JogoRepositorio();

        public FormListagem()
        {
            InitializeComponent();
            EstilizarGrid();

            pnlGrid.BackColor = Color.FromArgb(180, 8, 12, 32);
        }

        private void FormListagem_Activated(object sender, EventArgs e)
        {
            dgvJogos.DataSource = null;
            dgvJogos.DataSource = repo.Carregar();
            ConfigurarColunas();

            int altura = dgvJogos.ColumnHeadersHeight
             + dgvJogos.Rows.Count * dgvJogos.RowTemplate.Height + 2;
            dgvJogos.Height = Math.Min(altura, pnlGrid.ClientSize.Height);
        }

        private void EstilizarGrid()
        {
            // Desativa o estilo padrão do Windows
            dgvJogos.EnableHeadersVisualStyles = false;

            // Estilo do Cabeçalho
            dgvJogos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvJogos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            dgvJogos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvJogos.ColumnHeadersHeight = 40;

            //Estilo das Linhas e Células
            dgvJogos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvJogos.GridColor = Color.FromArgb(226, 232, 240);
            dgvJogos.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvJogos.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvJogos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvJogos.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
            dgvJogos.RowTemplate.Height = 35;

            //dgvJogos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvJogos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
        }

        private void ConfigurarColunas()
        {
            if (dgvJogos.Columns.Count == 0) return;

            //Ajusta titulos exibidos no DataGridView
            dgvJogos.Columns["Codigo"].HeaderText = "ID";
            dgvJogos.Columns["Titulo"].HeaderText = "Nome do Jogo";
            dgvJogos.Columns["Genero"].HeaderText = "Gênero";
            dgvJogos.Columns["DataAquisicao"].HeaderText = "Data de Aquisição";
            dgvJogos.Columns["HorasJogadas"].HeaderText = "Horas Jogadas";

            //Ajusta a largura das colunas
            dgvJogos.Columns["Codigo"].FillWeight = 35;
            dgvJogos.Columns["Titulo"].FillWeight = 160;
            dgvJogos.Columns["Plataforma"].FillWeight = 80;
            dgvJogos.Columns["Genero"].FillWeight = 70;
            dgvJogos.Columns["Nota"].FillWeight = 45;
            dgvJogos.Columns["Zerado"].FillWeight = 45;
            dgvJogos.Columns["DataAquisicao"].FillWeight = 100;
            dgvJogos.Columns["HorasJogadas"].FillWeight = 70;

            //Formata data para não exibir tempo
            dgvJogos.Columns["DataAquisicao"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void FormListagem_Load(object sender, EventArgs e)
        {

        }
    }
}