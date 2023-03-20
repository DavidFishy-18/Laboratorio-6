using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio__6
{
    public partial class MostrarD : Form
    {
        List<Clientes> c = new List<Clientes>();
        List<Vehiculos> v = new List<Vehiculos>();
        List<Alquiler> a = new List<Alquiler>();
        List<DatosF> d = new List<DatosF>();
        public MostrarD()
        {
            InitializeComponent();
        }

        private void leerC(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Clientes cc = new Clientes();
                cc.Nit = reader.ReadLine();
                cc.Nombre = reader.ReadLine();
                cc.Direccion = reader.ReadLine();

                c.Add(cc);
            }

            reader.Close();
        }

        private void leerV(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Vehiculos vv = new Vehiculos();
                vv.Placa = reader.ReadLine();
                vv.Marca = reader.ReadLine();
                vv.Modelo = Convert.ToInt32(reader.ReadLine());
                vv.Color = reader.ReadLine();
                vv.PrecioPorKilometro = Convert.ToDouble(reader.ReadLine());

                v.Add(vv);
            }

            reader.Close();
        }

        private void leerA(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Alquiler aa = new Alquiler();
                aa.Nit = reader.ReadLine();
                aa.Placa = reader.ReadLine();
                aa.FechaAlquiler = Convert.ToDateTime(reader.ReadLine());
                aa.FechaDevolucion = Convert.ToDateTime(reader.ReadLine());
                aa.KilometrosRecorridos = Convert.ToDouble(reader.ReadLine());

                a.Add(aa);
            }

            reader.Close();
        }

        private void MostrarD_Load(object sender, EventArgs e)
        {
            leerC("Clientes.txt"); leerV("Vehiculos.txt"); leerA("Alquiler.txt"); leerDf();
            mostC(); mostV(); mostDf();
        }

        private void mostC()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = c;
            dataGridView1.Refresh();
        }

        private void mostV()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = v;
            dataGridView2.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show(); this.Hide();
        }

        private void leerDf()
        {
            int indN = 0, indV = 0;

            for (int i = 0; i < a.Count; i++)
            {
                DatosF dd = new DatosF();
                for (int j = 0; j < c.Count; j++) if (a[i].Nit == c[j].Nit) indN = j;
                for (int j = 0; j < v.Count; j++) if (a[i].Placa.Equals(v[j].Placa)) indV = j;

                dd.Nombre = c[indN].Nombre;
                dd.Placa = v[indV].Placa; dd.Marca = v[indV].Marca; dd.Modelo = v[indV].Modelo;
                dd.Color = v[indV].Color; dd.PrecioPorKilometro = v[indV].PrecioPorKilometro;
                dd.Fecha_de_devolucion = a[i].FechaDevolucion; dd.Total_a_pagar = v[indV].PrecioPorKilometro * a[i].KilometrosRecorridos;

                d.Add(dd);
            }
        }

        private void mostDf()
        {
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = d;
            dataGridView3.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vKM();
        }

        private void vKM()
        {
            int aux = Convert.ToInt32(a[0].KilometrosRecorridos), ind = 0, ind2 = 0; bool cl = true;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].KilometrosRecorridos > aux)
                {
                    aux = Convert.ToInt32(a[i].KilometrosRecorridos);
                    ind = i;
                }
            }
            for (int i = 0; i < v.Count && cl; i++)
            {
                if (v[i].Placa == a[ind].Placa) { ind2 = i; cl = false; }
            }
            MessageBox.Show("El vehiculo con mas kilometros recorridos\nes: " + v[ind2].Marca + " con " + a[ind].KilometrosRecorridos + "km.");
        }
    }
}
