using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace correcao.solo.Frontend
{
    public partial class CorrecaoFosforo : Form
    {

        Random rand = new Random();
        public decimal qtdAplicar { get; set; }

        public CorrecaoFosforo()
        {
            InitializeComponent();
        }

       

        private void CorrecaoFosforo_Load(object sender, EventArgs e)
        {
            GetQuantidadeAplicar();

        }

        private void GetQuantidadeAplicar()
        {
            var calculo = 4 * 50 * 100 / EfFosforo.Value*2;
            qtdAplicar = calculo;
            qtdAplicarTextBox.Text = calculo.ToString();
        }

        private void GetCusto()
        {
            Custo.Text = rand.Next().ToString("C2");
        }

        private void FonteFosforoName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FonteFosforoNumero_TextChanged(object sender, EventArgs e)
        {
            FonteFosforoName.Text = "NomeDaFonte" + FonteFosforoNumero.Text;
        }

        private void efFosforoPercentual_TextChanged(object sender, EventArgs e)
        {

        }

        private void EfFosforo_ValueChanged(object sender, EventArgs e)
        {
            GetQuantidadeAplicar();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            GetCusto();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            GetCusto();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            GetCusto();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            GetCusto();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            GetCusto();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            GetCusto();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            GetCusto();
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            GetCusto();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            GetCusto();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            GetCusto();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            GetCusto();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            GetCusto();
        }

        private void Custo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
