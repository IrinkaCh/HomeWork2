Console.WriteLine("Введите два числа ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindStepenNumber(A));

double FindStepenNumber(int A)
{
double result = Math.Pow(A, B);
return result;
}