// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double [] GetArray(int size, double minValue, double maxValue)
{
    double [] arr = new double[size];//метод заполнения мвссива вещественными числами
    Random rand = new Random();
    double range = maxValue - minValue;
    for (int i = 0; i < size; i++){
        double number = rand.NextDouble();
        arr[i] = (number*range)+minValue;
        Console.WriteLine($"{arr[i]} ");
        
    }
    return arr;
}
void CheckNumArr(double [] arr)
{
    double userMin = 0;
    double userMax = 0;
    foreach (double el in arr)
    {
        
        if(el <= userMin)
        {
            userMin = el;
        }
        if(el >= userMax)
        {
            userMax = el;
        }
        
    }
    Console.Write("Max number is " );
    Console.WriteLine("{0:F10}", (userMax));
    Console.Write("Min number is " );
    Console.WriteLine("{0:F10}", (userMin));
    Console.Write($"Difference between Min number and Max number is ");
    Console.WriteLine("{0:F10}", (userMax - userMin));
}
double[] array = GetArray(10, -999, 999);//метод создания массива
CheckNumArr(array);
