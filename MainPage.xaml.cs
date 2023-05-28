//MainPage.xaml.cs
using System;
using ProyectFinalP1A.Clases;
using ProyectFinalP1A.Cosas;

namespace ProyectFinalP1A
{
    public partial class MainPage : ContentPage
    {
        int Encendido = 0;
        int Encendido1 = 0;

        private VehiculoBase Carro1;
        private PickUp one;
        public MainPage()
        {
            InitializeComponent();

            Carro1 = new VehiculoBase();
            one = new PickUp();
            propiedades();
        }
        private void propiedades()
        {
            Carro1.Marca = "Marca:          Ford";
            Carro1.Modelo = "Modelo:        Ranger";
            Carro1.Color = "Color:          Gris";
            Carro1.Anio = 2023;
            Carro1.Placa = "Placa:          G896KOP";
            Carro1.Tipo = "Tipo:           Alto";
            Marca.Text = Carro1.Marca;
            Modelo.Text = Carro1.Modelo;
            Color.Text = Carro1.Color;
            Anio.Text = Carro1.Anio.ToString();
            Placa.Text = Carro1.Placa;
            Tipo.Text = Carro1.Tipo;
            nose.Text = "************************";
        }
        private void Bocinas_Clicked(object sender, EventArgs e)
        {
            Carro1.Bocina();
            if (Encendido == 1)
            {
                Fua.Text = "Bee Bee";
            }
            else
            {
                Fua.Text = "...";
            }
        }
        private void EncenderAutomovil_Clicked(object sender, EventArgs e)
        {
            Carro1.Encender();
            if (Encendido == 0)
            {
                Fua.Text = "El automóvil se ha encendido.";
                Encendido = 1;
            }
            else
            { Fua.Text = "El automovil ya esta encendido"; }
        }

        private void AcelerarAutomovil_Clicked(object sender, EventArgs e)
        {
            int velocidad = 21;
            Carro1.Acelerar(21);
            if (Encendido == 1)
            {
                Carro1.Acelerar(velocidad);
                Fua.Text = $"El Vehiculo a acelerado de 0 a {velocidad} km/h.";
            }
            else
            {
                Fua.Text = "El auto tiene que estar encendido para poder acelerar";
            }
        }
        private void Apagar_Cliked(object sender, EventArgs e)
        {
            Carro1.Apagar();
            if (Encendido == 1)
            {
                Fua.Text = "El automóvil se ha apagado.";
                Encendido = 0;
            }
            else
            { Fua.Text = "El automovil ya esta apagado"; }
        }
        private void Frenar_Clicked(object sender, EventArgs e)
        {
            Carro1.Frenar(5);
            int cuanto = 5;
            if (Encendido == 1)
            {
                Fua.Text = $"El vehiculo a frenado de 21 a {cuanto} km/h";
            }
            else
            {
                Fua.Text = $"El Vehiculo debe de estar en movimiento para poder frenar";
            }
        }
    }
}