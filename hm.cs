//№1
Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 161 == 0)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");

    //2
Console.Write("Введите координату X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double y = Convert.ToDouble(Console.ReadLine());
while (x == 0)
{
  Console.Write("Вы ошиблись!\nВведите координату X: ");
  x = Convert.ToDouble(Console.ReadLine());
}
while (y == 0)
{
  Console.Write("Вы ошиблись!\nВведите координату Y: ");
  y = Convert.ToDouble(Console.ReadLine());
}
if (x > 0 && y > 0)
  Console.WriteLine("I");
else if (x < 0 && y > 0)
  Console.WriteLine("II");
else if (x < 0 && y < 0)
  Console.WriteLine("III");
else
  Console.WriteLine("IV");

  //3
  int n = new Random().Next(10, 100); 
Console.WriteLine(n);
int n1 = n / 10;
int n2 = n % 10;
if (n1 > n2)
    Console.WriteLine(n1);
else
    Console.WriteLine(n2);

    