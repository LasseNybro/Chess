using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models
{
    public class Piece
    {
        //Custom Enum
        public enum Officer { Pawn, Rook, Knight, Bishop, Queen, King }

        //Properties
        int X { get; set; }
        int Y { get; set; }
        string Color { get; set; }
        int ID { get; set; }
        int GameID { get; set; }
        int Moves { get; set; }
        Officer Type { get; set; }


        //Constructor
        public Piece(int x, int y, string color, int id, int gameID, Officer Type)
        {
            this.X = x; this.Y = y; this.Color = color; this.ID = id; this.GameID = gameID; this.Moves = 0;
            Game.Pieces.Add(this);
        }

        //Methods
        public virtual Move Move(Move theMove)
        {
            string move = theMove.TheMove;
            int X1 = Convert.ToInt32(move[0]) - Convert.ToInt32('A') + 1;
            int Y1 = move[1];
            int X2 = Convert.ToInt32(move[2]) - Convert.ToInt32('A') + 1;
            int Y2 = move[3];
            Piece Moved =
                (from P in Game.Pieces
                 where X1 == P.X && Y1 == P.Y// && User.Color == P.Color, til når vi implementerer brugere
                 select P).FirstOrDefault();
            Piece Attacked =
                (from P in Game.Pieces
                 where X2 == P.X && Y2 == P.Y
                 select P).FirstOrDefault();
            if (Moved != null) {
                if (!(X2 < 1 || X2 > 8 || Y2 < 1 || Y2 > 8))
                {
                    if (Attacked == null || Attacked.Color != this.Color)
                    {
                        if (Attacked != null)
                        {
                            Game.Pieces.Remove(Attacked);
                        }
                        switch (Type)
                        {
                            case Officer.Pawn:
                                break;
                            case Officer.Rook:
                                break;
                            case Officer.Knight:
                                if ((X2 - X1) + (Y2 - Y1) == 5)
                                {
                                    theMove.TheMove = String.Concat("N", move);
                                    return theMove;
                                }
                                else
                                {
                                    throw new Exception("Wrong Move for this Piece, Buster Brown");
                                }
                            //break;
                            case Officer.Bishop:
                                break;
                            case Officer.Queen:
                                break;
                            case Officer.King:
                                break;
                            default:
                                break;
                        }
                        throw new Exception();
                    }
                    throw new Exception("You can't move on top of your own pieces...");
                }
                throw new Exception("You cannot move outside the board...");
            }
            throw new Exception("Either there is no piece on this tile or the piece is not your color.");
        }
    }
}
