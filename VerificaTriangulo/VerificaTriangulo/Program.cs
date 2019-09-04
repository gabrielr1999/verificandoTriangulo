using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            String entrada;//serve para armazernar as informações que o usuário irá informar 
            Triangulo objeto;//variável que representa o Objeto
            objeto = new Triangulo();
            Console.WriteLine("Verifica se três valores informados formam um trinângulo");
            Console.WriteLine("Lado A: ");
            entrada = Console.ReadLine();
            objeto.ladoA = Convert.ToInt32(entrada);//recebe a conversão para int32  do valor contido em entrada
            Console.WriteLine("Lado B: ");
            entrada = Console.ReadLine();
            objeto.ladoB = Convert.ToInt32(entrada);
            Console.WriteLine("Lado C: ");
            entrada = Console.ReadLine();
            objeto.ladoC = Convert.ToInt32(entrada);
            objeto.verificaTriangulo();//objeto executa a ação "vericaTriangulo",  para exibir na tela se os três lados que ele possui forma mesmo um triângulo

            Console.ReadKey();
        }
    }
}
