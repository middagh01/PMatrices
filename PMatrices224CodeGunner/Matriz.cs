using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace PMatrices224CodeGunner
{
    class Matriz
    {
        const int MAXF = 100;
        const int MAXC = 100;
        private int[,] x;
        private int f, c;
        public Matriz()
        {
            x = new int[MAXF, MAXC];
            f = 0; c = 0;
        }
        public void cargar(int nf, int nc, int a, int b)
        {
            f = nf; c = nc;
            int f1, c1;
            Random r = new Random();
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    x[f1, c1] = r.Next(a, b);
                }
            }
        }

        public void CargaManual(int nf, int nc)
        {
            f = nf;
            c = nc;

            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = 1; c1 <= c; c1++)
                {
                    string input = Microsoft.VisualBasic.Interaction.InputBox(
                        $"Ingrese el valor para la posición [{f1},{c1}]:",
                        "Carga Manual de Matriz"
                    );
                    x[f1, c1] = int.Parse(input); // Asume que siempre se ingresa un número válido
                }
            }
        }


        public string descargar()
        {
            string s = "";
            int f1, c1;
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    s = s + x[f1, c1] + "\x09";
                }
                s = s + "\x0d" + "\x0a";
            }
            return s;
        }
        public bool verif_primo(int ele)
        {
            bool ban = true;
            int c = 2;
            if (ele > 1)
            {
                while (c <= (ele / 2) && (ban == true))
                {
                    if (ele % c == 0)
                    {
                        ban = false;
                    }
                    c++;
                }
            }
            else
            {
                ban = false;
            }

            return ban;
        }

        public void intercambiar(int f1, int c1, int f2, int c2)
        {
            int aux = x[f1, c1];
            x[f1, c1] = x[f2, c2];
            x[f2, c2] = aux;
        }
    }
}
