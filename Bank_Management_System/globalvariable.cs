using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS
{
    class globalvariable
    {
        private static string value1 = "";
        public static string value
        {
            get { return value1;  }
            set { value1 = value; }   
            
        }    
           
             
    }
}
