// Рекурсия
// Рекурсия - это функция, которая вызывает сама себя

// Вычисление факториала

// 5! = 5 * 4 * 3 * 2 * 1
// 5! = 5 * 4!

// int Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }

// Console.WriteLine(Factorial(5));

// Когда мы будем вычислять большие числа (допустим, 40!), в какой-то момент начнём получать отрицательные числа, 
// чего быть не должно. Это связано с переполнением типа.
// Одно из возможных решений - смена типа на более подходящий.

// double Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

// Число Фибоначчи

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 50; i++)
{
    Console.Write($"f({i}) = {Fibonacci(i)} ");
}

// ~ начиная с 40-го вывод происходит очень медленно.
