namespace PharmaManagerAppDesktop.UserControls
{
    partial class UserControlFaturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtCampoPesquisar = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPesquisarFatura = new Guna.UI2.WinForms.Guna2Button();
            this.btnRestaurar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelarFatura = new Guna.UI2.WinForms.Guna2Button();
            this.btnFacturaDetalhes = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvFaturaLista = new Guna.UI2.WinForms.Guna2DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIdFatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeClienteFatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataEmissaoFatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFuncionarioFatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetodoPagamentoFatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoFatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.flowLayoutPanel1.Controls.Add(this.btnPesquisarFatura);
            this.flowLayoutPanel1.Controls.Add(this.btnRestaurar);
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
            this.guna2Panel3.Controls.Add(this.txtCampoPesquisar);
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
            // txtCampoPesquisar
            // 
            this.txtCampoPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCampoPesquisar.BorderColor = System.Drawing.Color.Gray;
            this.txtCampoPesquisar.BorderRadius = 3;
            this.txtCampoPesquisar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtCampoPesquisar.BorderThickness = 0;
            this.txtCampoPesquisar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCampoPesquisar.DefaultText = "";
            this.txtCampoPesquisar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCampoPesquisar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCampoPesquisar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCampoPesquisar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCampoPesquisar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCampoPesquisar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCampoPesquisar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCampoPesquisar.ForeColor = System.Drawing.Color.Black;
            this.txtCampoPesquisar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCampoPesquisar.Location = new System.Drawing.Point(38, 4);
            this.txtCampoPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCampoPesquisar.Name = "txtCampoPesquisar";
            this.txtCampoPesquisar.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCampoPesquisar.PlaceholderText = "Pesquisar Factura";
            this.txtCampoPesquisar.SelectedText = "";
            this.txtCampoPesquisar.Size = new System.Drawing.Size(308, 44);
            this.txtCampoPesquisar.TabIndex = 62;
            // 
            // btnPesquisarFatura
            // 
            this.btnPesquisarFatura.BorderRadius = 4;
            this.btnPesquisarFatura.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPesquisarFatura.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPesquisarFatura.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPesquisarFatura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPesquisarFatura.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(183)))));
            this.btnPesquisarFatura.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarFatura.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarFatura.Location = new System.Drawing.Point(360, 4);
            this.btnPesquisarFatura.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarFatura.Name = "btnPesquisarFatura";
            this.btnPesquisarFatura.Size = new System.Drawing.Size(130, 53);
            this.btnPesquisarFatura.TabIndex = 135;
            this.btnPesquisarFatura.Text = "Procurar";
            this.btnPesquisarFatura.Click += new System.EventHandler(this.btnPesquisarFatura_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.Color.White;
            this.btnRestaurar.BackgroundImage = global::PharmaManagerAppDesktop.Properties.Resources.magnifying_glass_fill__1_;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRestaurar.BorderRadius = 4;
            this.btnRestaurar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRestaurar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRestaurar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRestaurar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRestaurar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(154)))), ((int)(((byte)(112)))));
            this.btnRestaurar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRestaurar.ForeColor = System.Drawing.Color.White;
            this.btnRestaurar.Image = global::PharmaManagerAppDesktop.Properties.Resources.arrow_counter_clockwise_fill__1_;
            this.btnRestaurar.ImageSize = new System.Drawing.Size(22, 22);
            this.btnRestaurar.Location = new System.Drawing.Point(497, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(60, 53);
            this.btnRestaurar.TabIndex = 149;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
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
            this.label2.Size = new System.Drawing.Size(184, 32);
            this.label2.TabIndex = 73;
            this.label2.Text = "Lista de Faturas";
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
            this.flowLayoutPanel2.Controls.Add(this.btnCancelarFatura);
            this.flowLayoutPanel2.Controls.Add(this.btnFacturaDetalhes);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(762, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(441, 61);
            this.flowLayoutPanel2.TabIndex = 137;
            // 
            // btnCancelarFatura
            // 
            this.btnCancelarFatura.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelarFatura.BorderRadius = 4;
            this.btnCancelarFatura.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelarFatura.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelarFatura.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelarFatura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelarFatura.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(112)))));
            this.btnCancelarFatura.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFatura.ForeColor = System.Drawing.Color.White;
            this.btnCancelarFatura.Location = new System.Drawing.Point(4, 4);
            this.btnCancelarFatura.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarFatura.Name = "btnCancelarFatura";
            this.btnCancelarFatura.Size = new System.Drawing.Size(228, 53);
            this.btnCancelarFatura.TabIndex = 136;
            this.btnCancelarFatura.Text = "Cancelar Fatura";
            this.btnCancelarFatura.Click += new System.EventHandler(this.btnCancelarFatura_Click);
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
            this.btnFacturaDetalhes.Location = new System.Drawing.Point(240, 4);
            this.btnFacturaDetalhes.Margin = new System.Windows.Forms.Padding(4);
            this.btnFacturaDetalhes.Name = "btnFacturaDetalhes";
            this.btnFacturaDetalhes.Size = new System.Drawing.Size(197, 53);
            this.btnFacturaDetalhes.TabIndex = 138;
            this.btnFacturaDetalhes.Text = "Ver Detalhes";
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
            this.dgvFaturaLista.AllowUserToAddRows = false;
            this.dgvFaturaLista.AllowUserToDeleteRows = false;
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
            this.check,
            this.colIdFatura,
            this.colNomeClienteFatura,
            this.colDataEmissaoFatura,
            this.colFuncionarioFatura,
            this.colMetodoPagamentoFatura,
            this.colEstadoFatura,
            this.colValorPago});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFaturaLista.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFaturaLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFaturaLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFaturaLista.Location = new System.Drawing.Point(20, 20);
            this.dgvFaturaLista.Name = "dgvFaturaLista";
            this.dgvFaturaLista.RowHeadersVisible = false;
            this.dgvFaturaLista.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.dgvFaturaLista.RowsDefaultCellStyle = dataGridViewCellStyle6;
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
            // check
            // 
            this.check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.check.FillWeight = 214.2857F;
            this.check.Frozen = true;
            this.check.HeaderText = "";
            this.check.MinimumWidth = 6;
            this.check.Name = "check";
            this.check.Width = 6;
            // 
            // colIdFatura
            // 
            this.colIdFatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colIdFatura.FillWeight = 108.4522F;
            this.colIdFatura.Frozen = true;
            this.colIdFatura.HeaderText = "Cód.";
            this.colIdFatura.MinimumWidth = 6;
            this.colIdFatura.Name = "colIdFatura";
            this.colIdFatura.ReadOnly = true;
            this.colIdFatura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colIdFatura.Width = 76;
            // 
            // colNomeClienteFatura
            // 
            this.colNomeClienteFatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNomeClienteFatura.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNomeClienteFatura.FillWeight = 150F;
            this.colNomeClienteFatura.HeaderText = "Cliente";
            this.colNomeClienteFatura.MinimumWidth = 6;
            this.colNomeClienteFatura.Name = "colNomeClienteFatura";
            this.colNomeClienteFatura.ReadOnly = true;
            this.colNomeClienteFatura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colDataEmissaoFatura
            // 
            this.colDataEmissaoFatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDataEmissaoFatura.FillWeight = 77.14286F;
            this.colDataEmissaoFatura.HeaderText = "Data de emissão";
            this.colDataEmissaoFatura.MinimumWidth = 6;
            this.colDataEmissaoFatura.Name = "colDataEmissaoFatura";
            this.colDataEmissaoFatura.ReadOnly = true;
            this.colDataEmissaoFatura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDataEmissaoFatura.Width = 169;
            // 
            // colFuncionarioFatura
            // 
            this.colFuncionarioFatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colFuncionarioFatura.FillWeight = 77.14286F;
            this.colFuncionarioFatura.HeaderText = "Funcionário (Cód)";
            this.colFuncionarioFatura.MinimumWidth = 6;
            this.colFuncionarioFatura.Name = "colFuncionarioFatura";
            this.colFuncionarioFatura.ReadOnly = true;
            this.colFuncionarioFatura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFuncionarioFatura.Width = 170;
            // 
            // colMetodoPagamentoFatura
            // 
            this.colMetodoPagamentoFatura.FillWeight = 77.14286F;
            this.colMetodoPagamentoFatura.HeaderText = "M. Pagamento";
            this.colMetodoPagamentoFatura.MinimumWidth = 6;
            this.colMetodoPagamentoFatura.Name = "colMetodoPagamentoFatura";
            this.colMetodoPagamentoFatura.ReadOnly = true;
            this.colMetodoPagamentoFatura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colEstadoFatura
            // 
            this.colEstadoFatura.HeaderText = "Estado";
            this.colEstadoFatura.MinimumWidth = 6;
            this.colEstadoFatura.Name = "colEstadoFatura";
            this.colEstadoFatura.ReadOnly = true;
            this.colEstadoFatura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colValorPago
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.colValorPago.DefaultCellStyle = dataGridViewCellStyle4;
            this.colValorPago.FillWeight = 77.14286F;
            this.colValorPago.HeaderText = "Valor Pago";
            this.colValorPago.MinimumWidth = 6;
            this.colValorPago.Name = "colValorPago";
            this.colValorPago.ReadOnly = true;
            this.colValorPago.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // UserControlFaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlFaturas";
            this.Size = new System.Drawing.Size(1223, 736);
            this.Load += new System.EventHandler(this.UserControlFaturas_Load);
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
        private Guna.UI2.WinForms.Guna2TextBox txtCampoPesquisar;
        private Guna.UI2.WinForms.Guna2Button btnPesquisarFatura;
        private Guna.UI2.WinForms.Guna2Button btnRestaurar;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button btnCancelarFatura;
        private Guna.UI2.WinForms.Guna2Button btnFacturaDetalhes;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFaturaLista;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdFatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeClienteFatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataEmissaoFatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFuncionarioFatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetodoPagamentoFatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoFatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorPago;
    }
}
