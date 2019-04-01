using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webServiceStrategy.Entitites;

namespace webServiceStrategy
{
    public class ScoreCards
    {
        public List<ScoreCard> card { get; set; }

        public ScoreCards()
        {
            card = new List<ScoreCard>();
        }
    }
}