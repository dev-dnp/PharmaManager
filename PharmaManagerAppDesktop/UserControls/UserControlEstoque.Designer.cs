namespace PharmaManagerAppDesktop.UserControls
{
    partial class UserControlEstoque
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEstoqueNovoProduto = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEstoqueListaProdutos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.selecionarLinhaProduto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codEstoqueProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEstoqueProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaEstoqueProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loteEstoqueProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMovimentoEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeEstoqueProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEstoqueDetalhesProduto = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoqueListaProdutos)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEstoqueNovoProduto);
            this.panel2.Controls.Add(this.guna2Separator1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(1295, 137);
            this.panel2.TabIndex = 136;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnEstoqueNovoProduto
            // 
            this.btnEstoqueNovoProduto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEstoqueNovoProduto.BorderRadius = 4;
            this.btnEstoqueNovoProduto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEstoqueNovoProduto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEstoqueNovoProduto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEstoqueNovoProduto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEstoqueNovoProduto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(154)))), ((int)(((byte)(112)))));
            this.btnEstoqueNovoProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEstoqueNovoProduto.ForeColor = System.Drawing.Color.White;
            this.btnEstoqueNovoProduto.Location = new System.Drawing.Point(1012, 64);
            this.btnEstoqueNovoProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstoqueNovoProduto.Name = "btnEstoqueNovoProduto";
            this.btnEstoqueNovoProduto.Size = new System.Drawing.Size(259, 53);
            this.btnEstoqueNovoProduto.TabIndex = 136;
            this.btnEstoqueNovoProduto.Text = "Adicionar Quantidade";
            this.btnEstoqueNovoProduto.Click += new System.EventHandler(this.btnEstoqueNovoProduto_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(23, 124);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1249, 10);
            this.guna2Separator1.TabIndex = 133;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 73;
            this.label2.Text = "Estoque";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvEstoqueListaProdutos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1295, 644);
            this.panel1.TabIndex = 137;
            // 
            // dgvEstoqueListaProdutos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEstoqueListaProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstoqueListaProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstoqueListaProdutos.ColumnHeadersHeight = 77;
            this.dgvEstoqueListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEstoqueListaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecionarLinhaProduto,
            this.codEstoqueProduto,
            this.nomeEstoqueProduto,
            this.categoriaEstoqueProduto,
            this.loteEstoqueProduto,
            this.idFuncionario,
            this.tipoMovimentoEstoque,
            this.quantidadeEstoqueProduto});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstoqueListaProdutos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEstoqueListaProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstoqueListaProdutos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEstoqueListaProdutos.Location = new System.Drawing.Point(20, 20);
            this.dgvEstoqueListaProdutos.Name = "dgvEstoqueListaProdutos";
            this.dgvEstoqueListaProdutos.RowHeadersVisible = false;
            this.dgvEstoqueListaProdutos.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.dgvEstoqueListaProdutos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEstoqueListaProdutos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEstoqueListaProdutos.RowTemplate.Height = 40;
            this.dgvEstoqueListaProdutos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvEstoqueListaProdutos.Size = new System.Drawing.Size(1255, 604);
            this.dgvEstoqueListaProdutos.TabIndex = 133;
            this.dgvEstoqueListaProdutos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEstoqueListaProdutos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEstoqueListaProdutos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEstoqueListaProdutos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEstoqueListaProdutos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEstoqueListaProdutos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEstoqueListaProdutos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEstoqueListaProdutos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEstoqueListaProdutos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEstoqueListaProdutos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEstoqueListaProdutos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEstoqueListaProdutos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEstoqueListaProdutos.ThemeStyle.HeaderStyle.Height = 77;
            this.dgvEstoqueListaProdutos.ThemeStyle.ReadOnly = false;
            this.dgvEstoqueListaProdutos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEstoqueListaProdutos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEstoqueListaProdutos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEstoqueListaProdutos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEstoqueListaProdutos.ThemeStyle.RowsStyle.Height = 40;
            this.dgvEstoqueListaProdutos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEstoqueListaProdutos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // selecionarLinhaProduto
            // 
            this.selecionarLinhaProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.selecionarLinhaProduto.FillWeight = 214.2857F;
            this.selecionarLinhaProduto.HeaderText = "";
            this.selecionarLinhaProduto.MinimumWidth = 6;
            this.selecionarLinhaProduto.Name = "selecionarLinhaProduto";
            this.selecionarLinhaProduto.Width = 23;
            // 
            // codEstoqueProduto
            // 
            this.codEstoqueProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.codEstoqueProduto.FillWeight = 108.4522F;
            this.codEstoqueProduto.HeaderText = "ID Mov.";
            this.codEstoqueProduto.MinimumWidth = 6;
            this.codEstoqueProduto.Name = "codEstoqueProduto";
            this.codEstoqueProduto.Width = 94;
            // 
            // nomeEstoqueProduto
            // 
            this.nomeEstoqueProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nomeEstoqueProduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.nomeEstoqueProduto.FillWeight = 150F;
            this.nomeEstoqueProduto.HeaderText = "Produto";
            this.nomeEstoqueProduto.MinimumWidth = 6;
            this.nomeEstoqueProduto.Name = "nomeEstoqueProduto";
            // 
            // categoriaEstoqueProduto
            // 
            this.categoriaEstoqueProduto.FillWeight = 77.14286F;
            this.categoriaEstoqueProduto.HeaderText = "Categoria";
            this.categoriaEstoqueProduto.MinimumWidth = 6;
            this.categoriaEstoqueProduto.Name = "categoriaEstoqueProduto";
            // 
            // loteEstoqueProduto
            // 
            this.loteEstoqueProduto.FillWeight = 77.14286F;
            this.loteEstoqueProduto.HeaderText = "Lote";
            this.loteEstoqueProduto.MinimumWidth = 6;
            this.loteEstoqueProduto.Name = "loteEstoqueProduto";
            // 
            // idFuncionario
            // 
            this.idFuncionario.HeaderText = "Funcionário";
            this.idFuncionario.MinimumWidth = 6;
            this.idFuncionario.Name = "idFuncionario";
            // 
            // tipoMovimentoEstoque
            // 
            this.tipoMovimentoEstoque.HeaderText = "Tipo";
            this.tipoMovimentoEstoque.MinimumWidth = 6;
            this.tipoMovimentoEstoque.Name = "tipoMovimentoEstoque";
            // 
            // quantidadeEstoqueProduto
            // 
            this.quantidadeEstoqueProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.quantidadeEstoqueProduto.HeaderText = "Quantidade";
            this.quantidadeEstoqueProduto.MinimumWidth = 6;
            this.quantidadeEstoqueProduto.Name = "quantidadeEstoqueProduto";
            this.quantidadeEstoqueProduto.Width = 132;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 681);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1295, 100);
            this.panel3.TabIndex = 138;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.btnEstoqueDetalhesProduto);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1137, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(138, 61);
            this.flowLayoutPanel2.TabIndex = 137;
            // 
            // btnEstoqueDetalhesProduto
            // 
            this.btnEstoqueDetalhesProduto.BorderRadius = 4;
            this.btnEstoqueDetalhesProduto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEstoqueDetalhesProduto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEstoqueDetalhesProduto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEstoqueDetalhesProduto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEstoqueDetalhesProduto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(183)))));
            this.btnEstoqueDetalhesProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueDetalhesProduto.ForeColor = System.Drawing.Color.White;
            this.btnEstoqueDetalhesProduto.Location = new System.Drawing.Point(4, 4);
            this.btnEstoqueDetalhesProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstoqueDetalhesProduto.Name = "btnEstoqueDetalhesProduto";
            this.btnEstoqueDetalhesProduto.Size = new System.Drawing.Size(130, 53);
            this.btnEstoqueDetalhesProduto.TabIndex = 138;
            this.btnEstoqueDetalhesProduto.Text = "Detalhes";
            // 
            // UserControlEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlEstoque";
            this.Size = new System.Drawing.Size(1295, 781);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoqueListaProdutos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEstoqueListaProdutos;
        private Guna.UI2.WinForms.Guna2Button btnEstoqueNovoProduto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button btnEstoqueDetalhesProduto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecionarLinhaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEstoqueProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEstoqueProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaEstoqueProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn loteEstoqueProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMovimentoEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeEstoqueProduto;
    }
}
