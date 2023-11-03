namespace Laboratory_work_5._1
{
    internal abstract class Day
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            this._context = context;
        }

        public abstract void MorningMedication();
        public abstract void EveningMedication();
    }
}
