
namespace CadastroCliente
{
    partial class CdCLIENTE
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
            this.mskCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtCodcliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomcliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCPFCNPJ = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mskTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mskDdd1 = new System.Windows.Forms.MaskedTextBox();
            this.mskDdd2 = new System.Windows.Forms.MaskedTextBox();
            this.Datnascimento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboIndTipoPessoa = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tbrNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.tbrSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.tbrExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.tbrSair = new System.Windows.Forms.ToolStripMenuItem();
            this.label12 = new System.Windows.Forms.Label();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskCPFCNPJ
            // 
            this.mskCPFCNPJ.Location = new System.Drawing.Point(112, 87);
            this.mskCPFCNPJ.Mask = "###\\.###\\.###\\-##";
            this.mskCPFCNPJ.Name = "mskCPFCNPJ";
            this.mskCPFCNPJ.Size = new System.Drawing.Size(113, 20);
            this.mskCPFCNPJ.TabIndex = 3;
            // 
            // txtCodcliente
            // 
            this.txtCodcliente.Enabled = false;
            this.txtCodcliente.Location = new System.Drawing.Point(15, 46);
            this.txtCodcliente.Name = "txtCodcliente";
            this.txtCodcliente.Size = new System.Drawing.Size(51, 20);
            this.txtCodcliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código:";
            // 
            // txtNomcliente
            // 
            this.txtNomcliente.Location = new System.Drawing.Point(15, 128);
            this.txtNomcliente.MaxLength = 60;
            this.txtNomcliente.Name = "txtNomcliente";
            this.txtNomcliente.Size = new System.Drawing.Size(270, 20);
            this.txtNomcliente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "*Nome:";
            // 
            // lblCPFCNPJ
            // 
            this.lblCPFCNPJ.AutoSize = true;
            this.lblCPFCNPJ.Location = new System.Drawing.Point(109, 71);
            this.lblCPFCNPJ.Name = "lblCPFCNPJ";
            this.lblCPFCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCPFCNPJ.TabIndex = 2;
            this.lblCPFCNPJ.Text = "*CPF:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 169);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "*E-mail:";
            // 
            // mskTelefone1
            // 
            this.mskTelefone1.BackColor = System.Drawing.SystemColors.Window;
            this.mskTelefone1.Location = new System.Drawing.Point(49, 210);
            this.mskTelefone1.Mask = "####-####";
            this.mskTelefone1.Name = "mskTelefone1";
            this.mskTelefone1.Size = new System.Drawing.Size(60, 20);
            this.mskTelefone1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Telefone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "DDD:";
            // 
            // mskTelefone2
            // 
            this.mskTelefone2.Location = new System.Drawing.Point(159, 210);
            this.mskTelefone2.Mask = "#####-####";
            this.mskTelefone2.Name = "mskTelefone2";
            this.mskTelefone2.Size = new System.Drawing.Size(66, 20);
            this.mskTelefone2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Celular:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "DDD:";
            // 
            // mskDdd1
            // 
            this.mskDdd1.BackColor = System.Drawing.SystemColors.Window;
            this.mskDdd1.Location = new System.Drawing.Point(15, 210);
            this.mskDdd1.Mask = "(##)";
            this.mskDdd1.Name = "mskDdd1";
            this.mskDdd1.Size = new System.Drawing.Size(28, 20);
            this.mskDdd1.TabIndex = 9;
            // 
            // mskDdd2
            // 
            this.mskDdd2.Location = new System.Drawing.Point(125, 210);
            this.mskDdd2.Mask = "(##)";
            this.mskDdd2.Name = "mskDdd2";
            this.mskDdd2.Size = new System.Drawing.Size(28, 20);
            this.mskDdd2.TabIndex = 13;
            // 
            // Datnascimento
            // 
            this.Datnascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datnascimento.Location = new System.Drawing.Point(15, 251);
            this.Datnascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.Datnascimento.Name = "Datnascimento";
            this.Datnascimento.Size = new System.Drawing.Size(94, 20);
            this.Datnascimento.TabIndex = 17;
            this.Datnascimento.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.Datnascimento.Leave += new System.EventHandler(this.Datnascimento_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Data de Nascimento:";
            // 
            // txtIdade
            // 
            this.txtIdade.Enabled = false;
            this.txtIdade.Location = new System.Drawing.Point(135, 251);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(34, 20);
            this.txtIdade.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Idade:";
            // 
            // cboIndTipoPessoa
            // 
            this.cboIndTipoPessoa.FormattingEnabled = true;
            this.cboIndTipoPessoa.Location = new System.Drawing.Point(15, 87);
            this.cboIndTipoPessoa.Name = "cboIndTipoPessoa";
            this.cboIndTipoPessoa.Size = new System.Drawing.Size(80, 21);
            this.cboIndTipoPessoa.TabIndex = 2;
            this.cboIndTipoPessoa.SelectedValueChanged += new System.EventHandler(this.cboTipoPessoa_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "*Tipo de pessoa:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbrNovo,
            this.tbrSalvar,
            this.tbrExcluir,
            this.tbrSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(297, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tbrNovo
            // 
            this.tbrNovo.Name = "tbrNovo";
            this.tbrNovo.Size = new System.Drawing.Size(48, 20);
            this.tbrNovo.Text = "Novo";
            this.tbrNovo.Click += new System.EventHandler(this.tbrNovo_Click);
            // 
            // tbrSalvar
            // 
            this.tbrSalvar.Name = "tbrSalvar";
            this.tbrSalvar.Size = new System.Drawing.Size(50, 20);
            this.tbrSalvar.Text = "Salvar";
            this.tbrSalvar.Click += new System.EventHandler(this.tbrSalvar_Click);
            // 
            // tbrExcluir
            // 
            this.tbrExcluir.Name = "tbrExcluir";
            this.tbrExcluir.Size = new System.Drawing.Size(54, 20);
            this.tbrExcluir.Text = "Excluir";
            this.tbrExcluir.Click += new System.EventHandler(this.tbrExcluir_Click);
            // 
            // tbrSair
            // 
            this.tbrSair.Name = "tbrSair";
            this.tbrSair.Size = new System.Drawing.Size(38, 20);
            this.tbrSair.Text = "Sair";
            this.tbrSair.Click += new System.EventHandler(this.tbrSair_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 433);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "* Campo Obrigatório";
            // 
            // mskCEP
            // 
            this.mskCEP.BackColor = System.Drawing.SystemColors.Window;
            this.mskCEP.Location = new System.Drawing.Point(6, 35);
            this.mskCEP.Mask = "#####-###";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(60, 20);
            this.mskCEP.TabIndex = 21;
            this.mskCEP.Leave += new System.EventHandler(this.mskCEP_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "*CEP:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUf);
            this.groupBox1.Controls.Add(this.txtMunicipio);
            this.groupBox1.Controls.Add(this.txtComplemento);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.mskCEP);
            this.groupBox1.Controls.Add(this.txtLogradouro);
            this.groupBox1.Location = new System.Drawing.Point(15, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 143);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(181, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "*UF:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(167, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Complemento:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "*Município:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "*Nro:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(58, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "*Bairro:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(69, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "*Logradouro:";
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(184, 113);
            this.txtUf.MaxLength = 2;
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(22, 20);
            this.txtUf.TabIndex = 33;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(6, 113);
            this.txtMunicipio.MaxLength = 30;
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(172, 20);
            this.txtMunicipio.TabIndex = 31;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(170, 74);
            this.txtComplemento.MaxLength = 20;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(94, 20);
            this.txtComplemento.TabIndex = 29;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(6, 74);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(49, 20);
            this.txtNumero.TabIndex = 25;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(61, 74);
            this.txtBairro.MaxLength = 20;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(103, 20);
            this.txtBairro.TabIndex = 27;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(72, 35);
            this.txtLogradouro.MaxLength = 50;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(192, 20);
            this.txtLogradouro.TabIndex = 23;
            // 
            // CdCLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboIndTipoPessoa);
            this.Controls.Add(this.Datnascimento);
            this.Controls.Add(this.lblCPFCNPJ);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNomcliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodcliente);
            this.Controls.Add(this.mskTelefone2);
            this.Controls.Add(this.mskDdd2);
            this.Controls.Add(this.mskDdd1);
            this.Controls.Add(this.mskTelefone1);
            this.Controls.Add(this.mskCPFCNPJ);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CdCLIENTE";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskCPFCNPJ;
        private System.Windows.Forms.TextBox txtCodcliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomcliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCPFCNPJ;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTelefone1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskTelefone2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskDdd1;
        private System.Windows.Forms.MaskedTextBox mskDdd2;
        private System.Windows.Forms.DateTimePicker Datnascimento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboIndTipoPessoa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tbrNovo;
        private System.Windows.Forms.ToolStripMenuItem tbrSalvar;
        private System.Windows.Forms.ToolStripMenuItem tbrSair;
        private System.Windows.Forms.ToolStripMenuItem tbrExcluir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtNumero;
    }
}

