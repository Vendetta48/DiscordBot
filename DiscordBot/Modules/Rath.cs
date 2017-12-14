using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Discord;

namespace MemeballBot.Modules
{
   public class Rath : ModuleBase<SocketCommandContext>
    {
        Random rand = new Random();

        string[] rath;

            [Command("rath")]
            public async Task RathAsync()
        {
            rath = System.IO.File.ReadAllLines("Memes/rath/rath.txt");
            System.Console.WriteLine("Contents of rath.txt = ");
            foreach (string rath in rath)
            {
                Console.WriteLine(rath);
            };

            int randomRathPlay = rand.Next(rath.Length);
            string rathPlaysToPost = rath[randomRathPlay];
            await ReplyAsync(rathPlaysToPost);
        }
        
    }
}
