namespace Lab_0
{
    using System;

    class Program
    {
        static void Main()
        {
            Random random = new Random();

            // Генерируем два случайных целых числа
            int num1 = random.Next(1, 11); 
            int num2 = random.Next(1, 11); 

            // Вызываем функцию SquareProduct и выводим результат на консоль
            int result = SquareProduct(num1, num2);
            Console.WriteLine("Квадрат произведения {0} и {1} равен {2}", num1, num2, result);
        }

        /// <summary>
        /// 12. Реализовать функцию возведения в квадрат произведения двух целых чисел
        /// </summary>
        /// <param name="num1">Первый множитель</param>
        /// <param name="num2">Второй множитель</param>
        /// <returns>возвращает результат возведения в квадрат произведения двух целых чисел</returns>
        static int SquareProduct(int num1, int num2)
        {
            int product = num1 * num2; 
            int square = product * product; 
            return square; 
        }
    }

}