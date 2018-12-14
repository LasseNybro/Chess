using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chess.App_Start
{
    public class Knight : IPiece
    {
        public Game.Horz X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }
        public int ID { get; set; }
        public int GameID { get; set; }
        public int Moves { get; set; }
        public bool LastMove { get; set; }

        public string Move(string move)
        {
            char startX = move[0];
            char startY = move[1];
            char endX = move[2];
            char endY = move[3];

            if (startX == this.X && startY == this.Y)//Choosing the tile of the Piece
            {
                return string.Concat("K", move);
            }
            else { throw new Exception("You have not chosen this piece"); }
        }
    }
}