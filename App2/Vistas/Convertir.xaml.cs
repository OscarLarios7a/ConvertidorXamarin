using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Convertir : ContentPage
    {
        double cm;
        double m;
        public Convertir()
        {
            InitializeComponent();
        }

        private void Calcular()
        {
            cm = Convert.ToDouble(txtDatos.Text);
            m = cm/100;
            txtResultado.Text = m.ToString() + " m";
        }
        private void Validar()
        {
            if (!string.IsNullOrEmpty(txtDatos.Text))
            {
                Calcular();
            }
            else
            {
                DisplayAlert("Error", "Ingrese un Cantidad", "OK");
            }
        }

        private void btnVolver_Clicked(object sender, EventArgs e)
        {
           Navigation.PopAsync();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            Validar();
        }
    }
}