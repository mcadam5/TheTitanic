using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// base class for the player and all game characters
    /// </summary>
    public class Character
    {
        #region ENUMERABLES

        public enum nationalityType
        {
            None,
            American,
            British,
            Canadian,
            French,
            German,
            Irish,
            Swiss,
            Other

        }

        #endregion

        #region FIELDS

        private string _name;
        private int _age;
        private nationalityType _race;

        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public nationalityType Race
        {
            get { return _race; }
            set { _race = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Character()
        {

        }

        public Character(string name, nationalityType race)
        {
            _name = name;
            _race = race;
        }

        #endregion

        #region METHODS



        #endregion
    }
}
