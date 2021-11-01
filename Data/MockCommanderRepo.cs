using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Run Startup", Line = "Work Hard", Platform = "Dotnet" },
                new Command { Id = 1, HowTo = "Work in Startup", Line = "Work Smart", Platform = "Any" },
                new Command { Id = 2, HowTo = "Build It ", Line = "Good Team", Platform = "Friends" }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Run Startup", Line = "Work Hard", Platform = "Dotnet" };
        }
    }
}
