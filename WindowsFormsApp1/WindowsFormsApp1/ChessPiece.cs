using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    public class ChessPiece
    {

        public PieceType Type { get; set; }
        public PieceColor Color { get; set; }

        public ChessPiece(PieceType type, PieceColor color)
        {
            Type = type;
            Color = color;
        }

        public override string ToString()
        {
            return Type == PieceType.None ? "." : ($"{Color.ToString()[0]}{Type.ToString()[0]}");
        }
    }
}
