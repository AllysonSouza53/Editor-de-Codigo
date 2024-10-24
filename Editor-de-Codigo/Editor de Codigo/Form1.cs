using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_de_Codigo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exercutar_Click(object sender, EventArgs e)
        {

            string texto = "";
            string texto2 = "";
            int PF = 0;
            do
            {
                texto2 = BibliotecadeTexto.LerLinha(Texto.Text);
                PF = texto2.IndexOf("fim");
                texto += Interpretador.Trasformador(texto2);
            } while (PF < 0);
            BibliotecadeTexto.ReiniciarLeitura();
            label1.Text = texto;
        }
    }
}
