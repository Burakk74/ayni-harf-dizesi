using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aynı_harf_dizesi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Birinci Kelimeyi Giriniz :");
            string birinci = Console.ReadLine();

            Console.WriteLine("İkinci Kelimeyi Giriniz :");
            string ikinci = Console.ReadLine();

            Console.WriteLine("Üçüncü Kelimeyi Giriniz :");
            string ucuncu = Console.ReadLine();

            string ayni_harf = "";
            Boolean mi = false;
           
        
        
            for (int i = 0; i < birinci.Length; i++)
            {
            git:
                for (int j = 0; j < ikinci.Length; j++)
                {
                    for (int k = 0; k < ucuncu.Length; k++)
                    {

                        if ((birinci[i] == ikinci[j]) && (birinci[i] == ucuncu[k]))
                        {
                            ayni_harf += birinci[i];
                                    
                           
                        }
                         
                       
                    }
                  
                    
                }
            


            }

            Console.WriteLine("Aynı harf dizesi :" + ayni_harf);

            Console.ReadKey();
        }
    }
}
