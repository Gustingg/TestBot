using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System.Collections.Generic;

namespace TestBot.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;

            var message = activity.CreateReply();

            var heroCard = new HeroCard();
            heroCard.Title = "Bem vindo!";
            heroCard.Text = "Sou eu, seu Pé de Feijão. Gostaria de saber a temperatura do ar? Digite !temp caso queira saber a umidade do ar? Digite !humiar ou então está interessado saber a umidade do solo, então digite !humisol";
            heroCard.Images = new List<CardImage>
            {
                new CardImage("https://images2.storyjumper.com/transcoder.png?trim&id=2n-jhpiaty51l-57l6u8w5d&maxw=512&maxh=512","Flor")
            };

            message.Attachments.Add(heroCard.ToAttachment());

            await context.PostAsync(message);

            // calculate something for us to return
            int length = (activity.Text ?? string.Empty).Length;

            // return our reply to the user
            await context.PostAsync($"You sent {activity.Text} which was {length} characters");

            Random x = new Random();
            int Temp = x.Next(-10, 40);
            if (Temp <= 20 && Temp >= 10)
            {
                await context.PostAsync($"A temperatura está muito agradável! \n Temperatura atual: "+Temp);
            }

            context.Wait(MessageReceivedAsync);
        }
    }
}