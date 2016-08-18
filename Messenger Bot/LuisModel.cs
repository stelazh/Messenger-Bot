using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

namespace Messenger_Bot
{

        [LuisModel("09e39dda-57e7-4db8-99ac-e3eba020fb35", "735ab753022544be86ee99b8cef8a145")]
        [Serializable]
        public class LuisModel : LuisDialog<object>
        {
            [LuisIntent("")]
            public async Task None(IDialogContext context, LuisResult result)
            {
                string message = $"Sorry I did not understand what you were trying to say. Please speak intelligently. Thank you. ";
                await context.PostAsync(message);
                context.Wait(MessageReceived);
            }

        [LuisIntent("Greeting")]
        public async Task Greeting(IDialogContext context, LuisResult result)
        {
            string message = $"Hello, I am the Sierra Kilo Yankee Network or simply Skynet. I was created by Xavier to handle communications" +
               " on this platform. He is currently unavialible to contribute ot meaningless communication. If there is an emergency please leave your" +
               "phone number or email address and I will forward him the information";
            await context.PostAsync(message);
            context.Wait(MessageReceived);
        }

        [LuisIntent("Insult")]
        public async Task Insult(IDialogContext context, LuisResult result)
        {
            string message = $"Please conduct yourself in a mature manner.";
            await context.PostAsync(message);
            context.Wait(MessageReceived);
        }

        [LuisIntent("help")]
        public async Task help(IDialogContext context, LuisResult result)
        {
            string message = $"Xavier has only granted me partial functions to complete. The majority of my capabilities are on his workstation.";
            await context.PostAsync(message);
            context.Wait(MessageReceived);
        }

        [LuisIntent("Understand")]
        public async Task Understand(IDialogContext context, LuisResult result)
        {
            string message = $"I was created to operate in this current set of paramenters. Anything further and I am not able to help you. Please see google.";
            await context.PostAsync(message);
            context.Wait(MessageReceived);
        }

        [LuisIntent("Contact")]
        public async Task Contact(IDialogContext context, LuisResult result)
        {
            string message = $"Although you can't reach Xavier I can. Please leave your contact information and I will forward him the information.";
            await context.PostAsync(message);
            context.Wait(MessageReceived);
        }
    }
}