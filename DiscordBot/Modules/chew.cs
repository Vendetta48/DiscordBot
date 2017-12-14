using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Discord;

namespace MemeballBot.Modules
{
  public  class Chew : ModuleBase<SocketCommandContext>
    {
        Random rand = new Random();

        string[] chewQuotes;

        [Command("chew")]
        public async Task ChewAsync()
        {
            chewQuotes = System.IO.File.ReadAllLines("Memes/chew/chew.txt");
            System.Console.WriteLine("Contents of chew.txt = ");
            foreach (string chewQuotes in chewQuotes)
            {
                Console.WriteLine(chewQuotes);
            };

            int randomChewQuote = rand.Next(chewQuotes.Length);
            string chewQuotesToPost = chewQuotes[randomChewQuote];
            await ReplyAsync(chewQuotesToPost);      
       
        }
    }
}
