namespace PharmaManagerAppDesktop.UserControls
{
    partial class UserControlListaClientes
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAbrirFrmAdicionarFuncionario = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tbNomeCompleto = new Guna.UI2.WinForms.Guna2TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditarCliente = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminarCliente = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAbrirFrmAdicionarFuncionario);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1384, 100);
            this.panel2.TabIndex = 78;
            // 
            // btnAbrirFrmAdicionarFuncionario
            // 
            this.btnAbrirFrmAdicionarFuncionario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAbrirFrmAdicionarFuncionario.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAbrirFrmAdicionarFuncionario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAbrirFrmAdicionarFuncionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbrirFrmAdicionarFuncionario.Location = new System.Drawing.Point(1118, 33);
            this.btnAbrirFrmAdicionarFuncionario.Name = "btnAbrirFrmAdicionarFuncionario";
            this.btnAbrirFrmAdicionarFuncionario.Size = new System.Drawing.Size(246, 49);
            this.btnAbrirFrmAdicionarFuncionario.TabIndex = 76;
            this.btnAbrirFrmAdicionarFuncionario.Text = "Adicionar cliente";
            this.btnAbrirFrmAdicionarFuncionario.UseVisualStyleBackColor = false;
            this.btnAbrirFrmAdicionarFuncionario.Click += new System.EventHandler(this.btnAbrirFrmAdicionarFuncionario_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel3);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(745, 51);
            this.flowLayoutPanel1.TabIndex = 0;
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
            this.guna2Panel3.Location = new System.Drawing.Point(3, 2);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(423, 42);
            this.guna2Panel3.TabIndex = 71;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::PharmaManagerAppDesktop.Properties.Resources.magnifying_glass_fill__1_;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(10, 12);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tbNomeCompleto.Location = new System.Drawing.Point(37, 4);
            this.tbNomeCompleto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNomeCompleto.Name = "tbNomeCompleto";
            this.tbNomeCompleto.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNomeCompleto.PlaceholderText = "Pesquisar clientes...";
            this.tbNomeCompleto.SelectedText = "";
            this.tbNomeCompleto.Size = new System.Drawing.Size(382, 33);
            this.tbNomeCompleto.TabIndex = 62;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(432, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 43);
            this.button1.TabIndex = 75;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(568, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 43);
            this.button2.TabIndex = 76;
            this.button2.Text = "Remover filtro";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 72;
            this.label2.Text = "Pesquisar clientes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1384, 507);
            this.panel1.TabIndex = 79;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.nomeCliente,
            this.telefoneCliente,
            this.emailCliente,
            this.enderecoCliente,
            this.btnEditarCliente,
            this.btnEliminarCliente});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1344, 467);
            this.dataGridView1.TabIndex = 1;
            // 
            // idCliente
            // 
            this.idCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idCliente.FillWeight = 80F;
            this.idCliente.HeaderText = "ID";
            this.idCliente.MinimumWidth = 6;
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Width = 80;
            // 
            // nomeCliente
            // 
            this.nomeCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeCliente.HeaderText = "Nome";
            this.nomeCliente.MinimumWidth = 6;
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.ReadOnly = true;
            // 
            // telefoneCliente
            // 
            this.telefoneCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefoneCliente.HeaderText = "Telefone";
            this.telefoneCliente.MinimumWidth = 6;
            this.telefoneCliente.Name = "telefoneCliente";
            this.telefoneCliente.ReadOnly = true;
            // 
            // emailCliente
            // 
            this.emailCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailCliente.HeaderText = "Email";
            this.emailCliente.MinimumWidth = 6;
            this.emailCliente.Name = "emailCliente";
            this.emailCliente.ReadOnly = true;
            // 
            // enderecoCliente
            // 
            this.enderecoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.enderecoCliente.HeaderText = "Endereço";
            this.enderecoCliente.MinimumWidth = 6;
            this.enderecoCliente.Name = "enderecoCliente";
            this.enderecoCliente.ReadOnly = true;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.HeaderText = "Ação";
            this.btnEditarCliente.MinimumWidth = 6;
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.ReadOnly = true;
            this.btnEditarCliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseColumnTextForButtonValue = true;
            this.btnEditarCliente.Width = 125;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.HeaderText = "Ação";
            this.btnEliminarCliente.MinimumWidth = 6;
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.ReadOnly = true;
            this.btnEliminarCliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEliminarCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.Width = 125;
            // 
            // UserControlListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlListaClientes";
            this.Size = new System.Drawing.Size(1384, 607);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAbrirFrmAdicionarFuncionario;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox tbNomeCompleto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoCliente;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditarCliente;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminarCliente;
    }
}
