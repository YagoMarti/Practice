using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.ProminenteTest
{
    public class ProminenteClass
    {
        // devuelve una cadena de números ordenados, múltiplos de 3, 5 y 7 son reemplazados por claves en texto
        public void solution2(int N)
        {
            string outp;
            for (int i = 1; i <= N; i++)
            {
                outp = "";
                // si el número es multiplo de 3, agrega el string Fizz
                if ((i % 3) == 0)
                    outp += "Fizz";
                // si el número es multiplo de 5, agrega el string Buzz
                if ((i % 5) == 0)
                    outp += "Buzz";
                // si el número es multiplo de 7, agrega el string Wooz
                if ((i % 7) == 0)
                    outp += "Woof";
                // si el número no es multiplo de los anteriores asigna el valor del número al string de salida
                if (outp == "")
                    outp = i.ToString();
                Console.WriteLine(outp);
            }
        }
        public int solution(int N)
        { // Dado un valor N, se obtiene el mayor valor posible usando sus dígitos en cualquier orden. 
            // Si el resultado excede 100.000.000 debe retornar -1
            if (N >= 100000000)
                {
                if (N == 100000000)
                    return N;
                else
                    return -1;
                }
            // descomponemos el número a caracteres. 
                List<decimal> listN = new List<decimal>();
                do
                {
                    listN.Add(N % 10);
                    N /= 10;
                } while (N > 0);
                // se ordenan los caracteres en orden decreciente
                listN = listN.OrderByDescending(x => x).ToList();
                // se genera un string con los valores ordenados, y se convierte el resultado a entero.  
            return Convert.ToInt32(string.Join("",listN));
        }
    }
}


/* Parte SQL
SELECT inv_num
      ,sum(price)
  FROM invoice_items
  group by inv_num
  order by inv_num desc
 *  en mi sql
SELECT [inv_num]
      ,sum(price)
  FROM [prominente].[dbo].[invoice_items]
  group by [inv_num]
  order by [inv_num] desc
*/