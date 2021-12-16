namespace Dojo.Games.Clifford
{
    public class CliffordDirection : Direction
    {
        public static string CRACK_LEFT = "ACT,LEFT";
        public static string CRACK_RIGHT = "ACT,RIGHT";
        public static string DIE = "ACT(0)";
        public static string SHOOT_LEFT = "ACT(1),LEFT";
        public static string SHOOT_RIGHT = "ACT(1),RIGHT";
        public static string OPEN_DOOR_LEFT = "ACT(2),LEFT";
        public static string OPEN_DOOR_RIGHT = "ACT(2),RIGHT";
        public static string CLOSE_DOOR_LEFT = "ACT(3),LEFT";
        public static string CLOSE_DOOR_RIGHT = "ACT(3),RIGHT";
    }
}