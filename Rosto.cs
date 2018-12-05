using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto
{
    public class Rosto
    {
        public Olho OlhoDireito {get; set;}
        public Olho OlhoEsquerdo {get; set;}

        public string Estado { get; set; }

        public void Feliz()
        {
            OlhoDireito.AbrirOlho();
            OlhoEsquerdo.AbrirOlho();
            Estado = "(________)";
        }
        public void Triste()
        {
            OlhoDireito.FecharOlho();
            OlhoEsquerdo.FecharOlho();
            Estado = " ---- ";
        }
        public void Desconfiar()
        {
            OlhoDireito.AbrirOlho();
            OlhoEsquerdo.FecharOlho();
            Estado = "(___";
        }

        public Rosto()
        {
            OlhoDireito = new Olho();
            OlhoEsquerdo = new Olho();            
            Feliz();
        }
    }
}
