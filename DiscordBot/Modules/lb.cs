using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Discord;

namespace MemeballBot.Memes
{
    public class Lb : ModuleBase<SocketCommandContext>
    {
       Random rand = new Random();

        string[] lbquotes;

        [Command("lb")] 
        public async Task LBAsync()
        {        
            lbquotes = System.IO.File.ReadAllLines("Memes/lb/lb.array.txt");
            System.Console.WriteLine("Contents of lb.array.txt = ");
            foreach (string lbquotes in lbquotes)
            {
                Console.WriteLine(lbquotes);
            };
            int randomLBQuote = rand.Next(lbquotes.Length);
            string lbQuotesToPost = lbquotes[randomLBQuote];

            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle(lbQuotesToPost)
                .WithColor(Color.Blue);

            await ReplyAsync("", false, builder.Build());
        }
         

        

    }  
    
}
