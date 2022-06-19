using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>{
                new Command { Id = 0, Howto = "Boil an egg", Line = "Boil water", Platform = "Kettle and pan" },
                new Command { Id = 1, Howto = "Cut bread", Line = "Get a knife", Platform = "Knife and chopping board" },
                new Command { Id = 2, Howto = "Make cup of tea", Line = "Place teabag in cup", Platform = "Kettle and cup" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, Howto = "Boil an egg", Line = "Boil water", Platform = "Kettle and pan" };
        }
    }
}