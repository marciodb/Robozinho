using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto
{
    public class Olho
    {
        public string Cor { get; set;}
        public string Estado { get; set;}

        public void AbrirOlho()
        {
            Estado = "O";
        }

        public void FecharOlho()
        {
            Estado = "__";
        }

        public void PiscarOlhos()
        {
            FecharOlho();
            AbrirOlho();
        }

        public Olho()
        {
            Estado = "__";
            Cor = "Castanho";
        }
    }
}
