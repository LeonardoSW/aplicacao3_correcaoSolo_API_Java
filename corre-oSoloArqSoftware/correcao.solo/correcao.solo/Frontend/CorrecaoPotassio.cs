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
    public partial class CorrecaoPotassio : Form
    {
        public CorrecaoPotassio()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        public decimal qtdAplicar{ get; set; }

        public CorrecaoPotassio(string potassioNoSolo, string CTC) 
        {
            textBox6.Text = "Valor X: "+ potassioNoSolo+"-"+CTC;
        }

        private void CorrecaoPotassio_Load(object sender, EventArgs e)
        {
            
        }

        private void GetCusto()
        {
            Custo.Text = rand.Next().ToString("C2").ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            GetCusto();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetCusto();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            GetCusto();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            qtdAplicarBox.Text = rand.Next().ToString("F2");
            qtdAplicar = rand.Next();
        }
    }
}
