using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITMOS_EM_C_
{
    public class Result
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            int posicaoG1 = 0;
            int posicaoG2 = 0;

            posicaoG1 = x1 + v1;
            posicaoG2 = x2 + v2;

            if (posicaoG1 == posicaoG2)
                return "YES";

            return "NO";
        }
    }
}
