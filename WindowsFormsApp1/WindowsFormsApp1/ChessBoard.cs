using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    public enum PieceType { King, Queen, Rook, Bishop, Knight, Pawn, None }
    public enum PieceColor { White, Black, None }
    public class ChessBoard
    {

        public ChessPiece[,] Board { get; private set; }

        public ChessBoard()
        {
            Board = new ChessPiece[8, 8];
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            // Set up pawns
            for (int i = 0; i < 8; i++)
            {
                Board[1, i] = new ChessPiece(PieceType.Pawn, PieceColor.White);
                Board[6, i] = new ChessPiece(PieceType.Pawn, PieceColor.Black);
            }

            // Set up major pieces
            PlaceMajorPieces(0, PieceColor.White);
            PlaceMajorPieces(7, PieceColor.Black);

            // Fill empty squares
            for (int i = 2; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Board[i, j] = new ChessPiece(PieceType.None, PieceColor.None);
                }
            }
        }

        private void PlaceMajorPieces(int row, PieceColor color)
        {
            Board[row, 0] = new ChessPiece(PieceType.Rook, color);
            Board[row, 1] = new ChessPiece(PieceType.Knight, color);
            Board[row, 2] = new ChessPiece(PieceType.Bishop, color);
            Board[row, 3] = new ChessPiece(PieceType.Queen, color);
            Board[row, 4] = new ChessPiece(PieceType.King, color);
            Board[row, 5] = new ChessPiece(PieceType.Bishop, color);
            Board[row, 6] = new ChessPiece(PieceType.Knight, color);
            Board[row, 7] = new ChessPiece(PieceType.Rook, color);
        }

        public string DisplayBoard()
        {
            string text = "";
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    text += Board[row, col].ToString() + " ";
                    
                }
                
            }
            return text;
        }
    }
}
