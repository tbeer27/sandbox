string[] names = { "tom", "Kodi", "Matthew" };
int LinearSearch(int[] numbers, int target)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == target)
        {
            return i;
        }
    }
    return -1;
}

{
	{
        string index = LinearSearch(names, 5);
		Console.WriteLine("The number 5 is at index " + index);
	}
}