using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MemeballBot.Modules
{
    public class SupraPlayers : ModuleBase<SocketCommandContext>
    {
        [Command("sbplayers")]

        public async Task PlayersAsync()
        {
            await ReplyAsync("http://steamcharts.com/app/321400");
        }
    }
}
