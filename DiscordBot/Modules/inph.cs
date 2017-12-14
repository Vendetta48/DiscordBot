using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using Discord;
using System.Threading.Tasks;

namespace MemeballBot.Modules
{
    public class Inph : ModuleBase<SocketCommandContext>
    {
        Random rand = new Random();

        string[] inphQuotes;

            [Command("inph")]
            public async Task InphAsync()
        {
            inphQuotes = System.IO.File.ReadAllLines("Memes/inph/inph.txt");
            System.Console.WriteLine("Contents of inph.txt = ");
            foreach (string inphQuotes in inphQuotes)
            {
                Console.WriteLine(inphQuotes);

            };

            int randomInphQuote = rand.Next(inphQuotes.Length);
            string inphQuotesToPost = inphQuotes[randomInphQuote];

            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle(inphQuotesToPost)
                .WithColor(Color.Blue);

            await ReplyAsync("", false, builder.Build());

        }
    }
}
