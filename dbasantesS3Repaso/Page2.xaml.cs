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
    public partial class Page2 : ContentPage
    {

        string usuario;
        public Page2(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario conectado: " + usuario;
        }

        private void txtDato_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato = Convert.ToDouble(txtDato.Text);
                if (dato > 100) {
                    DisplayAlert("Alerta", "Dato fuera de rango", "Cerrar");
                    txtDato.Text = "";
                }
            }
            catch (Exception)
            {

                
            }
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            double dato = Convert.ToDouble((string)txtDato.Text);
            string estudiante = pkEstudiantes.SelectedItem.ToString();

            Navigation.PushAsync(new Page3(usuario, dato, estudiante));
        }
    }
}