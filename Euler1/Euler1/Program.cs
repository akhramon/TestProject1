using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Program
    {
        public static void Main()
        { 
        
        }

        public List<int> SearchMultiple()
        {

            List<int> l = new List<int>();
         

            for (int c = 1; c <= 1000; c++)
            {
  
               l.Add((c % 3 == 0) ? c : 0);
               l.Add((c % 5 == 0) ? c : 0);
                
       
            }
            return l;
        }

       
        public int Summa(List<int> i)
        {
            // не понимаю как сюда передать значение l
            // и еще смущает строчка int h = i.Sum(); i это список а h int? или метод sum выдает int?   

            int h = i.Sum();
            Console.WriteLine(h);
            Console.ReadLine();





                
           
            return h;
            
        }

    }
}