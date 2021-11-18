using correcao.solo.Frontend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace correcao.solo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double valorCmol = 0;
        InformacoesClienteSolo telaClienteSolo = new InformacoesClienteSolo();
        CorrecaoFosforo telaCorrecaoFosforo = new CorrecaoFosforo();
        CorrecaoPotassio telaCorrecaoPotassio = new CorrecaoPotassio();
        CorrecaoCalcioMagnésio telaCorrecaoCalcioMagnesio = new CorrecaoCalcioMagnésio("ValidaçãoGUI","ctcTeste","1");
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CarregarInformacoes_Click(object sender, EventArgs e)
        {
            telaClienteSolo.ShowDialog();
            textBox1.Text = telaClienteSolo.texturaSolo == 1 ? "9,0" : telaClienteSolo.texturaSolo == 2 ? "12,0" : "";
            cMolPotassio.Text = telaClienteSolo.texturaSolo == 1 ? "0,35" : telaClienteSolo.texturaSolo == 2 ? "0,25" : "";
            cMolCalcio.Text = telaClienteSolo.texturaSolo == 1 ? "6,0" : telaClienteSolo.texturaSolo == 2 ? "4,0" : "";
            cMolMagnesio.Text = telaClienteSolo.texturaSolo == 1 ? "1,5" : telaClienteSolo.texturaSolo == 2 ? "1,0" : "";
            textBox27.Text = telaClienteSolo.texturaSolo == 1 ? "9,0" : telaClienteSolo.texturaSolo == 2 ? "6,0" : "";
            textBox6.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Enxofre.Text = "0";
            HmaisAL.Text = "0";
            Aluminio.Text = "0";
            Fosforo.Text = "0";
            GetValorCmol();
        }

        private void cMolPotassio_TextChanged(object sender, EventArgs e)
        {

        }

        private void potassioNoSolo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(potassioNoSolo.Text) && potassioNoSolo.Text != "0") { 
                GetValorCmol();
                GetCtcCmol();
            }
        }

        private void calcioNoSolo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(calcioNoSolo.Text) && calcioNoSolo.Text != "0")
            {
                GetValorCmol();
                GetCtcCmol();
                GetVPercentualAtual();
            }
        }

        private void magnesioNoSolo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(magnesioNoSolo.Text) && magnesioNoSolo.Text != "0")
            {
                GetValorCmol();
                GetCtcCmol();
                GetVPercentualAtual();
            }
        }

        private void HmaisAL_TextChanged(object sender, EventArgs e)
        {
            GetCtcCmol();
            GetVPercentualAtual();
        }

        private void GetValorCmol()
        {
            if (string.IsNullOrEmpty(magnesioNoSolo.Text) &&
               string.IsNullOrEmpty(potassioNoSolo.Text) &&
               string.IsNullOrEmpty(calcioNoSolo.Text))
            {
                magnesioNoSolo.Text = "0";
                potassioNoSolo.Text = "0";
                calcioNoSolo.Text = "0";
            }

            valorCmol = double.Parse(potassioNoSolo.Text) + double.Parse(magnesioNoSolo.Text) + double.Parse(calcioNoSolo.Text);
            sCmol.Text = valorCmol.ToString();
        }

        private void GetCtcCmol()
        {
            GetValorCmol();
            var somaCTC = double.Parse(HmaisAL.Text) + double.Parse(sCmol.Text);
            ctcCmol.Text = somaCTC.ToString();
        }

        private void GetVPercentualAtual()
        {
            var somaVPercentualAtual = double.Parse(sCmol.Text) + double.Parse(ctcCmol.Text);
            vPercentualAtual.Text = somaVPercentualAtual.ToString();
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AbrirTelaCorrecaoFosforo_Click(object sender, EventArgs e)
        {
            telaCorrecaoFosforo.ShowDialog();
            textBox21.Text = telaCorrecaoFosforo.qtdAplicar.ToString();
        }

        private void AplicarValoresCorrecaoPotassio_Click(object sender, EventArgs e)
        {
            telaCorrecaoPotassio.ShowDialog();
            textBox20.Text = telaCorrecaoPotassio.qtdAplicar.ToString();
        }

        private void AplicarValoresCalcioMagnésio_Click(object sender, EventArgs e)
        {
            telaCorrecaoCalcioMagnesio.ShowDialog();
            textBox18.Text = telaCorrecaoCalcioMagnesio.qtdAplicar_.ToString();
        }
    }
}
