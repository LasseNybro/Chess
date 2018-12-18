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
        public enum Officer { Pawn, Rook, Knight, Bishop, Queen, King}

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
        public virtual string Move(string move)
        {
            int X1 = Convert.ToInt32(move[0]) - Convert.ToInt32('A') + 1;
            int Y1 = move[1];
            int X2 = Convert.ToInt32(move[2]) - Convert.ToInt32('A') + 1;
            int Y2 = move[3];
            string theMove = "";
            Piece Attacked =
                (from P in Game.Pieces
                where X2 == P.X && Y2 == P.Y
                select P).firstOrDefault;

            if (!(X2 < 1 || X2 > 8 || Y2 < 1 || Y2 > 8))
            {
                if(Attacked == null || Attacked.Color != this.Color)
                {
                    switch (Type)
                    {
                        case Officer.Pawn:
                            break;
                        case Officer.Rook:
                            break;
                        case Officer.Knight:
                            if ((X2 - X1) + (Y2 - Y1) == 5)
                            {
                                theMove = String.Concat("N", move);
                            }
                            else
                            {
                                throw new Exception();
                            }
                            break;
                        case Officer.Bishop:
                            break;
                        case Officer.Queen:
                            break;
                        case Officer.King:
                            break;
                        default:
                            break;
                    }
                    if (Attacked != null)
                    {
                        Game.Pieces.Remove(Attacked);
                    }
                /*}
                    for (int i = 0; i < Length; i++)
                    {
                        if (X2 == Pieces[i].X && Y2 == Pieces[i].Y)
                        {
                            Remove = Pieces[i].PieceID;
                        }
                    }
                    if (Remove == null)
                    {
                        return String.Concat("N", move);
                    }
                    else if (Remove != null && Pieces[i].Color != Pieces[PieceID = PieceID].Color)
                    {
                        Piece.RemoveMethod(PieceID); //Make a remove method to remove pieces based on their PieceID
                        return String.Concat("N", move);
                    }*/
                    throw new Exception();
                }
                throw new Exception();
            }
            throw new Exception();
        }

        public void Remove(int x, int y)
        {
            
        }
    }
}
