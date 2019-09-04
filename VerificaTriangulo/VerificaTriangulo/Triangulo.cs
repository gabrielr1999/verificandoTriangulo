using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaTriangulo
{
    class Triangulo
    {
        public int ladoA;
        public int ladoB;
        public int ladoC;

        public void verificaTriangulo()
        {
            if((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoB + ladoA))
            {
                Console.WriteLine("Forma um triângulo");
            }else
            {
                Console.WriteLine("Não forma um triângulo");
            }
        }
    }
}
