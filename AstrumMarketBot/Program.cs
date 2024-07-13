using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

internal class Program
{
    private static async Task Main(string[] args)
    {
        using var cts = new CancellationTokenSource();
        var bot = new TelegramBotClient("7417598765:AAEBGNq-n5eunmSbz_lMPQtO2DPgek7a9FE");
        bot.StartReceiving(OnUpdate, async (bot, ex, ct) => Console.WriteLine(ex));

        var me = await bot.GetMeAsync();
        Console.WriteLine($"@{me.Username} is running... Press Enter to terminate");
        Console.ReadLine();
        cts.Cancel(); // stop the bot

        // method that handle updates coming for the bot:
        async Task OnUpdate(ITelegramBotClient bot, Update update, CancellationToken ct)
        {
            var message = update.Type switch
            {
                UpdateType.Message => await OnMessage(update.Message),
                UpdateType.EditedMessage => await OnEditMessage(update.EditedMessage),
                UpdateType.CallbackQuery => await OnCallbackQuery(update.CallbackQuery),
                _ => await OnUnknownUpdateType(update)
            };
        }

        async Task<Message> OnCallbackQuery(CallbackQuery? callbackQuery)
        {
            return await bot.SendTextMessageAsync(callbackQuery.Message.Chat, "Buyurtma qabul qilindi", replyToMessageId: callbackQuery.Message.MessageId);
        }

        async Task<Message> OnUnknownUpdateType(Update update)
        {
            Console.WriteLine($"Unknown update type: {update.Type}");
            return null;
        }

        async Task<Message> OnEditMessage(Message? editedMessage)
        {
            return null;
        }

        async Task<Message> OnMessage(Message? message)
        {
            // we want only updates about new Text Message
            var msg = message;
            Console.WriteLine($"Received message '{msg.Text}' in {msg.Chat}");

            Message? response = null;

            string text = null;


            ReplyKeyboardMarkup replyKeyboardMarkup = new ReplyKeyboardMarkup(new[]
            {
            new KeyboardButton[]
            {
                new KeyboardButton("Buyurtma berish"),
                new KeyboardButton("Buyurtma berish"),
            },
             new KeyboardButton[]
            {
                new KeyboardButton("Buyurtma berish")
            },
        });

            InlineKeyboardMarkup replyKeyboardMarkup = new InlineKeyboardMarkup(new[]
            {
        new[]
        {
            InlineKeyboardButton.WithCallbackData("Buyurtma berish", "buyurtma"),
            InlineKeyboardButton.WithCallbackData("Buyurtma berish", "buyurtma"),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData("Buyurtma berish", "buyurtma")
        },
    });

            text = msg.Text switch
            {
                "/start" => "Salomat",
                "/help" => "Yordam",
                "/stop" => "Stop",
                _ => "Noma'lum buyruq"
            };

            response = await bot.SendContactAsync(msg.Chat, "+998912040618", "Sardor", lastName: "Sohinazarov", replyToMessageId: msg.MessageId,);


            response = await bot.SendTextMessageAsync(msg.Chat, text, replyMarkup: replyKeyboardMarkup);

            return response;
        }
    }
}