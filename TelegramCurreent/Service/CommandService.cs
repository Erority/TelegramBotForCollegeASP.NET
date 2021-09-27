using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelegramCurreent.Abstractions;
using TelegramCurreent.Command;

namespace TelegramCurreent.Service
{
    public class CommandService : ICommandService
    {
        private readonly List<TelegramCommand> _commands;

        public CommandService()
        {
            _commands = new List<TelegramCommand>
            {
                new StartCommand(),
                new TimetableCommand()
            };
        }

        public List<TelegramCommand> Get() => _commands;
    }
}
