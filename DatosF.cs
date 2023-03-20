using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio__6
{
    internal class DatosF
    {
        string nombre = "";
        string placa = "", marca = "";
        int modelo;
        string color = "";
        double precioPorKilometro;
        DateTime fecha_de_devolucion;
        double total_a_pagar;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public double PrecioPorKilometro { get => precioPorKilometro; set => precioPorKilometro = value; }
        public DateTime Fecha_de_devolucion { get => fecha_de_devolucion; set => fecha_de_devolucion = value; }
        public double Total_a_pagar { get => total_a_pagar; set => total_a_pagar = value; }
    }
}
