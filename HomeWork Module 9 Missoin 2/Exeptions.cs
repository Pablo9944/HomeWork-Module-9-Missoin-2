using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Module_9_Missoin_2
{
    internal class MyExeptions: ApplicationException
    {
        public string message;
        public MyExeptions(string message):base (message)   
        {
            this.message = message; 
        }
    }
}
