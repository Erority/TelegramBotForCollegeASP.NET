using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TelegramCurreent.Abstractions;

namespace TelegramCurreent.Command
{
    public class TimetableCommand : TelegramCommand
    {
        public override string Name => "Узнать сегодняшнее расписание";

        public override bool Contains(Message message)
        {
            if (message.Type != MessageType.Text)
                return false;

            return message.Text.Contains(Name);
        }

        public override async Task Execute(Message message, ITelegramBotClient telegramBotClient)
        {
            var chatId = message.Chat.Id;

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    await telegramBotClient.SendTextMessageAsync(
                        chatId: chatId,
                        text: "1.МДК 04.02\n2.Базы данных\n3.БЖ\n4.Програмные модули",
                        parseMode: ParseMode.Html);
                    break;

                case DayOfWeek.Tuesday:
                    await telegramBotClient.SendTextMessageAsync(
                        chatId: chatId,
                        text: "1.МДК 04.02\n2.Базы данных\n4.Програмные модули",
                        parseMode: ParseMode.Html);
                    break;
            }
        }
    }
}
