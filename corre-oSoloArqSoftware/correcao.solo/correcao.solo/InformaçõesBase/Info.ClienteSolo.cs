using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json.Net;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace correcao.solo.Backend.InformaçõesBase
{
    class Info
    {
        

        public Info(ObjetoInfo obj )
        {
           saveData(obj);
        }

        private void saveData(ObjetoInfo objetoDeInformacoes)
        {
            string JsonSave = JsonConvert.SerializeObject(objetoDeInformacoes);
            string nomeArq = "infoIniciais" + DateTime.Now.ToString("HH-mm-ss-ff") + ".txt";
            try
            {
                StreamWriter file = new StreamWriter(nomeArq);
                // gravar aqui o Json com os dados informados
            }
            catch (Exception e)
            {

            }
        }
    }
}
