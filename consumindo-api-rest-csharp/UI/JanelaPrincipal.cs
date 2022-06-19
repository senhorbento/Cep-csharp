using consumindo_api_rest_csharp.API;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consumindo_api_rest_csharp
{
    public partial class JanelaPrincipal : Form
    {
        EntidadeCep address = new EntidadeCep();
        public JanelaPrincipal()
        {
            InitializeComponent();
        }

        public void GetEntidade(string cep)
        {
            var task = new RequestApi();
            address = Task.Run(async () => await task.Request(cep)).Result;
        }

        private void BtFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtConsultar_Click(object sender, EventArgs e)
        {
            GetEntidade(TxBoxInput.Text);
            TxBoxInput.Text = "";
            TxBoxCep.Text = address.cep;
            TxBoxLogradouro.Text = address.logradouro;
            TxBoxComplemento.Text = address.complemento;
            TxBoxBairro.Text = address.bairro;
            TxBoxLocalidade.Text = address.localidade;
            TxBoxUf.Text = address.uf;
            TxBoxIbge.Text = address.ibge;
            TxBoxGia.Text = address.gia;
            TxBoxDdd.Text = address.ddd;
            TxBoxSiafi.Text = address.siafi;
        }
    }
}
