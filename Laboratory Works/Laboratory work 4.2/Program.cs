namespace Laboratory_work_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeddingBuilder customBuilder = new CustomBeddingBuilder();
            BeddingDirector director = new BeddingDirector(customBuilder);

            director.BuildBeddingKit();
            BeddingKit customKit = customBuilder.GetBeddingKit();
            Console.WriteLine("Custom Bedding Kit:");
            customKit.Display();
        }
    }
}