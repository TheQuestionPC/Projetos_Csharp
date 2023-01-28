using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP08
{
    class clsTitulo
    {
        public static Boolean ValidaTitulo(string Titulo)
        {
            int soma = 0;
            int resto = 0;
            int soma2 = 0;
            int resto2 = 0; 

            Titulo = Titulo.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "").Replace(" ", "").Trim();

            if (Titulo.Length != 12)
            {
                for (int o = 0; o < 12 - Titulo.Length; o++)
                {
                    Titulo = Titulo.Insert(o, "0");
                }
            }
            for (int i = 0; i < 8; i++)
            {
                soma += (int.Parse(Titulo.Substring(i, 1)) * (i + 2));
            }
            resto = soma % 11;
            for (int i = 7; i < 10; i++)
            {
                for (int y = 8; y < 11; y++)
                {
                    soma2 += (int.Parse(Titulo.Substring(y, 1)) * (i));
                }
                resto2 = soma2 % 11;
            }
            if (resto > 0 || resto2 >28) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
