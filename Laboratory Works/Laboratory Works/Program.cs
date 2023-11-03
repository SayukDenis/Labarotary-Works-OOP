using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Engineer engineer = new Engineer();
        engineer.Work();
        engineer.Dispose();

        Console.WriteLine();

        Console.WriteLine(GC.GetTotalMemory(false) / 1024);

        Engineer eng = new Engineer();
        for (int i = 0; i < 1000; i++)
        {
            Engineer eng2 = new Engineer();
        }
        Console.WriteLine("Memory before collect: " + GC.GetTotalMemory(false));
        Console.WriteLine("Generation: " + GC.GetGeneration(eng));
        GC.Collect(2, GCCollectionMode.Forced);
        GC.WaitForPendingFinalizers();
        Console.WriteLine("Memory after collect: " + GC.GetTotalMemory(false));
        Console.WriteLine("Generation: " + GC.GetGeneration(eng));
    }
}