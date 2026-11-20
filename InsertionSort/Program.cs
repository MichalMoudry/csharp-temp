int[] values = [5, 2, 4, 6, 1, 3];
PrintValues(values);

for (var i = 1; i < values.Length; i++)
{
    var current = values[i];
    var previousIndex = i - 1;
    while (previousIndex >= 0 && values[previousIndex] > current)
    {
        values[previousIndex + 1] = values[previousIndex];
        previousIndex -= 1;
    }

    values[previousIndex + 1] = current;
}
PrintValues(values);

return;

static void PrintValues<T>(IList<T> values)
{
    Console.Write("[ ");
    foreach (var value in values)
    {
        Console.Write($"{value} ");
    }
    Console.WriteLine("]");
}
