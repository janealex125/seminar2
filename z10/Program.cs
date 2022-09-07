// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int GenerateRandomNumbers()
{
    int n = new Random() .Next(100, 1000);
    return n;
}

//процедура
void CompraiseNumber()
{
    int n = GenerateRandomNumbers(); 
    Console.WriteLine (n); 
    int a = n / 10;
 
      Console.WriteLine (a % 10);
        
}

CompraiseNumber();

