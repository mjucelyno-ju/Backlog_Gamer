namespace Backlog_Gamer
{
    partial class FormListagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListagem));
            this.dgvJogos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJogos
            // 
            this.dgvJogos.AllowUserToAddRows = false;
            this.dgvJogos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJogos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJogos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJogos.Location = new System.Drawing.Point(0, 0);
            this.dgvJogos.Name = "dgvJogos";
            this.dgvJogos.ReadOnly = true;
            this.dgvJogos.RowHeadersVisible = false;
            this.dgvJogos.RowTemplate.ReadOnly = true;
            this.dgvJogos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJogos.Size = new System.Drawing.Size(800, 450);
            this.dgvJogos.TabIndex = 0;
            // 
            // FormListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvJogos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListagem";
            this.Activated += new System.EventHandler(this.FormListagem_Activated);
            this.Load += new System.EventHandler(this.FormListagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJogos;
    }
}