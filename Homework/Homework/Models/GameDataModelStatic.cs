namespace Homework.Models
{
    public class GameDataModelStatic
    {
        public static PlayerDataModel NameUserFirst { get; set; }

		public static PlayerDataModel NameUserSecond { get; set; }
		public static string[] Fields { set; get; }

        public static bool isX { get; set; } = true;

		public static void FillTheField()
        {
            Random rnd = new Random();
            Fields = new string[9];
            for (int i = 0; i < 9; i++)
            {
                int value = rnd.Next(0, 3);
                Fields[i] = value == 0 ? "" : value == 1 ? "X" : "O";
            }
        }

        public static void Hod(int id)
        {
            Fields[id] = isX ?"X":"0";
            isX = !isX;
		}
    }
}
