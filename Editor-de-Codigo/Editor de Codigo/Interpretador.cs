using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Editor_de_Codigo
{
    internal class Interpretador
    {
        static string nomedeespaco = "";
        public static string Trasformador(string Texto)
        {
            string codigo = "";
            int PP = Texto.IndexOf("programa ");
            int PI = Texto.IndexOf("inicio");
            int PF = Texto.IndexOf("fim");
            int PV = Texto.IndexOf("variavel");
            int PDF = Texto.IndexOf("variaveis");
            if (PP != -1) 
            {
                nomedeespaco = Texto.Substring(PP+9);
                codigo = "using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Text;\r\nusing System.Threading.Tasks;\r\n\r\n namespace "+nomedeespaco+"{\r\n";
            }
            if(PDF != -1)
            {
                
            }
            if (PV != -1)
            {
                codigo += "static ";
                int PN = Texto.IndexOf("numero ");
                int PT = Texto.IndexOf("texto ");
                int PL = Texto.IndexOf("logico ");
                int PVA = Texto.IndexOf("vazio ");
                int PR = Texto.IndexOf("=");
                int PPV = Texto.IndexOf(";");
                string declaracao = "";
                if (PN != -1)
                {
                    if (PR != -1)
                    {
                        declaracao = Texto.Substring(PN+7);
                    }
                    else
                    {
                        declaracao = Texto.Substring(PN + 7);
                    }
                    codigo += "double " + declaracao+ "\r\n";
                }
                else if (PT != -1)
                {
                    codigo += "string ";
                }
                else if (PL != -1)
                {
                    codigo += "bool ";
                }
                else if (PV != -1)
                {
                    codigo += "void";
                }

            }
            if (PI != -1)
            {
                codigo += "internal class "+nomedeespaco+"\r\n    {\r\n        static void Main(string[] args)\r\n        {";
            }
            
            if(PF != -1)
            {
                codigo += "\t\t\t\n}\t\t\n}\t\t\n}";
            }
            return codigo;
        }

    }
}
