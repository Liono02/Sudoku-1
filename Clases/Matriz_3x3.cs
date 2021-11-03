using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Matriz_3x3
    {
        public int[,] Arreglo_3x3=new int[3,3];
        Random NumeroAleatorio=new Random();
        public void CargarMatriz()
        {
            for(int i=0;i<3;i++)
            {
                for(int z=0;z<3;z++)
                {
                    Arreglo_3x3[i,z]=NumeroAleatorio.Next(1,9);
                }
            }
        }
        public void m()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Arreglo_3x3[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}