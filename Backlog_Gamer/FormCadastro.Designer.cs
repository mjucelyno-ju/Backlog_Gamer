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
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.dtpAquisicao = new System.Windows.Forms.DateTimePicker();
            this.chkZerado = new System.Windows.Forms.CheckBox();
            this.nudNota = new System.Windows.Forms.NumericUpDown();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.cboPlataforma = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.nudCodigo = new System.Windows.Forms.NumericUpDown();
            this.HorasJo = new System.Windows.Forms.Label();
            this.DataAqui = new System.Windows.Forms.Label();
            this.Zerado = new System.Windows.Forms.Label();
            this.Nota = new System.Windows.Forms.Label();
            this.Genero = new System.Windows.Forms.Label();
            this.Plataforma = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCampos
            // 
            this.pnlCampos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCampos.Controls.Add(this.btnNovo);
            this.pnlCampos.Controls.Add(this.nudHoras);
            this.pnlCampos.Controls.Add(this.dtpAquisicao);
            this.pnlCampos.Controls.Add(this.chkZerado);
            this.pnlCampos.Controls.Add(this.nudNota);
            this.pnlCampos.Controls.Add(this.cboGenero);
            this.pnlCampos.Controls.Add(this.cboPlataforma);
            this.pnlCampos.Controls.Add(this.txtTitulo);
            this.pnlCampos.Controls.Add(this.nudCodigo);
            this.pnlCampos.Controls.Add(this.HorasJo);
            this.pnlCampos.Controls.Add(this.DataAqui);
            this.pnlCampos.Controls.Add(this.Zerado);
            this.pnlCampos.Controls.Add(this.Nota);
            this.pnlCampos.Controls.Add(this.Genero);
            this.pnlCampos.Controls.Add(this.Plataforma);
            this.pnlCampos.Controls.Add(this.Titulo);
            this.pnlCampos.Controls.Add(this.Codigo);
            this.pnlCampos.Controls.Add(this.btnExcluir);
            this.pnlCampos.Controls.Add(this.btnSalvar);
            this.pnlCampos.Location = new System.Drawing.Point(202, 30);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(380, 408);
            this.pnlCampos.TabIndex = 19;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(272, 367);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 37;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(167, 312);
            this.nudHoras.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(120, 20);
            this.nudHoras.TabIndex = 36;
            // 
            // dtpAquisicao
            // 
            this.dtpAquisicao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAquisicao.Location = new System.Drawing.Point(167, 265);
            this.dtpAquisicao.MaxDate = new System.DateTime(4026, 11, 15, 0, 0, 0, 0);
            this.dtpAquisicao.Name = "dtpAquisicao";
            this.dtpAquisicao.Size = new System.Drawing.Size(120, 20);
            this.dtpAquisicao.TabIndex = 35;
            this.dtpAquisicao.Value = new System.DateTime(2026, 11, 15, 0, 0, 0, 0);
            // 
            // chkZerado
            // 
            this.chkZerado.AutoSize = true;
            this.chkZerado.Location = new System.Drawing.Point(167, 220);
            this.chkZerado.Name = "chkZerado";
            this.chkZerado.Size = new System.Drawing.Size(15, 14);
            this.chkZerado.TabIndex = 34;
            this.chkZerado.UseVisualStyleBackColor = true;
            // 
            // nudNota
            // 
            this.nudNota.DecimalPlaces = 1;
            this.nudNota.Location = new System.Drawing.Point(167, 176);
            this.nudNota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNota.Name = "nudNota";
            this.nudNota.Size = new System.Drawing.Size(120, 20);
            this.nudNota.TabIndex = 33;
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(166, 140);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(121, 21);
            this.cboGenero.TabIndex = 32;
            // 
            // cboPlataforma
            // 
            this.cboPlataforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlataforma.FormattingEnabled = true;
            this.cboPlataforma.Location = new System.Drawing.Point(166, 98);
            this.cboPlataforma.Name = "cboPlataforma";
            this.cboPlataforma.Size = new System.Drawing.Size(121, 21);
            this.cboPlataforma.TabIndex = 31;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(166, 58);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(121, 20);
            this.txtTitulo.TabIndex = 30;
            // 
            // nudCodigo
            // 
            this.nudCodigo.Location = new System.Drawing.Point(167, 19);
            this.nudCodigo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCodigo.Name = "nudCodigo";
            this.nudCodigo.Size = new System.Drawing.Size(120, 20);
            this.nudCodigo.TabIndex = 29;
            // 
            // HorasJo
            // 
            this.HorasJo.AutoSize = true;
            this.HorasJo.BackColor = System.Drawing.Color.Transparent;
            this.HorasJo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HorasJo.ForeColor = System.Drawing.Color.White;
            this.HorasJo.Location = new System.Drawing.Point(14, 312);
            this.HorasJo.Name = "HorasJo";
            this.HorasJo.Size = new System.Drawing.Size(96, 17);
            this.HorasJo.TabIndex = 28;
            this.HorasJo.Text = "Horas Jogadas";
            // 
            // DataAqui
            // 
            this.DataAqui.AutoSize = true;
            this.DataAqui.BackColor = System.Drawing.Color.Transparent;
            this.DataAqui.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataAqui.ForeColor = System.Drawing.Color.White;
            this.DataAqui.Location = new System.Drawing.Point(14, 265);
            this.DataAqui.Name = "DataAqui";
            this.DataAqui.Size = new System.Drawing.Size(114, 17);
            this.DataAqui.TabIndex = 27;
            this.DataAqui.Text = "Data de Aquisição";
            // 
            // Zerado
            // 
            this.Zerado.AutoSize = true;
            this.Zerado.BackColor = System.Drawing.Color.Transparent;
            this.Zerado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zerado.ForeColor = System.Drawing.Color.White;
            this.Zerado.Location = new System.Drawing.Point(15, 218);
            this.Zerado.Name = "Zerado";
            this.Zerado.Size = new System.Drawing.Size(51, 16);
            this.Zerado.TabIndex = 26;
            this.Zerado.Text = "Zerado";
            // 
            // Nota
            // 
            this.Nota.AutoSize = true;
            this.Nota.BackColor = System.Drawing.Color.Transparent;
            this.Nota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nota.ForeColor = System.Drawing.Color.White;
            this.Nota.Location = new System.Drawing.Point(14, 179);
            this.Nota.Name = "Nota";
            this.Nota.Size = new System.Drawing.Size(37, 17);
            this.Nota.TabIndex = 25;
            this.Nota.Text = "Nota";
            // 
            // Genero
            // 
            this.Genero.AutoSize = true;
            this.Genero.BackColor = System.Drawing.Color.Transparent;
            this.Genero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genero.ForeColor = System.Drawing.Color.White;
            this.Genero.Location = new System.Drawing.Point(14, 140);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(51, 17);
            this.Genero.TabIndex = 24;
            this.Genero.Text = "Gênero";
            // 
            // Plataforma
            // 
            this.Plataforma.AutoSize = true;
            this.Plataforma.BackColor = System.Drawing.Color.Transparent;
            this.Plataforma.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plataforma.ForeColor = System.Drawing.Color.White;
            this.Plataforma.Location = new System.Drawing.Point(14, 102);
            this.Plataforma.Name = "Plataforma";
            this.Plataforma.Size = new System.Drawing.Size(71, 17);
            this.Plataforma.TabIndex = 23;
            this.Plataforma.Text = "Plataforma";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(14, 58);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(40, 17);
            this.Titulo.TabIndex = 22;
            this.Titulo.Text = "Título";
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.BackColor = System.Drawing.Color.Transparent;
            this.Codigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.ForeColor = System.Drawing.Color.White;
            this.Codigo.Location = new System.Drawing.Point(14, 19);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(51, 17);
            this.Codigo.TabIndex = 21;
            this.Codigo.Text = "Código";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(149, 367);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(32, 367);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCampos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastro";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.DateTimePicker dtpAquisicao;
        private System.Windows.Forms.CheckBox chkZerado;
        private System.Windows.Forms.NumericUpDown nudNota;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.ComboBox cboPlataforma;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.NumericUpDown nudCodigo;
        private System.Windows.Forms.Label HorasJo;
        private System.Windows.Forms.Label DataAqui;
        private System.Windows.Forms.Label Zerado;
        private System.Windows.Forms.Label Nota;
        private System.Windows.Forms.Label Genero;
        private System.Windows.Forms.Label Plataforma;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
    }
}