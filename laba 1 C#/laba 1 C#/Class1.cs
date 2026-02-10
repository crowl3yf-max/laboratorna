using System;
internal class Class1
{
    public string value;
    public void show()
    {
        Console.WriteLine(value);
    }
    public int lenght()
    {
        return value.Length;
    }
    public void sort()
    {
        char[] chars = value.ToCharArray();
        for (int i = 0; i < chars.Length - 1; i++)
        {
            for (int j = 0; j < chars.Length - i - 1; j++)
            {
                if (chars[j] > chars[j + 1])
                {
                    char temp = chars[j];
                    chars[j] = chars[j + 1];
                    chars[j + 1] = temp;
                }
            }
        }
        value = new string(chars);
    }
}