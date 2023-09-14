namespace Lab_0
{
    using System;

    class Program
    {
        static void Main()
        {
            // Создаем объект Random для генерации случайных чисел
            Random random = new Random();

            // Генерируем два случайных целых числа
            int num1 = random.Next(1, 11); // Генерируем число от 1 до 10
            int num2 = random.Next(1, 11); // Генерируем число от 1 до 10

            // Вызываем функцию SquareProduct и выводим результат на консоль
            int result = SquareProduct(num1, num2);
            Console.WriteLine("Квадрат произведения {0} и {1} равен {2}", num1, num2, result);
        }

        // Функция для возврата квадрата произведения двух целых чисел
        static int SquareProduct(int num1, int num2)
        {
            int product = num1 * num2; // Вычисляем произведение
            int square = product * product; // Возводим произведение в квадрат
            return square; // Возвращаем результат
        }
    }

}