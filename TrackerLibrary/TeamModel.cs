using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class TeamModel
    {
        public List<PersonsModel> TeamMembers{
            get; set;
        } = new List<PersonsModel>();

        public string TeamName {
            get;set;
        }
    }
}
