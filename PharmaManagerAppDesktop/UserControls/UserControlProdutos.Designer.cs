namespace PharmaManagerAppDesktop.UserControls
{
    partial class UserControlProdutos
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEliminarProdutos = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditarProduto = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListaProdutos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoriaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tbEstoqueCampoPesquisa = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEstoquePesquisarProduto = new Guna.UI2.WinForms.Guna2Button();
            this.btnEstoqueAtualizarListaProduto = new Guna.UI2.WinForms.Guna2Button();
            this.btnProdutoNovo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdutos)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 669);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1254, 100);
            this.panel3.TabIndex = 141;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.btnEliminarProdutos);
            this.flowLayoutPanel2.Controls.Add(this.btnEditarProduto);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(958, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(276, 61);
            this.flowLayoutPanel2.TabIndex = 137;
            // 
            // btnEliminarProdutos
            // 
            this.btnEliminarProdutos.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarProdutos.BorderRadius = 4;
            this.btnEliminarProdutos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarProdutos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarProdutos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarProdutos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarProdutos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(112)))));
            this.btnEliminarProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProdutos.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProdutos.Location = new System.Drawing.Point(4, 4);
            this.btnEliminarProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarProdutos.Name = "btnEliminarProdutos";
            this.btnEliminarProdutos.Size = new System.Drawing.Size(130, 53);
            this.btnEliminarProdutos.TabIndex = 136;
            this.btnEliminarProdutos.Text = "Eliminar";
            this.btnEliminarProdutos.Click += new System.EventHandler(this.btnEliminarProdutos_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.BorderRadius = 4;
            this.btnEditarProduto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarProduto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarProduto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditarProduto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditarProduto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(151)))), ((int)(((byte)(34)))));
            this.btnEditarProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProduto.ForeColor = System.Drawing.Color.White;
            this.btnEditarProduto.Location = new System.Drawing.Point(142, 4);
            this.btnEditarProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(130, 53);
            this.btnEditarProduto.TabIndex = 137;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvListaProdutos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1254, 532);
            this.panel1.TabIndex = 140;
            // 
            // dgvListaProdutos
            // 
            this.dgvListaProdutos.AllowUserToAddRows = false;
            this.dgvListaProdutos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListaProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaProdutos.ColumnHeadersHeight = 77;
            this.dgvListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.colIdProduto,
            this.colNomeProduto,
            this.colCategoriaProduto,
            this.colQuantidadeProduto,
            this.colPrecoProduto});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaProdutos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaProdutos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListaProdutos.Location = new System.Drawing.Point(20, 20);
            this.dgvListaProdutos.Name = "dgvListaProdutos";
            this.dgvListaProdutos.RowHeadersVisible = false;
            this.dgvListaProdutos.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.dgvListaProdutos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListaProdutos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaProdutos.RowTemplate.Height = 40;
            this.dgvListaProdutos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListaProdutos.Size = new System.Drawing.Size(1214, 492);
            this.dgvListaProdutos.TabIndex = 134;
            this.dgvListaProdutos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListaProdutos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListaProdutos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListaProdutos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListaProdutos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListaProdutos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListaProdutos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListaProdutos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvListaProdutos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListaProdutos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaProdutos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListaProdutos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListaProdutos.ThemeStyle.HeaderStyle.Height = 77;
            this.dgvListaProdutos.ThemeStyle.ReadOnly = false;
            this.dgvListaProdutos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListaProdutos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaProdutos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaProdutos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListaProdutos.ThemeStyle.RowsStyle.Height = 40;
            this.dgvListaProdutos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListaProdutos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // check
            // 
            this.check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.check.FillWeight = 10F;
            this.check.HeaderText = "#";
            this.check.MinimumWidth = 10;
            this.check.Name = "check";
            this.check.Width = 27;
            // 
            // colIdProduto
            // 
            this.colIdProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colIdProduto.FillWeight = 108.4522F;
            this.colIdProduto.HeaderText = "Cód.";
            this.colIdProduto.MinimumWidth = 6;
            this.colIdProduto.Name = "colIdProduto";
            this.colIdProduto.ReadOnly = true;
            this.colIdProduto.Width = 76;
            // 
            // colNomeProduto
            // 
            this.colNomeProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNomeProduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNomeProduto.FillWeight = 150F;
            this.colNomeProduto.HeaderText = "Produto";
            this.colNomeProduto.MinimumWidth = 6;
            this.colNomeProduto.Name = "colNomeProduto";
            this.colNomeProduto.ReadOnly = true;
            // 
            // colCategoriaProduto
            // 
            this.colCategoriaProduto.FillWeight = 77.14286F;
            this.colCategoriaProduto.HeaderText = "Categoria";
            this.colCategoriaProduto.MinimumWidth = 6;
            this.colCategoriaProduto.Name = "colCategoriaProduto";
            this.colCategoriaProduto.ReadOnly = true;
            // 
            // colQuantidadeProduto
            // 
            this.colQuantidadeProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colQuantidadeProduto.HeaderText = "Quantidade";
            this.colQuantidadeProduto.MinimumWidth = 6;
            this.colQuantidadeProduto.Name = "colQuantidadeProduto";
            this.colQuantidadeProduto.ReadOnly = true;
            this.colQuantidadeProduto.Width = 132;
            // 
            // colPrecoProduto
            // 
            this.colPrecoProduto.FillWeight = 77.14286F;
            this.colPrecoProduto.HeaderText = "Preço";
            this.colPrecoProduto.MinimumWidth = 6;
            this.colPrecoProduto.Name = "colPrecoProduto";
            this.colPrecoProduto.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.btnProdutoNovo);
            this.panel2.Controls.Add(this.guna2Separator1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(1254, 137);
            this.panel2.TabIndex = 139;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel3);
            this.flowLayoutPanel1.Controls.Add(this.btnEstoquePesquisarProduto);
            this.flowLayoutPanel1.Controls.Add(this.btnEstoqueAtualizarListaProduto);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(560, 61);
            this.flowLayoutPanel1.TabIndex = 134;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.AutoSize = true;
            this.guna2Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel3.BorderRadius = 3;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel3.Controls.Add(this.tbEstoqueCampoPesquisa);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.guna2Panel3.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(350, 53);
            this.guna2Panel3.TabIndex = 134;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::PharmaManagerAppDesktop.Properties.Resources.magnifying_glass_fill__1_;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(14, 17);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(20, 20);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 60;
            this.guna2PictureBox2.TabStop = false;
            // 
            // tbEstoqueCampoPesquisa
            // 
            this.tbEstoqueCampoPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbEstoqueCampoPesquisa.BorderColor = System.Drawing.Color.Gray;
            this.tbEstoqueCampoPesquisa.BorderRadius = 3;
            this.tbEstoqueCampoPesquisa.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.tbEstoqueCampoPesquisa.BorderThickness = 0;
            this.tbEstoqueCampoPesquisa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEstoqueCampoPesquisa.DefaultText = "";
            this.tbEstoqueCampoPesquisa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEstoqueCampoPesquisa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEstoqueCampoPesquisa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEstoqueCampoPesquisa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEstoqueCampoPesquisa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbEstoqueCampoPesquisa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEstoqueCampoPesquisa.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbEstoqueCampoPesquisa.ForeColor = System.Drawing.Color.Black;
            this.tbEstoqueCampoPesquisa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEstoqueCampoPesquisa.Location = new System.Drawing.Point(38, 4);
            this.tbEstoqueCampoPesquisa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEstoqueCampoPesquisa.Name = "tbEstoqueCampoPesquisa";
            this.tbEstoqueCampoPesquisa.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEstoqueCampoPesquisa.PlaceholderText = "Pesquisar Produto";
            this.tbEstoqueCampoPesquisa.SelectedText = "";
            this.tbEstoqueCampoPesquisa.Size = new System.Drawing.Size(308, 44);
            this.tbEstoqueCampoPesquisa.TabIndex = 62;
            // 
            // btnEstoquePesquisarProduto
            // 
            this.btnEstoquePesquisarProduto.BorderRadius = 4;
            this.btnEstoquePesquisarProduto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEstoquePesquisarProduto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEstoquePesquisarProduto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEstoquePesquisarProduto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEstoquePesquisarProduto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(183)))));
            this.btnEstoquePesquisarProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoquePesquisarProduto.ForeColor = System.Drawing.Color.White;
            this.btnEstoquePesquisarProduto.Location = new System.Drawing.Point(360, 4);
            this.btnEstoquePesquisarProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstoquePesquisarProduto.Name = "btnEstoquePesquisarProduto";
            this.btnEstoquePesquisarProduto.Size = new System.Drawing.Size(130, 53);
            this.btnEstoquePesquisarProduto.TabIndex = 135;
            this.btnEstoquePesquisarProduto.Text = "Procurar";
            // 
            // btnEstoqueAtualizarListaProduto
            // 
            this.btnEstoqueAtualizarListaProduto.BackColor = System.Drawing.Color.White;
            this.btnEstoqueAtualizarListaProduto.BackgroundImage = global::PharmaManagerAppDesktop.Properties.Resources.magnifying_glass_fill__1_;
            this.btnEstoqueAtualizarListaProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEstoqueAtualizarListaProduto.BorderRadius = 4;
            this.btnEstoqueAtualizarListaProduto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEstoqueAtualizarListaProduto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEstoqueAtualizarListaProduto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEstoqueAtualizarListaProduto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEstoqueAtualizarListaProduto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(154)))), ((int)(((byte)(112)))));
            this.btnEstoqueAtualizarListaProduto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEstoqueAtualizarListaProduto.ForeColor = System.Drawing.Color.White;
            this.btnEstoqueAtualizarListaProduto.Image = global::PharmaManagerAppDesktop.Properties.Resources.arrow_counter_clockwise_fill__1_;
            this.btnEstoqueAtualizarListaProduto.ImageSize = new System.Drawing.Size(22, 22);
            this.btnEstoqueAtualizarListaProduto.Location = new System.Drawing.Point(497, 3);
            this.btnEstoqueAtualizarListaProduto.Name = "btnEstoqueAtualizarListaProduto";
            this.btnEstoqueAtualizarListaProduto.Size = new System.Drawing.Size(60, 53);
            this.btnEstoqueAtualizarListaProduto.TabIndex = 149;
            // 
            // btnProdutoNovo
            // 
            this.btnProdutoNovo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnProdutoNovo.BorderRadius = 4;
            this.btnProdutoNovo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProdutoNovo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProdutoNovo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProdutoNovo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProdutoNovo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(154)))), ((int)(((byte)(112)))));
            this.btnProdutoNovo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnProdutoNovo.ForeColor = System.Drawing.Color.White;
            this.btnProdutoNovo.Location = new System.Drawing.Point(1020, 64);
            this.btnProdutoNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnProdutoNovo.Name = "btnProdutoNovo";
            this.btnProdutoNovo.Size = new System.Drawing.Size(210, 53);
            this.btnProdutoNovo.TabIndex = 136;
            this.btnProdutoNovo.Text = "Novo Produto";
            this.btnProdutoNovo.Click += new System.EventHandler(this.btnProdutoNovo_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(23, 124);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1208, 10);
            this.guna2Separator1.TabIndex = 133;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 32);
            this.label2.TabIndex = 73;
            this.label2.Text = "Lista de Produtos";
            // 
            // UserControlProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "UserControlProdutos";
            this.Size = new System.Drawing.Size(1254, 769);
            this.Load += new System.EventHandler(this.UserControlProdutos_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdutos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button btnEliminarProdutos;
        private Guna.UI2.WinForms.Guna2Button btnEditarProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox tbEstoqueCampoPesquisa;
        private Guna.UI2.WinForms.Guna2Button btnEstoquePesquisarProduto;
        private Guna.UI2.WinForms.Guna2Button btnEstoqueAtualizarListaProduto;
        private Guna.UI2.WinForms.Guna2Button btnProdutoNovo;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListaProdutos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoriaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecoProduto;
    }
}
