using System;

class Program
{
    static void Main()
    {
        //// ВАРИАНТ 1: DivideByZeroException

        //try
        //{
        //    int a = 10;
        //    int b = 0;
        //    Console.WriteLine(a / b);
        //}
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("DivideByZeroException: " + ex.Message);
        //}


        ////ВАРИАНТ 2: ArgumentOutOfRangeException

        //try
        //{
        //    int number = -5;

        //    if (number < 0)
        //        throw new ArgumentOutOfRangeException("number", "Число не может быть отрицательным.");
        //}
        //catch (ArgumentOutOfRangeException ex)
        //{
        //    Console.WriteLine("ArgumentOutOfRangeException: " + ex.Message);
        //}




        ////ВАРИАНТ 3: ArgumentException

        //try
        //{
        //    throw new ArgumentException("Передан неправильный аргумент.");
        //}
        //catch (ArgumentException ex)
        //{
        //    Console.WriteLine("ArgumentException: " + ex.Message);
        //}




        ////ВАРИАНТ 4: IndexOutOfRangeException

        //try
        //{
        //    int[] numbers = { 1, 2, 3 };
        //    Console.WriteLine(numbers[5]);
        //}
        //catch (IndexOutOfRangeException ex)
        //{
        //    Console.WriteLine("IndexOutOfRangeException: " + ex.Message);
        //}




        ////ВАРИАНТ 5: InvalidCastException

        //try
        //{
        //    object value = "Текст";
        //    int number = (int)value;
        //    Console.WriteLine(number);
        //}
        //catch (InvalidCastException ex)
        //{
        //    Console.WriteLine("InvalidCastException: " + ex.Message);
        //}




        ////ВАРИАНТ 6: NullReferenceException

        //try
        //{
        //    string? text = null;
        //    Console.WriteLine(text!.Length);
        //}
        //catch (NullReferenceException ex)
        //{
        //    Console.WriteLine("NullReferenceException: " + ex.Message);
        //}



        //Console.WriteLine("\nПрограмма завершена.");
        //Console.ReadKey();
    }
}