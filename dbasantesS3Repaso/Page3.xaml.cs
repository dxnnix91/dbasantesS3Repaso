using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dbasantesS3Repaso
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3(string usuario, double dato, string estudiante)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario conectado: " + usuario;
            txtDato.Text = dato.ToString();
            txtEstudiante.Text = estudiante;
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {

        }
    }
}