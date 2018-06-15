using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museu
{
    class Utils
    {   
        public class Utils 
    {
        public static int PressKleyRetournZero(object value)
        {
            int valueReturn = 0; 

            int.TryParse(value.ToString(),out valueReturn);

            return valueReturn;
        }
       
    }

internal static int PressKleyRetournZero(string p)
{
 	throw new NotImplementedException();
}}
    }
}
