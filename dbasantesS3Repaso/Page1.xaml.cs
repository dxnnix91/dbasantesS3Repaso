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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btbIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "usuario";
            string contrasena = "2023";

            if(txtUsuario.Text == usuario && txtContrasena.Text == contrasena)
            {
                Navigation.PushAsync(new Page2(usuario));
            }
            else
            {
                DisplayAlert("Mensaje", "Usuario o contraseñan incorrecto", Title, "OK");
            }
        }
    }
}