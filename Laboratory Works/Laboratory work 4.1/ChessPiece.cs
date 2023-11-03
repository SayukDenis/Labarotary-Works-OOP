using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_4._1
{
    internal class ChessPiece
    {
        public string Position;
        public ChessPieceType PieceType;
        public bool IsBlack;

        public ChessPiece(ChessPieceType type)
        {
            PieceType = type;
        }


        public ChessPiece DeepCopy()
        {
            return new ChessPiece(this.PieceType)
            {
                Position = this.Position,
                IsBlack = this.IsBlack
            };
        }
    }

}
