using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Discord;

namespace MemeballBot.Modules
{
    public class DavidM : ModuleBase<SocketCommandContext>
    {
        Random rand = new Random();

        string[] davidQuotes;

        [Command("david")]
        public async Task DavidAsync()
        {
            davidQuotes = System.IO.File.ReadAllLines("Memes/davidQuotes/davidQuotes.txt");
            System.Console.WriteLine("Contents of davidQuotes.txt = ");
            foreach (string davidQuotes in davidQuotes)
            {
                Console.WriteLine(davidQuotes);
            };
            int randomDavidQuote = rand.Next(davidQuotes.Length);
            string davidQuotesToPost = davidQuotes[randomDavidQuote];

            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle(davidQuotesToPost)
                .WithColor(Color.Blue);

            await ReplyAsync("", false, builder.Build());
        }




    }

}

