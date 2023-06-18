/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
#region 
int GetNumber(string message)
{
   Console.Write(message);
   int number = Convert.ToInt32(Console.ReadLine());
   return number;
}

void ReversNumber(int number)
{
    int temp = number;
    int revers, sum = 0;

    while(Convert.ToBoolean(number))
        {
            revers = number % 10;
            number /= 10;
            sum = sum * 10 + revers;
        }
        
        if(temp == sum)
        {
            Console.WriteLine(" Палиндром ");
        }
        else
            Console.WriteLine(" Непалиндром");
        
}

int num = GetNumber(" Введите число: ");
ReversNumber(num);
#endregion

/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
#region 
int PointCoordinates(string message)
{
    Console.Write( " " + message);
    int number = Convert.ToInt32(Console.ReadLine());
        return number;
}
int xA = PointCoordinates(" Введите координату x для A: ");
int yA = PointCoordinates(" Введите координату y для A: ");
int zA = PointCoordinates(" Введите координату z для A: ");
int xB = PointCoordinates(" Введите координату x для B: ");
int yB = PointCoordinates(" Введите координату y для B: ");
int zB = PointCoordinates(" Введите координату z для B: ");

double Root(int xA, int yA, int zA, int xB, int yB, int zB)
{
 double result1 = Math.Pow(xB - xA, 2);
 double result2 = Math.Pow(yA - yB, 2);
 double result3 = Math.Pow(zA - zB, 2);
 double result = Math.Sqrt(result1 + result2 + result3);
    return result;
}

double distance = Root(xA, yA, zA, xB, yB, zB);
Console.WriteLine("  Растояние между точками: " + Math.Round(distance, 2));
#endregion
/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
#region 
int ImputNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
        return number;
}

void CubeNumber(int number)
{
    int num = number;
    Console.Write(" Кубы чисел чесла N: ");
    for (int i = 1; i <= num; i++)
    {
        
       Console.Write( Math.Pow(i, 3));

        if(i < num)
        {
            Console.Write(" , ");
        }
        else
        {
            Console.Write(" . ");
        }
    }
    
}

int numN = ImputNumber(" Введите число N: ");
CubeNumber(numN);
#endregion