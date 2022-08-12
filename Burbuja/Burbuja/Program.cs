using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbuja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            burbujav2();
            Console.ReadLine();
        }

        static void burbujav1()
        {
            int aux;
            int d = 7;
            int[] num = new int[d];
            num[0] = 7;
            num[1] = 6;
            num[2] = 5;
            num[3] = 4;
            num[4] = 3;
            num[5] = 2;
            num[6] = 1;

            Console.Write("Numeros desacomodados: ");
            for (int i = 0; i < d; i++)
            {
                Console.Write(num[i] + " ");
            }

            for (int i = 0; i < d - 1; i++)
            {
                for (int j = 0; j < d - 1; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        aux = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = aux;
                    }
                }
            }
            Console.Write("\nNumeros acomodados: ");
            for (int i = 0; i < d; i++)
            {
                Console.Write(num[i] + " ");
            }
        }

        static void burbujav2()
        {
            int aux;
            int d = 7;
            int[] num = new int[d];
            num[0] = 7;
            num[1] = 6;
            num[2] = 5;
            num[3] = 4;
            num[4] = 3;
            num[5] = 2;
            num[6] = 1;

            Console.Write("Numeros desacomodados: ");
            for (int i = 0; i < d; i++)
            {
                Console.Write(num[i] + " ");
            }

            for (int i = 0; i < d - 1; i++)
            {
                int bandera = 0;
                for (int j = 0; j < d - 1; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        aux = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = aux;
                        bandera = 1;
                    }
                }
                if (bandera == 0)
                    break;
            }
            Console.Write("\nNumeros acomodados: ");
            for (int i = 0; i < d; i++)
            {
                Console.Write(num[i] + " ");
            }
        }
    }
}
