using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;

namespace TelegramCurreent
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTelegramBotClient(this IServiceCollection serviceCollection,
            IConfiguration configuration)
        {
            var client = new TelegramBotClient(configuration["Token"]);
            var webhook = $"{configuration["Url"]}/api/bot";
            client.SetWebhookAsync(webhook).Wait();

            return serviceCollection.AddTransient<ITelegramBotClient>(x => client);
        }
    }
}
