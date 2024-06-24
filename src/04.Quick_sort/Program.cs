Console.WriteLine("Quick sort!");

var array = new List<int>{ 7, 4, 3, 6, 10, 1, 2, 8, 5, 9 };
var sorted = QuickSort(array);

Console.WriteLine(string.Join(", ", sorted));

List<int> QuickSort(List<int> array)
{
    if (array.Count < 2)
    {
        return array;
    }

    var pivot = array[0];
    var less = array.Where(x => x < pivot).ToList();
    var greater = array.Where(x => x > pivot).ToList();

    return [..QuickSort(less), pivot, ..QuickSort(greater)];
}
