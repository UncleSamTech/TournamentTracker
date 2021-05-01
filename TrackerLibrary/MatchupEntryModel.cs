using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class MatchupEntryModel
    {
        /// <summary>
        /// represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// represents the score for this particular team
        /// </summary>
        public double score { get; set; }
        /// <summary>
        /// represents the matching that this team came from
        /// as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

        /// <summary>
        /// Represents the matchup that this came from
        /// as the winner
        /// </summary>
        /// <param name="iniScore"></param>
        /// 
        public MatchupEntryModel(double iniScore)
        {
            
        }
    }
}
