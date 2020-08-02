using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var Command = new List<Command>
            {
                new Command{Id=0, HowTo="H", Line="A", Platform="I"},
                new Command{Id=1, HowTo="H", Line="C", Platform="D"},
                new Command{Id=2, HowTo="H", Line="V", Platform="E"}
            };
            return Command;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="H", Line="A", Platform="I"};
        }
    }
}