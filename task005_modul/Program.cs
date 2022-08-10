//Напишите программу вычисления модуля числа.
//2 -> 2
int Prompt(string message)
{
    System.Console.Write(message); 
    string readValue = Console.ReadLine(); 
    int result = int.Parse(readValue); 
    return result; 
}

int N = Prompt("Введите число ");
Console.WriteLine(Math.Abs(N));
