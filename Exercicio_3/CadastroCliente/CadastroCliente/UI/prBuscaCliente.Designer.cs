namespace CadastroCliente
{
    partial class prBuscaCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomcliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtClientes = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.clmcodcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmtipopessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcpfcnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome:";
            // 
            // txtNomcliente
            // 
            this.txtNomcliente.Location = new System.Drawing.Point(15, 26);
            this.txtNomcliente.MaxLength = 60;
            this.txtNomcliente.Name = "txtNomcliente";
            this.txtNomcliente.Size = new System.Drawing.Size(240, 20);
            this.txtNomcliente.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(261, 26);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(511, 24);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtClientes
            // 
            this.dtClientes.AllowUserToAddRows = false;
            this.dtClientes.AllowUserToDeleteRows = false;
            this.dtClientes.AllowUserToResizeRows = false;
            this.dtClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmcodcliente,
            this.clmtipopessoa,
            this.clmcpfcnpj,
            this.clmcliente,
            this.clmemail});
            this.dtClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtClientes.Location = new System.Drawing.Point(12, 55);
            this.dtClientes.Name = "dtClientes";
            this.dtClientes.RowTemplate.ReadOnly = true;
            this.dtClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtClientes.Size = new System.Drawing.Size(680, 245);
            this.dtClientes.TabIndex = 11;
            this.dtClientes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtClientes_CellMouseDoubleClick);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(599, 24);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(93, 23);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo Cliente";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // clmcodcliente
            // 
            this.clmcodcliente.DataPropertyName = "codcliente";
            this.clmcodcliente.HeaderText = "Cód.";
            this.clmcodcliente.Name = "clmcodcliente";
            this.clmcodcliente.ReadOnly = true;
            this.clmcodcliente.Width = 35;
            // 
            // clmtipopessoa
            // 
            this.clmtipopessoa.DataPropertyName = "tipopessoa";
            this.clmtipopessoa.HeaderText = "Tipo Pessoa";
            this.clmtipopessoa.Name = "clmtipopessoa";
            this.clmtipopessoa.ReadOnly = true;
            this.clmtipopessoa.Width = 90;
            // 
            // clmcpfcnpj
            // 
            this.clmcpfcnpj.DataPropertyName = "cpfcnpj";
            this.clmcpfcnpj.HeaderText = "CPF/CNPJ";
            this.clmcpfcnpj.Name = "clmcpfcnpj";
            this.clmcpfcnpj.ReadOnly = true;
            this.clmcpfcnpj.Width = 95;
            // 
            // clmcliente
            // 
            this.clmcliente.DataPropertyName = "nomcliente";
            this.clmcliente.HeaderText = "Nome";
            this.clmcliente.Name = "clmcliente";
            this.clmcliente.Width = 215;
            // 
            // clmemail
            // 
            this.clmemail.DataPropertyName = "email";
            this.clmemail.HeaderText = "Email";
            this.clmemail.Name = "clmemail";
            this.clmemail.ReadOnly = true;
            this.clmemail.Width = 185;
            // 
            // prBuscaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 310);
            this.Controls.Add(this.dtClientes);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomcliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "prBuscaCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomcliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dtClientes;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcodcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmtipopessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcpfcnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmemail;
    }
}