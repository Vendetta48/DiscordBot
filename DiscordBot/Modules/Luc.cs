using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Discord;


namespace MemeballBot.Modules
{
    public class Luc : ModuleBase<SocketCommandContext>
    {
        Random rand = new Random();
            string[] luc;

        [Command("luc")]
        public async Task LucAsync()
        {
            luc = System.IO.File.ReadAllLines("Memes/luc/luc.txt");
            System.Console.WriteLine("Contents of luc.txt = ");
            foreach (string luc in luc)
            {
                Console.WriteLine(luc);
            };

            int randomLucQuote = rand.Next(luc.Length);
            string lucQuotesToPost = luc[randomLucQuote];
            await ReplyAsync(lucQuotesToPost);

        }
    
    }
}
