using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramCurreent.Command
{
    public class KeyBoard
    {
        public static ReplyKeyboardMarkup GetButtons()
        {
            var replyKeyboardMarkup = new ReplyKeyboardMarkup
            {
                Keyboard = new[]
                {
                    new KeyboardButton[]{"\U0001F4DAУзнать сегодняшние пары", "\U0001F4C5Узнать расписание на неделю" }
                },
                ResizeKeyboard = true
            };

            return replyKeyboardMarkup;
        }

        public static InlineKeyboardMarkup GetInlineKeyboard()
        {
            var inlineKeyboard = new InlineKeyboardMarkup(
                new[]
                {
                    InlineKeyboardButton.WithUrl(text: "Посмотреть репозиторий бота", url: "https://github.com/Hazeltanget/TelegramBotForCollegeASP.NET")
                });

            return inlineKeyboard;
        }
    }
}
