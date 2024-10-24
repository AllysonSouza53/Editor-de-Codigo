using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Editor_de_Codigo;

namespace Editor_de_Codigo
{

    internal class BibliotecadeTexto
    {
        static string[] linha = new string[100000];
        static int NLinha = 1;
        static int Confirmacao = 1;
        static int PE = 0;
        static int cont = 1;
        static string SubTexto1 = "";
        static int PF;

        public static char LerCaracter(string texto, int posicao)
        {
            char caracter = ' ';
            caracter = texto[posicao];
            return caracter;
        }

        public static string LerLinha(string texto)
        {
            char caracter = ' ';
            int posicao = 0;
            if (NLinha != Confirmacao)
            {
                if (texto == texto & NLinha >= 3)
                {
                    texto = SubTexto1;
                }
                while (cont != 0)
                {

                    PF = texto.IndexOf("fim");
                    PE = texto.IndexOf("\n");
                    SubTexto1 = SubTexto(texto, PE + 1, PF + 3);
                    if (SubTexto1 != "fim")
                    {
                        PE = SubTexto1.IndexOf("\n");
                        linha[NLinha] = SubTexto(SubTexto1, 0, PE);
                    }
                    else
                    {
                        linha[NLinha] = "fim";
                        PE = linha[NLinha].IndexOf("\n");
                    }

                    if (PE != -1)
                    {
                        cont++;
                    }
                    else
                    {
                        cont = 0;
                    }
                    linha[NLinha] += "\n";
                    Confirmacao = NLinha;
                    if (cont == NLinha)
                    {
                        NLinha++;
                        texto = SubTexto1;
                        return linha[NLinha - 1];
                    }
                    else if (cont == NLinha - NLinha)
                    {
                        NLinha++;
                        texto = SubTexto1;
                        return linha[NLinha - 1];
                    }
                }
            }
            else
            {
                caracter = ' ';
                posicao = 0;
                while (caracter != '\n')
                {
                    caracter = LerCaracter(texto, posicao);
                    posicao++;
                    linha[NLinha] += caracter;
                }
                Confirmacao = NLinha;
            }
            NLinha++;
            return linha[NLinha - 1];
        }

        public static string SubTexto(string texto, int PosicaoInicial, int PosicaoFinal)
        {
            string SubTexto = "";
            while (PosicaoInicial != PosicaoFinal)
            {
                SubTexto += texto[PosicaoInicial];
                PosicaoInicial++;
            }
            return SubTexto;
        }

        public static void ReiniciarLeitura()
        {
            NLinha = 1;
            Confirmacao = 1;
            PE = 0;
            cont = 1;
            SubTexto1 = "";
            PF = 0;
            linha[1] = "";
        }
    }
}
