using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MinhaString
    {
        string s;
      

        public  MinhaString(string str)  
        {
         s = str;
        }

        public string SubString (int inicio)
        {
            String pedaco = "";
            for (int i = inicio; i < s.Length; i++)
            {
                pedaco += s[i];
            }
            return pedaco;

        }
            public string  Substring(int inicio, int final)
            {
                string pedaco = "";
                for ( int i = inicio; i <= final; i ++)
                {
                    pedaco += s[i];
                }
                return pedaco;
            }
             public string[] Split()
            {
                string[] partes = new string[10]; //Podem consideram um máximo de partes fixos

                 //Achar as partes
                for (int i = 0; i < s.Length; i++)
                {
                    
                }
                return partes;
            }
        
    }
}
