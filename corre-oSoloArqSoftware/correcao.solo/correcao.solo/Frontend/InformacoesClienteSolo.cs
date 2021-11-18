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
    public partial class InformacoesClienteSolo : Form
    {
        public InformacoesClienteSolo()
        {
            InitializeComponent();
        }

        public int texturaSolo { get; set; }
        public int sistemaCultivo { get; set; }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 1 || numericUpDown1.Value != 2)
            { 
                textBox1.Text = "";
                textBox2.Text = "";
            }
            if (numericUpDown1.Value == 1) { 
                textBox1.Text = "Argiloso";
                textBox2.Text = " + 40% de argila ";
            }
            if (numericUpDown1.Value == 2) { 
                textBox1.Text = "Text. Média";
                textBox2.Text = "25 a 40% de argila";
            }

            texturaSolo = (int)numericUpDown1.Value;

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value != 1 || numericUpDown2.Value != 2)
                textBox3.Text = "";
            if (numericUpDown2.Value == 1)
                textBox3.Text = "Plantio Direto";
            if (numericUpDown2.Value == 2)
                textBox3.Text = "Convencional";

            sistemaCultivo = (int)numericUpDown2.Value;

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
