// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++){
        arr[i] = new Random().Next(minValue, maxValue);
        Console.WriteLine($"{arr[i]} ");
        
    }
    return arr;
}

void CheckSumArr(int [] arr)
{
    int sum = 0;
    for (int i = 0; i<arr.Length; i++)
    {
        
        if(i%2 != 0)
        {
            sum = sum + arr[i];
        }
        
    }
    Console.WriteLine($"Sum of non-even array members = {sum}");
    //Console.WriteLine($"{count}");
}
int[] array = GetArray(10, -1000, 999);//метод создания массива
CheckSumArr(array);