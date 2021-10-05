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
        public override string Name => "\U0001F4DAУзнать сегодняшние пары";

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
                        parseMode: ParseMode.Html,
                        replyMarkup: KeyBoard.GetButtons());
                    break;

                case DayOfWeek.Tuesday:
                    await telegramBotClient.SendTextMessageAsync(
                        chatId: chatId,
                        text: "1.МДК 04.02\n2.Базы данных\n3.Програмные модули",
                        parseMode: ParseMode.Html,
                        replyMarkup: KeyBoard.GetButtons());
                    break;

                case DayOfWeek.Wednesday:
                    await telegramBotClient.SendTextMessageAsync(
                        chatId: chatId,
                        text: "2.Моб.приложения\n3.МДК 04.02\n4.Ин.яз",
                        parseMode: ParseMode.Html,
                        replyMarkup: KeyBoard.GetButtons());
                    break;

                case DayOfWeek.Thursday:
                    await telegramBotClient.SendTextMessageAsync(
                        chatId: chatId,
                        text: "1.Философия\n2.Базы данных\n3.БЖ\n4.Физ.культура",
                        parseMode: ParseMode.Html,
                        replyMarkup: KeyBoard.GetButtons());
                    break;

                case DayOfWeek.Friday:
                    await telegramBotClient.SendTextMessageAsync(
                        chatId: chatId,
                        text: "1.Нет пары\n2.Базы данных\n3.Моб.приложения\n4.Философия",
                        parseMode: ParseMode.Html,
                        replyMarkup: KeyBoard.GetButtons());
                    break;

                case DayOfWeek.Saturday:
                    await telegramBotClient.SendTextMessageAsync(
                        chatId: chatId,
                        text: "Ты что больной ? Иди спать",
                        parseMode: ParseMode.Html,
                        replyMarkup: KeyBoard.GetButtons());
                    break;
                    await telegramBotClient.SendStickerAsync(
                        chatId: chatId,
                        sticker: "https://tlgrm.ru/_/stickers/cbe/e09/cbee092b-2911-4290-b015-f8eb4f6c7ec4/192/24.webp"
                        replyMarkup: KeyBoard.GetButtons());

                case DayOfWeek.Sunday:
                    await telegramBotClient.SendTextMessageAsync(
                        chatId: chatId,
                        text: "1.Нет пары\n2.Базы данных\n3.Моб.приложения\n4.Философия",
                        parseMode: ParseMode.Html,
                        replyMarkup: KeyBoard.GetButtons());
                    await telegramBotClient.SendStickerAsync(
                        chatId: chatId,
                        sticker: "https://tlgrm.ru/_/stickers/cbe/e09/cbee092b-2911-4290-b015-f8eb4f6c7ec4/192/24.webp"
                        replyMarkup: KeyBoard.GetButtons());
                    break;
            }
        }
    }
}
