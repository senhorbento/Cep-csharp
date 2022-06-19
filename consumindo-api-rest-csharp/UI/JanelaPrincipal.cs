using consumindo_api_rest_csharp.API;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace consumindo_api_rest_csharp
{
    public partial class JanelaPrincipal : Form
    {
        EntidadeCep address = new EntidadeCep();
        public JanelaPrincipal()
        {
            InitializeComponent();
            GetEntidade("25750614");
            Debug.WriteLine("Estou rodando");
        }

        public async void GetEntidade(string cep)
        {
            address = await RequestApi.Request(cep);
        }
    }
}
