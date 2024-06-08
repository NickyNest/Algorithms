Console.WriteLine("Binary search");
var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var position = BinarySearch(array, 8);
Console.WriteLine(position.HasValue ? position : "not found");

int? BinarySearch(int[] array, int elementToSearch)
{
    var low = 0;
    var high = array.Length - 1;

    while (low <= high)
    {
        var mid = (low + high) / 2;
        var guess = array[mid];

        if (guess == elementToSearch)
        {
            return mid;
        }

        if (guess > elementToSearch)
        {
            high = mid - 1;
        }
        else
        {
            low = mid + 1;
        }
    }

    return null;
}
