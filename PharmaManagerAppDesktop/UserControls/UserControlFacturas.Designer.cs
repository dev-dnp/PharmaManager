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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListaItemProduto = new Guna.UI2.WinForms.Guna2DataGridView();
            this.codigoProdutoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeProdutoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnitarioProdutoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelarFatura = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDetalhesFatura = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAdicionarItemProduto = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdicionarCliente = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaItemProduto)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(1223, 137);
            this.panel2.TabIndex = 133;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(20, 124);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1183, 10);
            this.guna2Separator1.TabIndex = 133;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 32);
            this.label2.TabIndex = 73;
            this.label2.Text = "Histórico de Facturas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvListaItemProduto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1223, 599);
            this.panel1.TabIndex = 134;
            // 
            // dgvListaItemProduto
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListaItemProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaItemProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaItemProduto.ColumnHeadersHeight = 77;
            this.dgvListaItemProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListaItemProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProdutoItem,
            this.quantidadeProdutoItem,
            this.precoUnitarioProdutoItem,
            this.btnCancelarFatura,
            this.btnDetalhesFatura});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaItemProduto.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListaItemProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaItemProduto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListaItemProduto.Location = new System.Drawing.Point(20, 20);
            this.dgvListaItemProduto.Name = "dgvListaItemProduto";
            this.dgvListaItemProduto.RowHeadersVisible = false;
            this.dgvListaItemProduto.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.dgvListaItemProduto.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListaItemProduto.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaItemProduto.RowTemplate.Height = 40;
            this.dgvListaItemProduto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListaItemProduto.Size = new System.Drawing.Size(1183, 559);
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
            this.codigoProdutoItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigoProdutoItem.FillWeight = 108.4522F;
            this.codigoProdutoItem.HeaderText = "Código Fatura";
            this.codigoProdutoItem.MinimumWidth = 6;
            this.codigoProdutoItem.Name = "codigoProdutoItem";
            // 
            // quantidadeProdutoItem
            // 
            this.quantidadeProdutoItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantidadeProdutoItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantidadeProdutoItem.FillWeight = 34.13703F;
            this.quantidadeProdutoItem.HeaderText = "Data de Emissão";
            this.quantidadeProdutoItem.MinimumWidth = 6;
            this.quantidadeProdutoItem.Name = "quantidadeProdutoItem";
            // 
            // precoUnitarioProdutoItem
            // 
            this.precoUnitarioProdutoItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.precoUnitarioProdutoItem.DefaultCellStyle = dataGridViewCellStyle4;
            this.precoUnitarioProdutoItem.HeaderText = "Total";
            this.precoUnitarioProdutoItem.MinimumWidth = 6;
            this.precoUnitarioProdutoItem.Name = "precoUnitarioProdutoItem";
            // 
            // btnCancelarFatura
            // 
            this.btnCancelarFatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnCancelarFatura.DefaultCellStyle = dataGridViewCellStyle5;
            this.btnCancelarFatura.HeaderText = "Cancelar";
            this.btnCancelarFatura.MinimumWidth = 6;
            this.btnCancelarFatura.Name = "btnCancelarFatura";
            this.btnCancelarFatura.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnCancelarFatura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnCancelarFatura.UseColumnTextForButtonValue = true;
            this.btnCancelarFatura.Width = 105;
            // 
            // btnDetalhesFatura
            // 
            this.btnDetalhesFatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnDetalhesFatura.DefaultCellStyle = dataGridViewCellStyle6;
            this.btnDetalhesFatura.HeaderText = "Detalhes";
            this.btnDetalhesFatura.MinimumWidth = 6;
            this.btnDetalhesFatura.Name = "btnDetalhesFatura";
            this.btnDetalhesFatura.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDetalhesFatura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnDetalhesFatura.UseColumnTextForButtonValue = true;
            this.btnDetalhesFatura.Width = 107;
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
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnAdicionarCliente);
            this.flowLayoutPanel1.Controls.Add(this.btnAdicionarItemProduto);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(681, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(522, 66);
            this.flowLayoutPanel1.TabIndex = 134;
            // 
            // UserControlFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlFacturas";
            this.Size = new System.Drawing.Size(1223, 736);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaItemProduto)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListaItemProduto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnAdicionarCliente;
        private Guna.UI2.WinForms.Guna2Button btnAdicionarItemProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProdutoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeProdutoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnitarioProdutoItem;
        private System.Windows.Forms.DataGridViewButtonColumn btnCancelarFatura;
        private System.Windows.Forms.DataGridViewButtonColumn btnDetalhesFatura;
    }
}
