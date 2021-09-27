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
    public class StartCommand : TelegramCommand
    {
        public override string Name => @"/start";

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
                text: "Привет ! Я телеграм бот разработанныый Денисом." +
                " Ты можешь узнать расписание пар на сегодня, либо на всю неделю",
                parseMode: ParseMode.Html);
        }
    }
}
