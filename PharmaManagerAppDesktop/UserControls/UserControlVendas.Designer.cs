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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbVendaValorImposto = new System.Windows.Forms.Label();
            this.lbVendaTotalPagar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbVendaTotalDesconto = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbVendaTotalSemDescontos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVendaFinalizar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lbVendaEnderecoCliente = new System.Windows.Forms.Label();
            this.lbVendaTelefoneCliente = new System.Windows.Forms.Label();
            this.lbVendaNomeCliente = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVendaAdicionarCliente = new Guna.UI2.WinForms.Guna2Button();
            this.btnVendaAdicionarItemProduto = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvVendaListaProdutos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.selecionarLinhaProduto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnitarioProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxaImpostoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorImpostoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFaturaEliminarItemSelecionado = new Guna.UI2.WinForms.Guna2Button();
            this.btnVendaEditarItemProduto = new Guna.UI2.WinForms.Guna2Button();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendaListaProdutos)).BeginInit();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.guna2CustomGradientPanel2);
            this.panel3.Controls.Add(this.guna2Separator2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 581);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20);
            this.panel3.Size = new System.Drawing.Size(1275, 218);
            this.panel3.TabIndex = 135;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.btnVendaFinalizar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(589, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(659, 160);
            this.flowLayoutPanel1.TabIndex = 139;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbVendaValorImposto);
            this.panel1.Controls.Add(this.lbVendaTotalPagar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbVendaTotalDesconto);
            this.panel1.Controls.Add(this.lb2);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Controls.Add(this.lbVendaTotalSemDescontos);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 154);
            this.panel1.TabIndex = 138;
            // 
            // lbVendaValorImposto
            // 
            this.lbVendaValorImposto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbVendaValorImposto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbVendaValorImposto.Location = new System.Drawing.Point(264, 42);
            this.lbVendaValorImposto.Name = "lbVendaValorImposto";
            this.lbVendaValorImposto.Size = new System.Drawing.Size(150, 36);
            this.lbVendaValorImposto.TabIndex = 146;
            this.lbVendaValorImposto.Text = "0,00 AOA";
            this.lbVendaValorImposto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbVendaTotalPagar
            // 
            this.lbVendaTotalPagar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbVendaTotalPagar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbVendaTotalPagar.Location = new System.Drawing.Point(263, 118);
            this.lbVendaTotalPagar.Name = "lbVendaTotalPagar";
            this.lbVendaTotalPagar.Size = new System.Drawing.Size(150, 36);
            this.lbVendaTotalPagar.TabIndex = 148;
            this.lbVendaTotalPagar.Text = "0,00 AOA";
            this.lbVendaTotalPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 141;
            this.label1.Text = "Total sem descontos:";
            // 
            // lbVendaTotalDesconto
            // 
            this.lbVendaTotalDesconto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbVendaTotalDesconto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbVendaTotalDesconto.Location = new System.Drawing.Point(263, 80);
            this.lbVendaTotalDesconto.Name = "lbVendaTotalDesconto";
            this.lbVendaTotalDesconto.Size = new System.Drawing.Size(150, 36);
            this.lbVendaTotalDesconto.TabIndex = 147;
            this.lbVendaTotalDesconto.Text = "0,00 AOA";
            this.lbVendaTotalDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lb2.Location = new System.Drawing.Point(29, 44);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(168, 28);
            this.lb2.TabIndex = 142;
            this.lb2.Text = "Valor do Imposto:";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lb1.Location = new System.Drawing.Point(17, 82);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(181, 28);
            this.lb1.TabIndex = 143;
            this.lb1.Text = "Total de Descontos:";
            // 
            // lbVendaTotalSemDescontos
            // 
            this.lbVendaTotalSemDescontos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbVendaTotalSemDescontos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbVendaTotalSemDescontos.Location = new System.Drawing.Point(264, 4);
            this.lbVendaTotalSemDescontos.Name = "lbVendaTotalSemDescontos";
            this.lbVendaTotalSemDescontos.Size = new System.Drawing.Size(150, 36);
            this.lbVendaTotalSemDescontos.TabIndex = 145;
            this.lbVendaTotalSemDescontos.Text = "15 000,00 AOA";
            this.lbVendaTotalSemDescontos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(61, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 28);
            this.label5.TabIndex = 144;
            this.label5.Text = "Total a pagar:";
            // 
            // btnVendaFinalizar
            // 
            this.btnVendaFinalizar.BorderRadius = 4;
            this.btnVendaFinalizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVendaFinalizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVendaFinalizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVendaFinalizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVendaFinalizar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(183)))));
            this.btnVendaFinalizar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendaFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnVendaFinalizar.Location = new System.Drawing.Point(453, 4);
            this.btnVendaFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVendaFinalizar.Name = "btnVendaFinalizar";
            this.btnVendaFinalizar.Size = new System.Drawing.Size(202, 149);
            this.btnVendaFinalizar.TabIndex = 145;
            this.btnVendaFinalizar.Text = "Finalizar";
            this.btnVendaFinalizar.Click += new System.EventHandler(this.btnVendaFinalizar_Click);
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.lbVendaEnderecoCliente);
            this.guna2CustomGradientPanel2.Controls.Add(this.lbVendaTelefoneCliente);
            this.guna2CustomGradientPanel2.Controls.Add(this.lbVendaNomeCliente);
            this.guna2CustomGradientPanel2.Controls.Add(this.label16);
            this.guna2CustomGradientPanel2.Controls.Add(this.label12);
            this.guna2CustomGradientPanel2.Controls.Add(this.label14);
            this.guna2CustomGradientPanel2.Controls.Add(this.label15);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(13, 29);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(256, 153);
            this.guna2CustomGradientPanel2.TabIndex = 142;
            // 
            // lbVendaEnderecoCliente
            // 
            this.lbVendaEnderecoCliente.AutoSize = true;
            this.lbVendaEnderecoCliente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVendaEnderecoCliente.Location = new System.Drawing.Point(162, 114);
            this.lbVendaEnderecoCliente.Name = "lbVendaEnderecoCliente";
            this.lbVendaEnderecoCliente.Size = new System.Drawing.Size(84, 23);
            this.lbVendaEnderecoCliente.TabIndex = 144;
            this.lbVendaEnderecoCliente.Text = "(nenhum)";
            // 
            // lbVendaTelefoneCliente
            // 
            this.lbVendaTelefoneCliente.AutoSize = true;
            this.lbVendaTelefoneCliente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVendaTelefoneCliente.Location = new System.Drawing.Point(162, 81);
            this.lbVendaTelefoneCliente.Name = "lbVendaTelefoneCliente";
            this.lbVendaTelefoneCliente.Size = new System.Drawing.Size(84, 23);
            this.lbVendaTelefoneCliente.TabIndex = 143;
            this.lbVendaTelefoneCliente.Text = "(nenhum)";
            // 
            // lbVendaNomeCliente
            // 
            this.lbVendaNomeCliente.AutoSize = true;
            this.lbVendaNomeCliente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVendaNomeCliente.Location = new System.Drawing.Point(162, 45);
            this.lbVendaNomeCliente.Name = "lbVendaNomeCliente";
            this.lbVendaNomeCliente.Size = new System.Drawing.Size(84, 23);
            this.lbVendaNomeCliente.TabIndex = 142;
            this.lbVendaNomeCliente.Text = "(nenhum)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 23);
            this.label16.TabIndex = 141;
            this.label16.Text = "Endereço:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 23);
            this.label12.TabIndex = 133;
            this.label12.Text = "Dados do cliente";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 23);
            this.label14.TabIndex = 134;
            this.label14.Text = "Nome do cliente:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 23);
            this.label15.TabIndex = 135;
            this.label15.Text = "Telefone:";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.Location = new System.Drawing.Point(13, 6);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(1235, 10);
            this.guna2Separator2.TabIndex = 142;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2Separator1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(1275, 137);
            this.panel2.TabIndex = 137;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(23, 124);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1229, 10);
            this.guna2Separator1.TabIndex = 133;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 32);
            this.label2.TabIndex = 73;
            this.label2.Text = "Nova venda / Factura";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.btnVendaAdicionarCliente);
            this.flowLayoutPanel2.Controls.Add(this.btnVendaAdicionarItemProduto);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(827, 53);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(428, 61);
            this.flowLayoutPanel2.TabIndex = 150;
            // 
            // btnVendaAdicionarCliente
            // 
            this.btnVendaAdicionarCliente.BorderRadius = 4;
            this.btnVendaAdicionarCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVendaAdicionarCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVendaAdicionarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVendaAdicionarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVendaAdicionarCliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(183)))));
            this.btnVendaAdicionarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendaAdicionarCliente.ForeColor = System.Drawing.Color.White;
            this.btnVendaAdicionarCliente.Location = new System.Drawing.Point(4, 4);
            this.btnVendaAdicionarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnVendaAdicionarCliente.Name = "btnVendaAdicionarCliente";
            this.btnVendaAdicionarCliente.Size = new System.Drawing.Size(202, 53);
            this.btnVendaAdicionarCliente.TabIndex = 135;
            this.btnVendaAdicionarCliente.Text = "Adicionar Cliente";
            this.btnVendaAdicionarCliente.Click += new System.EventHandler(this.btnFaturaAdicionarCliente_Click);
            // 
            // btnVendaAdicionarItemProduto
            // 
            this.btnVendaAdicionarItemProduto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnVendaAdicionarItemProduto.BorderRadius = 4;
            this.btnVendaAdicionarItemProduto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVendaAdicionarItemProduto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVendaAdicionarItemProduto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVendaAdicionarItemProduto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVendaAdicionarItemProduto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(154)))), ((int)(((byte)(112)))));
            this.btnVendaAdicionarItemProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnVendaAdicionarItemProduto.ForeColor = System.Drawing.Color.White;
            this.btnVendaAdicionarItemProduto.Location = new System.Drawing.Point(214, 4);
            this.btnVendaAdicionarItemProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnVendaAdicionarItemProduto.Name = "btnVendaAdicionarItemProduto";
            this.btnVendaAdicionarItemProduto.Size = new System.Drawing.Size(210, 53);
            this.btnVendaAdicionarItemProduto.TabIndex = 136;
            this.btnVendaAdicionarItemProduto.Text = "Adicionar Produto";
            this.btnVendaAdicionarItemProduto.Click += new System.EventHandler(this.btnFaturaAdicionarItemProduto_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvVendaListaProdutos);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 137);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(20);
            this.panel4.Size = new System.Drawing.Size(1275, 444);
            this.panel4.TabIndex = 138;
            // 
            // dgvVendaListaProdutos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvVendaListaProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVendaListaProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVendaListaProdutos.ColumnHeadersHeight = 77;
            this.dgvVendaListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVendaListaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecionarLinhaProduto,
            this.codProduto,
            this.nomeProduto,
            this.quantidadeProduto,
            this.precoUnitarioProduto,
            this.descontoProduto,
            this.taxaImpostoProduto,
            this.valorImpostoProduto,
            this.subtotalProduto});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVendaListaProdutos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVendaListaProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVendaListaProdutos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVendaListaProdutos.Location = new System.Drawing.Point(20, 20);
            this.dgvVendaListaProdutos.Name = "dgvVendaListaProdutos";
            this.dgvVendaListaProdutos.RowHeadersVisible = false;
            this.dgvVendaListaProdutos.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.dgvVendaListaProdutos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVendaListaProdutos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVendaListaProdutos.RowTemplate.Height = 40;
            this.dgvVendaListaProdutos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvVendaListaProdutos.Size = new System.Drawing.Size(1235, 329);
            this.dgvVendaListaProdutos.TabIndex = 134;
            this.dgvVendaListaProdutos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVendaListaProdutos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVendaListaProdutos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVendaListaProdutos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVendaListaProdutos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvVendaListaProdutos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvVendaListaProdutos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVendaListaProdutos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvVendaListaProdutos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVendaListaProdutos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVendaListaProdutos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVendaListaProdutos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVendaListaProdutos.ThemeStyle.HeaderStyle.Height = 77;
            this.dgvVendaListaProdutos.ThemeStyle.ReadOnly = false;
            this.dgvVendaListaProdutos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVendaListaProdutos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVendaListaProdutos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVendaListaProdutos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVendaListaProdutos.ThemeStyle.RowsStyle.Height = 40;
            this.dgvVendaListaProdutos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVendaListaProdutos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // codProduto
            // 
            this.codProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.codProduto.FillWeight = 108.4522F;
            this.codProduto.HeaderText = "Cód.";
            this.codProduto.MinimumWidth = 6;
            this.codProduto.Name = "codProduto";
            this.codProduto.Width = 76;
            // 
            // nomeProduto
            // 
            this.nomeProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nomeProduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.nomeProduto.FillWeight = 150F;
            this.nomeProduto.HeaderText = "Produto";
            this.nomeProduto.MinimumWidth = 6;
            this.nomeProduto.Name = "nomeProduto";
            // 
            // quantidadeProduto
            // 
            this.quantidadeProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.quantidadeProduto.HeaderText = "Qntd.";
            this.quantidadeProduto.MinimumWidth = 6;
            this.quantidadeProduto.Name = "quantidadeProduto";
            this.quantidadeProduto.Width = 84;
            // 
            // precoUnitarioProduto
            // 
            this.precoUnitarioProduto.FillWeight = 77.14286F;
            this.precoUnitarioProduto.HeaderText = "Preço uni.";
            this.precoUnitarioProduto.MinimumWidth = 6;
            this.precoUnitarioProduto.Name = "precoUnitarioProduto";
            // 
            // descontoProduto
            // 
            this.descontoProduto.FillWeight = 77.14286F;
            this.descontoProduto.HeaderText = "Desconto";
            this.descontoProduto.MinimumWidth = 6;
            this.descontoProduto.Name = "descontoProduto";
            // 
            // taxaImpostoProduto
            // 
            this.taxaImpostoProduto.HeaderText = "Taxa de Imposto (%)";
            this.taxaImpostoProduto.MinimumWidth = 6;
            this.taxaImpostoProduto.Name = "taxaImpostoProduto";
            // 
            // valorImpostoProduto
            // 
            this.valorImpostoProduto.HeaderText = "Valor do Imposto";
            this.valorImpostoProduto.MinimumWidth = 6;
            this.valorImpostoProduto.Name = "valorImpostoProduto";
            // 
            // subtotalProduto
            // 
            this.subtotalProduto.HeaderText = "Subtotal";
            this.subtotalProduto.MinimumWidth = 6;
            this.subtotalProduto.Name = "subtotalProduto";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.flowLayoutPanel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(20, 349);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1235, 75);
            this.panel5.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.btnFaturaEliminarItemSelecionado);
            this.flowLayoutPanel3.Controls.Add(this.btnVendaEditarItemProduto);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(952, 6);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(276, 61);
            this.flowLayoutPanel3.TabIndex = 138;
            // 
            // btnFaturaEliminarItemSelecionado
            // 
            this.btnFaturaEliminarItemSelecionado.BackColor = System.Drawing.SystemColors.Control;
            this.btnFaturaEliminarItemSelecionado.BorderRadius = 4;
            this.btnFaturaEliminarItemSelecionado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFaturaEliminarItemSelecionado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFaturaEliminarItemSelecionado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFaturaEliminarItemSelecionado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFaturaEliminarItemSelecionado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(112)))));
            this.btnFaturaEliminarItemSelecionado.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturaEliminarItemSelecionado.ForeColor = System.Drawing.Color.White;
            this.btnFaturaEliminarItemSelecionado.Location = new System.Drawing.Point(4, 4);
            this.btnFaturaEliminarItemSelecionado.Margin = new System.Windows.Forms.Padding(4);
            this.btnFaturaEliminarItemSelecionado.Name = "btnFaturaEliminarItemSelecionado";
            this.btnFaturaEliminarItemSelecionado.Size = new System.Drawing.Size(130, 53);
            this.btnFaturaEliminarItemSelecionado.TabIndex = 136;
            this.btnFaturaEliminarItemSelecionado.Text = "Eliminar";
            // 
            // btnVendaEditarItemProduto
            // 
            this.btnVendaEditarItemProduto.BorderRadius = 4;
            this.btnVendaEditarItemProduto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVendaEditarItemProduto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVendaEditarItemProduto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVendaEditarItemProduto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVendaEditarItemProduto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(151)))), ((int)(((byte)(34)))));
            this.btnVendaEditarItemProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendaEditarItemProduto.ForeColor = System.Drawing.Color.White;
            this.btnVendaEditarItemProduto.Location = new System.Drawing.Point(142, 4);
            this.btnVendaEditarItemProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnVendaEditarItemProduto.Name = "btnVendaEditarItemProduto";
            this.btnVendaEditarItemProduto.Size = new System.Drawing.Size(130, 53);
            this.btnVendaEditarItemProduto.TabIndex = 138;
            this.btnVendaEditarItemProduto.Text = "Editar";
            this.btnVendaEditarItemProduto.Click += new System.EventHandler(this.btnVendaEditarItemProduto_Click);
            // 
            // UserControlVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlVendas";
            this.Size = new System.Drawing.Size(1275, 799);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendaListaProdutos)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnVendaAdicionarItemProduto;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button btnVendaAdicionarCliente;
        private Guna.UI2.WinForms.Guna2Button btnVendaFinalizar;
        private System.Windows.Forms.Label lbVendaEnderecoCliente;
        private System.Windows.Forms.Label lbVendaTelefoneCliente;
        private System.Windows.Forms.Label lbVendaNomeCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbVendaValorImposto;
        private System.Windows.Forms.Label lbVendaTotalPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbVendaTotalDesconto;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbVendaTotalSemDescontos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvVendaListaProdutos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Guna.UI2.WinForms.Guna2Button btnFaturaEliminarItemSelecionado;
        private Guna.UI2.WinForms.Guna2Button btnVendaEditarItemProduto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecionarLinhaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnitarioProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxaImpostoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorImpostoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalProduto;
    }
}
