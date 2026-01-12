namespace PharmaManagerAppDesktop.UserControls
{
    partial class UserControlPainel
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seja bem-vindo(a),";
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.lblNomeFuncionario.Location = new System.Drawing.Point(46, 145);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(458, 67);
            this.lblNomeFuncionario.TabIndex = 1;
            this.lblNomeFuncionario.Text = "[Nome do usuário]";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.DarkGray;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(58, 241);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1132, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // UserControlPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlPainel";
            this.Size = new System.Drawing.Size(1223, 736);
            this.Load += new System.EventHandler(this.UserControlPainel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
