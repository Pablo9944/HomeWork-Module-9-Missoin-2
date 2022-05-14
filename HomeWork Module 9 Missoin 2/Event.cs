using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Module_9_Missoin_2
{
    public class Event
    {
        SurName surName = new SurName();
        public event DSurname DSurnameEvent;
        

        public void DoEvent(string number)
        {
            DSurnameEvent(number);
        }

        public void Sorted(string number)
        {

            int temp = 0;
            bool result = int.TryParse(number, out temp);

            if (temp != 1 && temp != 2 )
            {
                throw new MyExeptions("Неккоректное значение");
            }
         
            switch (temp)
            {

                case 1:
                    ShowSortedA();
                    break;
                case 2:
                    ShowSortedB();
                    break;
            
            }
        }
        
        
        public void ShowSortedA()
        {
            Console.WriteLine();
            surName.listSurname.Sort();
            foreach (var e in surName.listSurname)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }
        public void ShowSortedB()
        {
            Console.WriteLine();
            surName.listSurname.Reverse();
            foreach (var e in surName.listSurname)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }
    }
}
