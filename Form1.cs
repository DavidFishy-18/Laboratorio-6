namespace Laboratorio__6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            MostrarD m = new MostrarD();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            AgregarV a = new AgregarV();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}