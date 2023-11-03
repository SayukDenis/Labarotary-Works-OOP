namespace Laboratory_work_5._1
{
    internal class Monday : Day
    {
        public override void MorningMedication()
        {
            Console.WriteLine("Medicine #1");
        }

        public override void EveningMedication()
        {
            Console.WriteLine("Medicine #4");
            this._context.SwitchTo(new Tuesday());
        }
    }
}
