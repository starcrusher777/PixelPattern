class Program
{
    static void Main()
    {
        Console.WriteLine(string.Join("\n", GeneratePattern()));
    }

    static string[] GeneratePattern()
    {
        char[] name = { 'N', 'a', 'm', 'e' };
        int width = 60;
        int height = 30;

        char[,] pattern = new char[height, width];

        for (int y = height - 1; y >= -height; y--)
        {
            for (int x = -width / 2; x < width / 2; x++)
            {
                char pixel = ' ';

                if ((Math.Pow((x * 0.05), 2) + Math.Pow((y * 0.1), 2) - 1) * 3 - Math.Pow((x * 0.05), 2) * Math.Pow((y * 0.1), 2) <= 0)
                {
                    int index = (x - y + 4) % 4; 
                    pixel = name[index];
                }

                pattern[y + height - 1, x + width / 2] = pixel;
            }
        }

        
        string[] lines = new string[height];
        for (int y = 0; y < height; y++)
        {
            char[] lineChars = new char[width];
            for (int x = 0; x < width; x++)
            {
                lineChars[x] = pattern[y, x];
            }
            lines[y] = new string(lineChars);
        }

        Console.WriteLine(lines);
        return lines;
    }
}