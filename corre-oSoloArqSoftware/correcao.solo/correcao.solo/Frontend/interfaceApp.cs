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
using RestSharp;


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

        private void GetValorScmol()
        {
            try { 
                var client = new RestClient("http://localhost:8080/calcula/calculascmol");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                var body = "["+"\""+calcioNoSolo.Text+"\","+"\"" + potassioNoSolo.Text+ "\",\"" + magnesioNoSolo.Text + "\"]";
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                if(response.StatusCode != System.Net.HttpStatusCode.OK)
                    MessageBox.Show("Não foi possivel estabelecer conexão com a API de calculos");
                
                sCmol.Text = response.Content.ToString();
            }
            catch(Exception e)
            {
                MessageBox.Show("Não foi possivel estabelecer conexão com a API de calculos");
            }
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
            GetValorScmol();
        }

        private void potassioNoSolo_TextChanged(object sender, EventArgs e)
        {
            GetValorScmol();
        }

        private void calcioNoSolo_TextChanged(object sender, EventArgs e)
        {
            GetValorScmol();
        }

        private void magnesioNoSolo_TextChanged(object sender, EventArgs e)
        {
            GetValorScmol();
        }

        private void HmaisAL_TextChanged(object sender, EventArgs e)
        {

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

        private void testarConexão_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://localhost:8080/calcula/testeconexao");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            _ = response.StatusCode == System.Net.HttpStatusCode.OK ? MessageBox.Show(response.Content) : MessageBox.Show("Falha ao conectar.");

        }

        private void sCmol_TextChanged(object sender, EventArgs e)
        {

        }

        private void cMolCalcio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cMolMagnesio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
