Console.WriteLine("Recursion");

Console.WriteLine("5! = {0}", Factorial(5));

var arraySum = new List<int> { 4, 1, 3, 2 };
Console.WriteLine("Sum: {0}", Sum(arraySum));
var arrayCount = new List<int> { 4, 1, 3, 2, 6 };
Console.WriteLine("Count: {0}", Count(arrayCount));
var arrayMax = new List<int> { 3, 2, 6, 4, 10, 7, 1 };
Console.WriteLine("Max: {0}", Max(arrayMax));

long Factorial(int x)
{
    if (x == 1)
    {
        return 1;
    }

    return x * Factorial(x - 1);
}

int Sum(List<int> arr)
{
    if (arr.Count == 0)
    {
        return 0;
    }

    return arr[0] + Sum(arr.Skip(1).ToList());
}

int Count(List<int> arr)
{
    if (arr.Count == 0)
    {
        return 0;
    }
    
    return 1 + Count(arr.Skip(1).ToList());
}

int Max(List<int> arr)
{
    if(arr.Count == 1)
    {
        return arr[0];
    }

    var subMax = Max(arr.Skip(1).ToList());
    return arr[0] > subMax ? arr[0] : subMax;
}