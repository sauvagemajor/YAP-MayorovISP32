using System;
class MainClass
{
    static void Main()
    {
        Console.Write("Введите кол-во элементов вашего массива:\t");
        int e = int.Parse(Console.ReadLine());
        double[] m = new double[e];
        double t;

        for (int i = 0; i < m.Length; i++)
        {
            Console.Write("[" + i + "] : ");
            m[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < m.Length - 1; i++)
        {
            for (int j = i + 1; j < m.Length; j++)
            {
                if (m[i] > m[j])
                {
                    t = m[i];
                    m[i] = m[j];
                    m[j] = t;
                }
            }
        }

        Console.Write("|1|Вывод четных чисел: ");
        for (int i = 0; i < m.Length; i++)
        {
            if (m[i] % 2 == 0)
                Console.Write(m[i] + " ");
        }

        Console.Write("\n|2|Вывод нечетных чисел: ");
        for (int i = 0; i < m.Length; i++)
        {
            if ((m[i] % 2 != 0) & (m[i] > 1))
                Console.Write(m[i] + " ");
        }
    }
}
