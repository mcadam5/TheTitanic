using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// static class to hold key/value pairs for menu options
    /// </summary>
    public static class ActionMenu
    {
        public static Menu MissionIntro = new Menu()
        {
            MenuName = "MissionIntro",
            MenuTitle = "",
            MenuChoices = new Dictionary<char, PassengerAction>()
                    {
                        { ' ', PassengerAction.None }
                    }
        };

        public static Menu InitializeMission = new Menu()
        {
            MenuName = "InitializeMission",
            MenuTitle = "Initialize Mission",
            MenuChoices = new Dictionary<char, PassengerAction>()
                {
                    { '1', PassengerAction.Exit }
                }
        };

        public static Menu MainMenu = new Menu()
        {
            MenuName = "MainMenu",
            MenuTitle = "Main Menu",
            MenuChoices = new Dictionary<char, PassengerAction>()
                {
                    { '1', PassengerAction.PassengerInfo },
                    { '2', PassengerAction.Exit }
                }
        };

        //public static Menu ManagePassenger = new Menu()
        //{
        //    MenuName = "Manage Passenger",
        //    MenuTitle = "Manage Passenger",
        //    MenuChoices = new Dictionary<char, PlayerAction>()
        //            {
        //                PlayerAction.MissionSetup,
        //                PlayerAction.PassengerInfo,
        //                PlayerAction.Exit
        //            }
        //};
    }
}
