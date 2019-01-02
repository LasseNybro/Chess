using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chess.Models
{
    public class Move
    {
        public string TheMove { get; set; }
        public DateTime TimeStamp { get; set; }

        public Move(string move, DateTime timeStamp)
        {
            TheMove = move; TimeStamp = timeStamp;
        }

        /*
        if(true)//Korrekt format på text inputtet, LINQ er den nemmeste måde at gøre dette på
            if(true)//Der er en brik i start feltet
            //Find brik ID uf fra positionen
            if(true)//Brikken har den korrekte farve
            //Kald brikken med brik ID og find classen ud fra denne
            //Kald <T>.Move(move), hvor move er en streng i formatet "XYXY"*/
    }
    
}