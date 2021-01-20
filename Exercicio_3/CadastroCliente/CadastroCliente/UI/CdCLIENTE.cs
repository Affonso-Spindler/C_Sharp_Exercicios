using CadastroCliente.Classes;
using CadastroCliente.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class CdCLIENTE : Form
    {
        private CLIENTE cliente = new CLIENTE();
        private int? Codcliente;

        public CdCLIENTE(int? codcliente = null)
        {
            InitializeComponent();

            MontaCboTipoPessoa();
            //this.carregando = false;
            cboIndTipoPessoa.SelectedIndex = 0;

            //mskCPFCNPJ.Enabled = true;
            tbrExcluir.Enabled = false;
            Datnascimento.Value = DateTime.Now;
            this.Codcliente = codcliente;

            if (Codcliente.HasValue)
            {
                CarregaTela(Convert.ToInt32(Codcliente));
            }
        }

        private void MontaCboTipoPessoa()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("indpessoa", typeof(short));
            dt.Columns.Add("desc", typeof(string));

            dt.Rows.Add(0, "Fisica");
            dt.Rows.Add(1, "Jurídica");

            cboIndTipoPessoa.ValueMember = "indpessoa";
            cboIndTipoPessoa.DisplayMember = "desc";
            cboIndTipoPessoa.DataSource = dt;
        }

        private void CarregaTela(int codcliente)
        {
            try
            {
                cliente = DbCliente.Get(codcliente);

                if (cliente != null)
                {
                    txtCodcliente.Text = cliente.Codcliente.ToString();
                    txtNomcliente.Text = cliente.Nomcliente;
                    txtEmail.Text = cliente.Email;
                    mskCPFCNPJ.Text = cliente.Cpfcnpj;
                    mskDdd1.Text = cliente.Ddd1;
                    mskTelefone1.Text = cliente.Telefone1;
                    mskDdd2.Text = cliente.Ddd2;
                    mskTelefone2.Text = cliente.Telefone2;
                    Datnascimento.Value = cliente.Datnascimento;
                    txtIdade.Text = cliente.Idade.ToString();
                    cboIndTipoPessoa.SelectedValue = cliente.Indtipopessoa;
                    mskCEP.Text = cliente.Cep;
                    txtLogradouro.Text = cliente.Logradouro;
                    txtBairro.Text = cliente.Bairro;
                    txtNumero.Text = cliente.Numero;
                    txtMunicipio.Text = cliente.Localidade;
                    txtComplemento.Text = cliente.Complemento;
                    txtUf.Text = cliente.Uf;

                    //mskCPFCNPJ.Enabled = false;
                    tbrExcluir.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Falha ao carregar o cadastro do Cliente");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro!");
            }
        }

        private void LimpaTela()
        {
            txtCodcliente.Text = null;
            txtNomcliente.Text = null;
            txtEmail.Text = null;
            mskCPFCNPJ.Text = null;
            mskDdd1.Text = null;
            mskTelefone1.Text = null;
            mskDdd2.Text = null;
            mskTelefone2.Text = null;
            Datnascimento.Value = DateTime.Now;
            txtIdade.Text = null;
            cboIndTipoPessoa.SelectedValue = 0;
            mskCEP.Text = null;
            txtLogradouro.Text = null;
            txtBairro.Text = null;
            txtNumero.Text = null;
            txtMunicipio.Text = null;
            txtComplemento.Text = null;
            txtUf.Text = null;



            //mskCPFCNPJ.Enabled = true;
            tbrExcluir.Enabled = false;
        }

        private void Salva()
        {
            try
            {
                if (!Valida())
                {
                    return;
                }
                CalculaIdade(Datnascimento.Value);

                cliente.Nomcliente = txtNomcliente.Text;
                cliente.Email = txtEmail.Text;
                cliente.Cpfcnpj = RemoveMask(mskCPFCNPJ.Text, mskCPFCNPJ.Mask);
                cliente.Ddd1 = RemoveMask(mskDdd1.Text, mskDdd1.Mask);
                cliente.Telefone1 = RemoveMask(mskTelefone1.Text, mskTelefone1.Mask);
                cliente.Ddd2 = RemoveMask(mskDdd2.Text, mskDdd2.Mask);
                cliente.Telefone2 = RemoveMask(mskTelefone2.Text, mskTelefone2.Mask);
                cliente.Datnascimento = Datnascimento.Value;
                cliente.Idade = Convert.ToInt16(txtIdade.Text);
                cliente.Indtipopessoa = Convert.ToInt16(cboIndTipoPessoa.SelectedValue);
                cliente.Cep = RemoveMask(mskCEP.Text, mskCEP.Mask);
                cliente.Logradouro = txtLogradouro.Text;
                cliente.Bairro= txtBairro.Text;
                cliente.Numero= txtNumero.Text;
                cliente.Localidade = txtMunicipio.Text;
                cliente.Complemento= txtComplemento.Text;
                cliente.Uf= txtUf.Text;


                if (cliente.Codcliente.HasValue)
                {
                    DbCliente.Update(cliente);
                }
                else
                {
                    DbCliente.Insert(cliente);
                }
                MessageBox.Show("Cadastro salvo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaTela(Convert.ToInt32(cliente.Codcliente));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro!");
            }
        }

        private void Delete()
        {
            try
            {
                DbCliente.Delete(Convert.ToInt32(cliente.Codcliente));
                LimpaTela();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro!");
            }
        }

        private bool Valida()
        {
            string CPFCNPJ = RemoveMask(mskCPFCNPJ.Text, mskCPFCNPJ.Mask);
            string DDD1 = RemoveMask(mskDdd1.Text, mskDdd1.Mask);
            string telefone1 = RemoveMask(mskTelefone1.Text, mskTelefone1.Mask);
            string DDD2 = RemoveMask(mskDdd2.Text, mskDdd2.Mask);
            string telefone2 = RemoveMask(mskTelefone2.Text, mskTelefone2.Mask);

            string cep = RemoveMask(mskCEP.Text, mskCEP.Mask);

            bool DDD1Preenchido = !string.IsNullOrWhiteSpace(DDD1);
            bool telefone1Preenchido = !string.IsNullOrWhiteSpace(telefone1);
            bool DDD2Preenchido = !string.IsNullOrWhiteSpace(DDD2);
            bool telefone2Preenchido = !string.IsNullOrWhiteSpace(telefone2);

            int? indTipoPessoa = Convert.ToInt32(cboIndTipoPessoa.SelectedValue);
            if (cboIndTipoPessoa.SelectedValue == null)
            {
                indTipoPessoa = null;
            }


            if (string.IsNullOrWhiteSpace(CPFCNPJ))
            {
                MessageBox.Show("CPF/CNPJ não informado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskCPFCNPJ.Focus();
                return false;
            }

            if (indTipoPessoa == null)
            {
                MessageBox.Show("Tipo de Pessoa não informado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboIndTipoPessoa.Focus();
                return false;
            }

            if (indTipoPessoa == 0)
            {
                if (!Validations.ValidaCPF(CPFCNPJ))
                {
                    MessageBox.Show("O CPF informado não é válido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mskCPFCNPJ.Focus();
                    return false;
                }
            }

            if (indTipoPessoa == 1)
            {
                if (!Validations.ValidaCNPJ(CPFCNPJ))
                {
                    MessageBox.Show("O CNPJ informado não é válido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mskCPFCNPJ.Focus();
                    return false;
                }
            }

            if (DbCliente.ValidaCPFCNPJCadastrado(CPFCNPJ, cliente.Codcliente))
            {
                MessageBox.Show("CPF/CNPJ já cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboIndTipoPessoa.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNomcliente.Text))
            {
                MessageBox.Show("Nome do cliente não informado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomcliente.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email do cliente não informado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return false;
            }

            if (!Validations.ValidaEmail(txtEmail.Text))
            {
                MessageBox.Show("O email informado não é válido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return false;
            }

            if (!(DDD1Preenchido && telefone1Preenchido || DDD2Preenchido && telefone2Preenchido))
            {
                MessageBox.Show("Informe pelo menos um telefone!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskDdd1.Focus();
                return false;
            }

            //Validação de Endereço
            if (string.IsNullOrWhiteSpace(cep))
            {
                MessageBox.Show("CEP não informado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskCEP.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLogradouro.Text))
            {
                MessageBox.Show("Logradouro não informado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogradouro.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("Número não informado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumero.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                MessageBox.Show("Bairro não informado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBairro.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMunicipio.Text))
            {
                MessageBox.Show("Município não informado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMunicipio.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUf.Text))
            {
                MessageBox.Show("UF não informado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUf.Focus();
                return false;
            }



            return true;
        }

        private void Datnascimento_Leave(object sender, EventArgs e)
        {
            CalculaIdade(Datnascimento.Value);
        }

        private void CalculaIdade(DateTime datNascimento)
        {
            int idade = Convert.ToInt32((DateTime.Today - datNascimento).TotalDays / 365.2425);
            txtIdade.Text = idade.ToString();
        }

        private void cboTipoPessoa_SelectedValueChanged(object sender, EventArgs e)
        {
            FormataTipoPessoa();
        }

        private void FormataTipoPessoa()
        {
            if (cboIndTipoPessoa.DataSource != null)
            {
                if (Convert.ToInt32(cboIndTipoPessoa.SelectedValue) == 0)
                {
                    mskCPFCNPJ.Mask = @"###\.###\.###\-##";
                    lblCPFCNPJ.Text = "*CPF:";
                }
                else
                {
                    mskCPFCNPJ.Mask = @"##\.###\.###/####-##";
                    lblCPFCNPJ.Text = "*CNPJ:";
                }
            }
        }

        private string RemoveMask(string texto, string mask)
        {
            foreach (char m in mask)
            {
                texto = texto.Replace(m.ToString(), "");
            }
            return texto.Trim();
        }

        private void tbrExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Deseja excluir o cadastro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Delete();
            }
        }

        private void tbrSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbrSalvar_Click(object sender, EventArgs e)
        {
            Salva();
        }

        private void tbrNovo_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void mskCEP_Leave(object sender, EventArgs e)
        {
            BuscaCep();

        }

        private void BuscaCep()
        {
            try
            {
                string cep = RemoveMask(mskCEP.Text, mskCEP.Mask);

                CEP Cep = new CEP();

                Cep = Utils.GetCep(cep);

                if (Cep != null)
                {
                    mskCEP.Text = Cep.Cep;
                    txtLogradouro.Text = Cep.Logradouro;
                    txtBairro.Text = Cep.Bairro;
                    txtComplemento.Text = Cep.Complemento;
                    txtMunicipio.Text = Cep.Localidade;
                    txtUf.Text = Cep.Uf;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Atenção!");
            }
        }
    }
}
