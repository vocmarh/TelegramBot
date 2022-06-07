using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot
{
    class Bot
    {
        /// <summary>
        /// объект, отвеающий за отправку сообщений клиенту
        /// </summary>
        private TelegramBotClient _telegramClient;

        public Bot(TelegramBotClient telegramClient)
        {
            _telegramClient = telegramClient;
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            _telegramClient.OnMessage += HandleMessage;
            _telegramClient.OnMessage += HandleButtonClick;

            Console.WriteLine("Bot started");
        }

        /// <summary>
        /// Обработчик входящих текстовых сообщений  
        /// </summary>
        private async Task HandleMessage(object sender, MessageEventArgs e)
        {
        }

        /// <summary>
        /// Обработчик нажатий на кнопки
        /// </summary>
        private async Task HandleButtonClick(object sender, MessageEventArgs e)
        {
        }
    }
}
