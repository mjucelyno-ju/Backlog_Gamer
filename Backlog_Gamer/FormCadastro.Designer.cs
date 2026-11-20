namespace Backlog_Gamer
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.Plataforma = new System.Windows.Forms.Label();
            this.Genero = new System.Windows.Forms.Label();
            this.Nota = new System.Windows.Forms.Label();
            this.Zerado = new System.Windows.Forms.Label();
            this.DataAqui = new System.Windows.Forms.Label();
            this.HorasJo = new System.Windows.Forms.Label();
            this.nudCodigo = new System.Windows.Forms.NumericUpDown();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.cboPlataforma = new System.Windows.Forms.ComboBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.nudNota = new System.Windows.Forms.NumericUpDown();
            this.chkZerado = new System.Windows.Forms.CheckBox();
            this.dtpAquisicao = new System.Windows.Forms.DateTimePicker();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(202, 396);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(319, 396);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.BackColor = System.Drawing.Color.Transparent;
            this.Codigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.ForeColor = System.Drawing.Color.White;
            this.Codigo.Location = new System.Drawing.Point(184, 48);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(51, 17);
            this.Codigo.TabIndex = 2;
            this.Codigo.Text = "Código";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(184, 87);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(40, 17);
            this.Titulo.TabIndex = 3;
            this.Titulo.Text = "Título";
            // 
            // Plataforma
            // 
            this.Plataforma.AutoSize = true;
            this.Plataforma.BackColor = System.Drawing.Color.Transparent;
            this.Plataforma.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plataforma.ForeColor = System.Drawing.Color.White;
            this.Plataforma.Location = new System.Drawing.Point(184, 131);
            this.Plataforma.Name = "Plataforma";
            this.Plataforma.Size = new System.Drawing.Size(71, 17);
            this.Plataforma.TabIndex = 4;
            this.Plataforma.Text = "Plataforma";
            // 
            // Genero
            // 
            this.Genero.AutoSize = true;
            this.Genero.BackColor = System.Drawing.Color.Transparent;
            this.Genero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genero.ForeColor = System.Drawing.Color.White;
            this.Genero.Location = new System.Drawing.Point(184, 169);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(51, 17);
            this.Genero.TabIndex = 5;
            this.Genero.Text = "Gênero";
            // 
            // Nota
            // 
            this.Nota.AutoSize = true;
            this.Nota.BackColor = System.Drawing.Color.Transparent;
            this.Nota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nota.ForeColor = System.Drawing.Color.White;
            this.Nota.Location = new System.Drawing.Point(184, 208);
            this.Nota.Name = "Nota";
            this.Nota.Size = new System.Drawing.Size(37, 17);
            this.Nota.TabIndex = 6;
            this.Nota.Text = "Nota";
            // 
            // Zerado
            // 
            this.Zerado.AutoSize = true;
            this.Zerado.BackColor = System.Drawing.Color.Transparent;
            this.Zerado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zerado.ForeColor = System.Drawing.Color.White;
            this.Zerado.Location = new System.Drawing.Point(185, 247);
            this.Zerado.Name = "Zerado";
            this.Zerado.Size = new System.Drawing.Size(51, 16);
            this.Zerado.TabIndex = 7;
            this.Zerado.Text = "Zerado";
            // 
            // DataAqui
            // 
            this.DataAqui.AutoSize = true;
            this.DataAqui.BackColor = System.Drawing.Color.Transparent;
            this.DataAqui.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataAqui.ForeColor = System.Drawing.Color.White;
            this.DataAqui.Location = new System.Drawing.Point(184, 294);
            this.DataAqui.Name = "DataAqui";
            this.DataAqui.Size = new System.Drawing.Size(114, 17);
            this.DataAqui.TabIndex = 8;
            this.DataAqui.Text = "Data de Aquisição";
            // 
            // HorasJo
            // 
            this.HorasJo.AutoSize = true;
            this.HorasJo.BackColor = System.Drawing.Color.Transparent;
            this.HorasJo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HorasJo.ForeColor = System.Drawing.Color.White;
            this.HorasJo.Location = new System.Drawing.Point(184, 341);
            this.HorasJo.Name = "HorasJo";
            this.HorasJo.Size = new System.Drawing.Size(96, 17);
            this.HorasJo.TabIndex = 9;
            this.HorasJo.Text = "Horas Jogadas";
            // 
            // nudCodigo
            // 
            this.nudCodigo.Location = new System.Drawing.Point(337, 48);
            this.nudCodigo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCodigo.Name = "nudCodigo";
            this.nudCodigo.Size = new System.Drawing.Size(120, 20);
            this.nudCodigo.TabIndex = 10;
            this.nudCodigo.ValueChanged += new System.EventHandler(this.nudCodigo_ValueChanged);
            this.nudCodigo.Leave += new System.EventHandler(this.nudCodigo_Leave);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(336, 87);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 11;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // cboPlataforma
            // 
            this.cboPlataforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlataforma.FormattingEnabled = true;
            this.cboPlataforma.Location = new System.Drawing.Point(336, 127);
            this.cboPlataforma.Name = "cboPlataforma";
            this.cboPlataforma.Size = new System.Drawing.Size(121, 21);
            this.cboPlataforma.TabIndex = 12;
            this.cboPlataforma.SelectedIndexChanged += new System.EventHandler(this.cboPlataforma_SelectedIndexChanged);
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(336, 169);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(121, 21);
            this.cboGenero.TabIndex = 13;
            this.cboGenero.SelectedIndexChanged += new System.EventHandler(this.cboGenero_SelectedIndexChanged);
            // 
            // nudNota
            // 
            this.nudNota.DecimalPlaces = 1;
            this.nudNota.Location = new System.Drawing.Point(337, 205);
            this.nudNota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNota.Name = "nudNota";
            this.nudNota.Size = new System.Drawing.Size(120, 20);
            this.nudNota.TabIndex = 14;
            this.nudNota.ValueChanged += new System.EventHandler(this.nudNota_ValueChanged);
            // 
            // chkZerado
            // 
            this.chkZerado.AutoSize = true;
            this.chkZerado.Location = new System.Drawing.Point(337, 249);
            this.chkZerado.Name = "chkZerado";
            this.chkZerado.Size = new System.Drawing.Size(15, 14);
            this.chkZerado.TabIndex = 15;
            this.chkZerado.UseVisualStyleBackColor = true;
            this.chkZerado.CheckedChanged += new System.EventHandler(this.chkZerado_CheckedChanged);
            // 
            // dtpAquisicao
            // 
            this.dtpAquisicao.Location = new System.Drawing.Point(337, 294);
            this.dtpAquisicao.MaxDate = new System.DateTime(4026, 11, 15, 0, 0, 0, 0);
            this.dtpAquisicao.Name = "dtpAquisicao";
            this.dtpAquisicao.Size = new System.Drawing.Size(200, 20);
            this.dtpAquisicao.TabIndex = 16;
            this.dtpAquisicao.Value = new System.DateTime(2026, 11, 15, 0, 0, 0, 0);
            this.dtpAquisicao.ValueChanged += new System.EventHandler(this.dtpAquisicao_ValueChanged);
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(337, 341);
            this.nudHoras.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(120, 20);
            this.nudHoras.TabIndex = 17;
            this.nudHoras.ValueChanged += new System.EventHandler(this.nudHoras_ValueChanged);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(442, 396);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 18;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.nudHoras);
            this.Controls.Add(this.dtpAquisicao);
            this.Controls.Add(this.chkZerado);
            this.Controls.Add(this.nudNota);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.cboPlataforma);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.nudCodigo);
            this.Controls.Add(this.HorasJo);
            this.Controls.Add(this.DataAqui);
            this.Controls.Add(this.Zerado);
            this.Controls.Add(this.Nota);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.Plataforma);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastro";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Plataforma;
        private System.Windows.Forms.Label Genero;
        private System.Windows.Forms.Label Nota;
        private System.Windows.Forms.Label Zerado;
        private System.Windows.Forms.Label DataAqui;
        private System.Windows.Forms.Label HorasJo;
        private System.Windows.Forms.NumericUpDown nudCodigo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox cboPlataforma;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.NumericUpDown nudNota;
        private System.Windows.Forms.CheckBox chkZerado;
        private System.Windows.Forms.DateTimePicker dtpAquisicao;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.Button btnNovo;
    }
}