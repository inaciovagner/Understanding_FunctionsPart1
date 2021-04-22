using System;
namespace CsharpPrograms
{
    class Program
    {
        static public int Average(float a, float b, float c, float d, float e)
        {
            int avg = (int)((a + b + c + d + e) / 5);
            return avg;
        }
        static void Main(string[] args)
        {
            float v, w, x, y, z;
            int result = 0;
            v = float.Parse(Console.ReadLine());
            w = float.Parse(Console.ReadLine());
            x = float.Parse(Console.ReadLine());
            y = float.Parse(Console.ReadLine());
            z = float.Parse(Console.ReadLine());
            result = Average(v, w, x, y, z);
            Console.WriteLine(result);
        }
    }
}