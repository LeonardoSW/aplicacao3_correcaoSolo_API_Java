using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correcao.solo.Backend.InformaçõesBase
{
    class ObjetoInfo
    {
        public string produtor { get; set; }
        public string municipio { get; set; }
        public int talhao { get; set; }
        public int texturaSolo { get; set; }
        public string responsavelTecnico { get; set; }
        public DateTime data { get; set; }
        public string lote { get; set; }
        public double areaTalhao { get; set; }
        public int sistemaCultivo { get; set; }
        public double profundidadeAmostraSolos { get; set; }
        public double areaTotal { get; set; }
        public string matriculaLote { get; set; }
    }
}
