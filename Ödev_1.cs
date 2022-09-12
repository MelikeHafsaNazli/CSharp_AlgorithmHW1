using System.Collections.Generic;
using System.Linq;
using System;

public class Soru_1
{
    public static void Main()
    {
        Console.WriteLine("Pozitif bir sayı giriniz: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(n + " pozitif sayı daha giriniz: ");

        List<int> arr = Console
            .ReadLine()
            .TrimEnd()
            .Split(' ')
            .ToList()
            .Select(arrTemp => Convert.ToInt32(arrTemp))
            .ToList();

        for (int i = 0; i < n; i++)
        {
            if (arr[i] % 2 == 0)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

public class Soru_2
{
    public static void Main()
    {
        Console.WriteLine("Sayı adedini giriniz: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Bölünecek sayıyı giriniz: ");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Sayı Giriniz : ");
        List<int> numbers = Console
            .ReadLine()
            .TrimEnd()
            .Split(' ')
            .ToList()
            .Select(arrTemp => Convert.ToInt32(arrTemp))
            .ToList();
        ;

        for (int i = 0; i < n; i++)
        {
            if (numbers[i] % m == 0)
                Console.Write(numbers[i] + " ");
        }
    }
}

public class Soru_3
{
    public static void Main()
    {
        Console.WriteLine("Pozitif bir sayı giriniz: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(n + " kelime giriniz: ");

        List<String> arr = Console.ReadLine().TrimEnd().Split(' ').ToList();

        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }
}

public class Soru_4
{
    public static void Main()
    {
        Console.Write("Cümle Giriniz: ");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(' ');

        Console.WriteLine("Kelime Sayısı: {0}", words.Count());
        Console.WriteLine("Harf Sayısı: {0}", sentence.Count());
    }
}
