using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelegramCurreent.Abstractions
{
    public interface ICommandService
    {
        public List<TelegramCommand> Get();
    }
}
