using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Discord;
namespace MemeballBot.Modules
{
    public class Shado : ModuleBase<SocketCommandContext>
    {
        Random rand = new Random();

        string[] shadoQuotes;

        [Command("shado")]
        public async Task ShadoAsync()
        {
            shadoQuotes = System.IO.File.ReadAllLines("Memes/shado/shado.txt");
            System.Console.WriteLine("Contents of shado.txt = ");
            foreach (string shadoQuotes in shadoQuotes)
            {
                Console.WriteLine(shadoQuotes);
            };

            int randomShadoQuote = rand.Next(shadoQuotes.Length);
            string shadoQuotesToPost = shadoQuotes[randomShadoQuote];

            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle(shadoQuotesToPost)
                .WithColor(Color.Blue);

            await ReplyAsync("", false, builder.Build());


        }
    }
}
