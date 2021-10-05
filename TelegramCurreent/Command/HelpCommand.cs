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
    public class HelpCommand : TelegramCommand
    {
        public override string Name => @"/help";

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
                text: "Ты можешь посмотреть репозиторий проекта, а также узнать пары не сегодня, либо на неделю",
                parseMode: ParseMode.Html,
                replyMarkup: KeyBoard.GetInlineKeyboard());
        }
    }
}
