namespace PharmaManagerAppDesktop.UserControls
{
    partial class UserControlListaFuncionarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdicionarItemProduto = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListaItemProduto = new Guna.UI2.WinForms.Guna2DataGridView();
            this.codigoProdutoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeProdutoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnitarioProdutoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilheteIdentidadeFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarFuncionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEditarFuncionario = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tbNomeCompleto = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdicionarCliente = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaItemProduto)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdicionarCliente);
            this.panel2.Controls.Add(this.guna2Panel3);
            this.panel2.Controls.Add(this.btnAdicionarItemProduto);
            this.panel2.Controls.Add(this.guna2Separator1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1384, 137);
            this.panel2.TabIndex = 134;
            // 
            // btnAdicionarItemProduto
            // 
            this.btnAdicionarItemProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarItemProduto.BorderRadius = 4;
            this.btnAdicionarItemProduto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionarItemProduto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionarItemProduto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdicionarItemProduto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdicionarItemProduto.FillColor = System.Drawing.Color.MediumAquamarine;
            this.btnAdicionarItemProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAdicionarItemProduto.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionarItemProduto.Image = global::PharmaManagerAppDesktop.Properties.Resources.user_plus;
            this.btnAdicionarItemProduto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdicionarItemProduto.Location = new System.Drawing.Point(1121, 65);
            this.btnAdicionarItemProduto.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnAdicionarItemProduto.Name = "btnAdicionarItemProduto";
            this.btnAdicionarItemProduto.Size = new System.Drawing.Size(243, 52);
            this.btnAdicionarItemProduto.TabIndex = 131;
            this.btnAdicionarItemProduto.Text = "Adicionar funcionário";
            this.btnAdicionarItemProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdicionarItemProduto.Click += new System.EventHandler(this.btnAdicionarItemProduto_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(20, 124);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1344, 10);
            this.guna2Separator1.TabIndex = 133;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 32);
            this.label2.TabIndex = 73;
            this.label2.Text = "Lista dos funcionários";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvListaItemProduto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1384, 470);
            this.panel1.TabIndex = 135;
            // 
            // dgvListaItemProduto
            // 
            dataGridViewCellStyle57.BackColor = System.Drawing.Color.White;
            this.dgvListaItemProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle57;
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle58.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaItemProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle58;
            this.dgvListaItemProduto.ColumnHeadersHeight = 77;
            this.dgvListaItemProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListaItemProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProdutoItem,
            this.quantidadeProdutoItem,
            this.precoUnitarioProdutoItem,
            this.bilheteIdentidadeFuncionario,
            this.cargoFuncionario,
            this.emailFuncionario,
            this.telefoneFuncionario,
            this.enderecoFuncionario,
            this.btnEliminarFuncionar,
            this.btnEditarFuncionario});
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaItemProduto.DefaultCellStyle = dataGridViewCellStyle63;
            this.dgvListaItemProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaItemProduto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListaItemProduto.Location = new System.Drawing.Point(20, 20);
            this.dgvListaItemProduto.Name = "dgvListaItemProduto";
            this.dgvListaItemProduto.RowHeadersVisible = false;
            this.dgvListaItemProduto.RowHeadersWidth = 51;
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle64.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle64.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.dgvListaItemProduto.RowsDefaultCellStyle = dataGridViewCellStyle64;
            this.dgvListaItemProduto.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaItemProduto.RowTemplate.Height = 40;
            this.dgvListaItemProduto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListaItemProduto.Size = new System.Drawing.Size(1344, 430);
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
            this.codigoProdutoItem.FillWeight = 200F;
            this.codigoProdutoItem.HeaderText = "ID";
            this.codigoProdutoItem.MinimumWidth = 6;
            this.codigoProdutoItem.Name = "codigoProdutoItem";
            this.codigoProdutoItem.Width = 57;
            // 
            // quantidadeProdutoItem
            // 
            this.quantidadeProdutoItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantidadeProdutoItem.DefaultCellStyle = dataGridViewCellStyle59;
            this.quantidadeProdutoItem.FillWeight = 200F;
            this.quantidadeProdutoItem.HeaderText = "Nome";
            this.quantidadeProdutoItem.MinimumWidth = 6;
            this.quantidadeProdutoItem.Name = "quantidadeProdutoItem";
            // 
            // precoUnitarioProdutoItem
            // 
            this.precoUnitarioProdutoItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.precoUnitarioProdutoItem.DefaultCellStyle = dataGridViewCellStyle60;
            this.precoUnitarioProdutoItem.HeaderText = "Data de nascimento";
            this.precoUnitarioProdutoItem.MinimumWidth = 6;
            this.precoUnitarioProdutoItem.Name = "precoUnitarioProdutoItem";
            this.precoUnitarioProdutoItem.Width = 180;
            // 
            // bilheteIdentidadeFuncionario
            // 
            this.bilheteIdentidadeFuncionario.HeaderText = "Bilhete de Identidade";
            this.bilheteIdentidadeFuncionario.MinimumWidth = 6;
            this.bilheteIdentidadeFuncionario.Name = "bilheteIdentidadeFuncionario";
            // 
            // cargoFuncionario
            // 
            this.cargoFuncionario.HeaderText = "Cargo";
            this.cargoFuncionario.MinimumWidth = 6;
            this.cargoFuncionario.Name = "cargoFuncionario";
            // 
            // emailFuncionario
            // 
            this.emailFuncionario.HeaderText = "Email";
            this.emailFuncionario.MinimumWidth = 6;
            this.emailFuncionario.Name = "emailFuncionario";
            // 
            // telefoneFuncionario
            // 
            this.telefoneFuncionario.HeaderText = "Telefone";
            this.telefoneFuncionario.MinimumWidth = 6;
            this.telefoneFuncionario.Name = "telefoneFuncionario";
            // 
            // enderecoFuncionario
            // 
            this.enderecoFuncionario.HeaderText = "Endereço";
            this.enderecoFuncionario.MinimumWidth = 6;
            this.enderecoFuncionario.Name = "enderecoFuncionario";
            // 
            // btnEliminarFuncionar
            // 
            this.btnEliminarFuncionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle61.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnEliminarFuncionar.DefaultCellStyle = dataGridViewCellStyle61;
            this.btnEliminarFuncionar.HeaderText = "Ações";
            this.btnEliminarFuncionar.MinimumWidth = 6;
            this.btnEliminarFuncionar.Name = "btnEliminarFuncionar";
            this.btnEliminarFuncionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEliminarFuncionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEliminarFuncionar.Text = "Eliminar";
            this.btnEliminarFuncionar.UseColumnTextForButtonValue = true;
            this.btnEliminarFuncionar.Width = 87;
            // 
            // btnEditarFuncionario
            // 
            this.btnEditarFuncionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnEditarFuncionario.DefaultCellStyle = dataGridViewCellStyle62;
            this.btnEditarFuncionario.HeaderText = "Ações";
            this.btnEditarFuncionario.MinimumWidth = 6;
            this.btnEditarFuncionario.Name = "btnEditarFuncionario";
            this.btnEditarFuncionario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditarFuncionario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEditarFuncionario.Text = "Editar";
            this.btnEditarFuncionario.UseColumnTextForButtonValue = true;
            this.btnEditarFuncionario.Width = 87;
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
            this.guna2Panel3.Controls.Add(this.tbNomeCompleto);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.guna2Panel3.Location = new System.Drawing.Point(20, 65);
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
            // tbNomeCompleto
            // 
            this.tbNomeCompleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbNomeCompleto.BorderColor = System.Drawing.Color.Gray;
            this.tbNomeCompleto.BorderRadius = 3;
            this.tbNomeCompleto.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.tbNomeCompleto.BorderThickness = 0;
            this.tbNomeCompleto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNomeCompleto.DefaultText = "";
            this.tbNomeCompleto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNomeCompleto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNomeCompleto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNomeCompleto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNomeCompleto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbNomeCompleto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNomeCompleto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbNomeCompleto.ForeColor = System.Drawing.Color.Black;
            this.tbNomeCompleto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNomeCompleto.Location = new System.Drawing.Point(38, 4);
            this.tbNomeCompleto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNomeCompleto.Name = "tbNomeCompleto";
            this.tbNomeCompleto.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNomeCompleto.PlaceholderText = "Pesquisar funcionário";
            this.tbNomeCompleto.SelectedText = "";
            this.tbNomeCompleto.Size = new System.Drawing.Size(308, 44);
            this.tbNomeCompleto.TabIndex = 62;
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
            this.btnAdicionarCliente.Location = new System.Drawing.Point(377, 65);
            this.btnAdicionarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionarCliente.Name = "btnAdicionarCliente";
            this.btnAdicionarCliente.Size = new System.Drawing.Size(130, 53);
            this.btnAdicionarCliente.TabIndex = 135;
            this.btnAdicionarCliente.Text = "Procurar";
            // 
            // UserControlListaFuncionarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlListaFuncionarios";
            this.Size = new System.Drawing.Size(1384, 607);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaItemProduto)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnAdicionarItemProduto;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListaItemProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProdutoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeProdutoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnitarioProdutoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilheteIdentidadeFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoFuncionario;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminarFuncionar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditarFuncionario;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox tbNomeCompleto;
        private Guna.UI2.WinForms.Guna2Button btnAdicionarCliente;
    }
}
