using CadastroCliente.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class prBuscaCliente : Form
    {
        public prBuscaCliente()
        {
            InitializeComponent();
            dtClientes.AutoGenerateColumns = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaClientes();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            using (CdCLIENTE cdCliente = new CdCLIENTE())
            {
                cdCliente.ShowDialog();
                CarregaClientes();
            }
        }

        private void dtClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int codcliente = Convert.ToInt32(dtClientes.Rows[e.RowIndex].Cells["clmcodcliente"].Value);

                CdCLIENTE CdCliente = new CdCLIENTE(codcliente);
                CdCliente.ShowDialog();
                CarregaClientes();
            }
        }
        
        private void CarregaClientes()
        {
            dtClientes.DataSource = DbCliente.BuscarCliente(txtNomcliente.Text, txtEmail.Text);
        }
    }
}
