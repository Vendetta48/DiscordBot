using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;


namespace MemeballBot.Modules
{
    public class Bear : ModuleBase<SocketCommandContext>
    {
        Random rand = new Random();

        string[] bear;

            [Command("bear")]
            public async Task BearAsync()
        {
            bear = System.IO.File.ReadAllLines("Memes/bear/bear.txt");
            System.Console.WriteLine("Contents of bear.txt = ");
            foreach (string bear in bear)
            {
                Console.WriteLine(bear);
            };

            int randomBearQuote = rand.Next(bear.Length);
            string bearQuotesToPost = bear[randomBearQuote];
            await ReplyAsync(bearQuotesToPost);
                
        }

    }
}
