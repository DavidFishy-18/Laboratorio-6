using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio__6
{
    internal class Vehiculos
    {
        string placa = "", marca = "";
        int modelo;
        string color = "";
        double precioPorKilometro;

        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public double PrecioPorKilometro { get => precioPorKilometro; set => precioPorKilometro = value; }
    }
}
