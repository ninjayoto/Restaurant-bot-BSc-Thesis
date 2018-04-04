﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

namespace Restaurant_bot__BSc_Thesis_.Dialogs
{
    [LuisModel("4bdcdf2d-c797-4355-9003-6ab486c91460", "88c34c414eec43d3ab3f068892db86f1", LuisApiVersion.V2, domain: "westeurope.api.cognitive.microsoft.com")]
    [Serializable]
    public class OrderDialog:LuisDialog<Order>
    {     
        [LuisIntent("")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("I'm sorry. I didn't understand you.");
            context.Wait(MessageReceived);
        }

        [LuisIntent("MakeOrder")]
        public async Task Order(IDialogContext context, LuisResult result)
        {
            //TODO
            await context.PostAsync("Making order...");
            context.Wait(MessageReceived);
        }

        [LuisIntent("OrderMenu")]
        public async Task Menu(IDialogContext context, LuisResult result)
        {
            //TODO
            await context.PostAsync("menu order...");
            context.Wait(MessageReceived);
        }

        [LuisIntent("WorkingHours")]
        public async Task WorkingHours(IDialogContext context, LuisResult result)
        { 
            await context.PostAsync("The restaurant is open from 9:00 to 24:00, every day of the week.");
            await context.PostAsync("But I'm available anytime ;)");
            context.Wait(MessageReceived);
        }

        [LuisIntent("Help")]
        public async Task Help(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("This is restaurant bot for ordering food and drinks! ");
            await context.PostAsync("Type order for starting ordering process");
            context.Wait(MessageReceived);
        }

        [LuisIntent("Hello")]
        public async Task Hello(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("![bot](https://pbs.twimg.com/profile_images/833180315153608704/g_LAHGXB_400x400.jpg)");
            await context.PostAsync("Hi I'm restaurant bot!");
            context.Wait(MessageReceived);
        }
    }
}