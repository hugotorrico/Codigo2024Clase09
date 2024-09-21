using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    public static class Matematica
    {


        //Sobrecarga
        public static int Sumar(int a,int b)
        {
            return a + b;
        }

        public static int Sumar(int a,int b,int c)
        {
            return a + b + c;
        }

        public static int Sumar(int a, int b, int c,int d)
        {
            return a + b + c+d;
        }
    }
}
