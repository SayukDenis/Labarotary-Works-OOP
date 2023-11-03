namespace Laboratory_work_4._2
{
    internal

    class BeddingDirector
    {
        private IBeddingBuilder builder;

        public BeddingDirector(IBeddingBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildBeddingKit()
        {
            builder.AddPillowcase();
            builder.AddSheet();
            builder.AddCover();
        }
    }
}

