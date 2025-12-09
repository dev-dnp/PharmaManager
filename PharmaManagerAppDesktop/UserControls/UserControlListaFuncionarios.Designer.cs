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
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.tbNomeCompleto = new Guna.UI2.WinForms.Guna2TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilheteIdentidadeFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAbrirFrmAdicionarFuncionario = new System.Windows.Forms.Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 72;
            this.label2.Text = "Pesquisar";
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
            this.tbNomeCompleto.PlaceholderText = "Pesquisar funcionários...";
            this.tbNomeCompleto.SelectedText = "";
            this.tbNomeCompleto.Size = new System.Drawing.Size(382, 33);
            this.tbNomeCompleto.TabIndex = 62;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(432, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 43);
            this.button1.TabIndex = 75;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
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
            this.panel2.TabIndex = 77;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel3);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(572, 51);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1384, 507);
            this.panel1.TabIndex = 78;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFuncionario,
            this.nomeFuncionario,
            this.dataNascimentoFuncionario,
            this.bilheteIdentidadeFuncionario,
            this.emailFuncionario,
            this.telefoneFuncionario,
            this.cargoFuncionario});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1344, 467);
            this.dataGridView1.TabIndex = 1;
            // 
            // idFuncionario
            // 
            this.idFuncionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idFuncionario.HeaderText = "ID";
            this.idFuncionario.MinimumWidth = 6;
            this.idFuncionario.Name = "idFuncionario";
            // 
            // nomeFuncionario
            // 
            this.nomeFuncionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeFuncionario.HeaderText = "Nome";
            this.nomeFuncionario.MinimumWidth = 6;
            this.nomeFuncionario.Name = "nomeFuncionario";
            // 
            // dataNascimentoFuncionario
            // 
            this.dataNascimentoFuncionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataNascimentoFuncionario.HeaderText = "Data de Nascimento";
            this.dataNascimentoFuncionario.MinimumWidth = 6;
            this.dataNascimentoFuncionario.Name = "dataNascimentoFuncionario";
            // 
            // bilheteIdentidadeFuncionario
            // 
            this.bilheteIdentidadeFuncionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bilheteIdentidadeFuncionario.HeaderText = "Bilhete de Identidade";
            this.bilheteIdentidadeFuncionario.MinimumWidth = 6;
            this.bilheteIdentidadeFuncionario.Name = "bilheteIdentidadeFuncionario";
            // 
            // emailFuncionario
            // 
            this.emailFuncionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailFuncionario.HeaderText = "Email";
            this.emailFuncionario.MinimumWidth = 6;
            this.emailFuncionario.Name = "emailFuncionario";
            // 
            // telefoneFuncionario
            // 
            this.telefoneFuncionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefoneFuncionario.HeaderText = "Telefone";
            this.telefoneFuncionario.MinimumWidth = 6;
            this.telefoneFuncionario.Name = "telefoneFuncionario";
            // 
            // cargoFuncionario
            // 
            this.cargoFuncionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cargoFuncionario.HeaderText = "Cargo";
            this.cargoFuncionario.MinimumWidth = 6;
            this.cargoFuncionario.Name = "cargoFuncionario";
            // 
            // btnAbrirFrmAdicionarFuncionario
            // 
            this.btnAbrirFrmAdicionarFuncionario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAbrirFrmAdicionarFuncionario.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAbrirFrmAdicionarFuncionario.Location = new System.Drawing.Point(1192, 39);
            this.btnAbrirFrmAdicionarFuncionario.Name = "btnAbrirFrmAdicionarFuncionario";
            this.btnAbrirFrmAdicionarFuncionario.Size = new System.Drawing.Size(172, 43);
            this.btnAbrirFrmAdicionarFuncionario.TabIndex = 76;
            this.btnAbrirFrmAdicionarFuncionario.Text = "Adicionar funcionário";
            this.btnAbrirFrmAdicionarFuncionario.UseVisualStyleBackColor = false;
            this.btnAbrirFrmAdicionarFuncionario.Click += new System.EventHandler(this.btnAbrirFrmAdicionarFuncionario_Click);
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
            this.guna2Panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox tbNomeCompleto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilheteIdentidadeFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoFuncionario;
        private System.Windows.Forms.Button btnAbrirFrmAdicionarFuncionario;
    }
}
