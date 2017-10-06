using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// the character class the player uses in the game
    /// </summary>
    public class Passenger : Character
    {
        #region ENUMERABLES


        #endregion

        #region FIELDS

        private String _hasTraveled;



        #endregion

        #region PROPERTIES
        public String HasTraveled
        {
            get { return _hasTraveled; }
            set { _hasTraveled = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Passenger()
        {

        }

        public Passenger(string name, nationalityType race) : base(name, race)
        {

        }

        #endregion
        
        #region METHODS
        

        #endregion
    }
}
