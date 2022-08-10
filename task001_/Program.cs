// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

int Prompt(string message)
{
System.Console.Write(message); // Вывести сообщение
string readValue = Console.ReadLine(); // Считавает с консоли строку
int result = int.Parse(readValue); // Преобрадует строку в целое число
return result; // Возвращает результат
}


int value1 = Prompt("Введите число >"); // Вводим значение
int value2 = Prompt("Введите квадрат >");

if (value2 == value1 * value1)
{
    Console.WriteLine ("Число b является квадратом числа а");
}
else
{
    Console.WriteLine ("Число b не является квадратом числа а");

}

