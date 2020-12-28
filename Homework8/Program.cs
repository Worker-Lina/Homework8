using System;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {

            //---------1---------------

            /*var service = new NumberDivideService();
            try
            {
                Console.WriteLine(service.NumberDivide(35, 5));
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }*/



            //-------------2-------------

            Random random = new Random();
            int defaultArraySize = 5;

            Console.WriteLine("Введите размер массива");
            if (!int.TryParse(Console.ReadLine(), out int arraySize))
            {
                arraySize = defaultArraySize;
            }


            int[] someArray = new int[arraySize];
            Console.WriteLine("Введите индекс элемента массива");
            int index = int.Parse(Console.ReadLine());


            try
            {
                someArray[index] = random.Next(0, 100);
            }
            catch(IndexOutOfRangeException exception)
            {
                Console.WriteLine($"{ exception.Message}\nБыл изменен последний элемент массива");
            }
            finally
            {
                someArray[someArray.Length-1] = random.Next(0, 100);
                Console.WriteLine("Выполнение завершено");
            }



        }
    }
}
