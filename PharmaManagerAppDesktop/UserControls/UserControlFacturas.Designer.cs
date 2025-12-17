namespace PharmaManagerAppDesktop.UserControls
{
    partial class UserControlFacturas
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
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tbFacturaCampoPesquisa = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFaturaPesquisar = new Guna.UI2.WinForms.Guna2Button();
            this.btnFacturaAtualizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnNovaFatura = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFacturaCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnFacturaDetalhes = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvFaturaLista = new Guna.UI2.WinForms.Guna2DataGridView();
            this.checkFactura = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmissaoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimentoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoPagamentoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturaLista)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.btnNovaFatura);
            this.panel2.Controls.Add(this.guna2Separator1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(1223, 137);
            this.panel2.TabIndex = 137;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel3);
            this.flowLayoutPanel1.Controls.Add(this.btnFaturaPesquisar);
            this.flowLayoutPanel1.Controls.Add(this.btnFacturaAtualizar);
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
            this.guna2Panel3.Controls.Add(this.tbFacturaCampoPesquisa);
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
            // tbFacturaCampoPesquisa
            // 
            this.tbFacturaCampoPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbFacturaCampoPesquisa.BorderColor = System.Drawing.Color.Gray;
            this.tbFacturaCampoPesquisa.BorderRadius = 3;
            this.tbFacturaCampoPesquisa.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.tbFacturaCampoPesquisa.BorderThickness = 0;
            this.tbFacturaCampoPesquisa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFacturaCampoPesquisa.DefaultText = "";
            this.tbFacturaCampoPesquisa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFacturaCampoPesquisa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFacturaCampoPesquisa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFacturaCampoPesquisa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFacturaCampoPesquisa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbFacturaCampoPesquisa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFacturaCampoPesquisa.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbFacturaCampoPesquisa.ForeColor = System.Drawing.Color.Black;
            this.tbFacturaCampoPesquisa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFacturaCampoPesquisa.Location = new System.Drawing.Point(38, 4);
            this.tbFacturaCampoPesquisa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFacturaCampoPesquisa.Name = "tbFacturaCampoPesquisa";
            this.tbFacturaCampoPesquisa.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbFacturaCampoPesquisa.PlaceholderText = "Pesquisar Factura";
            this.tbFacturaCampoPesquisa.SelectedText = "";
            this.tbFacturaCampoPesquisa.Size = new System.Drawing.Size(308, 44);
            this.tbFacturaCampoPesquisa.TabIndex = 62;
            // 
            // btnFaturaPesquisar
            // 
            this.btnFaturaPesquisar.BorderRadius = 4;
            this.btnFaturaPesquisar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFaturaPesquisar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFaturaPesquisar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFaturaPesquisar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFaturaPesquisar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(183)))));
            this.btnFaturaPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturaPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnFaturaPesquisar.Location = new System.Drawing.Point(360, 4);
            this.btnFaturaPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFaturaPesquisar.Name = "btnFaturaPesquisar";
            this.btnFaturaPesquisar.Size = new System.Drawing.Size(130, 53);
            this.btnFaturaPesquisar.TabIndex = 135;
            this.btnFaturaPesquisar.Text = "Procurar";
            // 
            // btnFacturaAtualizar
            // 
            this.btnFacturaAtualizar.BackColor = System.Drawing.Color.White;
            this.btnFacturaAtualizar.BackgroundImage = global::PharmaManagerAppDesktop.Properties.Resources.magnifying_glass_fill__1_;
            this.btnFacturaAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFacturaAtualizar.BorderRadius = 4;
            this.btnFacturaAtualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFacturaAtualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFacturaAtualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFacturaAtualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFacturaAtualizar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(154)))), ((int)(((byte)(112)))));
            this.btnFacturaAtualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFacturaAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnFacturaAtualizar.Image = global::PharmaManagerAppDesktop.Properties.Resources.arrow_counter_clockwise_fill__1_;
            this.btnFacturaAtualizar.ImageSize = new System.Drawing.Size(22, 22);
            this.btnFacturaAtualizar.Location = new System.Drawing.Point(497, 3);
            this.btnFacturaAtualizar.Name = "btnFacturaAtualizar";
            this.btnFacturaAtualizar.Size = new System.Drawing.Size(60, 53);
            this.btnFacturaAtualizar.TabIndex = 149;
            // 
            // btnNovaFatura
            // 
            this.btnNovaFatura.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNovaFatura.BorderRadius = 4;
            this.btnNovaFatura.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNovaFatura.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNovaFatura.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNovaFatura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNovaFatura.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(154)))), ((int)(((byte)(112)))));
            this.btnNovaFatura.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNovaFatura.ForeColor = System.Drawing.Color.White;
            this.btnNovaFatura.Location = new System.Drawing.Point(989, 64);
            this.btnNovaFatura.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovaFatura.Name = "btnNovaFatura";
            this.btnNovaFatura.Size = new System.Drawing.Size(210, 53);
            this.btnNovaFatura.TabIndex = 136;
            this.btnNovaFatura.Text = "Nova fatura";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(23, 124);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1177, 10);
            this.guna2Separator1.TabIndex = 133;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 32);
            this.label2.TabIndex = 73;
            this.label2.Text = "Lista de Facturas";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 636);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1223, 100);
            this.panel3.TabIndex = 139;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.btnFacturaCancelar);
            this.flowLayoutPanel2.Controls.Add(this.btnFacturaDetalhes);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(927, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(276, 61);
            this.flowLayoutPanel2.TabIndex = 137;
            // 
            // btnFacturaCancelar
            // 
            this.btnFacturaCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnFacturaCancelar.BorderRadius = 4;
            this.btnFacturaCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFacturaCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFacturaCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFacturaCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFacturaCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(112)))));
            this.btnFacturaCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturaCancelar.ForeColor = System.Drawing.Color.White;
            this.btnFacturaCancelar.Location = new System.Drawing.Point(4, 4);
            this.btnFacturaCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFacturaCancelar.Name = "btnFacturaCancelar";
            this.btnFacturaCancelar.Size = new System.Drawing.Size(130, 53);
            this.btnFacturaCancelar.TabIndex = 136;
            this.btnFacturaCancelar.Text = "Cancelar";
            this.btnFacturaCancelar.Click += new System.EventHandler(this.btnFacturaCancelar_Click);
            // 
            // btnFacturaDetalhes
            // 
            this.btnFacturaDetalhes.BorderRadius = 4;
            this.btnFacturaDetalhes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFacturaDetalhes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFacturaDetalhes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFacturaDetalhes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFacturaDetalhes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(183)))));
            this.btnFacturaDetalhes.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturaDetalhes.ForeColor = System.Drawing.Color.White;
            this.btnFacturaDetalhes.Location = new System.Drawing.Point(142, 4);
            this.btnFacturaDetalhes.Margin = new System.Windows.Forms.Padding(4);
            this.btnFacturaDetalhes.Name = "btnFacturaDetalhes";
            this.btnFacturaDetalhes.Size = new System.Drawing.Size(130, 53);
            this.btnFacturaDetalhes.TabIndex = 138;
            this.btnFacturaDetalhes.Text = "Detalhes";
            this.btnFacturaDetalhes.Click += new System.EventHandler(this.btnFacturaDetalhes_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvFaturaLista);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1223, 499);
            this.panel1.TabIndex = 140;
            // 
            // dgvFaturaLista
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvFaturaLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFaturaLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFaturaLista.ColumnHeadersHeight = 77;
            this.dgvFaturaLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvFaturaLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFactura,
            this.codFactura,
            this.nomeClienteFactura,
            this.dataEmissaoFactura,
            this.dataVencimentoFactura,
            this.metodoPagamentoFactura,
            this.statusFactura,
            this.valorTotalFactura});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFaturaLista.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFaturaLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFaturaLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFaturaLista.Location = new System.Drawing.Point(20, 20);
            this.dgvFaturaLista.Name = "dgvFaturaLista";
            this.dgvFaturaLista.RowHeadersVisible = false;
            this.dgvFaturaLista.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.dgvFaturaLista.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFaturaLista.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFaturaLista.RowTemplate.Height = 40;
            this.dgvFaturaLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFaturaLista.Size = new System.Drawing.Size(1183, 459);
            this.dgvFaturaLista.TabIndex = 133;
            this.dgvFaturaLista.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFaturaLista.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFaturaLista.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFaturaLista.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFaturaLista.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFaturaLista.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvFaturaLista.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFaturaLista.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvFaturaLista.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFaturaLista.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFaturaLista.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFaturaLista.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvFaturaLista.ThemeStyle.HeaderStyle.Height = 77;
            this.dgvFaturaLista.ThemeStyle.ReadOnly = false;
            this.dgvFaturaLista.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFaturaLista.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFaturaLista.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFaturaLista.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFaturaLista.ThemeStyle.RowsStyle.Height = 40;
            this.dgvFaturaLista.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFaturaLista.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // checkFactura
            // 
            this.checkFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.checkFactura.FillWeight = 214.2857F;
            this.checkFactura.HeaderText = "";
            this.checkFactura.MinimumWidth = 6;
            this.checkFactura.Name = "checkFactura";
            this.checkFactura.Width = 23;
            // 
            // codFactura
            // 
            this.codFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.codFactura.FillWeight = 108.4522F;
            this.codFactura.HeaderText = "Cód.";
            this.codFactura.MinimumWidth = 6;
            this.codFactura.Name = "codFactura";
            this.codFactura.Width = 76;
            // 
            // nomeClienteFactura
            // 
            this.nomeClienteFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nomeClienteFactura.DefaultCellStyle = dataGridViewCellStyle3;
            this.nomeClienteFactura.FillWeight = 150F;
            this.nomeClienteFactura.HeaderText = "Cliente";
            this.nomeClienteFactura.MinimumWidth = 6;
            this.nomeClienteFactura.Name = "nomeClienteFactura";
            // 
            // dataEmissaoFactura
            // 
            this.dataEmissaoFactura.FillWeight = 77.14286F;
            this.dataEmissaoFactura.HeaderText = "Data de emissão";
            this.dataEmissaoFactura.MinimumWidth = 6;
            this.dataEmissaoFactura.Name = "dataEmissaoFactura";
            // 
            // dataVencimentoFactura
            // 
            this.dataVencimentoFactura.FillWeight = 77.14286F;
            this.dataVencimentoFactura.HeaderText = "Data de vencimento";
            this.dataVencimentoFactura.MinimumWidth = 6;
            this.dataVencimentoFactura.Name = "dataVencimentoFactura";
            // 
            // metodoPagamentoFactura
            // 
            this.metodoPagamentoFactura.FillWeight = 77.14286F;
            this.metodoPagamentoFactura.HeaderText = "M. Pagamento";
            this.metodoPagamentoFactura.MinimumWidth = 6;
            this.metodoPagamentoFactura.Name = "metodoPagamentoFactura";
            // 
            // statusFactura
            // 
            this.statusFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.statusFactura.HeaderText = "Status";
            this.statusFactura.MinimumWidth = 6;
            this.statusFactura.Name = "statusFactura";
            this.statusFactura.Width = 87;
            // 
            // valorTotalFactura
            // 
            this.valorTotalFactura.FillWeight = 77.14286F;
            this.valorTotalFactura.HeaderText = "Valor Total";
            this.valorTotalFactura.MinimumWidth = 6;
            this.valorTotalFactura.Name = "valorTotalFactura";
            // 
            // UserControlFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlFacturas";
            this.Size = new System.Drawing.Size(1223, 736);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturaLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox tbFacturaCampoPesquisa;
        private Guna.UI2.WinForms.Guna2Button btnFaturaPesquisar;
        private Guna.UI2.WinForms.Guna2Button btnFacturaAtualizar;
        private Guna.UI2.WinForms.Guna2Button btnNovaFatura;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button btnFacturaCancelar;
        private Guna.UI2.WinForms.Guna2Button btnFacturaDetalhes;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFaturaLista;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissaoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimentoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodoPagamentoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalFactura;
    }
}
