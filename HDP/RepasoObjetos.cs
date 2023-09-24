using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class Vehiculo
    {
        public string Color { get; set; }
        public string Patente { get; set; }
        public string Modelo { get; set; }
        
    }

    Public interface  AccionesVehiculo
    {
        void Arranque();
        int GetKilometros();
        void ApagarMotor();
    }

    public class Auto : Vehiculo extends AccionesVehiculo
    {
        public string Transmision {get ;set;}

        void Arranque()
        {
            //Se implemeta el arranque del motor
        }

        int GetKilometros()
        {
            //se implementa la funcion que retorna los kilometros recorridos por un auto
        }
    }

    public class Ejemplo()
    {
        var objeto = new Auto();
        objecto.Modelo = "Roca";
    }
}