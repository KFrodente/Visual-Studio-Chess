using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA6_Draft
{
    internal class UnitTests
    {

        public bool TestSidesAreSame(ChessGame game)
        {
            //goes through each back piece, if the pieces arent the same it returns as FAILED
            for(int i = 0; i < 8; i++)
            {
                // Occupant + 1 is to swap piece from black to white
                if (game.Board[i][0].Occupant + 1 != game.Board[i][7].Occupant)
                {
                    return false;
                }
            }

            return true;
        }

        public bool TestPawnsInPlace(ChessGame game)
        {
            // checks that all front pieces are still pawns
            for(int i = 0; i < 8; i++)
            {
                if (game.Board[i][1].Occupant != Piece.BPAWN || game.Board[i][6].Occupant != Piece.WPAWN)
                {
                    return false;
                }
            }

            return true;
        }

        public bool TestCorrectRules(ChessGame game, Rules wantedRules)
        {
            return wantedRules == game.GetRulesCompleted();
        }

        public bool TestKingBetweenRooks(ChessGame game)
        {
            int rook1Pos = -1;
            int rook2Pos = -1;
            int kingPos = -1;

            // goes through back pieces to find both rooks and king
            for (int i = 0; i < 8; i++)
            {
                if (game.Board[i][0].Occupant == Piece.BROOK && rook1Pos == -1)
                    rook1Pos = i;
                else if (game.Board[i][0].Occupant == Piece.BROOK && rook1Pos != -1)
                    rook2Pos = i;
                else if (game.Board[i][0].Occupant == Piece.BKING)
                    kingPos = i;

            }

            // returns true if king position is past rook 1 and before rook 2
            return kingPos > rook1Pos && kingPos < rook2Pos;
        }
    }
}
