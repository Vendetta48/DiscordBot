using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Discord;

namespace MemeballBot.Modules
{
   public class Stan : ModuleBase<SocketCommandContext>
    {
        Random rand = new Random();

        string[] stan;

        [Command("stan")]
        public async Task StanAsync()
        {
            stan = System.IO.File.ReadAllLines("Memes/stan/stan.txt");
            System.Console.WriteLine("Contents of stan.txt = ");
            foreach (string stan in stan)
            {
                Console.WriteLine(stan);
            };

            int randomStanPlay = rand.Next(stan.Length);
            string stanPlaysToPost = stan[randomStanPlay];
            await ReplyAsync(stanPlaysToPost);
        }

            
    }
}
