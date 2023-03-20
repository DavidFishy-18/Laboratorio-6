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
    public partial class AgregarV : Form
    {
        List<Vehiculos> v = new List<Vehiculos>();
        public AgregarV()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show(); this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bus())
            {
                guardarV("Vehiculos.txt");
                MessageBox.Show("El vehiculo se registro exitosamente");
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = "";
            }
            else
            {
                MessageBox.Show("El vehiculo ingresado, ya se encuentra registrado");
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = "";
            }
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

        private bool bus()
        {
            string p = textBox1.Text; bool ag = true;

            for(int i = 0; i < v.Count; i++) if (v[i].Placa.Equals(p)) ag = false;

            return ag;
        }

        private void guardarV(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(textBox1.Text); writer.WriteLine(textBox2.Text); writer.WriteLine(textBox3.Text);
            writer.WriteLine(textBox4.Text); writer.WriteLine(textBox5.Text);
            writer.Close();
        }

        private void AgregarV_Load(object sender, EventArgs e)
        {
            leerV("Vehiculos.txt");
        }
    }
}
