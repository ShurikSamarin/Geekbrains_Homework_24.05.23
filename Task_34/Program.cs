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

void CheckNumArr(int [] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        
        if(el%2 == 0)
        {
            count++;
        }
        
    }
    Console.WriteLine($"Quantity of even numbers = {count}");
    //Console.WriteLine($"{count}");
}
int[] array = GetArray(10, 100, 999);//метод создания массива
CheckNumArr(array);
