using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForModal
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            String cep = txtCep.Text;
            serviceConsultaCEP.AtendeClienteClient webservice = new serviceConsultaCEP.AtendeClienteClient();
            serviceConsultaCEP.enderecoERP end = webservice.consultaCEP(cep);

            txtRua.Text = end.end;
            txtBairro.Text = end.bairro;
            txtCidade.Text = end.cidade;
            txtEstado.Text = end.uf;
            
        }
    }
}
