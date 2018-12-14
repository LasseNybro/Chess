using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.App_Start
{
    interface IPiece
    {
        //Properties
        Game.Horz X { get; set; }
        int Y { get; set; }
        string Color { get; set; }
        int ID { get; set; }
        int GameID { get; set; }
        int Moves { get; set; }
        bool LastMove { get; set; }

        //Methods
        string Move(string move);
    }
}
