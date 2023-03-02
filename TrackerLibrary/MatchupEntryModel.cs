using System;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {/// <summary>
    /// Represents one team in the matchup
    /// </summary>
        public TeamModel TeamCometing { get; set; }
        /// <summary>
        /// Repesents the score for this particuar team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup that this team came 
        /// from as thewinner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

   
    }
}