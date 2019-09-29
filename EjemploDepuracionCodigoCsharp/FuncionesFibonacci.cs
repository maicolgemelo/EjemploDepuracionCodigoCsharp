using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDepuracionCodigoCsharp
{
    public class FuncionesFibonacci : Funciones
    {
        

        public List<int> sumatoria()
        {
          int numero1 = 0;
          int numero2 = 1;
          List<int> valores = new List<int>();


            //for (int i = 0; i <= this.getNumero(); i++)
            //{

            //    int temp = numero1;
            //    valores.Add(numero1);
            //    numero1 = numero2;
            //    numero2 = temp + numero2;
                
            //}

            int i = 0;

            while (i <= this.getNumero()) {
                int temp = numero1;
                valores.Add(numero1);
                numero1 = numero2;
                numero2 = temp + numero2;
                i++;



            }
            return valores;



            

        }
    }   
}

