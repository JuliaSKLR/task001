//Напишите программу, которая будет выдавать название дня недели по заданному номеру.

int Prompt(string message)
{
    System.Console.Write(message); 
    string readValue = Console.ReadLine(); 
    int result = int.Parse(readValue); 
    return result; 
}

int daynumber = Prompt("Введите номер дня недели  ");

if (daynumber == 1)
{
    Console.WriteLine("Понедельник");
}
else
if (daynumber == 2)
{
    Console.WriteLine("Вторник");
}
else
if (daynumber == 3)
{
    Console.WriteLine("Среда");
}
else

if (daynumber == 4)
{
    Console.WriteLine("Четверг");
}
else

if (daynumber == 5)
{
    Console.WriteLine("Пятница");
}
else

if (daynumber == 6)
{
    Console.WriteLine("Суббота");
}

else

if (daynumber == 7)
{
    Console.WriteLine("Воскресенье");
}

else Console.WriteLine("Вводите значения от 1 до 7, дней недели только семь!");


