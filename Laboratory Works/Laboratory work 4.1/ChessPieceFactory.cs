using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_4._1
{
    internal class ChessPieceFactory
    {
        private ChessPiece whitePawnPrototype;
        private ChessPiece whiteRookPrototype;
        private ChessPiece whiteBishopPrototype;
        private ChessPiece whiteQueenPrototype;
        private ChessPiece whiteKingPrototype;
        private ChessPiece whiteKnightPrototype;

        private ChessPiece blackPawnPrototype;
        private ChessPiece blackRookPrototype;
        private ChessPiece blackBishopPrototype;
        private ChessPiece blackQueenPrototype;
        private ChessPiece blackKingPrototype;
        private ChessPiece blackKnightPrototype;

        public ChessPieceFactory()
        {
            whitePawnPrototype = new ChessPiece(ChessPieceType.Pawn);
            whiteRookPrototype = new ChessPiece(ChessPieceType.Rook);
            whiteBishopPrototype = new ChessPiece(ChessPieceType.Bishop);
            whiteQueenPrototype = new ChessPiece(ChessPieceType.Queen);
            whiteKingPrototype = new ChessPiece(ChessPieceType.King);
            whiteKnightPrototype = new ChessPiece(ChessPieceType.Knight);

            blackPawnPrototype = whitePawnPrototype.DeepCopy();
            blackRookPrototype = whiteRookPrototype.DeepCopy();
            blackBishopPrototype = whiteBishopPrototype.DeepCopy();
            blackQueenPrototype = whiteQueenPrototype.DeepCopy();
            blackKingPrototype = whiteKingPrototype.DeepCopy();
            blackKnightPrototype = whiteKnightPrototype.DeepCopy();

            blackPawnPrototype.IsBlack = true;
            blackRookPrototype.IsBlack = true;
            blackBishopPrototype.IsBlack = true;
            blackQueenPrototype.IsBlack = true;
            blackKingPrototype.IsBlack = true;
            blackKnightPrototype.IsBlack = true;
        }

        public ChessPiece CreatePiece(ChessPieceType pieceType, bool isBlack)
        {
            if (isBlack)
            {
                switch (pieceType)
                {
                    case ChessPieceType.Pawn: return blackPawnPrototype.DeepCopy();
                    case ChessPieceType.Rook: return blackRookPrototype.DeepCopy();
                    case ChessPieceType.Bishop: return blackBishopPrototype.DeepCopy();
                    case ChessPieceType.Queen: return blackQueenPrototype.DeepCopy();
                    case ChessPieceType.King: return blackKingPrototype.DeepCopy();
                    case ChessPieceType.Knight: return blackKnightPrototype.DeepCopy();
                    default: throw new ArgumentException("Unknown piece type");
                }
            }
            else
            {
                switch (pieceType)
                {
                    case ChessPieceType.Pawn: return whitePawnPrototype.DeepCopy();
                    case ChessPieceType.Rook: return whiteRookPrototype.DeepCopy();
                    case ChessPieceType.Bishop: return whiteBishopPrototype.DeepCopy();
                    case ChessPieceType.Queen: return whiteQueenPrototype.DeepCopy();
                    case ChessPieceType.King: return whiteKingPrototype.DeepCopy();
                    case ChessPieceType.Knight: return whiteKnightPrototype.DeepCopy();
                    default: throw new ArgumentException("Unknown piece type");
                }
            }
        }
    }
}
