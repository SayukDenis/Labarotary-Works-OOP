namespace Laboratory_work_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new Sunday());

            bool isMorning = true;

            for (int i = 0; i < 14; i++)
            {


                if (isMorning)
                {
                    Console.WriteLine("Morning:");
                    context.TakeMorningMedication();
                }
                else
                {
                    Console.WriteLine("Evening:");
                    context.TakeEveningMedication();
                }

                isMorning = !isMorning;
               
            }
        }
    }
}