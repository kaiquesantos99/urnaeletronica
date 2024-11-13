using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica.classes
{
    public class Candidatos
    {
        public int Numero { get; set; }
        public string Candidato { get; set; }

        public string Partido { get; set; }

        public Image Foto { get; set; }

        public int QtdVotos { get; set; } = 0;
    }
}
