namespace Laboratory_work_5._1
{
    internal class Sunday : Day
    {
        public override void MorningMedication()
        {
            Console.WriteLine("Break in Sunday morning");
        }

        public override void EveningMedication()
        {
            Console.WriteLine("Break in Sunday evening");
            this._context.SwitchTo(new Monday());
        }
    }
}
