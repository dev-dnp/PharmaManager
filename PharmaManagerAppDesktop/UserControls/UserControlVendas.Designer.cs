namespace PharmaManagerAppDesktop.UserControls
{
    partial class UserControlVendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle81 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle82 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle89 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle90 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle83 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle84 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle85 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle86 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle87 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle88 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionarCliente = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.dgvListaItemProduto = new Guna.UI2.WinForms.Guna2DataGridView();
            this.codigoProdutoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeProdutoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnitarioProdutoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoProdutoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxaDeImpostoProdutoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDoImpostoProdutoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalProdutoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdicionarItemProduto = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaItemProduto)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 32);
            this.label2.TabIndex = 73;
            this.label2.Text = "Nova Fatura";
            // 
            // btnAdicionarCliente
            // 
            this.btnAdicionarCliente.BorderRadius = 4;
            this.btnAdicionarCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionarCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdicionarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdicionarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionarCliente.Location = new System.Drawing.Point(4, 4);
            this.btnAdicionarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionarCliente.Name = "btnAdicionarCliente";
            this.btnAdicionarCliente.Size = new System.Drawing.Size(252, 58);
            this.btnAdicionarCliente.TabIndex = 130;
            this.btnAdicionarCliente.Text = "Adicionar Cliente";
            this.btnAdicionarCliente.Click += new System.EventHandler(this.btnAdicionarCliente_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.guna2Separator1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1275, 137);
            this.panel2.TabIndex = 132;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnAdicionarCliente);
            this.flowLayoutPanel1.Controls.Add(this.btnAdicionarItemProduto);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(733, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(522, 66);
            this.flowLayoutPanel1.TabIndex = 134;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(20, 124);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1235, 10);
            this.guna2Separator1.TabIndex = 133;
            // 
            // dgvListaItemProduto
            // 
            dataGridViewCellStyle81.BackColor = System.Drawing.Color.White;
            this.dgvListaItemProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle81;
            dataGridViewCellStyle82.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle82.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle82.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle82.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle82.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle82.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle82.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaItemProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle82;
            this.dgvListaItemProduto.ColumnHeadersHeight = 77;
            this.dgvListaItemProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListaItemProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProdutoItem,
            this.nomeProdutoItem,
            this.quantidadeProdutoItem,
            this.precoUnitarioProdutoItem,
            this.descontoProdutoItem,
            this.taxaDeImpostoProdutoItem,
            this.valorDoImpostoProdutoItem,
            this.totalProdutoItem});
            dataGridViewCellStyle89.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle89.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle89.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle89.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle89.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle89.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle89.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaItemProduto.DefaultCellStyle = dataGridViewCellStyle89;
            this.dgvListaItemProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaItemProduto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListaItemProduto.Location = new System.Drawing.Point(20, 20);
            this.dgvListaItemProduto.Name = "dgvListaItemProduto";
            this.dgvListaItemProduto.RowHeadersVisible = false;
            this.dgvListaItemProduto.RowHeadersWidth = 51;
            dataGridViewCellStyle90.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle90.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle90.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.dgvListaItemProduto.RowsDefaultCellStyle = dataGridViewCellStyle90;
            this.dgvListaItemProduto.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaItemProduto.RowTemplate.Height = 40;
            this.dgvListaItemProduto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListaItemProduto.Size = new System.Drawing.Size(1235, 420);
            this.dgvListaItemProduto.TabIndex = 133;
            this.dgvListaItemProduto.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListaItemProduto.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListaItemProduto.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListaItemProduto.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListaItemProduto.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListaItemProduto.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListaItemProduto.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListaItemProduto.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvListaItemProduto.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListaItemProduto.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaItemProduto.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListaItemProduto.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListaItemProduto.ThemeStyle.HeaderStyle.Height = 77;
            this.dgvListaItemProduto.ThemeStyle.ReadOnly = false;
            this.dgvListaItemProduto.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListaItemProduto.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaItemProduto.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaItemProduto.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListaItemProduto.ThemeStyle.RowsStyle.Height = 40;
            this.dgvListaItemProduto.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListaItemProduto.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // codigoProdutoItem
            // 
            this.codigoProdutoItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.codigoProdutoItem.FillWeight = 108.4522F;
            this.codigoProdutoItem.HeaderText = "Cód.";
            this.codigoProdutoItem.MinimumWidth = 6;
            this.codigoProdutoItem.Name = "codigoProdutoItem";
            this.codigoProdutoItem.Width = 76;
            // 
            // nomeProdutoItem
            // 
            this.nomeProdutoItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeProdutoItem.HeaderText = "Produto";
            this.nomeProdutoItem.MinimumWidth = 6;
            this.nomeProdutoItem.Name = "nomeProdutoItem";
            // 
            // quantidadeProdutoItem
            // 
            this.quantidadeProdutoItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle83.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantidadeProdutoItem.DefaultCellStyle = dataGridViewCellStyle83;
            this.quantidadeProdutoItem.FillWeight = 34.13703F;
            this.quantidadeProdutoItem.HeaderText = "Qntd.";
            this.quantidadeProdutoItem.MinimumWidth = 6;
            this.quantidadeProdutoItem.Name = "quantidadeProdutoItem";
            this.quantidadeProdutoItem.Width = 84;
            // 
            // precoUnitarioProdutoItem
            // 
            this.precoUnitarioProdutoItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle84.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.precoUnitarioProdutoItem.DefaultCellStyle = dataGridViewCellStyle84;
            this.precoUnitarioProdutoItem.HeaderText = "Preço unitário";
            this.precoUnitarioProdutoItem.MinimumWidth = 6;
            this.precoUnitarioProdutoItem.Name = "precoUnitarioProdutoItem";
            this.precoUnitarioProdutoItem.Width = 135;
            // 
            // descontoProdutoItem
            // 
            this.descontoProdutoItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle85.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.descontoProdutoItem.DefaultCellStyle = dataGridViewCellStyle85;
            this.descontoProdutoItem.FillWeight = 85.34258F;
            this.descontoProdutoItem.HeaderText = "Desconto";
            this.descontoProdutoItem.MinimumWidth = 6;
            this.descontoProdutoItem.Name = "descontoProdutoItem";
            this.descontoProdutoItem.Width = 115;
            // 
            // taxaDeImpostoProdutoItem
            // 
            this.taxaDeImpostoProdutoItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle86.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.taxaDeImpostoProdutoItem.DefaultCellStyle = dataGridViewCellStyle86;
            this.taxaDeImpostoProdutoItem.FillWeight = 34.13703F;
            this.taxaDeImpostoProdutoItem.HeaderText = "Taxa de Imposto (%)";
            this.taxaDeImpostoProdutoItem.MinimumWidth = 6;
            this.taxaDeImpostoProdutoItem.Name = "taxaDeImpostoProdutoItem";
            this.taxaDeImpostoProdutoItem.Width = 126;
            // 
            // valorDoImpostoProdutoItem
            // 
            this.valorDoImpostoProdutoItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle87.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.valorDoImpostoProdutoItem.DefaultCellStyle = dataGridViewCellStyle87;
            this.valorDoImpostoProdutoItem.HeaderText = "Valor do Imposto";
            this.valorDoImpostoProdutoItem.MinimumWidth = 6;
            this.valorDoImpostoProdutoItem.Name = "valorDoImpostoProdutoItem";
            this.valorDoImpostoProdutoItem.Width = 163;
            // 
            // totalProdutoItem
            // 
            this.totalProdutoItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle88.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.totalProdutoItem.DefaultCellStyle = dataGridViewCellStyle88;
            this.totalProdutoItem.FillWeight = 37.13013F;
            this.totalProdutoItem.HeaderText = "Total";
            this.totalProdutoItem.MinimumWidth = 6;
            this.totalProdutoItem.Name = "totalProdutoItem";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvListaItemProduto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1275, 460);
            this.panel1.TabIndex = 133;
            // 
            // btnAdicionarItemProduto
            // 
            this.btnAdicionarItemProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarItemProduto.BorderRadius = 4;
            this.btnAdicionarItemProduto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionarItemProduto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionarItemProduto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdicionarItemProduto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdicionarItemProduto.FillColor = System.Drawing.Color.MediumAquamarine;
            this.btnAdicionarItemProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarItemProduto.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionarItemProduto.Image = global::PharmaManagerAppDesktop.Properties.Resources.shopping_cart1;
            this.btnAdicionarItemProduto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdicionarItemProduto.Location = new System.Drawing.Point(264, 4);
            this.btnAdicionarItemProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionarItemProduto.Name = "btnAdicionarItemProduto";
            this.btnAdicionarItemProduto.Size = new System.Drawing.Size(248, 58);
            this.btnAdicionarItemProduto.TabIndex = 131;
            this.btnAdicionarItemProduto.Text = "Adicionar produto";
            this.btnAdicionarItemProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAdicionarItemProduto.Click += new System.EventHandler(this.btnAdicionarItemProduto_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2Separator2);
            this.panel3.Controls.Add(this.guna2CustomGradientPanel1);
            this.panel3.Controls.Add(this.guna2Button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 597);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20);
            this.panel3.Size = new System.Drawing.Size(1275, 202);
            this.panel3.TabIndex = 135;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Button1.BorderRadius = 4;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.MediumAquamarine;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = global::PharmaManagerAppDesktop.Properties.Resources.check_circle_fill;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button1.Location = new System.Drawing.Point(1045, 29);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(210, 58);
            this.guna2Button1.TabIndex = 132;
            this.guna2Button1.Text = "Finalizar venda";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 133;
            this.label1.Text = "Total sem descontos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 134;
            this.label3.Text = "Valor do Imposto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 135;
            this.label4.Text = "Total de Desconto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 136;
            this.label5.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 137;
            this.label6.Text = "0,00 AOA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(248, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 138;
            this.label7.Text = "0,00 AOA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(248, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 23);
            this.label8.TabIndex = 139;
            this.label8.Text = "0,00 AOA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(248, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 23);
            this.label9.TabIndex = 140;
            this.label9.Text = "0,00 AOA";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.label7);
            this.guna2CustomGradientPanel1.Controls.Add(this.label9);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.label8);
            this.guna2CustomGradientPanel1.Controls.Add(this.label3);
            this.guna2CustomGradientPanel1.Controls.Add(this.label4);
            this.guna2CustomGradientPanel1.Controls.Add(this.label6);
            this.guna2CustomGradientPanel1.Controls.Add(this.label5);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(3, 29);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(383, 153);
            this.guna2CustomGradientPanel1.TabIndex = 141;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.Location = new System.Drawing.Point(13, 6);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(1235, 10);
            this.guna2Separator2.TabIndex = 142;
            // 
            // UserControlVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlVendas";
            this.Size = new System.Drawing.Size(1275, 799);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaItemProduto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnAdicionarCliente;
        private Guna.UI2.WinForms.Guna2Button btnAdicionarItemProduto;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListaItemProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProdutoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeProdutoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnitarioProdutoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoProdutoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxaDeImpostoProdutoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDoImpostoProdutoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalProdutoItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
    }
}
