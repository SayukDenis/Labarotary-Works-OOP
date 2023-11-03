namespace Laboratory_work_5._1
{
    internal class Context
    {
        private Day day = null;

        public Context(Day state)
        {
            this.SwitchTo(state);
        }

        public void SwitchTo(Day day)
        {
            Console.WriteLine($"Switched to {day.GetType().Name}.");
            this.day = day;
            this.day.SetContext(this);
        }

        public void TakeMorningMedication()
        {
            this.day.MorningMedication();
        }

        public void TakeEveningMedication()
        {
            this.day.EveningMedication();
        }
    }
}
