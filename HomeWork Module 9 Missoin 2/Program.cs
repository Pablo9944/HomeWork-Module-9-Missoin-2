using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Module_9_Missoin_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Event eve = new Event();
            eve.DSurnameEvent += eve.Sorted;

            while (true)
            {
                try
                {
                    Console.WriteLine("Выберите как отсортивать список фамилий" +
                        "\n1 - от А - Я" +
                        "\n2 - от Я - А");
                    string number = Console.ReadLine();
                    eve.DoEvent(number);

                }
                catch (MyExeptions e)
                {

                    Console.WriteLine(e.Message);
                }
                
            }
        }
    }


    class SurName
    {
        public List<string> listSurname;
      
        public SurName()
        {
            listSurname = new List<string> {"Андреев","Борисов", "Хмельницкий", "Юсупов", "Яровой" };
        }

       
    }
}
