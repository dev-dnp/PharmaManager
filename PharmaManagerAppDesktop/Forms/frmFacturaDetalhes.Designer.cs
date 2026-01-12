namespace PharmaManagerAppDesktop.Forms
{
    partial class frmFacturaDetalhes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEstadoFatura = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVendaValorImposto = new System.Windows.Forms.Label();
            this.lblVendaTotalPagar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVendaTotalDesconto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVendaTotalSemDescontosEImpostos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvListaDetalhesItens = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblTelefoneCliente = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFecharDetalhesFactura = new Guna.UI2.WinForms.Guna2Button();
            this.label13 = new System.Windows.Forms.Label();
            this.colCodProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecoUnitarioProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescontoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaxaImpostoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorImpostoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotalProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDetalhesItens)).BeginInit();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblEstadoFatura);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.guna2Separator1);
            this.panel2.Controls.Add(this.guna2CustomGradientPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1310, 606);
            this.panel2.TabIndex = 185;
            // 
            // lblEstadoFatura
            // 
            this.lblEstadoFatura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoFatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(146)))));
            this.lblEstadoFatura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoFatura.ForeColor = System.Drawing.Color.White;
            this.lblEstadoFatura.Location = new System.Drawing.Point(191, 150);
            this.lblEstadoFatura.Name = "lblEstadoFatura";
            this.lblEstadoFatura.Size = new System.Drawing.Size(248, 44);
            this.lblEstadoFatura.TabIndex = 234;
            this.lblEstadoFatura.Text = "PAGA";
            this.lblEstadoFatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(21, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 28);
            this.label7.TabIndex = 233;
            this.label7.Text = "Estado da Fatura:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.lblVendaValorImposto);
            this.panel5.Controls.Add(this.lblVendaTotalPagar);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.lblVendaTotalDesconto);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.lblVendaTotalSemDescontosEImpostos);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(789, 6);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(509, 186);
            this.panel5.TabIndex = 232;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 149;
            this.label1.Text = "Resumo das contas:";
            // 
            // lblVendaValorImposto
            // 
            this.lblVendaValorImposto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVendaValorImposto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVendaValorImposto.Location = new System.Drawing.Point(357, 69);
            this.lblVendaValorImposto.Name = "lblVendaValorImposto";
            this.lblVendaValorImposto.Size = new System.Drawing.Size(150, 36);
            this.lblVendaValorImposto.TabIndex = 146;
            this.lblVendaValorImposto.Text = "0,00 Kz";
            this.lblVendaValorImposto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVendaTotalPagar
            // 
            this.lblVendaTotalPagar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVendaTotalPagar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblVendaTotalPagar.Location = new System.Drawing.Point(356, 145);
            this.lblVendaTotalPagar.Name = "lblVendaTotalPagar";
            this.lblVendaTotalPagar.Size = new System.Drawing.Size(150, 36);
            this.lblVendaTotalPagar.TabIndex = 148;
            this.lblVendaTotalPagar.Text = "0,00 Kz";
            this.lblVendaTotalPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 23);
            this.label2.TabIndex = 141;
            this.label2.Text = "Total sem descontos/imposto:";
            // 
            // lblVendaTotalDesconto
            // 
            this.lblVendaTotalDesconto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVendaTotalDesconto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVendaTotalDesconto.Location = new System.Drawing.Point(356, 107);
            this.lblVendaTotalDesconto.Name = "lblVendaTotalDesconto";
            this.lblVendaTotalDesconto.Size = new System.Drawing.Size(150, 36);
            this.lblVendaTotalDesconto.TabIndex = 147;
            this.lblVendaTotalDesconto.Text = "0,00 Kz";
            this.lblVendaTotalDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 23);
            this.label3.TabIndex = 142;
            this.label3.Text = "Valor do Imposto (IVA):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(7, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 143;
            this.label4.Text = "Total de Descontos:";
            // 
            // lblVendaTotalSemDescontosEImpostos
            // 
            this.lblVendaTotalSemDescontosEImpostos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVendaTotalSemDescontosEImpostos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVendaTotalSemDescontosEImpostos.Location = new System.Drawing.Point(357, 27);
            this.lblVendaTotalSemDescontosEImpostos.Name = "lblVendaTotalSemDescontosEImpostos";
            this.lblVendaTotalSemDescontosEImpostos.Size = new System.Drawing.Size(150, 36);
            this.lblVendaTotalSemDescontosEImpostos.TabIndex = 145;
            this.lblVendaTotalSemDescontosEImpostos.Text = "0,00 Kz";
            this.lblVendaTotalSemDescontosEImpostos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(7, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 23);
            this.label6.TabIndex = 144;
            this.label6.Text = "Total a pagar:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvListaDetalhesItens);
            this.panel4.Location = new System.Drawing.Point(22, 214);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1276, 343);
            this.panel4.TabIndex = 231;
            // 
            // dgvListaDetalhesItens
            // 
            this.dgvListaDetalhesItens.AllowUserToAddRows = false;
            this.dgvListaDetalhesItens.AllowUserToDeleteRows = false;
            this.dgvListaDetalhesItens.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListaDetalhesItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaDetalhesItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaDetalhesItens.ColumnHeadersHeight = 77;
            this.dgvListaDetalhesItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodProduto,
            this.colNomeProduto,
            this.colQuantidadeProduto,
            this.colPrecoUnitarioProduto,
            this.colDescontoProduto,
            this.colTaxaImpostoProduto,
            this.colValorImpostoProduto,
            this.colSubtotalProduto});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaDetalhesItens.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListaDetalhesItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaDetalhesItens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListaDetalhesItens.Location = new System.Drawing.Point(0, 0);
            this.dgvListaDetalhesItens.Name = "dgvListaDetalhesItens";
            this.dgvListaDetalhesItens.ReadOnly = true;
            this.dgvListaDetalhesItens.RowHeadersVisible = false;
            this.dgvListaDetalhesItens.RowHeadersWidth = 51;
            this.dgvListaDetalhesItens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.dgvListaDetalhesItens.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListaDetalhesItens.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaDetalhesItens.RowTemplate.Height = 40;
            this.dgvListaDetalhesItens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListaDetalhesItens.Size = new System.Drawing.Size(1276, 343);
            this.dgvListaDetalhesItens.TabIndex = 135;
            this.dgvListaDetalhesItens.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListaDetalhesItens.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListaDetalhesItens.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListaDetalhesItens.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListaDetalhesItens.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListaDetalhesItens.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListaDetalhesItens.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListaDetalhesItens.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvListaDetalhesItens.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListaDetalhesItens.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaDetalhesItens.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListaDetalhesItens.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListaDetalhesItens.ThemeStyle.HeaderStyle.Height = 77;
            this.dgvListaDetalhesItens.ThemeStyle.ReadOnly = true;
            this.dgvListaDetalhesItens.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListaDetalhesItens.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaDetalhesItens.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaDetalhesItens.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListaDetalhesItens.ThemeStyle.RowsStyle.Height = 40;
            this.dgvListaDetalhesItens.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListaDetalhesItens.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(22, 198);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1276, 10);
            this.guna2Separator1.TabIndex = 230;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.lblTelefoneCliente);
            this.guna2CustomGradientPanel2.Controls.Add(this.lblNomeCliente);
            this.guna2CustomGradientPanel2.Controls.Add(this.label12);
            this.guna2CustomGradientPanel2.Controls.Add(this.label14);
            this.guna2CustomGradientPanel2.Controls.Add(this.label15);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(12, 16);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(437, 117);
            this.guna2CustomGradientPanel2.TabIndex = 229;
            // 
            // lblTelefoneCliente
            // 
            this.lblTelefoneCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefoneCliente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneCliente.Location = new System.Drawing.Point(211, 81);
            this.lblTelefoneCliente.Name = "lblTelefoneCliente";
            this.lblTelefoneCliente.Size = new System.Drawing.Size(218, 23);
            this.lblTelefoneCliente.TabIndex = 143;
            this.lblTelefoneCliente.Text = "(nenhum)";
            this.lblTelefoneCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeCliente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(211, 45);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(218, 23);
            this.lblNomeCliente.TabIndex = 142;
            this.lblNomeCliente.Text = "(nenhum)";
            this.lblNomeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFecharDetalhesFactura);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 661);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 86);
            this.panel1.TabIndex = 184;
            // 
            // btnFecharDetalhesFactura
            // 
            this.btnFecharDetalhesFactura.BorderRadius = 4;
            this.btnFecharDetalhesFactura.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFecharDetalhesFactura.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFecharDetalhesFactura.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFecharDetalhesFactura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFecharDetalhesFactura.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(183)))));
            this.btnFecharDetalhesFactura.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharDetalhesFactura.ForeColor = System.Drawing.Color.White;
            this.btnFecharDetalhesFactura.Location = new System.Drawing.Point(547, 17);
            this.btnFecharDetalhesFactura.Margin = new System.Windows.Forms.Padding(4);
            this.btnFecharDetalhesFactura.Name = "btnFecharDetalhesFactura";
            this.btnFecharDetalhesFactura.Size = new System.Drawing.Size(216, 55);
            this.btnFecharDetalhesFactura.TabIndex = 172;
            this.btnFecharDetalhesFactura.Text = "Fechar";
            this.btnFecharDetalhesFactura.Click += new System.EventHandler(this.btnFecharDetalhesFactura_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Teal;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1310, 55);
            this.label13.TabIndex = 183;
            this.label13.Text = "DETALHES DA FACTURA";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colCodProduto
            // 
            this.colCodProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCodProduto.FillWeight = 108.4522F;
            this.colCodProduto.HeaderText = "Cód.";
            this.colCodProduto.MinimumWidth = 6;
            this.colCodProduto.Name = "colCodProduto";
            this.colCodProduto.ReadOnly = true;
            this.colCodProduto.Width = 76;
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
            // colQuantidadeProduto
            // 
            this.colQuantidadeProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colQuantidadeProduto.HeaderText = "Qntd.";
            this.colQuantidadeProduto.MinimumWidth = 6;
            this.colQuantidadeProduto.Name = "colQuantidadeProduto";
            this.colQuantidadeProduto.ReadOnly = true;
            this.colQuantidadeProduto.Width = 84;
            // 
            // colPrecoUnitarioProduto
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.colPrecoUnitarioProduto.DefaultCellStyle = dataGridViewCellStyle4;
            this.colPrecoUnitarioProduto.FillWeight = 77.14286F;
            this.colPrecoUnitarioProduto.HeaderText = "Preço uni.";
            this.colPrecoUnitarioProduto.MinimumWidth = 6;
            this.colPrecoUnitarioProduto.Name = "colPrecoUnitarioProduto";
            this.colPrecoUnitarioProduto.ReadOnly = true;
            // 
            // colDescontoProduto
            // 
            dataGridViewCellStyle5.Format = "N2";
            this.colDescontoProduto.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDescontoProduto.FillWeight = 77.14286F;
            this.colDescontoProduto.HeaderText = "Desconto";
            this.colDescontoProduto.MinimumWidth = 6;
            this.colDescontoProduto.Name = "colDescontoProduto";
            this.colDescontoProduto.ReadOnly = true;
            // 
            // colTaxaImpostoProduto
            // 
            this.colTaxaImpostoProduto.HeaderText = "Taxa de Imposto (%)";
            this.colTaxaImpostoProduto.MinimumWidth = 6;
            this.colTaxaImpostoProduto.Name = "colTaxaImpostoProduto";
            this.colTaxaImpostoProduto.ReadOnly = true;
            // 
            // colValorImpostoProduto
            // 
            dataGridViewCellStyle6.Format = "N2";
            this.colValorImpostoProduto.DefaultCellStyle = dataGridViewCellStyle6;
            this.colValorImpostoProduto.HeaderText = "Valor do Imposto";
            this.colValorImpostoProduto.MinimumWidth = 6;
            this.colValorImpostoProduto.Name = "colValorImpostoProduto";
            this.colValorImpostoProduto.ReadOnly = true;
            // 
            // colSubtotalProduto
            // 
            dataGridViewCellStyle7.Format = "N2";
            this.colSubtotalProduto.DefaultCellStyle = dataGridViewCellStyle7;
            this.colSubtotalProduto.HeaderText = "Subtotal";
            this.colSubtotalProduto.MinimumWidth = 6;
            this.colSubtotalProduto.Name = "colSubtotalProduto";
            this.colSubtotalProduto.ReadOnly = true;
            // 
            // frmFacturaDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 747);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFacturaDetalhes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmFacturaDetalhes_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDetalhesItens)).EndInit();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label lblTelefoneCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnFecharDetalhesFactura;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListaDetalhesItens;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVendaValorImposto;
        private System.Windows.Forms.Label lblVendaTotalPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVendaTotalDesconto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVendaTotalSemDescontosEImpostos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEstadoFatura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecoUnitarioProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescontoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaxaImpostoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorImpostoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotalProduto;
    }
}