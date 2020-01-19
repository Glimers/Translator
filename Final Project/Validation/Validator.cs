using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Validation
{
    public class Validator
    {               
        public static bool IsPresent(string text)
        {
            if(!text.Trim().Equals(""))
            { 
                return true;
            }
            return false;
        }

        
    }
}
