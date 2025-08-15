namespace ListaDeCompras
{
    partial class Forms1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms1));
            this.piblogo = new System.Windows.Forms.PictureBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txbproduto = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.libCompras = new System.Windows.Forms.ListBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dtvCompras = new System.Windows.Forms.DataGridView();
            this.coluna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.piblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // piblogo
            // 
            this.piblogo.Image = global::ListaDeCompras.Properties.Resources.Logo;
            this.piblogo.Location = new System.Drawing.Point(90, 21);
            this.piblogo.Name = "piblogo";
            this.piblogo.Size = new System.Drawing.Size(83, 77);
            this.piblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piblogo.TabIndex = 0;
            this.piblogo.TabStop = false;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(214, 12);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(536, 86);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Lista de compras ";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(12, 185);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(178, 26);
            this.lblNomeProduto.TabIndex = 2;
            this.lblNomeProduto.Text = "Nome do produto:";
            // 
            // txbproduto
            // 
            this.txbproduto.Location = new System.Drawing.Point(196, 188);
            this.txbproduto.Name = "txbproduto";
            this.txbproduto.Size = new System.Drawing.Size(173, 25);
            this.txbproduto.TabIndex = 3;
            this.txbproduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbproduto_KeyDown);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(90, 322);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(173, 39);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // libCompras
            // 
            this.libCompras.FormattingEnabled = true;
            this.libCompras.ItemHeight = 18;
            this.libCompras.Location = new System.Drawing.Point(390, 185);
            this.libCompras.Name = "libCompras";
            this.libCompras.Size = new System.Drawing.Size(398, 256);
            this.libCompras.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(390, 443);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(205, 34);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir item";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(601, 443);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(187, 34);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar lista";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dtvCompras
            // 
            this.dtvCompras.BackgroundColor = System.Drawing.Color.White;
            this.dtvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coluna1,
            this.Coluna2,
            this.coluna3});
            this.dtvCompras.Location = new System.Drawing.Point(390, 268);
            this.dtvCompras.Name = "dtvCompras";
            this.dtvCompras.Size = new System.Drawing.Size(398, 173);
            this.dtvCompras.TabIndex = 8;
            // 
            // coluna1
            // 
            this.coluna1.HeaderText = "Nome";
            this.coluna1.Name = "coluna1";
            this.coluna1.ReadOnly = true;
            // 
            // Coluna2
            // 
            this.Coluna2.HeaderText = "Quantidae";
            this.Coluna2.Name = "Coluna2";
            this.Coluna2.ReadOnly = true;
            // 
            // coluna3
            // 
            this.coluna3.HeaderText = "Marca";
            this.coluna3.Name = "coluna3";
            this.coluna3.ReadOnly = true;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(27, 222);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(129, 26);
            this.lblQuantidade.TabIndex = 9;
            this.lblQuantidade.Text = "Quantidade: ";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(52, 257);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(72, 26);
            this.lblMarca.TabIndex = 10;
            this.lblMarca.Text = "Marca:";
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(196, 257);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(173, 25);
            this.txbMarca.TabIndex = 11;
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(196, 225);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(173, 25);
            this.txbQuantidade.TabIndex = 12;
            // 
            // Forms1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 530);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.dtvCompras);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.libCompras);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txbproduto);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.piblogo);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Forms1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de compras";
            ((System.ComponentModel.ISupportInitialize)(this.piblogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox piblogo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txbproduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox libCompras;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dtvCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna3;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.TextBox txbQuantidade;
    }
}

