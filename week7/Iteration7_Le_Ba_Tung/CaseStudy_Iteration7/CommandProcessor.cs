using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Iteration5
{
    public class CommandProcessor
    {
        private List<Command> ocmd;
        public CommandProcessor()
        {
            ocmd = new List<Command>();
            ocmd.Add(new MoveCommand());
            ocmd.Add(new LookCommand());
        }
        public string Execute(string cmd, Player player)
        {

            string[] array = cmd.Split(' ');

            if (cmd.Length == 0)
            {
                return "I can see this command ";
            }

            if (array[0] == "out")
            {
                return "bai bai. See you again";
            }
            Command matchedCommand = null;

            foreach (Command command in ocmd)
            {
                if (command.AreYou(array[0].ToLower()))
                {
                    matchedCommand = command;
                    break;
                }
            }

            if (matchedCommand == null)
            {
                return "I dont know what do you want. Please enter another command";
            }

            return matchedCommand.Execute(player, array);
        }
    }

}