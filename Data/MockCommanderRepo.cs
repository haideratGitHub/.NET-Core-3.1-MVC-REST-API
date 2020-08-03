using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        private ICommanderRepo _context;

        public MockCommanderRepo(ICommanderRepo context)
        {
            _context = context;
        }

        public void CreatCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

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

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}