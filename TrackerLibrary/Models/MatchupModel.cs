﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        public int Id { get; set; }
        public List<MatchupEntryModel> Entries { get; set; }
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }

        public MatchupModel()
        {
            Entries = new List<MatchupEntryModel>();
        }
    }
}
