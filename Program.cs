Console.Write("Введите целое число: "); // запрашиваем пользователя 1 число
int number_1 = Convert.ToInt32(Console.ReadLine()); //преобразовывает из консоли в целое число



if (number_1 >= number_2) // условие сравнить первое число со вторым числом
    Console.WriteLine("Максимальное число = " + number_1 + ", Минимальное число = " + number_2);
else
    Console.WriteLine("Максимальное число = " + number_2 + ", Минимальное число = " + number_1);