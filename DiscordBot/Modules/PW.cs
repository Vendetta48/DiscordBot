using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace MemeballBot.Modules
{
    public class PW : ModuleBase<SocketCommandContext>
    {
        [Command("pw")]
        public async Task PWAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle("pug948")
               .WithColor(Color.Blue);
            await ReplyAsync("", false, builder.Build());
        }
    }
}
