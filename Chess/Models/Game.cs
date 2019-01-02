using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chess.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public int WhiteID { get; set; }
        public int BlackID { get; set; }
        public DateTime StartTime { get; set; } 
        public Move LastMove { get; set; }
        public string Moves { get; set; }
        public static List<Piece> Pieces = new List<Piece>();
        public List<Move> Log {get; set;}

        //Constructor
        public Game(int whiteID, int blackID)
        {
            GameID = 0; //temp 
            WhiteID = whiteID;
            BlackID = blackID;
            StartTime = DateTime.Now;
            LastMove = Moves;
        }

        public void MakeMove(string move)
        {
            Move theMove = new Move(move, DateTime.Now);
            Move TheMove = Piece.Move(theMove);

            //Render alle brikkerne igennem viewet

            //Nedenstående skal være de sidste linje kode
            Log.Add(TheMove);
            LastMove = TheMove;
        }

        public static List<Piece> Pieces = new List<Piece>();
    }
}