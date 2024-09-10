Console.WriteLine("The longetst common subsequence");
var word1 = "fish";
var word2 = "fosh";
var table = BuildTable(word1, word2);
Display(word1, word2, table);

int[,] BuildTable(string word1, string word2)
{
    var matrix = new int[word1.Length + 1, word2.Length + 1];

    for(int i = 1; i <= word1.Length; i++)
    {
        for (int j = 1; j <= word2.Length; j++)
        {
            if (word1[i - 1] == word2[j - 1])
            {
                matrix[i, j] = matrix[i - 1, j - 1] + 1;
            }
            else
            {
                matrix[i, j] = Math.Max(matrix[i - 1, j], matrix[i, j - 1]);
            }
        }
    }

    return matrix;
}

void Display(string word1, string word2, int[,] matrix)
{
    Console.Write(' ');
    word2.ToList().ForEach(x => Console.Write(" " + x));
    Console.WriteLine();

    for(int i = 1; i < matrix.GetLength(0); i++)
    {
        Console.Write(word1[i - 1] + " ");

        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }

        Console.WriteLine();
    }
}
