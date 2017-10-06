using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// class to store static and to generate dynamic text for the message and input boxes
    /// </summary>
    public static class Text
    {
        public static List<string> HeaderText = new List<string>() { "All Aboard the Titanic" };
        public static List<string> FooterText = new List<string>() { "Laughing Leaf Productions, 2017" };

        #region INTITIAL GAME SETUP

        public static string MissionIntro()
        {
            string messageBoxText =
            "You have just awoken from a deep sleep aboard the Titanic, as a average passenger. " +
            "With all the knowledge of the Titanic's soon to be sunken future! " +
            "Your mission is to complete all the challenges, to gain access to the captins office, and relay " +
            " the message. Before it's too Late.\n" +
            " \n" +
            "Press the Esc key to exit the game at any point.\n" +
            " \n" +
            "Your mission begins now.\n" +
            " \n" +
            "\tYour first task will be to set up the initial parameters of your mission.\n" +
            " \n" +
            "\tPress any key to begin the Mission Initialization Process.\n";

            return messageBoxText;
        }

        public static string CurrrentLocationInfo()
        {
            string messageBoxText =
            "You are currently in a small passenger room located in the third class passenger housing. " +
            "The Titanic has already begun it's journey to New York, NY and you are completely surrounded by the Atlantic Ocean. " +
            "Since you are only a third class member you currently only have access to the main deck. " +
             " \n" +
            " \n" +
            "\tChoose from the menu options to proceed.\n";

            return messageBoxText;
        }

        #region Initialize Mission Text

        public static string InitializeMissionIntro()
        {
            string messageBoxText =
                "Before you begin your mission we much gather your base data.\n" +
                " \n" +
                "You will be prompted for the required information. Please enter the information below.\n" +
                " \n" +
                "\tPress any key to begin.";

            return messageBoxText;
        }

        public static string InitializeMissionGetPassengerName()
        {
            string messageBoxText =
                "Enter your name Passenger" +
                ".\n" +
                " \n" +
                "Please use the name you wish to be referred during your mission.";

            return messageBoxText;
        }

        public static string InitializeMissionGetPassengerAge(Passenger gamePassenger)
        {
            string messageBoxText =
                $"Very good then, we will call you {gamePassenger.Name} on this mission.\n" +
                " \n" +
                "Enter your age below.\n" +
                " \n" +
                "Please use the age you were at before awaking on the Titanic.";

            return messageBoxText;
        }

        public static string InitializeMissionGetPassengerRace(Passenger gamePassenger)
        {
            string messageBoxText =
                $"{gamePassenger.Name}, it will be important for us to know your nationality on this mission.\n" +
                " \n" +
                "Enter your nationality below.\n" +
                " \n" +
                "Please use the nationality classifications below." +
                " \n";

            string nationalityList = null;

            foreach (Character.nationalityType nationality in Enum.GetValues(typeof(Character.nationalityType)))
            {
                if (nationality != Character.nationalityType.None)
                {
                    nationalityList += $"\t{nationality}\n";
                }
            }

            messageBoxText += nationalityList;

            return messageBoxText;
        }

        public static string InitializeMissionGetPassengerExperience(Passenger gamePassenger)
        {
            string messageBoxText =
                $"{gamePassenger.Name} experience on this mission could be cruital.\n" +
                " \n" +
                "Enter your age below.\n" +
                " \n" +
                "Please use the age you were at before awaking on the Titanic.";

            return messageBoxText;
        }

        public static string InitializeMissionEchoPassengerInfo(Passenger gamePassenger)
        {
            string messageBoxText =
                $"Very good then {gamePassenger.Name}.\n" +
                " \n" +
                "It appears we have all the necessary data to begin your mission. You will find it" +
                " listed below.\n" +
                " \n" +
                $"\tPassenger Name: {gamePassenger.Name}\n" +
                $"\tPassenger Age: {gamePassenger.Age}\n" +
                $"\tPassenger Race: {gamePassenger.Race}\n" +
                " \n" +
                "Press any key to begin your mission.";

            return messageBoxText;
        }

        #endregion

        #endregion

        #region MAIN MENU ACTION SCREENS

        public static string PassengerInfo(Passenger gamePassenger)
        {
            string messageBoxText =
                $"\tPassenger Name: {gamePassenger.Name}\n" +
                $"\tPassenger Age: {gamePassenger.Age}\n" +
                $"\tPassenger Race: {gamePassenger.Race}\n" +
                " \n";

            return messageBoxText;
        }

        //public static string Travel(int currentSpaceTimeLocationId, List<SpaceTimeLocation> spaceTimeLocations)
        //{
        //    string messageBoxText =
        //        $"{gamePassenger.Name}, Aion Base will need to know the name of the new location.\n" +
        //        " \n" +
        //        "Enter the ID number of your desired location from the table below.\n" +
        //        " \n";


        //    string spaceTimeLocationList = null;

        //    foreach (SpaceTimeLocation spaceTimeLocation in spaceTimeLocations)
        //    {
        //        if (nationality != Character.nationalityType.None)
        //        {
        //            nationalityList += $"\t{nationality}\n";
        //        }
        //    }

        //    messageBoxText += nationalityList;

        //    return messageBoxText;
        //}

        #endregion
    }
}
