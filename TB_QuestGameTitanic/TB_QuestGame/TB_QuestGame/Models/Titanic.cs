using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame.Assets
{
    /// <summary>
    /// class of the game map
    /// </summary>
    public class Titanic
    {
        #region ***** define all lists to be maintained by the Universe object *****

        //
        // list of all space-time locations
        //
        private List<RoomLocation> _roomLocations;

        public List<RoomLocation> RoomLocations
        {
            get { return _roomLocations; }
            set { _roomLocations = value; }
        }

        #endregion

        #region ***** constructor *****

        //
        // default Universe constructor
        //
        public Titanic()
        {
            //
            // add all of the universe objects to the game
            // 
            IntializeTitanic();
        }

        #endregion

        #region ***** define methods to initialize all game elements *****

        /// <summary>
        /// initialize the universe with all of the space-time locations
        /// </summary>
        private void IntializeTitanic()
        {
            _roomLocations = TitanicObjects.RoomLocations;
        }

        #endregion

        #region ***** define methods to return game element objects and information *****

        public bool IsValidRoomLocationId(int roomLocationId)
        {
            List<int> roomLocationIds = new List<int>();

            //
            // create a list of space-time location ids
            //
            foreach (RoomLocation rl in _roomLocations)
            {
                roomLocationIds.Add(rl.RoomLocationID);
            }

            //
            // determine if the space-time location id is a valid id and return the result
            //
            if (roomLocationIds.Contains(roomLocationId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// determine if a location is accessible to the player
        /// </summary>
        /// <param name="roomLocationId"></param>
        /// <returns>accessible</returns>
        public bool IsAccessibleLocation(int roomLocationId)
        {
            RoomLocation roomLocation = GetRoomLocationByID(roomLocationId);
            if (roomLocation.Accessable == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// return the next available ID for a SpaceTimeLocation object
        /// </summary>
        /// <returns>next SpaceTimeLocationObjectID </returns>
        public int GetMaxRoomLocationId()
        {
            int MaxId = 0;

            foreach (RoomLocation roomLocation in RoomLocations)
            {
                if (roomLocation.RoomLocationID > MaxId)
                {
                    MaxId = roomLocation.RoomLocationID;
                }
            }

            return MaxId;
        }

        /// <summary>
        /// get a SpaceTimeLocation object using an ID
        /// </summary>
        /// <param name="ID">space-time location ID</param>
        /// <returns>requested space-time location</returns>
        public RoomLocation GetRoomLocationByID(int ID)
        {
            RoomLocation roomLocation = null;

            //
            // run through the space-time location list and grab the correct one
            //
            foreach (RoomLocation location in _roomLocations)
            {
                if (location.RoomLocationID == ID)
                {
                    roomLocation = location;
                }
            }

            //
            // the specified ID was not found in the universe
            // throw and exception
            //
            if (roomLocation == null)
            {
                string feedbackMessage = $"The Room Location ID {ID} does not exist aboard the Titanic.";
                throw new ArgumentException(ID.ToString(), feedbackMessage);
            }

            return roomLocation;
        }
        public bool IsAccessableLocation(int roomLocationId)
        {
            RoomLocation roomLocation = GetRoomLocationByID(roomLocationId);
            if (roomLocation.Accessable == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetRoomLocationId()
        {
            int MaxId = 0;

            foreach (RoomLocation roomLocation in RoomLocations)
            {
                if (roomLocation.RoomLocationID > MaxId)
                {
                    MaxId = roomLocation.RoomLocationID;
                }
            }

            return MaxId;
        }

        #endregion
    }
}
