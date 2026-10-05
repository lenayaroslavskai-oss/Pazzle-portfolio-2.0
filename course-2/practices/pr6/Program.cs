//Задание 1

int a = 12;
int b = 5;

int sum = a + b;
int difference = a - b;
int product = a * b;
int quotient = a / b;
int remainder = a % b;

Console.WriteLine(sum);
Console.WriteLine(difference);
Console.WriteLine(product);
Console.WriteLine(quotient);
Console.WriteLine(remainder);
// Задание 2

Console.WriteLine("Введите ваше имя:");
string name = Console.ReadLine();
Console.WriteLine(name);

// Задание 3

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

int sum1 = num1 + num2;
Console.WriteLine(sum1);

// Задание 4

Console.Write("Введите длину прямоугольника: ");
double length = double.Parse(Console.ReadLine());

Console.Write("Введите ширину прямоугольника: ");
double width = double.Parse(Console.ReadLine());

double area = length * width;
Console.WriteLine(area);

// Задание 5

Console.Write("Введите температуру в градусах Цельсия: ");
double celsius = double.Parse(Console.ReadLine());

double fahrenheit = celsius * 9.0 / 5.0 + 32;

Console.WriteLine(celsius + "=" + fahrenheit);

// Задание 6

Console.Write("Введите первое число: ");
double num3 = double.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
double num4 = double.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
double num5 = double.Parse(Console.ReadLine());

double average = (num1 + num2 + num3) / 3.0;

Console.WriteLine(average);

// Задание 7

Console.Write("Введите первое число: ");
double x = double.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
double m = double.Parse(Console.ReadLine());

double sum5 = x + m;
double difference1 = x - m;
double product1 = x * m;
double quotient1 = x / m;

Console.WriteLine(x + " + " + m + " = " + (x + m));
Console.WriteLine(x + " - " + m + " = " + (x - m));
Console.WriteLine(x + " * " + m + " = " + (x * m));
Console.WriteLine(x + " / " + m + " = " + (x / m));