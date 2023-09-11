namespace HealthCare_Plus.Utils
{
    internal class RoomUtils
    {
        public static int GetSelectedRoomID(string selectedRoomValue)
        {
            switch (selectedRoomValue)
            {
                case "Room 1":
                    return 1;
                case "Room 2":
                    return 2;
                case "Room 3":
                    return 3;
                case "Room 4":
                    return 4;
                case "Room 5":
                    return 5;
                case "Room 6":
                    return 6;
                case "Room 7":
                    return 7;
                case "Room 8":
                    return 8;
                case "Room 9":
                    return 9;
                case "Room 10":
                    return 10;
                default:
                    return 0;
            }
        }

        public static string GetSelectedRoomText(int selectedRoomID)
        {
            switch (selectedRoomID)
            {
                case 1:
                    return "Room 1";
                case 2:
                    return "Room 2";
                case 3:
                    return "Room 3";
                case 4:
                    return "Room 4";
                case 5:
                    return "Room 5";
                case 6:
                    return "Room 6";
                case 7:
                    return "Room 7";
                case 8:
                    return "Room 8";
                case 9:
                    return "Room 9";
                case 10:
                    return "Room 10";
                default:
                    return "Room 1";
            }
        }
    }
}
