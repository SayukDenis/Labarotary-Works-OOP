namespace Laboratory_work_4._2
{
    internal class CustomBeddingBuilder : IBeddingBuilder
    {
        private BeddingKit beddingKit = new BeddingKit();

        public void AddPillowcase()
        {
            beddingKit.Pillowcase = new Pillowcase { Material = "Silk", Size = 20 };
        }

        public void AddSheet()
        {
            beddingKit.Sheet = new Sheet { Material = "Linen", Size = 100 };
        }

        public void AddCover()
        {
            beddingKit.Cover = new Cover { Material = "Cotton", Size = 100 };
        }

        public BeddingKit GetBeddingKit()
        {
            return beddingKit;
        }
    }
}
