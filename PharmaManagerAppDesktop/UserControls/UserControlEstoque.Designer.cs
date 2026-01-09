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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtCampoPesquisa = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPesquisar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdicionar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListaEstoque = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAtualizar = new Guna.UI2.WinForms.Guna2Button();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.btnAdicionar);
            this.panel2.Controls.Add(this.guna2Separator1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(1295, 137);
            this.panel2.TabIndex = 139;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel3);
            this.flowLayoutPanel1.Controls.Add(this.btnPesquisar);
            this.flowLayoutPanel1.Controls.Add(this.btnAtualizar);
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
            this.guna2Panel3.Controls.Add(this.txtCampoPesquisa);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.guna2Panel3.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(350, 53);
            this.guna2Panel3.TabIndex = 134;
            // 
            // txtCampoPesquisa
            // 
            this.txtCampoPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCampoPesquisa.BorderColor = System.Drawing.Color.Gray;
            this.txtCampoPesquisa.BorderRadius = 3;
            this.txtCampoPesquisa.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtCampoPesquisa.BorderThickness = 0;
            this.txtCampoPesquisa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCampoPesquisa.DefaultText = "";
            this.txtCampoPesquisa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCampoPesquisa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCampoPesquisa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCampoPesquisa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCampoPesquisa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCampoPesquisa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCampoPesquisa.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCampoPesquisa.ForeColor = System.Drawing.Color.Black;
            this.txtCampoPesquisa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCampoPesquisa.Location = new System.Drawing.Point(38, 4);
            this.txtCampoPesquisa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCampoPesquisa.Name = "txtCampoPesquisa";
            this.txtCampoPesquisa.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCampoPesquisa.PlaceholderText = "Pesquisar Produto";
            this.txtCampoPesquisa.SelectedText = "";
            this.txtCampoPesquisa.Size = new System.Drawing.Size(308, 44);
            this.txtCampoPesquisa.TabIndex = 62;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BorderRadius = 4;
            this.btnPesquisar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPesquisar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPesquisar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPesquisar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPesquisar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(183)))));
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(360, 4);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(130, 53);
            this.btnPesquisar.TabIndex = 135;
            this.btnPesquisar.Text = "Procurar";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdicionar.BorderRadius = 4;
            this.btnAdicionar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdicionar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdicionar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(154)))), ((int)(((byte)(112)))));
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(1003, 64);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(268, 53);
            this.btnAdicionar.TabIndex = 136;
            this.btnAdicionar.Text = "Adicionar Quantidade";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
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
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 32);
            this.label2.TabIndex = 73;
            this.label2.Text = "Lista de Estoque";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 681);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1295, 100);
            this.panel3.TabIndex = 141;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.btnEditar);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1137, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(138, 61);
            this.flowLayoutPanel2.TabIndex = 137;
            // 
            // btnEditar
            // 
            this.btnEditar.BorderRadius = 4;
            this.btnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(151)))), ((int)(((byte)(34)))));
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(4, 4);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 53);
            this.btnEditar.TabIndex = 137;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvListaEstoque);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1295, 544);
            this.panel1.TabIndex = 142;
            // 
            // dgvListaEstoque
            // 
            this.dgvListaEstoque.AllowUserToAddRows = false;
            this.dgvListaEstoque.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListaEstoque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaEstoque.ColumnHeadersHeight = 77;
            this.dgvListaEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListaEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.colId,
            this.colProduto,
            this.colFornecedor,
            this.colLote,
            this.colValidade,
            this.colQuantidade});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaEstoque.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaEstoque.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListaEstoque.Location = new System.Drawing.Point(20, 20);
            this.dgvListaEstoque.Name = "dgvListaEstoque";
            this.dgvListaEstoque.RowHeadersVisible = false;
            this.dgvListaEstoque.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.dgvListaEstoque.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListaEstoque.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaEstoque.RowTemplate.Height = 40;
            this.dgvListaEstoque.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListaEstoque.Size = new System.Drawing.Size(1255, 504);
            this.dgvListaEstoque.TabIndex = 135;
            this.dgvListaEstoque.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListaEstoque.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListaEstoque.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListaEstoque.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListaEstoque.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListaEstoque.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListaEstoque.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListaEstoque.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvListaEstoque.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListaEstoque.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaEstoque.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListaEstoque.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListaEstoque.ThemeStyle.HeaderStyle.Height = 77;
            this.dgvListaEstoque.ThemeStyle.ReadOnly = false;
            this.dgvListaEstoque.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListaEstoque.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaEstoque.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaEstoque.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListaEstoque.ThemeStyle.RowsStyle.Height = 40;
            this.dgvListaEstoque.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListaEstoque.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.White;
            this.btnAtualizar.BackgroundImage = global::PharmaManagerAppDesktop.Properties.Resources.magnifying_glass_fill__1_;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtualizar.BorderRadius = 4;
            this.btnAtualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAtualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAtualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAtualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAtualizar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(154)))), ((int)(((byte)(112)))));
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Image = global::PharmaManagerAppDesktop.Properties.Resources.arrow_counter_clockwise_fill__1_;
            this.btnAtualizar.ImageSize = new System.Drawing.Size(22, 22);
            this.btnAtualizar.Location = new System.Drawing.Point(497, 3);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(60, 53);
            this.btnAtualizar.TabIndex = 149;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
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
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colId.FillWeight = 108.4522F;
            this.colId.HeaderText = "Cód.";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 76;
            // 
            // colProduto
            // 
            this.colProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colProduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.colProduto.FillWeight = 150F;
            this.colProduto.HeaderText = "Produto";
            this.colProduto.MinimumWidth = 6;
            this.colProduto.Name = "colProduto";
            this.colProduto.ReadOnly = true;
            // 
            // colFornecedor
            // 
            this.colFornecedor.HeaderText = "Fornecedor";
            this.colFornecedor.MinimumWidth = 6;
            this.colFornecedor.Name = "colFornecedor";
            // 
            // colLote
            // 
            this.colLote.HeaderText = "Lote";
            this.colLote.MinimumWidth = 6;
            this.colLote.Name = "colLote";
            // 
            // colValidade
            // 
            this.colValidade.HeaderText = "Validade";
            this.colValidade.MinimumWidth = 6;
            this.colValidade.Name = "colValidade";
            this.colValidade.ReadOnly = true;
            // 
            // colQuantidade
            // 
            this.colQuantidade.FillWeight = 77.14286F;
            this.colQuantidade.HeaderText = "Quantidade";
            this.colQuantidade.MinimumWidth = 6;
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.ReadOnly = true;
            // 
            // UserControlEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlEstoque";
            this.Size = new System.Drawing.Size(1295, 781);
            this.Load += new System.EventHandler(this.UserControlEstoque_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtCampoPesquisa;
        private Guna.UI2.WinForms.Guna2Button btnPesquisar;
        private Guna.UI2.WinForms.Guna2Button btnAtualizar;
        private Guna.UI2.WinForms.Guna2Button btnAdicionar;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListaEstoque;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidade;
    }
}
