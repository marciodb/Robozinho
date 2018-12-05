using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrientacaoObjeto
{
    public partial class Form1 : Form
    {

        public Rosto MeuRosto {get; set; }


        public Form1()
        {
            InitializeComponent();

            MeuRosto = new Rosto();
            MeuRosto.Feliz();
            Ajustar();

        }
        public void Ajustar()
        {
            button1.Text = MeuRosto.OlhoDireito.Estado;
            button2.Text = MeuRosto.OlhoEsquerdo.Estado;
            button3.Text = MeuRosto.Estado;

        }

        private void bFeliz_Click(object sender, EventArgs e)
        {
            MeuRosto.Feliz();
            Ajustar();
        }

        private void bTriste_Click(object sender, EventArgs e)
        {
            MeuRosto.Triste();
            Ajustar();
        }

        private void bDesconfiado_Click(object sender, EventArgs e)
        {
            MeuRosto.Desconfiar();
            Ajustar();
        }
    }
}

    

