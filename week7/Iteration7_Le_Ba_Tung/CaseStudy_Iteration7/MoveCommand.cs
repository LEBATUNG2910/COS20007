using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Iteration5
{
    public class MoveCommand : Command
    {
        public MoveCommand() : base(new string[] { "move" })
        {

        }
        public override string Execute(Player player, string[] text)
        {
            string error = "Cannot know location you want to go ";
            string move = "";
            if (text[0] == "out")
            {
                return "Bai bai see you again ";
            }
            if (text.Length == 1)
            {
                return "What do you want to go";
            }
            else if (text.Length == 2)
            {
                move = text[1].ToLower();
            }
            else if (text.Length == 3)
            {
                move = text[2].ToLower();
            }
            else
            {
                return error;
            }

            GameObject pathObject = player.Location.Locate(move);

            if (pathObject == null)
            {
                return error;
            }
            else if (!(pathObject is Path path))
            {
                return "Cannot find " + pathObject.Name + ".";
            }
            else
            {
                string startLocationName = player.Location.Name;
                string pathName = path.Name;
                string endLocationName = path.FirstId;

                player.Move_Player(path);

                string result = "If you want to go to " + endLocationName + " going to " + pathName + " and reached the " + startLocationName + "\n\n" + player.Location.FullDescription;

                return result;
            }
        }

    }
}
