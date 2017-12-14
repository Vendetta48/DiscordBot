using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Discord;
namespace MemeballBot.Modules
{
    public class Juan : ModuleBase<SocketCommandContext>
    {
        Random rand = new Random();

        string[] juanQuotes;

            [Command("juan")]
            public async Task JuanAsync()
        {
            juanQuotes = System.IO.File.ReadAllLines("Memes/juan/juan.txt");
            System.Console.WriteLine("Contents of juan.txt = ");
            foreach (string juanQuotes in juanQuotes)
            {
                Console.WriteLine(juanQuotes);
            };

            int randomJuanQuote = rand.Next(juanQuotes.Length);
            string juanQuotesToPost = juanQuotes[randomJuanQuote];

            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle(juanQuotesToPost)
                .WithColor(Color.Blue);

            await ReplyAsync("", false, builder.Build());
        }
    }
    
}
