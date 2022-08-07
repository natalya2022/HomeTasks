//Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N. 5 -> 2, 4

// Функция, на вход получает параметр, на выходе введенное с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразует строку в целое число
    return result;                          // Возвращает результат
}

int num1;                                   // Объявление переменной 
num1 = Prompt("Введите число N > ");        // Вводим значение
if (num1 > 1)
{
    for (int count = 2; count <= num1; count = count + 2)
    {
        System.Console.Write($"{count} ");   // Вывод результата
    }
}
else
{
    System.Console.WriteLine($"Число {num1} не соотвествует условию задачи");   // Вывод результата
}