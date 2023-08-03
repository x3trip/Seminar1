
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
bool Paliondrop(int num)
{
        int result = 0;
        int LastNumber = num % 10;
        while (num > 99)
        {
                num = num / 10;
        }
        result = num / 10;
        
        return LastNumber == result;
}
Console.Write("input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
bool compare = Paliondrop(number);
if(compare) Console.Write("yes");
else Console.Write("no");
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distons(double x, double y, double z, double x1, double y1, double z1)
{
        double x2 = x1 - x;
        double y2 = y1 - y;
        double z2 = z1 - z;
        return Math.Sqrt(x2 * x2 + y2 * y2 + z2 * z2);
         
}
Console.Write("input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
double Distt = Distons(x1, y1, z1, x2, y2, z2);
Console.WriteLine(Distt);
*/

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void cube(int num)
{
        int i = 1;
        while (i <= num)
        {
                Console.WriteLine($"{i}^{num}={Math.Pow(i,num)}");
                i++;
        }
}
Console.Write("input a number ");
int num3 = Convert.ToInt32(Console.ReadLine());
cube(num3);
*/