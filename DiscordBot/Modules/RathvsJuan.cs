using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Discord;

namespace MemeballBot.Modules
{
    public class RathvsJuan : ModuleBase<SocketCommandContext>
    {
        Random rand = new Random();

        string[] rathvsJuan;

        [Command("rathvsjuan")]
        public async Task RathVsJuanAsync()
        {
            rathvsJuan = System.IO.File.ReadAllLines("Memes/rathvsjuan/rathvsjuan.txt");
            System.Console.WriteLine("Contents of rathvsjuan.txt = ");
            foreach (string rathvsJuan in rathvsJuan)
            {
                Console.WriteLine(rathvsJuan);
            };

            int randomRathVsJuanGif = rand.Next(rathvsJuan.Length);
            string rathVsJuanGifsToPost = rathvsJuan[randomRathVsJuanGif];
            await ReplyAsync(rathVsJuanGifsToPost);

        }
    }
}
