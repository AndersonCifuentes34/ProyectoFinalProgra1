//ClasePickUp
using ProyectFinalP1A.Cosas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectFinalP1A.Clases
{
    internal class PickUp : VehiculoBase
    {
        public string Llantas { get; set; }
        public string ElMotor { get; set; }
        public string Musica { get; set; }
        private int Encendido = 0;
        public void Encender1()
        {
            base.Encender();
            Console.WriteLine("Bienvenido a tu vehiculo");
            Encendido = 1;
        }
    }
}
