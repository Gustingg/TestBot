using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

namespace TestBot.Dialogs
{
    [Serializable]
    [LuisModel("e295f99b-4260-488b-91bb-c09bd2e641d6", "a57e46d658dc4fb99d94b2123acaed5b")]

    public class TemperaturaDialog : LuisDialog<object>
    {
        [LuisIntent("None")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Desculpe, não entendi, poderia falar novamente?");
        }
        [LuisIntent("Sobre")]
        public async Task Sobre(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Eu sou sua planta! Estou aqui pra ajudar a você cuidar de mim. :D");
        }
        [LuisIntent("Cumprimento")]
        public async Task Cumprimento(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Olá! Caso queira saber algo sobre mim é só perguntar! :)");
        }
        [LuisIntent("TemperaturaAr")]
        public async Task TemperaturaAr(IDialogContext context, LuisResult result)
        {
            var temp = result.Entities?.Select(e => e.Type);
            Random x = new Random();
            int Temp = x.Next(-10, 45);
            if (Temp >= 20 && Temp <= 35)
            {
                await context.PostAsync($"A temperatura do **ar** está muito agradável! \n Temperatura atual: **" + Temp + "**");
            }
            else if (Temp > 35)
            {
                await context.PostAsync($"O **ar** deste lugar está muito quente! \n Temperatura atual: **" + Temp+"**");
            }
            else
            {
                await context.PostAsync($"O **ar** deste lugar está muito frio! \n Temperatura atual: **" + Temp + "**");
            }

        }
        [LuisIntent("UmidadeAr")]
        public async Task UmidadeAr(IDialogContext context, LuisResult result)
        {
            var temp = result.Entities?.Select(e => e.Type);
            Random x = new Random();
            int Temp = x.Next(-10, 45);
            if (Temp >= 20 && Temp <= 35)
            {
                await context.PostAsync($"A **umidade** do Ar está muito agradável! \n Umidade do ar atual: **" + Temp + "**");
            }
            else if (Temp > 35)
            {
                await context.PostAsync($"A **umidade** deste lugar está muito seco! \n Umidade do ar atual: **" + Temp + "**");
            }
            else
            {
                await context.PostAsync($"A **umidade** deste lugar está muito umido! \n Umidade do ar atual: **" + Temp + "**");
            }

        }
        [LuisIntent("UmidadeSolo")]
        public async Task UmidadeSolo(IDialogContext context, LuisResult result)
        {
            var temp = result.Entities?.Select(e => e.Type);
            Random x = new Random();
            int Temp = x.Next(-10, 45);
            if (Temp >= 20 && Temp <= 35)
            {
                await context.PostAsync($"A **umidade** do solo está muito agradável! \n Umidade do solo atual: **" + Temp + "**");
            }
            else if (Temp > 35)
            {
                await context.PostAsync($"Este **solo** está muito seco! \n Umidade do solo atual: **" + Temp + "**");
            }
            else
            {
                await context.PostAsync($"Este **solo** está muito umido! \n Umidade do solo atual: **" + Temp + "**");
            }

        }
    }
}