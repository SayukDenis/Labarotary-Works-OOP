namespace Laboratory_work_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessPieceFactory factory = new ChessPieceFactory();

            ChessPiece whitePawn = factory.CreatePiece(ChessPieceType.Pawn, false);
            whitePawn.Position = "A2";
            Console.WriteLine($"Position: {whitePawn.Position}, Type: {whitePawn.PieceType}, Is Black: {whitePawn.IsBlack}");

            ChessPiece blackKing = factory.CreatePiece(ChessPieceType.King, true);
            blackKing.Position = "E8";
            Console.WriteLine($"Position: {blackKing.Position}, Type: {blackKing.PieceType}, Is Black: {blackKing.IsBlack}");
        }
    }
}