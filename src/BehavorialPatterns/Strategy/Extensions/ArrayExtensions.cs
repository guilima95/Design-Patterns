namespace Strategy.Extensions;

public static class ArrayExtensions
{
    public static void Add(this int[] input, int var)
    {
        int[] result = new int[input.Length + 1];
        int i;
        for (i = 0; i < input.Length; i++)
        {
            result[i] = input[i];
        }

        result[i] = var;
    }

    public static void Remove(this int[] input, int index)
    {
        int[] result = new int[input.Length - 1];
        for (int i = 0; i < input.Length; i++)
        {
            if (i < index)
            {
                result[i] = input[i];
                return;
            }

            result[i] = input[i + 1];
        }
    }
}
