namespace Laboratory_work_4._2
{
    internal class BeddingKit
    {
        public Pillowcase Pillowcase { get; set; }
        public Sheet Sheet { get; set; }
        public Cover Cover { get; set; }

        public void Display()
        {
            Console.WriteLine($"Pillowcase: {Pillowcase.Material}, Size: {Pillowcase.Size}");
            Console.WriteLine($"Sheet: {Sheet.Material}, Size: {Sheet.Size}");
            Console.WriteLine($"Cover: {Cover.Material}, Size: {Cover.Size}");
        }
    }
}
