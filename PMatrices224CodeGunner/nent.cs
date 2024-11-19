using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMatrices224CodeGunner
{
    class nent
    {
        private int n;
        public nent()
        {
            n = 0;
        }
        public void cargar(int dato)
        {
            n = dato;
        }
        public int descargar()
        {
            return n;
        }
        public bool verifpar()
        {
            return n % 2 == 0;
        }
        public bool verifnummult(int num)
        {
            return (n % num == 0);
        }
        public bool verifnumsubmult(int num)
        {
            return (num % n == 0);
        }
        public bool verifpri()
        {
            int i, c, r;
            c = 0;
            for (i = 1; i <= n; i++)
            {
                r = n % i;
                if (r == 0)
                    c = c + 1;
            }
            return c == 2;
        }
        public bool verifnumcapicua()
        {
            int na, nu, dig;
            na = n;
            nu = 0;
            while (na > 0)
            {
                dig = na % 10;
                nu = nu * 10 + dig;
                na = na / 10;
            }
            return n == nu;
        }
        public bool VerifDigPar()
        {
            return (n % 2 == 0);
        }
        public bool impar()
        {
            return (n % 2 != 0);
        }
        public bool veriffibo()
        {
            if (n == 0 || n == 1)
                return true;

            int fibonacciAnterior = 0;
            int fibonacciActual = 1;

            while (fibonacciActual <= n)
            {
                if (fibonacciActual == n)
                    return true;

                int siguienteFibonacci = fibonacciAnterior + fibonacciActual;
                fibonacciAnterior = fibonacciActual;
                fibonacciActual = siguienteFibonacci;
            }

            return false;
        }
    }
}
