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

            List<int> l = t;

            for (int c = 1; c <= 1000; c++)
            {
                Console.WriteLine(c);
                

                


                List<int> t = new List<int>(); 


                int f = ((c % 3 == 0) ? c : 0);
                t.Add(f);
                int g = ((c % 3 == 0) ? c : 0);
                t.Add(g);


                return t;
            }
            return l;
        }
        public int Summa(List<int> i)
        {
            
            int h = i.Sum();
            Console.WriteLine(h);





                
           
            return h;
            
        }

    }
}