using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Discord;

namespace MemeballBot.Modules
{
    public class Sane : ModuleBase<SocketCommandContext>
    {
        Random rand = new Random();

        string[] sane;

        [Command("sane")]
        public async Task SaneAsync()
        {
            sane = System.IO.File.ReadAllLines("Memes/sane/sane.txt");
            System.Console.WriteLine("Contents of sane.txt = ");
            foreach (string sane in sane)
            {
                Console.WriteLine(sane);
            };

            int randomSaneImage = rand.Next(sane.Length);
            string saneImagesToPost = sane[randomSaneImage];
            await ReplyAsync(saneImagesToPost);
        }
        
    }
}
