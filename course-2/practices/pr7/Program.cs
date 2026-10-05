//task1
int number = 10;


if (number > 0)
{
    Console.WriteLine("Число положительное");
}
else if (number < 0)
{
    Console.WriteLine("Число отрицательное");
}
else
{
    Console.WriteLine("Число равно нулю");
}

// task 2

Console.WriteLine("Введите возраст:");
int age = int.Parse(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("Вы совершеннолетний");
}
else
{
    Console.WriteLine("Вы несовершеннолетний");
}

// Task 3

int num = 7;

if (num % 2 == 0 )
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}

//Task 4 
int a = 5;
int b = -2;

if (a > 0 && b > 0)
{
    Console.WriteLine("Оба числа положительные");

}

if (a > 0 || b > 0)
{
    Console.WriteLine("Хотя бы одно число положительное");
}

if (a <= 0)
{
    Console.WriteLine(" a не положительное");
}

//Task 5

int grade = int.Parse(Console.ReadLine());

if (grade < 3)
{
    Console.WriteLine("Неудовлетворительно");
}
else if (grade == 3)
{
    Console.WriteLine("Удовлетворительно");
}
else if (grade == 4 )
{
    Console.WriteLine("Хорошо");
}
else
{
    Console.WriteLine("Отлично");
}

//Task 6

int min = 10;
int max = 100;

Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());

if (x >= min && x <= max)
{
    Console.WriteLine("Число в диапазоне.");
}
else
{
    Console.WriteLine("Число вне диапазона.");
}

//Task 7

Console.Write("Введите первую сторону: ");
double m = double.Parse(Console.ReadLine());

Console.Write("Введите вторую сторону: ");
double k = double.Parse(Console.ReadLine());

Console.Write("Введите третью сторону: ");
double c = double.Parse(Console.ReadLine());

if (m == k && k == c)
{
    Console.WriteLine("Треугольник равносторонний.");
}
else if (m == k || m == c || k == c)
{
    Console.WriteLine("Треугольник равнобедренный.");
}
else
{
    Console.WriteLine("Треугольник разносторонний.");
}

//Task 8

Console.Write("Введите сумму покупки: ");
double amount = double.Parse(Console.ReadLine());

double discount;

if (amount >= 5000)
{
    discount = amount * 0.10; //скидка 10%
}
else if (amount >= 2000)
{
    discount = amount * 0.05; //скидка 5 %
}
else
{
    discount = 0; //нет скидки
}

double finalsum = amount - discount;

Console.WriteLine(finalsum);
