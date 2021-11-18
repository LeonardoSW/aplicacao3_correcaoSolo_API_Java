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
    public partial class CorrecaoCalcioMagnésio : Form
    {
        public string calcio { get; set; }
        public string ctc { get; set; }
        public string texturaSolo { get; set; }
        public string qtdAplicar_ { get; set; }

        public CorrecaoCalcioMagnésio(string calcio, string ctc, string textSolo)
        {
            this.calcio = calcio;
            this.ctc = ctc;
            this.texturaSolo = texturaSolo;

            InitializeComponent();
        }

        private void CorrecaoCalcioMagnésio_Load(object sender, EventArgs e)
        {
            textSolo.Text = calcio;
            textBox1.Text = ctc;
            textBox2.Text = texturaSolo;
            qtdAplicar.Text = "3"; // serão todos manipulaveis automaticamente por dados previamente obtidos.
            textBox18.Text = qtdAplicar.ToString();
            GetQtdAplicar();
        }

        public void GetParticipacaoAtualCTCCalcio()
        {

        }

        public void GetQtdAplicar()
        {
            qtdAplicar_ = "3";
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qtdAplicar_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
