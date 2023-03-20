using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio__6
{
    internal class Alquiler
    {
        string nit = "", placa = "";
        DateTime fechaAlquiler, fechaDevolucion;
        double kilometrosRecorridos;

        public string Nit { get => nit; set => nit = value; }
        public string Placa { get => placa; set => placa = value; }
        public DateTime FechaAlquiler { get => fechaAlquiler; set => fechaAlquiler = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public double KilometrosRecorridos { get => kilometrosRecorridos; set => kilometrosRecorridos = value; }
    }
}
