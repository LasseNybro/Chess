using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chess.Models
{
    public class Game
    {
        public enum Horz { A,B,C,D,E,F,G,H};
        public List<Piece> Pieces = new List<Piece>();
    }
}