﻿using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBot
{
    public class Iwl250
    {
        private string photo = @"https://photos.app.goo.gl/xsZkAZfp2VmwtfqRA";
        public string Photo { get => photo; set => photo = value; }
        public Iwl250() { }
        public InlineKeyboardMarkup inlineKeybord = new InlineKeyboardMarkup(new[]
        {
            new[]{InlineKeyboardButton.WithUrl("վաճառք-Purchase","https://www.youtube.com/watch?v=L9VNSvJkM5w") },
            new[]{InlineKeyboardButton.WithUrl("անվավեր-Void","https://www.youtube.com/watch?v=L9VNSvJkM5w") },
            new[]{InlineKeyboardButton.WithUrl("հետվճար-Refund","https://www.youtube.com/watch?v=L9VNSvJkM5w") },
            new[]{InlineKeyboardButton.WithUrl("հավաստագրում-PrePurchase","https://www.youtube.com/watch?v=L9VNSvJkM5w") },
            new[]{InlineKeyboardButton.WithUrl("հաստատում-Complete(PrePurchase)","https://www.youtube.com/watch?v=L9VNSvJkM5w") },
        });
    }
}
