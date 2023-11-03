namespace Laboratory_work_5._1
{
    internal class Saturday : Day
    {
        public override void MorningMedication()
        {
            Console.WriteLine("Medicine #3");
        }

        public override void EveningMedication()
        {
            Console.WriteLine("Medicine #4");
            this._context.SwitchTo(new Sunday());
        }
    }
}
