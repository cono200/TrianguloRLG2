using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Triangulo_RLG
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            this.areaTriangulo(float.Parse(Base.Text), float.Parse(Altura.Text));
            this.esTriangulo(float.Parse(Lado1.Text), float.Parse(Lado2.Text), float.Parse(Base.Text));
        }
        public double areaTriangulo(float basetriangulo, float altura)
        {
            float area;

            if (basetriangulo == 0 || altura == 0)
            {
                DisplayAlert("Error", "NO PUEDE INGRESAR VALORES NULOS", "QUITAR");
            }

            area = (basetriangulo * altura) / 2;
            Area.Text = area.ToString();
            return area;
        }
        void esTriangulo(float lado1, float lado2, float baseTriangulo)
        {
            Base.Text = baseTriangulo.ToString();
            if (baseTriangulo == lado1 && lado2 == lado1)
            {
                DisplayAlert(title: "tipo", "Es un triangulo Equilatero", "Quitar");
                imgequlilatero.IsVisible = true;
                imgescaleno.IsVisible = false;
                imgisoceles.IsVisible = false;
            }
            else if ((baseTriangulo != lado1 && lado1 == lado2) || baseTriangulo == lado1 && lado2 != lado1)
            {
                DisplayAlert(title: "tipo", "Es un triangulo Isoceles", "Quitar");
                imgisoceles.IsVisible = true;
                imgescaleno.IsVisible = false;
                imgequlilatero.IsVisible = false;
            }
            else if (lado1 != lado2 && lado1 != baseTriangulo)
            {
                DisplayAlert(title: "tipo", "Es un triangulo Escaleno", "Quitar");
                imgescaleno.IsVisible = true;
                imgequlilatero.IsVisible = false;
                imgisoceles.IsVisible = false;
            }
            else if (lado1 == 0 && lado2 == 0)
            {
                DisplayAlert("Error", "NO PUEDE INGRESAR VALORES NULOS", "QUITAR");
            }
            else
            {
                DisplayAlert(title: "Error", "No se puede poner digitos nulos o negativos y si ya no es el caso no ingresaste datos", "Quitar");
            }

        }

    }
}
