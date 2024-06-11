Console.WriteLine("Selection sort v1");
var arrayToSort = new int [] { 1, 6, 4, 8, 7, 2, 5, 9, 3, 10 };
var sortedArray = SelectionSort(arrayToSort);
Console.WriteLine(string.Join(", ", sortedArray));

Console.WriteLine("Selection sort v2");
var arrayToSort2 = new int [] { 1, 6, 4, 8, 7, 2, 5, 9, 3, 10 };
SelectionSort2(arrayToSort2);
Console.WriteLine(string.Join(", ", arrayToSort2));


int[] SelectionSort(int[] array)
{
    var newArray = new int [array.Length];
    var length = array.Length;
    for (int i = 0; i < length; i++)
    {
        var smallestIndex = FindSmallest(array);
        newArray[i] = array[smallestIndex];
        array = array.Where(a => a != array[smallestIndex]).ToArray();
    }

    return newArray;
}

int FindSmallest(int[] array)
{
    var smallest = array[0];
    var smallestIndex = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < smallest)
        {
            smallest = array[i];
            smallestIndex = i;
        }
    }

    return smallestIndex;
}

void SelectionSort2(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for(int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[i])
            {
                // int temp = array[i];
                // array[i] = array[j];
                // array[j] = temp;
                (array[i], array[j]) = (array[j], array[i]);
            }
        }
    }
}