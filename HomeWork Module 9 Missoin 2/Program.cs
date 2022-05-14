using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork_Module_9_Missoin_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Missoin 1


            //string path = @"B:\";
            //int x = 0;

            //Exception[] exceptions = new Exception[5];
            //exceptions[0] = new FormatException("Вводите только числа");
            //exceptions[1] = new FileNotFoundException("Файл не найден");
            //exceptions[2] = new IndexOutOfRangeException("Индекс вне границ массива");
            //exceptions[3] = new DirectoryNotFoundException("Недопустимая часть пути к каталогу.");
            //exceptions[4] = new MyExeptions("число 777 вводить нельзя");


            //while (true)
            //{
            //    try
            //    {
            //        // exceptions [0] и exceptions[4]
            //        // Ловим ошибку если ввели буквы вместо чисел
            //        // Реализуем свою ошибку,если введем число 777

            //        Console.Write("Введите число: ");
            //        x = int.Parse(Console.ReadLine());
            //        if (x == 777)
            //        {
            //            throw exceptions[4];
            //        }

            //        // exceptions[2] IndexOutOfRangeException "Индекс вне границ массива"
            //        exceptions[5] = new Exception();


            //        // exceptions[1] = new FileNotFoundException "Файл не найден"
            //        File.Encrypt(path);

            //        // exceptions[3] = new DirectoryNotFoundException "Недопустимая часть пути к каталогу."
            //        DirectoryInfo dir = new DirectoryInfo(path);
            //        FileInfo[] files = dir.GetFiles();

            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine(exceptions[0].Message);

            //    }
            //    catch (FileNotFoundException)
            //    {
            //        Console.WriteLine(exceptions[1].Message);

            //    }
            //    catch (IndexOutOfRangeException)
            //    {
            //        Console.WriteLine(exceptions[2].Message);

            //    }
            //    catch (DirectoryNotFoundException)
            //    {
            //        Console.WriteLine(exceptions[3].Message);

            //    }
            //    catch (MyExeptions)
            //    {
            //        Console.WriteLine(exceptions[4].Message);

            //    }
            //}



            #endregion

            #region Missoin 2

            //Event eve = new Event();
            //eve.DSurnameEvent += eve.Sorted;

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Выберите как отсортивать список фамилий" +
            //            "\n1 - от А - Я" +
            //            "\n2 - от Я - А");
            //        string number = Console.ReadLine();
            //        eve.DoEvent(number);

            //    }
            //    catch (MyExeptions e)
            //    {

            //        Console.WriteLine(e.Message);
            //    }

            //}
            #endregion
        }
    }

}
