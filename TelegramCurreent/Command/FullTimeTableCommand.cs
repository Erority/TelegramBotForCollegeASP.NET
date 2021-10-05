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
    public class FullTimeTableCommand : TelegramCommand
    {
        public override string Name => "\U0001F4C5Узнать расписание на неделю";

        public override bool Contains(Message message)
        {
            if (message.Type != MessageType.Text)
                return false;

            return message.Text.Contains(Name);
        }

        public override async Task Execute(Message message, ITelegramBotClient telegramBotClient)
        {
            var chatId = message.Chat.Id;

            await telegramBotClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Понедельник:<pre>\n    1.МДК 04.02\n    2.Базы данных\n    3.БЖ\n    4.Програмные модули </pre>\n" +
                      "Вторник:<pre>\n    1.МДК 04.02\n    2.Базы данных\n    3.Програмные модули\n    4.Нет пары</pre>\n" +
                      "Среда:<pre>\n    1.Нет пары\n    2.Моб.приложения\n    3.МДК 04.02\n    4.Ин.яз</pre>\n" +
                      "Четверг:<pre>\n    1.Философия\n    2.Базы данных\n    3.БЖ\n    4.Физ.культура</pre>\n" +
                      "Пятница:<pre>\n    1.Нет пары\n    2.Базы данных\n    3.Моб.приложения\n    4.Философия</pre>\n",
                parseMode: ParseMode.Html,
                replyMarkup: KeyBoard.GetButtons());
        }
    }
}
